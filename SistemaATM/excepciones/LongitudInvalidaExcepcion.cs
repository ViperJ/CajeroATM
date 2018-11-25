using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaATM.excepciones
{
    public class LongitudInvalidaExcepcion : ValidacionExcepcion
    {
        private int maxLong, minLong;

        public LongitudInvalidaExcepcion() : base() { }

        public LongitudInvalidaExcepcion(string  mensaje) : base(mensaje) { }

        public LongitudInvalidaExcepcion(string mensaje, int maxLong, int minLong) : base(mensaje)
        {
            this.minLong = minLong;
            this.maxLong = maxLong;
        }
    }
}
