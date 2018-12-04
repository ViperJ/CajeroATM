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
    public partial class P12_ErrorProcesoDep : Form, Pantalla
    {
        private string numTarjeta;

        public P12_ErrorProcesoDep()
        {
            InitializeComponent();
        }

        public string NumTarjeta { get => numTarjeta; set => numTarjeta = value; }

        public void aceptarBtn_click(string dato)
        {
            P5_SeleccionTransaccion p5 = new P5_SeleccionTransaccion();
            p5.Show();
            p5.NumTarjeta = numTarjeta;
            this.Close();
        }

        public void cancelarBtn_click()
        {
            P1_IngresoTargeta.referencia.Visible = true;
            this.Close();
        }

        private void tableroNumerico1_Load(object sender, EventArgs e)
        {
            tableroNumerico1.Datos_txb.Visible = false;
            tableroNumerico1.Pantalla = this;
        }
    }
}
