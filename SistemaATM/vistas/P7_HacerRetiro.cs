using SistemaATM.SQL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaATM.vistas
{
    public partial class P7_HacerRetiro : Form, Pantalla
    {

        private string numTarjeta;

        public string NumTarjeta { get => numTarjeta; set => numTarjeta = value; }

        public P7_HacerRetiro()
        {
            InitializeComponent();
        }

        public void aceptarBtn_click(string dato)
        {
            string msj = "Hola Mundo";
            if (AyudanteValidacion.estaVacio(dato))
            {
                msj = "Introduzca el monto para poder continuar, por favor!";
                MessageBox.Show(this, msj, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int monto = Int32.Parse(dato);
            int maximoValor = 15000;
            if (!AyudanteValidacion.esMontoValido(monto, maximoValor))
            {
                msj = string.Format("Lo sentimos, pero solo puede hacer un retiro de hasta {0} pesos. (Dejele algo a los demas clientes).", maximoValor);
                MessageBox.Show(this, msj, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int retiro = 0;
            Int32.TryParse(dato, out retiro);
            // Ver que sea multiplo de diez
            if (!AyudanteValidacion.esMultiploDeDiez(retiro))
            {
                P9_ErrorDispensacion pantalla9 = new P9_ErrorDispensacion();
                pantalla9.Show();
                this.Close();
            }

            realizarRetiro(retiro);

        }

        public void cancelarBtn_click()
        {
            P1_IngresoTargeta.referencia.Show();
            this.Close();
        }

        private void tableroNumerico1_Load(object sender, EventArgs e)
        {
            tableroNumerico1.Pantalla = this;
            tableroNumerico1.NombreCampo = "Monto";
            tableroNumerico1.LongitudCampo = 4;
        }

        private void tableroNumerico1_Load_1(object sender, EventArgs e)
        {
            tableroNumerico1.Pantalla = this;
        }

        private void realizarRetiro(int retiro)
        {
            try
            {
                ConexionSQL conexionSql = new ConexionSQL();
                string[] columnas = { "D_100" };
                ConexionSQL.ParametroSQL montoParam = new ConexionSQL.ParametroSQL("@MONTO_RETIRO", retiro);
                ConexionSQL.ParametroSQL tarjetaParam = new ConexionSQL.ParametroSQL("@NUMERO_TARJETA", numTarjeta);
                List<string> r = conexionSql.query("up_retiro", columnas, tarjetaParam, montoParam);

                P11_BalanceActualizando p11 = new P11_BalanceActualizando();
                p11.NumTarjeta = numTarjeta;
                p11.Resultado = r;
                p11.Monto = retiro.ToString();
                p11.Show();
                this.Close();
                //string msg = string.Concat("Retiro exitoso ", r[0]);
                //MessageBox.Show(this, msg, "Exito!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            catch (Exception e)
            {
                if (e is SqlException || e is InvalidOperationException)
                {
                    if (e.Message == "Balance Insuficiente")
                    {
                        P8_FondosInsuficientes pantalla8 = new P8_FondosInsuficientes();
                        pantalla8.Show();
                        this.Close();
                    }
                    else if (e.Message == "Gaveta Insuficiente")
                    {
                        String msj = "Este ATM no tiene fondos suficientes para completar su retiro!";
                        MessageBox.Show(this, msj, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show(this, e.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private bool gavetaTieneDinero(int retiro)
        {
            bool tieneDinero = false;

            //try
            //{
            //    ConexionSQL conexionSql = new ConexionSQL();
            //    string r = conexionSql.query("up_ver_cantidad_gaveta", "total");
            //    int gaveta = 0;
            //    Int32.TryParse(r, out gaveta);
            //    if (gaveta > retiro)
            //    {
            //        tieneDinero = true;
                    
            //    }
            //    else
            //    {
            //        string msg = string.Format("El cajero no cuenta con dinero suficiente. Solo le quedan {0}!", gaveta.ToString());
            //        MessageBox.Show(this, msg, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            //    }

            //}
            //catch (Exception e)
            //{
            //    tieneDinero = false;
            //    if (e is SqlException || e is InvalidOperationException)
            //        MessageBox.Show(this, e.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            return tieneDinero;
        }
    }
}
