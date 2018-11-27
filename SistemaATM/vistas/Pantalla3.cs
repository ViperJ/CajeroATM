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
    public partial class Pantalla3 : Form
    {

        private Form pantAnterior;
        public Form PantAnterior { get => pantAnterior; set => pantAnterior = value; }

        public Pantalla3()
        {
            InitializeComponent();
        }

        private void aceptar_btn_Click(object sender, EventArgs e)
        {
            Pantalla2.referencia.Show();
            this.Close();
        }

        private void cancelar_btn_Click(object sender, EventArgs e)
        {
            Pantalla1.referencia.Show();
            this.Close();
        }
    }
}
