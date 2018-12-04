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
    public partial class P14_ImpresionBalance : Form, Pantalla
    {
        private string numTarjeta;
        private List<string> resultado;

        public P14_ImpresionBalance()
        {
            InitializeComponent();
        }

        public List<string> Resultado { get => resultado; set => resultado = value; }
        public string NumTarjeta { get => numTarjeta; set => numTarjeta = value; } 

        public void aceptarBtn_click(string dato)
        {
            P15_TransaccionTerminada p15 = new P15_TransaccionTerminada();
            p15.Show();
            p15.Resultado = Resultado;
            p15.NumTarjeta = numTarjeta;
            this.Close();
        }

        public void cancelarBtn_click()
        {
            P1_IngresoTargeta.referencia.Visible = true;
            this.Close();
        }

        private void tableroNumerico1_Load(object sender, EventArgs e)
        {
            tableroNumerico1.Pantalla = this;
            tableroNumerico1.Datos_txb.Visible = false;

        }
    }
}
