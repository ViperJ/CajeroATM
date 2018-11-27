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
    public partial class Pantalla5 : Form
    {
        public static Form referencia;

        public Pantalla5()
        {
            InitializeComponent();
            referencia = this;
        }

        private void verBalance_btn_Click(object sender, EventArgs e)
        {
            Pantalla6 pantalla6 = new Pantalla6();
            pantalla6.Show();
            this.Close();
        }

        private void cancelar_btn_Click(object sender, EventArgs e)
        {
            Pantalla1.referencia.Show();
            this.Close();
        }

        private void retirar_btn_Click(object sender, EventArgs e)
        {
            Pantalla7 pantalla7 = new Pantalla7();
            pantalla7.Show();
            this.Close();
        }

        private void depositar_btn_Click(object sender, EventArgs e)
        {
            Pantalla13 pantalla13 = new Pantalla13();
            pantalla13.Show();
            this.Close();
        }
    }
}
