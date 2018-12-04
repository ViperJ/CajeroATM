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
    public partial class P13_InsertarDeposito : Form, Pantalla
    {
        private string numTarjeta;

        public string NumTarjeta { get => numTarjeta; set => numTarjeta = value; }

        public P13_InsertarDeposito()
        {
            InitializeComponent();
        }

        private void tableroNumerico1_Load(object sender, EventArgs e)
        {
            tableroNumerico1.Pantalla = this;
            tableroNumerico1.Datos_txb.Visible = false;
        }

        public void aceptarBtn_click(string dato)
        {
            int pDosMil;
            int pMil;
            int pQuinientos;
            int pDosCientos;
            int pCien;

            int salida = 0;

            pDosMil = (tbx_dosMil.Text != "") ? (Int32.Parse(tbx_dosMil.Text)) : 0;

            pMil = (tbx_mil.Text != "") ? (Int32.Parse(tbx_mil.Text)) : 0;

            pQuinientos = (tbx_quinientos.Text != "") ? (Int32.Parse(tbx_quinientos.Text)) : 0;

            pDosCientos = (tbx_doscientos.Text != "") ? (Int32.Parse(tbx_doscientos.Text)) : 0;

            pCien = (tbx_cien.Text != "") ? (Int32.Parse(tbx_cien.Text)) : 0;

            int m = (2000 * pDosMil) + (1000 * pMil) + (500 * pQuinientos) + (200 * pDosCientos) + (100 * pCien);
            if (m == 0)
            {

                MessageBox.Show(this, "Debe introducir al menos un billete", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            int maximoValor = 15000;
            if (!AyudanteValidacion.esMontoValido(m, maximoValor))
            {
                string msj = string.Format("Lo sentimos, pero solo puede hacer un deposito de hasta {0} pesos.", maximoValor);
                MessageBox.Show(this, msj, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            hacerDeposito(m, pDosMil, pMil, pQuinientos, pDosCientos, pCien);
        }

        public void cancelarBtn_click()
        {
            P1_IngresoTargeta.referencia.Visible = true;
            this.Close();
        }

        private void hacerDeposito(int deposito, int pDosMil, int pMil, int pQuinientos, int pDosCientos, int pCien)
        {
            try
            {
                ConexionSQL conexionSql = new ConexionSQL();
                string[] columnas = { "BALANCE_CUENTA" };
                ConexionSQL.ParametroSQL tarjetaParam = new ConexionSQL.ParametroSQL("@NUMERO_TARJETA", numTarjeta);
                ConexionSQL.ParametroSQL montoParam = new ConexionSQL.ParametroSQL("@MONTO_DEPOSITO", deposito);
                ConexionSQL.ParametroSQL ga_100Param = new ConexionSQL.ParametroSQL("@GA_100", pCien);
                ConexionSQL.ParametroSQL ga_200Param = new ConexionSQL.ParametroSQL("@GA_200", pDosCientos);
                ConexionSQL.ParametroSQL ga_500Param = new ConexionSQL.ParametroSQL("@GA_500", pQuinientos);
                ConexionSQL.ParametroSQL ga_1000Param = new ConexionSQL.ParametroSQL("@GA_1000", pMil);
                ConexionSQL.ParametroSQL ga_2000Param = new ConexionSQL.ParametroSQL("@GA_2000", pCien);

                List<string> r = conexionSql.query("up_retiro", columnas, tarjetaParam, ga_100Param, ga_200Param, ga_500Param, ga_1000Param, ga_2000Param);

                P14_ImpresionBalance p14 = new P14_ImpresionBalance();
                p14.Show();
                p14.NumTarjeta = numTarjeta;
                p14.Resultado = r;
                this.Close();
                //string msg = string.Concat("Retiro exitoso ", r[0]);
                //MessageBox.Show(this, msg, "Exito!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            catch (Exception e)
            {
                if (e is SqlException || e is InvalidOperationException)
                {
                    P12_ErrorProcesoDep p12 = new P12_ErrorProcesoDep();
                    p12.Show();
                    p12.NumTarjeta = numTarjeta;
                    this.Close();
                }
            }
        }
    }
}
