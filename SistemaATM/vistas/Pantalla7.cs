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
    public partial class Pantalla7 : Form, Pantalla
    {
        public Pantalla7()
        {
            InitializeComponent();
        }

        public void aceptarBtn_click(string dato)
        {
            string msj = "Hola Mundo";
            if (AyudanteValidacion.estaVacio(dato))
            {
                msj = "Introduzca el monto para poder continuar, por favor!";
                MessageBox.Show(this, msj, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int monto = Int32.Parse(dato);
            int maximoValor = 15000;
            if (!AyudanteValidacion.esMontoValido(monto, maximoValor))
            {
                msj = string.Format("Lo sentimos, pero este cajero solo dispensa hasta un maximo de {0} pesos.", maximoValor);
                MessageBox.Show(this, msj, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int dineroPrueba = 12000;
            if (monto > dineroPrueba)
            {
                Pantalla8 pantalla8 = new Pantalla8();
                pantalla8.Show();
                this.Close();
            }

            if (!AyudanteValidacion.esMultiploDeDiez(monto))
            {
                Pantalla9 pantalla9 = new Pantalla9();
                pantalla9.Show();
                this.Close();
            }
        }

        public void cancelar()
        {
            Pantalla1.referencia.Show();
            this.Close();
        }

        private void tableroNumerico1_Load(object sender, EventArgs e)
        {
            tableroNumerico1.Pantalla = this;
            tableroNumerico1.NombreCampo = "Monto";
            tableroNumerico1.LongitudCampo = 4;
        }
    }
}
