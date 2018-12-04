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
    public partial class P15_TransaccionTerminada : Form, Pantalla
    {
        private List<string> resultado;
        private string numTarjeta;
        private string tipoTransaccion;
        private string monto;

        public P15_TransaccionTerminada()
        {
            InitializeComponent();
        }

        public List<string> Resultado { get => resultado; set => resultado = value; }
        public string NumTarjeta { get => numTarjeta; set => numTarjeta = value; }
        public string TipoTransaccion { get => tipoTransaccion; set => tipoTransaccion = value; }
        public string Monto { get => monto; set => monto = value; }

        public void aceptarBtn_click(string dato)
        {
            P1_IngresoTargeta.referencia.Visible = true;
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
            tableroNumerico1.Datos_txb.Visible=false;
        }

        private void P15_TransaccionTerminada_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible)
            {
                
            }
        }

        private void P15_TransaccionTerminada_Load(object sender, EventArgs e)
        {
            transac_lb.Text = tipoTransaccion;
            if (TipoTransaccion.Equals("Debito"))
            {
                nuevoBalance_txb.Text = resultado[6];
                transac_txb.Text = monto;
                tbx_cien.Text = resultado[0];
                tbx_doscientos.Text = resultado[1];
                tbx_quinientos.Text = resultado[2];
                tbx_mil.Text = resultado[3];
                tbx_dosMil.Text = resultado[4];
            }
            else if (tipoTransaccion == "Credito")
            {

            }
            else
            {

                nuevoBalance_txb.Text = resultado[0];
            }
        }
    }
}
