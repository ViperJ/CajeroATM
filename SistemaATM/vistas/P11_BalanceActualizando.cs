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
    public partial class P11_BalanceActualizando : Form
    {

        private string numTarjeta;
        private List<string> resultado;
        private string monto;

        public P11_BalanceActualizando()
        {
            InitializeComponent();
        }

        public string NumTarjeta { get => numTarjeta; set => numTarjeta = value; }
        public List<string> Resultado { get => resultado; set => resultado = value; }
        public string Monto { get => monto; set => monto = value; }

        private void reitarDinero_btn_Click(object sender, EventArgs e)
        {
            P15_TransaccionTerminada p15 = new P15_TransaccionTerminada();
            p15.NumTarjeta = NumTarjeta;
            p15.Resultado = resultado;
            p15.TipoTransaccion = "Debito";
            p15.Monto = monto;
            p15.Show();
        }
    }
}
