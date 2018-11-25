using System.Text.RegularExpressions;
using System;
using System.Collections.Generic;
using SistemaATM.excepciones;
using System.Globalization;

namespace FormularioClientes
{
    public class AyudanteValidacion
    {
        private static Dictionary<string, string> tablaCiudadISO;
        private static Dictionary<string, string> tablaPaisIso;

        public static void inicializar()
        {
            crearTablaCiudades();
            crearTablaPaises();
        }

        public static string validar(string campo, string nombreCampo, int minLong, int maxLong, string patron = "ninguno", string carInvalidosMsj = "ninguno")
        {
            campo.Trim();

            string msj = "No hay nada aqui.";
            // validar que el campo no este vacio
            if (campo.Length == 0)
            {
                msj = string.Format("El campo {0} es mandatorio. Por favor introduzca los datos.", nombreCampo);
                throw new ValidacionExcepcion(msj);
            }

            // Validar que el campo cumpla con los requerimientos de longitud minima y maxima
            if (!(campo.Length >= minLong && campo.Length <= maxLong))
            {
                if (maxLong > minLong)
                    msj = string.Format("El campo {0} no cumple con la longitud requerida. La longitud minima es {1}, y la maxima es {2}.", 
                        nombreCampo, minLong, maxLong);
                else
                    msj = string.Format("El campo {0} no cumple con la longitud requerida. La longitud debe de ser {1}.", 
                        nombreCampo, minLong);
                throw new LongitudInvalidaExcepcion(msj);
            }

            // Validar que el campo contenga solo caracteres validos
            if (!(patron.Equals("ninguno")))
            {
                if (!Regex.IsMatch(campo, patron))
                {
                    msj = string.Format("Campo {0} invalido. ", nombreCampo);
                    msj = string.Concat(msj, carInvalidosMsj);
                    throw new ValidacionExcepcion(msj);
                }
            }

            return campo;
        }

        public static DateTime validarFecha(string fecha, string nombreCampo, int minLong, int maxLong)
        {
            string campo = validar(fecha, nombreCampo, minLong, maxLong);
            string patron = "d/M/yyyy";
            DateTime f;
            bool esValido = DateTime.TryParseExact(fecha, patron, CultureInfo.InvariantCulture,
                DateTimeStyles.None, out f);
            if (!esValido)
                throw new ValidacionExcepcion(string.Format("Fecha Invalida. La Fecha debe estar en formato {0}", patron));
            return f;
        }

        /// <summary>
        /// Verifica que un campo cumple con la longitud requerida
        /// </summary>
        /// <param name="campo">el campo a evaluar</param>
        /// <param name="minLong">longitud minima</param>
        /// <param name="maxLong">longitud maxima</param>
        /// <returns>
        ///     Devuelve TRUE si el campo contiene la longitud correcta 
        /// </returns>
        public static bool esLongitudValida(string campo, int minLong, int maxLong)
        {
            bool resultado = false;
            if (campo.Length >= minLong && campo.Length <= maxLong)
                resultado = true;

            return resultado;
        }

        public static bool estaVacio(string campo)
        {
            bool estaVacio = false;
            if (campo.Length == 0)
                estaVacio = true;
            return estaVacio;
        }

        public static bool verificarCaracteresSonValidos(string entrada, string patron)
        {
            bool sonValidos = false;
            if (Regex.IsMatch(entrada, patron))
                sonValidos = true;
            return sonValidos;
        }

        public static bool esFechaValida(string entrada, string patron)
        {
            return false;
        }

        public static string mapearCiudadCodigoIso(string ciudad)
        {
            ciudad.Trim();
            if (tablaCiudadISO.ContainsKey(ciudad.ToLower()))
                tablaCiudadISO.TryGetValue(ciudad.ToLower(), out ciudad);
            return ciudad;
        }

        public static string mapearPaisCodigoIso(string pais)
        {
            pais.Trim();
            if (tablaPaisIso.ContainsKey(pais.ToLower()))
                tablaPaisIso.TryGetValue(pais.ToLower(), out pais);
            return pais;
        }

        private static void crearTablaCiudades()
        {
            tablaCiudadISO = new Dictionary<string, string>();
            tablaCiudadISO.Add("distrito nacional", "DO-01");
            tablaCiudadISO.Add("azua", "DO-02");
            tablaCiudadISO.Add("baoruco", "DO-03");
            tablaCiudadISO.Add("barahona", "DO-04");
            tablaCiudadISO.Add("dajabon", "DO-05");
            tablaCiudadISO.Add("duarte", "DO-06");
            tablaCiudadISO.Add("elias piña", "DO-07");
            tablaCiudadISO.Add("el seibo", "DO-08");
            tablaCiudadISO.Add("espaillat", "DO-09");
            tablaCiudadISO.Add("hato mayor", "DO-30");
            tablaCiudadISO.Add("hermanas mirabal", "DO-19");
            tablaCiudadISO.Add("independencia", "DO-10");
            tablaCiudadISO.Add("la altagracia", "DO-11");
            tablaCiudadISO.Add("la romana", "DO-12");
            tablaCiudadISO.Add("la vega", "DO-13");
            tablaCiudadISO.Add("maria trinidad sanchez", "DO-14");
            tablaCiudadISO.Add("monseñor nouel", "DO -28");
            tablaCiudadISO.Add("monte plata", "DO-29");
            tablaCiudadISO.Add("pedernales", "DO-16");
            tablaCiudadISO.Add("peravia", "DO-17");
            tablaCiudadISO.Add("puerto plata", "DO-18");
            tablaCiudadISO.Add("samana", "DO-20");
            tablaCiudadISO.Add("san cristobal", "DO-21");
            tablaCiudadISO.Add("san jose de ocoa", "DO-31");
            tablaCiudadISO.Add("san pedro de macoris", "DO-23");
            tablaCiudadISO.Add("sanchez ramirez", "DO-24");
            tablaCiudadISO.Add("santiago", "DO-25");
            tablaCiudadISO.Add("santiago rodriguez", "DO-26");
            tablaCiudadISO.Add("santo domingo", "DO-32");
            tablaCiudadISO.Add("valverde", "DO-27");
            tablaCiudadISO.Add("INVALIDO", "00-00");
        }

        private static void crearTablaPaises()
        {
            tablaPaisIso = new Dictionary<string, string>();
            tablaPaisIso.Add("republica dominicana", "DO");
            tablaPaisIso.Add("estados unidos", "US");
            tablaPaisIso.Add("canada", "CA");
            tablaPaisIso.Add("mexico", "MX");
            tablaPaisIso.Add("japon", "JP");
            tablaPaisIso.Add("china", "CN");
            tablaPaisIso.Add("argentina", "AR");
            tablaPaisIso.Add("puerto rico", "PR");
        }

        //public enum ResultadoValidacion
        //{
        //    ENTRADA_CORRECTA,
        //    CAMPO_VACIO,
        //    LONGITUD_INVALIDA,
        //    CHARACTER_INVALIDO,
        //}
    }
}
