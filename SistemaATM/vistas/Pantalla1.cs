using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaATM
{
    public partial class Pantalla1 : Form
    {
        //private AyudanteValidacion ayudValidacion;
        private bool caracterInvalidol;

        public Pantalla1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void tableroBotones_pnl_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tarjetaCredito_txb_TextChanged(object sender, EventArgs e)
        {
            if (caracterInvalidol == true)
            {
                caracterInvalidol = false;
                string texto = tarjetaCredito_txb.Text;
                if (texto.Length > 0)
                    tarjetaCredito_txb.Text = texto.Remove(texto.Length - 1);
                MessageBox.Show(this, "El campo Tarjeta de Credito solo puede contener valores numericos!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tableroNumerico1_Load(object sender, EventArgs e)
        {
            tableroNumerico1.obtenerTextBox(tarjetaCredito_txb);
        }

        private void tarjetaCredito_txb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!AyudanteValidacion.verificarCaracterEsValido(e.KeyChar))
                caracterInvalidol = true;
        }
    }
}
