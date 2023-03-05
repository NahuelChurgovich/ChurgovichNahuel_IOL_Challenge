using System.Collections.Generic;
using System.Linq;
using System.Text;

using CodingChallenge.Data.Enums;
using CodingChallenge.Data.Interfaces;

namespace CodingChallenge.Data.Classes
{
    public class Impresion
    {
        public static string Imprimir(List<FormaGeometrica> formas, EnumIdiomas idioma)//INCLUIR EL IDIOMA
        {
            var sb = new StringBuilder();

            if (!formas.Any())
            {
                sb.Append($"<h1>{Traductor.Traducir("Lista de formas vacía!", idioma)}</h1>");
            }
            else
            {
                sb.Append($"<h1>{Traductor.Traducir("Detalle", idioma)}:</h1><br/>");
                ImprimirDetalle(formas, sb, idioma);

                sb.Append($"<h1>{Traductor.Traducir("Agrupado", idioma)}:</h1><br/>");
                ImprimirAgrupado(formas, sb, idioma);

                sb.Append($"<h1>{Traductor.Traducir("TOTAL", idioma)}:</h1><br/>");
                ImprimirTotales(formas, sb, idioma);
            }
            return sb.ToString();
        }

        /// <summary>
        /// Imprime los datos de cada una de las figuras que se encuentran en la lista recibida por parámetro.
        /// </summary>
        /// <param name="formas"></param>
        /// <param name="sb"></param>
        private static void ImprimirDetalle(List<FormaGeometrica> formas, StringBuilder sb, EnumIdiomas idioma)
        {
            int contadorCirculos = 1;
            int contadorRectangulos = 1;
            int contadorTriangulos = 1;
            int contadorCuadrados = 1;
            int contadorPentagonos = 1;
            int contadorHexagonos = 1;
            int contadorTrapecios = 1;

            foreach (FormaGeometrica figura in formas)
            {
                switch (figura.tipo)
                {
                    case EnumTipoFigura.Circulo:
                        sb.Append($"{contadorCirculos}) {((IImprimible)figura).Imprimir(idioma)}");
                        contadorCirculos++;
                        break;
                    case EnumTipoFigura.Rectangulo:
                        sb.Append($"{contadorRectangulos}) {((IImprimible)figura).Imprimir(idioma)}");
                        contadorRectangulos++;
                        break;
                    case EnumTipoFigura.Triangulo:
                        sb.Append($"{contadorTriangulos}) {((IImprimible)figura).Imprimir(idioma)}");
                        contadorTriangulos++;
                        break;
                    case EnumTipoFigura.Cuadrado:
                        sb.Append($"{contadorCuadrados}) {((IImprimible)figura).Imprimir(idioma)}");
                        contadorCuadrados++;
                        break;
                    case EnumTipoFigura.Pentagono:
                        sb.Append($"{contadorPentagonos}) {((IImprimible)figura).Imprimir(idioma)}");
                        contadorPentagonos++;
                        break;
                    case EnumTipoFigura.Hexagono:
                        sb.Append($"{contadorHexagonos}) {((IImprimible)figura).Imprimir(idioma)}");
                        contadorHexagonos++;
                        break;
                    case EnumTipoFigura.Trapecio:
                        sb.Append($"{contadorTrapecios}) {((IImprimible)figura).Imprimir(idioma)}");
                        contadorTrapecios++;
                        break;
                    default:
                        sb.Append($"{Traductor.Traducir("-> Tipo de figura inexistente", idioma)}");
                        break;
                }
            }
        }
        /// <summary>
        /// Imprime la cantidad de figuras procesadas, agrupadas por tipo y la sumatoria de los perímetros y áreas del grupo.
        /// </summary>
        /// <param name="formas"></param>
        /// <param name="sb"></param>
        private static void ImprimirAgrupado(List<FormaGeometrica> formas, StringBuilder sb, EnumIdiomas idioma)
        {
            int cantidadCirculos = formas.Where(x => x.tipo == EnumTipoFigura.Circulo).Count();
            int cantidadRectangulos = formas.Where(x => x.tipo == EnumTipoFigura.Rectangulo).Count();
            int cantidadTriangulos = formas.Where(x => x.tipo == EnumTipoFigura.Triangulo).Count();
            int cantidadCuadrados = formas.Where(x => x.tipo == EnumTipoFigura.Cuadrado).Count();
            int cantidadPentagonos = formas.Where(x => x.tipo == EnumTipoFigura.Pentagono).Count();
            int cantidadHexagonos = formas.Where(x => x.tipo == EnumTipoFigura.Hexagono).Count();
            int cantidadTrapecios = formas.Where(x => x.tipo == EnumTipoFigura.Trapecio).Count();

            double perimetroCirculos = formas.Where(x => x.tipo == EnumTipoFigura.Circulo).Sum(x => x.perimetro);
            double perimetroRectangulos = formas.Where(x => x.tipo == EnumTipoFigura.Rectangulo).Sum(x => x.perimetro);
            double perimetroTriangulos = formas.Where(x => x.tipo == EnumTipoFigura.Triangulo).Sum(x => x.perimetro);
            double perimetroCuadrados = formas.Where(x => x.tipo == EnumTipoFigura.Cuadrado).Sum(x => x.perimetro);
            double perimetroPentagonos = formas.Where(x => x.tipo == EnumTipoFigura.Pentagono).Sum(x => x.perimetro);
            double perimetroHexagonos = formas.Where(x => x.tipo == EnumTipoFigura.Hexagono).Sum(x => x.perimetro);
            double perimetroTrapecios = formas.Where(x => x.tipo == EnumTipoFigura.Trapecio).Sum(x => x.perimetro);

            double areaCirculos = formas.Where(x => x.tipo == EnumTipoFigura.Circulo).Sum(x => x.area);
            double areaRectangulos = formas.Where(x => x.tipo == EnumTipoFigura.Rectangulo).Sum(x => x.area);
            double areaTriangulos = formas.Where(x => x.tipo == EnumTipoFigura.Triangulo).Sum(x => x.area);
            double areaCuadrados = formas.Where(x => x.tipo == EnumTipoFigura.Cuadrado).Sum(x => x.area);
            double areaPentagonos = formas.Where(x => x.tipo == EnumTipoFigura.Pentagono).Sum(x => x.area);
            double areaHexagonos = formas.Where(x => x.tipo == EnumTipoFigura.Hexagono).Sum(x => x.area);
            double areaTrapecios = formas.Where(x => x.tipo == EnumTipoFigura.Trapecio).Sum(x => x.area);

            if (cantidadCirculos == 1)
            {
                sb.Append($"{Traductor.Traducir("Hay solo un círculo, estos son los datos calculados: Área", idioma)} {areaCirculos:#.##} | {Traductor.Traducir("Perímetro", idioma)} {perimetroCirculos:#.##}<br/>");
            }
            else if (cantidadCirculos > 1)
            {
                sb.Append($"{Traductor.Traducir("Hay un total de", idioma)} {cantidadCirculos} {Traductor.Traducir("círculos, la sumatoria de sus áreas y perímetros es la siguiente: Área", idioma)} {areaCirculos:#.##} | {Traductor.Traducir("Perímetro", idioma)} {perimetroCirculos:#.##}<br/>");
            }

            if (cantidadRectangulos == 1)
            {
                sb.Append($"{Traductor.Traducir("Hay solo un rectángulo, estos son los datos calculados: Área", idioma)} {areaRectangulos:#.##} | {Traductor.Traducir("Perímetro", idioma)} {perimetroRectangulos:#.##}<br/>");
            }
            else if (cantidadRectangulos > 1)
            {
                sb.Append($"{Traductor.Traducir("Hay un total de", idioma)} {cantidadRectangulos} {Traductor.Traducir("rectángulos, la sumatoria de sus áreas y perímetros es la siguiente: Área", idioma)} {areaRectangulos:#.##} | {Traductor.Traducir("Perímetro", idioma)} {perimetroRectangulos:#.##}<br/>");
            }

            if (cantidadTriangulos == 1)
            {
                sb.Append($"{Traductor.Traducir("Hay solo un triángulo, estos son los datos calculados: Área", idioma)} {areaTriangulos:#.##} | {Traductor.Traducir("Perímetro", idioma)} {perimetroTriangulos:#.##}<br/>");
            }
            else if (cantidadTriangulos > 1)
            {
                sb.Append($"{Traductor.Traducir("Hay un total de", idioma)} {cantidadTriangulos} {Traductor.Traducir("triángulos, la sumatoria de sus áreas y perímetros es la siguiente: Área", idioma)} {areaTriangulos:#.##} | {Traductor.Traducir("Perímetro", idioma)} {perimetroTriangulos:#.##}<br/>");
            }

            if (cantidadCuadrados == 1)
            {
                sb.Append($"{Traductor.Traducir("Hay solo un cuadrado, estos son los datos calculados: Área", idioma)} {areaCuadrados:#.##} | {Traductor.Traducir("Perímetro", idioma)} {perimetroCuadrados:#.##}<br/>");
            }
            else if (cantidadCuadrados > 1)
            {
                sb.Append($"{Traductor.Traducir("Hay un total de", idioma)} {cantidadCuadrados} {Traductor.Traducir("cuadrados, la sumatoria de sus áreas y perímetros es la siguiente: Área", idioma)} {areaCuadrados:#.##} | {Traductor.Traducir("Perímetro", idioma)} {perimetroCuadrados:#.##}<br/>");
            }

            if (cantidadPentagonos == 1)
            {
                sb.Append($"{Traductor.Traducir("Hay solo un pentágono, estos son los datos calculados: Área", idioma)} {areaPentagonos:#.##} | {Traductor.Traducir("Perímetro", idioma)} {perimetroPentagonos:#.##}<br/>");
            }
            else if (cantidadPentagonos > 1)
            {
                sb.Append($"{Traductor.Traducir("Hay un total de", idioma)} {cantidadPentagonos} {Traductor.Traducir("pentágonos, la sumatoria de sus áreas y perímetros es la siguiente: Área", idioma)} {areaPentagonos:#.##} | {Traductor.Traducir("Perímetro", idioma)} {perimetroPentagonos:#.##}<br/>");
            }

            if (cantidadHexagonos == 1)
            {
                sb.Append($"{Traductor.Traducir("Hay solo un hexágono, estos son los datos calculados: Área", idioma)} {areaHexagonos:#.##} | {Traductor.Traducir("Perímetro", idioma)} {perimetroHexagonos:#.##}<br/>");
            }
            else if (cantidadHexagonos > 1)
            {
                sb.Append($"{Traductor.Traducir("Hay un total de", idioma)} {cantidadHexagonos} {Traductor.Traducir("hexágonos, la sumatoria de sus áreas y perímetros es la siguiente: Área", idioma)} {areaHexagonos:#.##} | {Traductor.Traducir("Perímetro", idioma)} {perimetroHexagonos:#.##}<br/>");
            }

            if (cantidadTrapecios == 1)
            {
                sb.Append($"{Traductor.Traducir("Hay solo un trapecio, estos son los datos calculados: Área", idioma)} {areaTrapecios:#.##} | {Traductor.Traducir("Perímetro", idioma)} {perimetroTrapecios:#.##}<br/>");
            }
            else if (cantidadTrapecios > 1)
            {
                sb.Append($"{Traductor.Traducir("Hay un total de", idioma)} {cantidadTrapecios} {Traductor.Traducir("trapecios, la sumatoria de sus áreas y perímetros es la siguiente: Área", idioma)} {areaTrapecios:#.##} | {Traductor.Traducir("Perímetro", idioma)} {perimetroTrapecios:#.##}<br/>");
            }
        }
        /// <summary>
        /// Imprime la cantidad de figuras procesadas y la sumatoria de sus perímetros y áreas.
        /// </summary>
        /// <param name="formas"></param>
        /// <param name="sb"></param>
        private static void ImprimirTotales(List<FormaGeometrica> formas, StringBuilder sb, EnumIdiomas idioma)
        {
            sb.Append($"{Traductor.Traducir("Figuras procesadas", idioma)} = {formas.Count()}<br/>");
            sb.Append($"{Traductor.Traducir("Sumatoria de perímetros", idioma)} = {formas.Sum(x => x.perimetro):#.##}<br/>");
            sb.Append($"{Traductor.Traducir("Sumatoria de áreas", idioma)} = {formas.Sum(x => x.area):#.##}<br/>");
        }
    }
}
