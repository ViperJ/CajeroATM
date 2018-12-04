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
    public partial class P1_IngresoTargeta : Form, Pantalla
    {
        public static Form referencia;

        private string numTarjeta;

        public string NumTarjeta { get => numTarjeta; set => numTarjeta = value; }

        public P1_IngresoTargeta()
        {
            InitializeComponent();
            referencia = this;
        }

        private void tableroNumerico1_Load(object sender, EventArgs e)
        {
            tableroNumerico1.Pantalla = this;
            tableroNumerico1.NombreCampo = "Tarjeta De Credito";
            tableroNumerico1.LongitudCampo = 20;
        }

        public void aceptarBtn_click(string dato)
        {
            string msj = "Hola Mundo";
            if (AyudanteValidacion.estaVacio(dato))
            {
                msj = "El campo Tarjeta de Credito no puede estar vacio!";
                MessageBox.Show(this, msj, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int longitudCampo = tableroNumerico1.LongitudCampo;
            if (!AyudanteValidacion.esLongitudValida(dato, 13, longitudCampo))
            {
                msj = string.Format("El campo Tarjeta de Credito no cumple con la longitud requerida! La longitud debe de ser {0}", longitudCampo);
                MessageBox.Show(this, msj, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string tipo = AyudanteValidacion.validarTipoTarjeta(dato);
            if (tipo == "NO VALIDO")
            {
                msj = "El campo Tarjeta de Credito No Es Valido! Necesita Ser VISA O MASTERCARD";
                MessageBox.Show(this, msj, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                //tipoTarjeta_lb.Text = tipo;
                //tipoTarjeta_lb.Visible = true;
            }

            string r;

            try
            {
                ConexionSQL conexionSql = new ConexionSQL();
                string[] columnas = { "NUMERO_TARJETA" };
                ConexionSQL.ParametroSQL p = new ConexionSQL.ParametroSQL("@NUMERO_TARJETA", dato);
                r = conexionSql.query("up_busca_tarjeta_pin", columnas, p)[0];
                if (dato == r)
                {
                    numTarjeta = dato;
                    P2_IngresoPin pantalla2 = new P2_IngresoPin();
                    pantalla2.NumTarjeta = dato;
                    pantalla2.Show();
                    this.Hide();
                }
            }
            catch (Exception e)
            {
                if (e is SqlException || e is InvalidOperationException)
                    MessageBox.Show(this, e.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        public void cancelarBtn_click()
        {
            this.Close();
        }

        private void P1_IngresoTargeta_VisibleChanged(object sender, EventArgs e)
        {
            tableroNumerico1.Datos_txb.Text = "";
        }
    }
}
