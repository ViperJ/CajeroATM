/****** Object:  StoredProcedure [dbo].[up_retiro]   ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[up_retiro]
	@NUMERO_TARJETA VARCHAR(16),
	@MONTO_RETIRO NUMERIC(16,2)
AS

DECLARE @BCE_NUEVO NUMERIC(16,2),
		@BCE_ACTUAL NUMERIC(16,2),
		@NUEVO_MONTO NUMERIC(16,2),
		@PAPELETA_2000 NUMERIC(16,2),
		@PAPELETA_1000 NUMERIC(16,2),

		@GA_100 int = 0, @ga_200 int = 0, @ga_500 int = 0, @ga_1000 int = 0, @ga_2000 int = 0, 
		
		@ga_100_papeleta NUMERIC(16,2), @ga_200_papeleta NUMERIC(16,2),
		@ga_500_papeleta NUMERIC(16,2), @ga_1000_papeleta NUMERIC(16,2),
		@ga_2000_papeleta NUMERIC(16,2)

SET @NUMERO_TARJETA = @NUMERO_TARJETA
SET @MONTO_RETIRO = @MONTO_RETIRO

SET @BCE_ACTUAL = ( SELECT [BALANCE_CUENTA] 
                    FROM [dbo].[TARJETA_CUENTA]
                    WHERE [NUMERO_TARJETA] = @NUMERO_TARJETA )

IF @BCE_ACTUAL < @MONTO_RETIRO
BEGIN
	RAISERROR (N'Balance Insuficiente', -- Message text.  
			   11, -- Severity,  
			   1 -- State
			   );
	return;
END

SET @BCE_NUEVO = @BCE_ACTUAL - @MONTO_RETIRO

SET @NUEVO_MONTO = @MONTO_RETIRO
PRINT @NUEVO_MONTO

SET @ga_100_papeleta  = 100 
SET @ga_200_papeleta = 200
SET @ga_500_papeleta = 500
SET @ga_1000_papeleta = 1000
SET	@ga_2000_papeleta = 2000

DECLARE @temp INT = 0;

WHILE @NUEVO_MONTO > 0
BEGIN
	SET @temp = (SELECT ga_2000 FROM GAVETA) - @ga_2000
	IF (@NUEVO_MONTO >= @ga_2000_papeleta AND @temp > 0)
		BEGIN
			PRINT 'HAY papeleta de 2000'
			SET @NUEVO_MONTO = @NUEVO_MONTO - @ga_2000_papeleta
			SET @ga_2000 = @ga_2000 + 1 
		END
	ELSE
		BEGIN
			SET @temp = (SELECT ga_1000 FROM GAVETA) - @ga_1000
			IF (@NUEVO_MONTO >= @ga_1000_papeleta AND @temp > 0)
				BEGIN
					PRINT 'HAY papeleta de 1000'
					SET @NUEVO_MONTO = @NUEVO_MONTO - @ga_1000_papeleta
					SET @ga_1000 = @ga_1000 + 1 
				END
			ELSE
				BEGIN
					SET @temp = (SELECT ga_500 FROM GAVETA) - @ga_500
					IF (@NUEVO_MONTO >= @ga_500_papeleta AND @temp > 0)
						BEGIN
							PRINT 'HAY papeleta de 500'
							SET @NUEVO_MONTO = @NUEVO_MONTO - @ga_500_papeleta
							SET @ga_500 = @ga_500 + 1 
						END
					ELSE
						BEGIN
							SET @temp = (SELECT ga_200 FROM GAVETA) - @ga_200
							IF (@NUEVO_MONTO >= @ga_200_papeleta AND @temp > 0)
								BEGIN
									PRINT 'HAY papeleta de 200'
									SET @NUEVO_MONTO = @NUEVO_MONTO - @ga_200_papeleta
									SET @ga_200 = @ga_200 + 1 
								END
							ELSE
								BEGIN
									SET @temp = (SELECT ga_100 FROM GAVETA) - @ga_100
									IF (@NUEVO_MONTO >= @ga_100_papeleta AND @temp > 0)
										BEGIN
											PRINT 'HAY papeleta de 100'
											SET @NUEVO_MONTO = @NUEVO_MONTO - @ga_100_papeleta
											SET @ga_100 = @ga_100 + 1 
										END
									ELSE
										BEGIN
											RAISERROR (N'Gaveta Insuficiente', -- Message text.  
												11, -- Severity,  
												1 -- State
												);
											return;
										END
								END
						END
				END
		END
END

UPDATE [dbo].[TARJETA_CUENTA]
SET [BALANCE_CUENTA] = @BCE_NUEVO
WHERE [NUMERO_TARJETA] = @NUMERO_TARJETA 

UPDATE [dbo].[GAVETA]
SET [ga_100] = ga_100 - @ga_100, 
	[ga_200] = ga_200 - @ga_200, 
	[ga_500] = ga_500 - @ga_500, 
	[ga_1000] = ga_1000 - @ga_1000, 
	[ga_2000] = ga_2000 - @ga_2000

SELECT @ga_100 as D_100, @ga_200 as D_200, @ga_500 as D_500, 
	   @ga_1000 as D_1000, @ga_2000 as D_2000, @BCE_ACTUAL as BALANCE_ACTUAL, 
	   @BCE_ACTUAL + @MONTO_RETIRO as BALANCE_VIEJO
------------------------------------------------------------------------------------------------

  /****** Object:  StoredProcedure [dbo].[up_deposito]    Script Date: 11/24/2018 9:53:23 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[up_deposito]
	@NUMERO_TARJETA VARCHAR(16),
	@MONTO_DEPOSITO NUMERIC(16,2),
	@GA_100 INT,
	@GA_200 INT,
	@GA_500 INT,
	@GA_1000 INT, 
	@GA_2000 INT
AS

DECLARE @BCE_NUEVO NUMERIC(16,2)
DECLARE @BCE_ACTUAL NUMERIC(16,2)

SET @NUMERO_TARJETA = @NUMERO_TARJETA
SET @MONTO_DEPOSITO = @MONTO_DEPOSITO

SET @BCE_ACTUAL = ( SELECT [BALANCE_CUENTA] 
                    FROM [dbo].[TARJETA_CUENTA]
                    WHERE [NUMERO_TARJETA] = @NUMERO_TARJETA )

SET @BCE_NUEVO = @BCE_ACTUAL + @MONTO_DEPOSITO

UPDATE [dbo].[TARJETA_CUENTA]
SET [BALANCE_CUENTA] = @BCE_NUEVO
WHERE [NUMERO_TARJETA] = @NUMERO_TARJETA 

UPDATE [dbo].[GAVETA]
SET [ga_100] = ga_100 + @GA_100, [ga_200] = ga_200 + @GA_200, 
	[ga_500] = ga_500 + @GA_500, [ga_1000] = ga_1000 + @GA_1000, [ga_2000] = ga_2000 + @GA_2000

SELECT [BALANCE_CUENTA]
FROM [dbo].[TARJETA_CUENTA]
WHERE NUMERO_TARJETA = @NUMERO_TARJETA 
