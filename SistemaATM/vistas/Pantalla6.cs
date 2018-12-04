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
    public partial class Pantalla6 : Form
    {
        private string numTarjeta;

        public string NumTarjeta { get => numTarjeta; set => numTarjeta = value; }

        public Pantalla6()
        {
            InitializeComponent();
        }

        private void aceptar_btn_Click(object sender, EventArgs e)
        {
            Pantalla15 pantalla15 = new Pantalla15();
            pantalla15.Show();
            this.Close();
        }

        private void cancelar_btn_Click(object sender, EventArgs e)
        {
            Pantalla1.referencia.Show();
            this.Close();
        }

        private void Pantalla6_Load(object sender, EventArgs e)
        {
            string r;
            try
            {
                ConexionSQL conexionSql = new ConexionSQL();
                r = conexionSql.query("up_busca_bce", "BALANCE_CUENTA", "@NUMERO_TARJETA", numTarjeta);
                balance_lb.Text = r;
            }
            catch (Exception ex)
            {
                if (ex is SqlException || ex is InvalidOperationException)
                    MessageBox.Show(this, ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
