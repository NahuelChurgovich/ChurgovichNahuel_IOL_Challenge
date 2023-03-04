using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;

using CodingChallenge.Data.Enums;
using CodingChallenge.Data.Traductor;

namespace CodingChallenge.Data.Classes
{
    public static class Traductor
    {
        public static string Traducir(string frase, EnumIdiomas idioma)
        {
            string retorno = string.Empty;
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
                    retorno = frase;
                    break;
            }
            return retorno;
        }
    }
}
