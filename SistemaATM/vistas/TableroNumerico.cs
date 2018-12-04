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
        private Pantalla pantalla;
        private string nombreCampo;
        private bool caracterInvalido;
        private string mascara;

        //public TextBox TextBox { get => textBox; set => textBox = value; }
        public Pantalla Pantalla { get => pantalla; set => pantalla = value; }
        public string NombreCampo { get => nombreCampo; set => nombreCampo = value; }
        public int LongitudCampo { get => datos_txb.MaxLength; set => datos_txb.MaxLength = value; }

        public TableroNumerico()
        {
            InitializeComponent();
            //.Mask = mascara;
        }

        private void escribirTextBox(string texto)
        {
            string nuevoTexto = string.Concat(datos_txb.Text, texto);
            datos_txb.Text = nuevoTexto;
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

        private void aceptar_btn_Click(object sender, EventArgs e)
        {
            pantalla.aceptarBtn_click(datos_txb.Text);
        }

        private void datos_txb_TextChanged(object sender, EventArgs e)
        {
            //string d = datos_txb.Text;
            //datos_txb.Text = d.Replace(" ", "");
            if (caracterInvalido == true)
            {
                caracterInvalido = false;
                string texto = datos_txb.Text;
                if (texto.Length > 0)
                    datos_txb.Text = texto.Remove(texto.Length - 1);
                string msj = string.Format("El campo {0} solo puede contener valores numericos!", nombreCampo);
                MessageBox.Show(this, msj, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void datos_txb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!AyudanteValidacion.verificarSoloDigitos(e.KeyChar))
                caracterInvalido = true;
        }

        private void cancelar_btn_Click(object sender, EventArgs e)
        {
            pantalla.cancelar();
        }

        private void borrar_btn_Click(object sender, EventArgs e)
        {
            datos_txb.Text = datos_txb.Text.Remove(datos_txb.Text.Length - 1);
        }
    }
}
