using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaATM.vistas
{
    public partial class Pantalla6 : Form
    {
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
    }
}
