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
    public partial class Pantalla2 : Form, Pantalla
    {
        public static Form referencia;
        private static int numIntentos;

        public Pantalla2()
        {
            numIntentos = 0;
            InitializeComponent();
            referencia = this;
        }

        private void tableroNumerico1_Load(object sender, EventArgs e)
        {
            tableroNumerico1.Pantalla = this;
            tableroNumerico1.NombreCampo = "PIN de Acceso";
            tableroNumerico1.LongitudCampo = 4;
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

            if (numIntentos >= 3)
            {
                Pantalla4 pantalla4 = new Pantalla4();
                pantalla4.Show();
                this.Hide();
            }
            else if (dato != "4444")
            {
                numIntentos++;
                Pantalla3 pantalla3 = new Pantalla3();
                pantalla3.Show();
                this.Hide();
            }
            else
            {
                Pantalla5 pantalla5 = new Pantalla5();
                pantalla5.Show();
                this.Close();
            }
        }

        public void cancelar()
        {
            Pantalla1.referencia.Show();
            this.Close();
        }
    }
}
