using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaATM.excepciones
{
    public class ValidacionExcepcion : Exception
    {
        public ValidacionExcepcion() : base() { }
        public ValidacionExcepcion(string mensaje) : base(mensaje) { }
    }
}
