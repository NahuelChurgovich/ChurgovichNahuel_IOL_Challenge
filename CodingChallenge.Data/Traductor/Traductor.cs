using System;
using System.Globalization;

using CodingChallenge.Data.Enums;
using CodingChallenge.Data.Traductor.Recursos;

namespace CodingChallenge.Data.Classes
{
    public static class Traductor
    {
        public static string Traducir(string frase, EnumIdiomas idioma)
        {
            string retorno = string.Empty;

            try
            {
                switch (idioma)
                {
                    case EnumIdiomas.Ingles:
                        retorno = Diccionario.ResourceManager.GetString(frase, new CultureInfo("en-US"));
                        break;
                    case EnumIdiomas.Italiano:
                        retorno = Diccionario.ResourceManager.GetString(frase, new CultureInfo("it-IT"));
                        break;
                    case EnumIdiomas.Portugues:
                        retorno = Diccionario.ResourceManager.GetString(frase, new CultureInfo("pt-PT"));
                        break;
                    default:
                        retorno = frase; // por default devolverá la frase escrita tal como la recibe el método.
                        break;
                }
                return retorno;
            }
            catch (Exception ex)
            {
                return $"Este es el mensaje de la una excepción: {ex.Message}";
            }
           
        }
    }
}
