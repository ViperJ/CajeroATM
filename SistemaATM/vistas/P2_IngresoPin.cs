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
    public partial class P2_IngresoPin : Form, Pantalla
    {
        public static Form referencia;
        private static int numIntentos;
        private string numTarjeta;
        private bool cancelar;


        public string NumTarjeta { get => numTarjeta; set => numTarjeta = value; }

        public P2_IngresoPin()
        {
            numIntentos = 0;
            InitializeComponent();
            referencia = this;
            this.ControlBox = false;
        }

        private void tableroNumerico1_Load(object sender, EventArgs e)
        {
            tableroNumerico1.Pantalla = this;
            tableroNumerico1.NombreCampo = "PIN de Acceso";
            tableroNumerico1.LongitudCampo = 4;
            //tableroNumerico1.tex
        }

        public void aceptarBtn_click(string dato)
        {
            string msj = "Hola Mundo";
            if (AyudanteValidacion.estaVacio(dato))
            {
                msj = "El campo PIN de Acceso no puede estar vacio!";
                MessageBox.Show(this, msj, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int longitudCampo = 4;
            if (!AyudanteValidacion.esLongitudValida(dato, longitudCampo, longitudCampo))
            {
                msj = string.Format("El campo PIN de Acceso no cumple con la longitud requerida! La longitud debe de ser {0}", longitudCampo);
                MessageBox.Show(this, msj, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (numIntentos >= 2)
            {
                P4_UsuarioBloqueado pantalla4 = new P4_UsuarioBloqueado();
                pantalla4.Show();
                this.Hide();
            }
            else
            {
                string r;
                try
                {
                    ConexionSQL conexionSql = new ConexionSQL();
                    string[] columnas = { "PIN_TARJETA" };
                    ConexionSQL.ParametroSQL p = new ConexionSQL.ParametroSQL("@NUMERO_TARJETA", numTarjeta);
                    r = conexionSql.query("up_busca_tarjeta_pin", columnas, p)[0];
                    if (dato == r)
                    {
                        P5_SeleccionTransaccion pantalla5 = new P5_SeleccionTransaccion();
                        pantalla5.NumTarjeta = numTarjeta;
                        pantalla5.Show();
                        this.Close();
                    }
                    else
                    {
                        numIntentos++;
                        P3_PinIncorrecto pantalla3 = new P3_PinIncorrecto();
                        pantalla3.Show();
                        this.Hide();
                    }
                }
                catch (Exception e)
                {
                    if (e is SqlException || e is InvalidOperationException)
                        MessageBox.Show(this, e.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public void cancelarBtn_click()
        {
            cancelar = true;
            P1_IngresoTargeta.referencia.Show();
            this.Close();
        }

        private void P2_IngresoPin_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }
    }
}
