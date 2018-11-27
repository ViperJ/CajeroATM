using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaATM.vistas
{
    public interface Pantalla
    {
        void aceptarBtn_click(string dato);
        void cancelar();
    }
}
