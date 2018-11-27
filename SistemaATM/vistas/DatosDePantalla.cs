using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaATM.vistas
{
    public class DatosDePantalla
    {
        private TipoPantalla tipoPantalla;
        private TextBox textBox_txb;
        private readonly string errorCampoVacio;

        public DatosDePantalla()
        {

        }

        public DatosDePantalla(TipoPantalla tipo, TextBox tbx, string errorCampoVacio)
        {
            tipoPantalla = tipo;
            
        }

        public enum TipoPantalla
        {
            ENTRADA_TARJETA = 1,
            ENTRADA_PIN = 2,
            RETIRO_DINERO = 3
        }
    }
}
