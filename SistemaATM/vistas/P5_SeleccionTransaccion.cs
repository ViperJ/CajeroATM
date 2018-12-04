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
    public partial class P5_SeleccionTransaccion : Form
    {
        public static Form referencia;

        private string numTarjeta;

        public string NumTarjeta { get => numTarjeta; set => numTarjeta = value; }


        public P5_SeleccionTransaccion()
        {
            InitializeComponent();
            referencia = this;
        }

        private void verBalance_btn_Click(object sender, EventArgs e)
        {
            P6_VerBalance pantalla6 = new P6_VerBalance();
            pantalla6.NumTarjeta = numTarjeta;
            pantalla6.Show();
            this.Close();
        }

        private void cancelar_btn_Click(object sender, EventArgs e)
        {
            P1_IngresoTargeta.referencia.Show();
            this.Close();
        }

        private void retirar_btn_Click(object sender, EventArgs e)
        {
            P7_HacerRetiro pantalla7 = new P7_HacerRetiro();
            pantalla7.NumTarjeta = numTarjeta;
            pantalla7.Show();
            this.Close();
        }

        private void depositar_btn_Click(object sender, EventArgs e)
        {
            P13_InsertarDeposito pantalla13 = new P13_InsertarDeposito();
            pantalla13.NumTarjeta = numTarjeta;
            pantalla13.Show();
            this.Close();
        }

      
    }
}
