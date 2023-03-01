using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodingChallenge.Data.Enums;

namespace CodingChallenge.Data.Classes
{
    public class Program
    {
        //public static string Imprimir(List<FormaGeometrica> formas, int idioma)
        //{
        //    var sb = new StringBuilder();

        //    if (!formas.Any())
        //    {
        //        if (idioma == (int)EnumIdiomas.Castellano)
        //            sb.Append("<h1>Lista vacía de formas!</h1>");
        //        else
        //            sb.Append("<h1>Empty list of shapes!</h1>");
        //    }
        //    else
        //    {
        //        // Hay por lo menos una forma
        //        // HEADER
        //        if (idioma == (int)EnumIdiomas.Castellano)
        //            sb.Append("<h1>Reporte de Formas</h1>");
        //        else
        //            // default es inglés
        //            sb.Append("<h1>Shapes report</h1>");

        //        var numeroCuadrados = 0;
        //        var numeroCirculos = 0;
        //        var numeroTriangulos = 0;

        //        var areaCuadrados = 0m;
        //        var areaCirculos = 0m;
        //        var areaTriangulos = 0m;

        //        var perimetroCuadrados = 0m;
        //        var perimetroCirculos = 0m;
        //        var perimetroTriangulos = 0m;

        //        for (var i = 0; i < formas.Count; i++)
        //        {
        //            if (formas[i].Tipo == Cuadrado)
        //            {
        //                numeroCuadrados++;
        //                areaCuadrados += formas[i].CalcularArea();
        //                perimetroCuadrados += formas[i].CalcularPerimetro();
        //            }
        //            if (formas[i].Tipo == Circulo)
        //            {
        //                numeroCirculos++;
        //                areaCirculos += formas[i].CalcularArea();
        //                perimetroCirculos += formas[i].CalcularPerimetro();
        //            }
        //            if (formas[i].Tipo == TrianguloEquilatero)
        //            {
        //                numeroTriangulos++;
        //                areaTriangulos += formas[i].CalcularArea();
        //                perimetroTriangulos += formas[i].CalcularPerimetro();
        //            }
        //        }

        //        sb.Append(ObtenerLinea(numeroCuadrados, areaCuadrados, perimetroCuadrados, Cuadrado, idioma));
        //        sb.Append(ObtenerLinea(numeroCirculos, areaCirculos, perimetroCirculos, Circulo, idioma));
        //        sb.Append(ObtenerLinea(numeroTriangulos, areaTriangulos, perimetroTriangulos, TrianguloEquilatero, idioma));

        //        // FOOTER
        //        sb.Append("TOTAL:<br/>");
        //        sb.Append(numeroCuadrados + numeroCirculos + numeroTriangulos + " " + (idioma == (int)EnumIdiomas.Castellano ? "formas" : "shapes") + " ");
        //        sb.Append((idioma == (int)EnumIdiomas.Castellano ? "Perimetro " : "Perimeter ") + (perimetroCuadrados + perimetroTriangulos + perimetroCirculos).ToString("#.##") + " ");
        //        sb.Append("Area " + (areaCuadrados + areaCirculos + areaTriangulos).ToString("#.##"));
        //    }

        //    return sb.ToString();
        //}

        //private static string ObtenerLinea(int cantidad, decimal area, decimal perimetro, int tipo, int idioma)
        //{
        //    if (cantidad > 0)
        //    {
        //        if (idioma == (int)EnumIdiomas.Castellano)
        //            return $"{cantidad} {TraducirForma(tipo, cantidad, idioma)} | Area {area:#.##} | Perimetro {perimetro:#.##} <br/>";

        //        return $"{cantidad} {TraducirForma(tipo, cantidad, idioma)} | Area {area:#.##} | Perimeter {perimetro:#.##} <br/>";
        //    }

        //    return string.Empty;
        //}
    }
}
