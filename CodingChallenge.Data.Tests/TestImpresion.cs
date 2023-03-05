using CodingChallenge.Data.Classes;
using CodingChallenge.Data.Enums;

using Microsoft.VisualStudio.TestTools.UnitTesting;

using System;
using System.Collections.Generic;

namespace CodingChallenge.Data.Tests
{
    [TestClass]
    public class TestImpresion
    {
        [TestMethod]
        public void Test_ImprimirCastellano_OK()
        {
            List<FormaGeometrica> list = new List<FormaGeometrica>();

            Circulo circulo = new Circulo(null, null, 12.5);
            Rectangulo rectangulo = new Rectangulo(5.5, 10.5, null);
            Triangulo triangulo = new Triangulo(6.5, 11.5, null);
            Cuadrado cuadrado = new Cuadrado(5.0, null, null);
            Pentagono pentagono = new Pentagono(6.0, null, null);
            Hexagono hexagono = new Hexagono(5.5, null, null);
            Trapecio trapecio = new Trapecio(5.0, 5.5, null, 4.0, 5.5, 5.5);


            list.Add(circulo);
            list.Add(rectangulo);
            list.Add(triangulo);
            list.Add(cuadrado);
            list.Add(pentagono);
            list.Add(hexagono);
            list.Add(trapecio);
            list.Add(rectangulo);

            string imprimible = Impresion.Imprimir(list, EnumIdiomas.Castellano);

            #region Resultado esperado
            string esperado = "<h1>Detalle:</h1><br/>" +
                "1) Circulo | Área 490,87 | Perímetro 78,54 | Radio 12,5<br/>" +
                "1) Rectangulo | Área 57,75 | Perímetro 32 | Base 5,5 | Altura 10,5<br/>" +
                "1) Triangulo | Área 37,38 | Perímetro 19,5 | Base 6,5 | Altura 11,5<br/>" +
                "1) Cuadrado | Área 25 | Perímetro 20 | Base 5<br/>" +
                "1) Pentagono | Área 61,94 | Perímetro 30 | Base 6<br/>" +
                "1) Hexagono | Área 78,59 | Perímetro 33 | Base 5,5<br/>" +
                "1) Trapecio | Área 24,75 | Perímetro 20 | Base 5 | Altura 5,5 | Base Superior 4<br/>" +
                "2) Rectangulo | Área 57,75 | Perímetro 32 | Base 5,5 | Altura 10,5<br/>" +
                "<h1>Agrupado:</h1><br/>" +
                "Hay solo un círculo, estos son los datos calculados: Área 490,87 | Perímetro 78,54<br/>" +
                "Hay un total de 2 rectángulos, la sumatoria de sus áreas y perímetros es la siguiente: Área 115,5 | Perímetro 64<br/>" +
                "Hay solo un triángulo, estos son los datos calculados: Área 37,38 | Perímetro 19,5<br/>" +
                "Hay solo un cuadrado, estos son los datos calculados: Área 25 | Perímetro 20<br/>" +
                "Hay solo un pentágono, estos son los datos calculados: Área 61,94 | Perímetro 30<br/>" +
                "Hay solo un hexágono, estos son los datos calculados: Área 78,59 | Perímetro 33<br/>" +
                "Hay solo un trapecio, estos son los datos calculados: Área 24,75 | Perímetro 20<br/>" +
                "<h1>TOTAL:</h1><br/>" +
                "Figuras procesadas = 8<br/>" +
                "Sumatoria de perímetros = 265,04<br/>" +
                "Sumatoria de áreas = 834,03<br/>";
            #endregion
            Assert.AreEqual(imprimible, esperado);
        }
        [TestMethod]
        public void Test_ImprimirItaliano_OK()
        {
            List<FormaGeometrica> list = new List<FormaGeometrica>();

            Circulo circulo = new Circulo(null, null, 12.5);
            Rectangulo rectangulo = new Rectangulo(5.5, 10.5, null);
            Triangulo triangulo = new Triangulo(6.5, 11.5, null);
            Cuadrado cuadrado = new Cuadrado(5.0, null, null);
            Pentagono pentagono = new Pentagono(6.0, null, null);
            Hexagono hexagono = new Hexagono(5.5, null, null);
            Trapecio trapecio = new Trapecio(5.0, 5.5, null, 4.0, 5.5, 5.5);


            list.Add(circulo);
            list.Add(rectangulo);
            list.Add(triangulo);
            list.Add(cuadrado);
            list.Add(pentagono);
            list.Add(hexagono);
            list.Add(trapecio);
            list.Add(rectangulo);

            string imprimible = Impresion.Imprimir(list, EnumIdiomas.Italiano);

            #region Resultado esperado
            string esperado = "<h1>Dettaglio:</h1><br/>" +
                "1) Cerchio | La zona 490,87 | Perimetro 78,54 | Radio 12,5<br/>" +
                "1) Rettangolo | La zona 57,75 | Perimetro 32 | Base 5,5 | Altezza 10,5<br/>" +
                "1) Triangolo | La zona 37,38 | Perimetro 19,5 | Base 6,5 | Altezza 11,5<br/>" +
                "1) Piazza | La zona 25 | Perimetro 20 | Base 5<br/>" +
                "1) Pentagono | La zona 61,94 | Perimetro 30 | Base 6<br/>" +
                "1) Esagono | La zona 78,59 | Perimetro 33 | Base 5,5<br/>" +
                "1) Trapezio | La zona 24,75 | Perimetro 20 | Base 5 | Altezza 5,5 | Base Superiore 4<br/>" +
                "2) Rettangolo | La zona 57,75 | Perimetro 32 | Base 5,5 | Altezza 10,5<br/>" +
                "<h1>Raggruppato:</h1><br/>" +
                "C'è solo un cerchio, questi sono i dati calcolati: Area 490,87 | Perimetro 78,54<br/>" +
                "C'è un totale di 2 rettangoli, la somma delle loro aree e perimetri è la seguente: Area 115,5 | Perimetro 64<br/>" +
                "C'è solo un triangolo, questi sono i dati calcolati: Area 37,38 | Perimetro 19,5<br/>" +
                "C'è solo un quadrato, questi sono i dati calcolati: Area 25 | Perimetro 20<br/>" +
                "C'è solo un pentagono, questi sono i dati calcolati: Area 61,94 | Perimetro 30<br/>" +
                "C'è solo un esagono, questi sono i dati calcolati: Area 78,59 | Perimetro 33<br/>" +
                "C'è un solo trapezio, questi sono i dati calcolati: Area 24,75 | Perimetro 20<br/>" +
                "<h1>TOTALE:</h1><br/>" +
                "Figure elaborate = 8<br/>" +
                "Somma di perimetri = 265,04<br/>" +
                "Somma di aree = 834,03<br/>";
            #endregion
            Assert.AreEqual(imprimible, esperado);

        }

        public void Test_ImprimirListaVacia_OK()
        {
            List<FormaGeometrica> list = new List<FormaGeometrica>();

            string imprimible = Impresion.Imprimir(list, EnumIdiomas.Castellano);

            #region Resultado esperado
            string esperado = "<h1>Lista de formas vacía!</h1>";
            #endregion
            Assert.AreEqual(imprimible, esperado);

        }

        public void Test_Imprimir_Exception()
        {




        }
    }
}
