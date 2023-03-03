using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CodingChallenge.Data.Enums;

namespace CodingChallenge.Data.Classes
{
    public class Impresion
    {

        public static string Imprimir(List<FormaGeometrica> formas)//INCLUIR EL IDIOMA
        {
            var sb = new StringBuilder();

            if (!formas.Any())
            {
                sb.Append("<h1>Lista vacía de formas!</h1>");
            }
            else
            {
                int numeroCirculos = formas.Where(x => x.GetTipo() == EnumTipoFigura.Circulo).Count();
                int numeroRectangulos = formas.Where(x => x.GetTipo() == EnumTipoFigura.Rectangulo).Count();
                int numeroTriangulos = formas.Where(x => x.GetTipo() == EnumTipoFigura.Triangulo).Count();
                int numeroCuadrados = formas.Where(x => x.GetTipo() == EnumTipoFigura.Cuadrado).Count();
                int numeroPentagonos = formas.Where(x => x.GetTipo() == EnumTipoFigura.Pentagono).Count();
                int numeroHexagonos = formas.Where(x => x.GetTipo() == EnumTipoFigura.Hexagono).Count();
                int numeroTrapecios = formas.Where(x => x.GetTipo() == EnumTipoFigura.Trapecio).Count();

                decimal perimetroCirculos = formas.Where(x => x.GetTipo() == EnumTipoFigura.Circulo).Sum(x => x.GetPerimetro()); 
                decimal perimetroRectangulos =formas.Where(x => x.GetTipo() == EnumTipoFigura.Rectangulo).Sum(x => x.GetPerimetro()); 
                decimal perimetroTriangulos = formas.Where(x => x.GetTipo() == EnumTipoFigura.Triangulo).Sum(x => x.GetPerimetro()); 
                decimal perimetroCuadrados =  formas.Where(x => x.GetTipo() == EnumTipoFigura.Cuadrado).Sum(x => x.GetPerimetro()); 
                decimal perimetroPentagonos = formas.Where(x => x.GetTipo() == EnumTipoFigura.Pentagono).Sum(x => x.GetPerimetro()); 
                decimal perimetroHexagonos =  formas.Where(x => x.GetTipo() == EnumTipoFigura.Hexagono).Sum(x => x.GetPerimetro()); 
                decimal perimetroTrapecios = formas.Where(x => x.GetTipo() == EnumTipoFigura.Trapecio).Sum(x => x.GetPerimetro());

                decimal areaCirculos = formas.Where(x => x.GetTipo() == EnumTipoFigura.Circulo).Sum(x => x.GetArea());
                decimal areaRectangulos = formas.Where(x => x.GetTipo() == EnumTipoFigura.Rectangulo).Sum(x => x.GetArea());
                decimal areaTriangulos = formas.Where(x => x.GetTipo() == EnumTipoFigura.Triangulo).Sum(x => x.GetArea());
                decimal areaCuadrados = formas.Where(x => x.GetTipo() == EnumTipoFigura.Cuadrado).Sum(x => x.GetArea());
                decimal areaPentagonos = formas.Where(x => x.GetTipo() == EnumTipoFigura.Pentagono).Sum(x => x.GetArea());
                decimal areaHexagonos = formas.Where(x => x.GetTipo() == EnumTipoFigura.Hexagono).Sum(x => x.GetArea());
                decimal areaTrapecios = formas.Where(x => x.GetTipo() == EnumTipoFigura.Trapecio).Sum(x => x.GetArea());


            }

            return sb.ToString();
        }

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
