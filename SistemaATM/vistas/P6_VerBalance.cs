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
    public partial class P6_VerBalance : Form, Pantalla
    {
        private string numTarjeta;
        private string resultado;

        public string NumTarjeta { get => numTarjeta; set => numTarjeta = value; }
        public string Resultado { get => resultado; set => resultado = value; }

        public P6_VerBalance()
        {
            InitializeComponent();
        }

        public void aceptarBtn_click(string datos)
        {
            P15_TransaccionTerminada pantalla15 = new P15_TransaccionTerminada();
            pantalla15.Resultado = new List<string>();
            pantalla15.Resultado.Add(resultado);
            pantalla15.Show();
            this.Close();
        }

        public void cancelarBtn_click()
        {
            P1_IngresoTargeta.referencia.Show();
            this.Close();
        }

        private void Pantalla6_Load(object sender, EventArgs e)
        {
            string r;
            try
            {
                ConexionSQL conexionSql = new ConexionSQL();
                string[] columnas = { "BALANCE_CUENTA" };
                ConexionSQL.ParametroSQL p = new ConexionSQL.ParametroSQL("@NUMERO_TARJETA", numTarjeta);
                r = conexionSql.query("up_busca_bce", columnas, p)[0];
                balance_lb.Text = r;
                resultado = r;
            }
            catch (Exception ex)
            {
                if (ex is SqlException || ex is InvalidOperationException)
                    MessageBox.Show(this, ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void P6_VerBalance_FormClosed(object sender, FormClosedEventArgs e)
        {
            //P1_IngresoTargeta.referencia.Visible = true;
        }

        private void tableroNumerico1_Load(object sender, EventArgs e)
        {
            tableroNumerico1.Datos_txb.Visible = false;
            tableroNumerico1.Pantalla = this;
        }
    }
}
