using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                sb.Append($"<h1>{Traductor.Traducir("Lista de formas vacía!",idioma)}</h1>");
            }
            else
            {
                sb.Append($"{Traductor.Traducir("Detalle",idioma)}:<br/>");
                ImprimirDetalle(formas, sb, idioma);

                sb.Append($"{Traductor.Traducir("Agrupado", idioma)}:<br/>");
                ImprimirAgrupado(formas, sb, idioma);

                sb.Append($"{Traductor.Traducir("TOTAL", idioma)}:<br/>");
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
                        sb.Append($"{contadorCirculos}) {((IImprimible)figura).Imprimir(idioma)}<br/>");
                        contadorCirculos++;
                        break;
                    case EnumTipoFigura.Rectangulo:
                        sb.Append($"{contadorRectangulos}) {((IImprimible)figura).Imprimir(idioma)}<br/>");
                        contadorRectangulos++;
                        break;
                    case EnumTipoFigura.Triangulo:
                        sb.Append($"{contadorTriangulos}) {((IImprimible)figura).Imprimir(idioma)}<br/>");
                        contadorTriangulos++;
                        break;
                    case EnumTipoFigura.Cuadrado:
                        sb.Append($"{contadorCuadrados}) {((IImprimible)figura).Imprimir(idioma)}<br/>");
                        contadorCuadrados++;
                        break;
                    case EnumTipoFigura.Pentagono:
                        sb.Append($"{contadorPentagonos}) {((IImprimible)figura).Imprimir(idioma)}<br/>");
                        contadorPentagonos++;
                        break;
                    case EnumTipoFigura.Hexagono:
                        sb.Append($"{contadorHexagonos}) {((IImprimible)figura).Imprimir(idioma)}<br/>");
                        contadorHexagonos++;
                        break;
                    case EnumTipoFigura.Trapecio:
                        sb.Append($"{contadorTrapecios}) {((IImprimible)figura).Imprimir(idioma)}<br/>");
                        contadorTrapecios++;
                        break;
                    default:
                        sb.Append($"{Traductor.Traducir("-> Tipo de figura inexistente", idioma)}<br/>");
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

            decimal perimetroCirculos = formas.Where(x => x.tipo == EnumTipoFigura.Circulo).Sum(x => x.perimetro);
            decimal perimetroRectangulos = formas.Where(x => x.tipo == EnumTipoFigura.Rectangulo).Sum(x => x.perimetro);
            decimal perimetroTriangulos = formas.Where(x => x.tipo == EnumTipoFigura.Triangulo).Sum(x => x.perimetro);
            decimal perimetroCuadrados = formas.Where(x => x.tipo == EnumTipoFigura.Cuadrado).Sum(x => x.perimetro);
            decimal perimetroPentagonos = formas.Where(x => x.tipo == EnumTipoFigura.Pentagono).Sum(x => x.perimetro);
            decimal perimetroHexagonos = formas.Where(x => x.tipo == EnumTipoFigura.Hexagono).Sum(x => x.perimetro);
            decimal perimetroTrapecios = formas.Where(x => x.tipo == EnumTipoFigura.Trapecio).Sum(x => x.perimetro);

            decimal areaCirculos = formas.Where(x => x.tipo == EnumTipoFigura.Circulo).Sum(x => x.area);
            decimal areaRectangulos = formas.Where(x => x.tipo == EnumTipoFigura.Rectangulo).Sum(x => x.area);
            decimal areaTriangulos = formas.Where(x => x.tipo == EnumTipoFigura.Triangulo).Sum(x => x.area);
            decimal areaCuadrados = formas.Where(x => x.tipo == EnumTipoFigura.Cuadrado).Sum(x => x.area);
            decimal areaPentagonos = formas.Where(x => x.tipo == EnumTipoFigura.Pentagono).Sum(x => x.area);
            decimal areaHexagonos = formas.Where(x => x.tipo == EnumTipoFigura.Hexagono).Sum(x => x.area);
            decimal areaTrapecios = formas.Where(x => x.tipo == EnumTipoFigura.Trapecio).Sum(x => x.area);

            //TODO: modificar las lineas de texto siguientes para lograr la traduccion.

            if (cantidadCirculos == 1)
            {
                sb.Append($"Hay solo un círculo, estos son los datos calculados: Área {areaCirculos:#.##} | Perímetro {perimetroCirculos:#.##}<br/>");
            }
            else if (cantidadCirculos > 1)
            {
                sb.Append($"Hay un total de {cantidadCirculos} círculos, la sumatoria de sus áreas y perímetros es la siguiente: Área {areaCirculos:#.##} | Perímetro {perimetroCirculos:#.##}<br/>");
            }

            if (cantidadRectangulos== 1)
            {
                sb.Append($"Hay solo un rectángulo, estos son los datos calculados: Área {areaCirculos:#.##} | Perímetro {perimetroCirculos:#.##}<br/>");
            }
            else if (cantidadRectangulos >1)
            {
                sb.Append($"Hay un total de {cantidadRectangulos} rectángulos, la sumatoria de sus áreas y perímetros es la siguiente: Área {areaRectangulos:#.##} | Perímetro {perimetroRectangulos:#.##}<br/>");
            }

            if (cantidadTriangulos == 1)
            {
                sb.Append($"Hay solo un triángulo, estos son los datos calculados: Área {areaCirculos:#.##} | Perímetro {perimetroCirculos:#.##}<br/>");
            }
            else if (cantidadTriangulos > 1)
            {
                sb.Append($"Hay un total de {cantidadTriangulos} triángulos, la sumatoria de sus áreas y perímetros es la siguiente: Área {areaTriangulos:#.##} | Perímetro {perimetroTriangulos:#.##}<br/>");
            }

            if (cantidadCuadrados == 1)
            {
                sb.Append($"Hay solo un cuadrado, estos son los datos calculados: Área {areaCirculos:#.##} | Perímetro {perimetroCirculos:#.##}<br/>");
            }
            else if (cantidadCuadrados > 1)
            {
                sb.Append($"Hay un total de {cantidadCuadrados} cuadrados, la sumatoria de sus áreas y perímetros es la siguiente: Área {areaCuadrados:#.##} | Perímetro {perimetroCuadrados:#.##}<br/>");
            }

            if (cantidadPentagonos == 1)
            {
                sb.Append($"Hay solo un pentágono, estos son los datos calculados: Área {areaCirculos:#.##} | Perímetro {perimetroCirculos:#.##}<br/>");
            }
            else if (cantidadPentagonos > 1)
            {
                sb.Append($"Hay un total de {cantidadPentagonos} pentágonos, la sumatoria de sus áreas y perímetros es la siguiente: Área {areaPentagonos:#.##} | Perímetro {perimetroPentagonos:#.##}<br/>");
            }

            if (cantidadHexagonos == 1)
            {
                sb.Append($"Hay solo un hexágono, estos son los datos calculados: Área {areaCirculos:#.##} | Perímetro {perimetroCirculos:#.##}<br/>");
            }
            else if (cantidadHexagonos > 1)
            {
                sb.Append($"Hay un total de {cantidadHexagonos} hexágonos, la sumatoria de sus áreas y perímetros es la siguiente: Área {areaHexagonos:#.##} | Perímetro {perimetroHexagonos:#.##}<br/>");
            }

            if (cantidadTrapecios == 1)
            {
                sb.Append($"Hay solo un trapecio, estos son los datos calculados: Área {areaCirculos:#.##} | Perímetro {perimetroCirculos:#.##}<br/>");
            }
            else if (cantidadTrapecios > 1)
            {
                sb.Append($"Hay un total de {cantidadTrapecios} trapecios, la sumatoria de sus áreas y perímetros es la siguiente: Área {areaTrapecios:#.##} | Perímetro {perimetroTrapecios:#.##}<br/>");
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
