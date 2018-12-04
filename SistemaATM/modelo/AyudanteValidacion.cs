using System.Text.RegularExpressions;
using System;
using System.Collections.Generic;
using SistemaATM.excepciones;
using System.Globalization;

namespace SistemaATM
{
    public class AyudanteValidacion
    {
        
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

        public static bool verificarSoloDigitos(char c)
        {
            bool esValido = false;
            if (char.IsControl(c) || char.IsDigit(c))
                esValido = true;
            return esValido;
        }

        public static string validarTipoTarjeta(string tarjeta)
        {
            const string MASTER_CARD = "MASTERCARD";
            const string VISA = "VISA";
            string tipo = "NO VALIDO";

            if (tarjeta.StartsWith("5"))
                tipo = MASTER_CARD;
            else if (tarjeta.StartsWith("4"))
                tipo = VISA;
            
            return tipo;
        }

        public static bool esMontoValido(int monto, int valorMax)
        {
            bool esValido = false;
            if (monto <= valorMax)
            {
                esValido = true;
            }
            return esValido;
        }

        public static bool esMultiploDeDiez(int monto)
        {
            bool esMultiplo = false;
            if (monto % 10 == 0)
                esMultiplo = true;
            return esMultiplo;
        }
    }
}
