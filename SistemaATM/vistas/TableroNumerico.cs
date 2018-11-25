using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaATM.vistas
{
    public partial class TableroNumerico : UserControl
    {
        private TextBox textBox;

        public TableroNumerico()
        {
            InitializeComponent();
        }

        public void obtenerTextBox(TextBox t)
        {
            textBox = t;
        }

        private void escribirTextBox(string texto)
        {
            string nuevoTexto = string.Concat(textBox.Text, texto);
            textBox.Text = nuevoTexto;
        }

        private void numeroUno_btn_Click(object sender, EventArgs e)
        {
            escribirTextBox("1");
        }

        private void numeroDos_btn_Click(object sender, EventArgs e)
        {
            escribirTextBox("2");
        }

        private void numTres_btn_Click(object sender, EventArgs e)
        {
            escribirTextBox("3");
        }

        private void numCuatro_btn_Click(object sender, EventArgs e)
        {
            escribirTextBox("4");
        }

        private void numCinco_btn_Click(object sender, EventArgs e)
        {
            escribirTextBox("5");
        }

        private void numSeis_btn_Click(object sender, EventArgs e)
        {
            escribirTextBox("6");
            
        }

        private void numSiete_btn_Click(object sender, EventArgs e)
        {
            escribirTextBox("7");
        }

        private void numOcho_btn_Click(object sender, EventArgs e)
        {
            escribirTextBox("8");
        }

        private void numNueve_btn_Click(object sender, EventArgs e)
        {
            escribirTextBox("9");
        }

        private void numCero_btn_Click(object sender, EventArgs e)
        {
            escribirTextBox("0");
        }
    }
}
