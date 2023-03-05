using System;
using System.Collections.Generic;
using CodingChallenge.Data.Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodingChallenge.Data;

namespace CodingChallenge.Data.Tests
{
    [TestClass]
    public class TestsClasesFiguras
    {        

        #region Circulo
        [TestMethod]
        [DataRow(null, null, 5.5, 34.6)]
        [DataRow(null, null, -5.5, 34.6)]
        public void Test_CalcularPerimetroCirculo_OK(double? ladoInferior, double? altura, double? radio, double esperado)
        {
            //Arrange
            Circulo c1 = new Circulo(ladoInferior, altura, radio);
            //Act
            double actual = Math.Round(c1.perimetro, 1);
            //Assert
            Assert.AreEqual(esperado, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        [DataRow(null, 5.5, null)]
        [DataRow(5.5, null, null)]
        [DataRow(5.5, 5.5, null)]
        public void Test_CalcularPerimetroCirculo_Exception(double? ladoInferior, double? altura, double? radio)
        {
            //Arrange
            Circulo c = new Circulo(ladoInferior, altura, radio);
            //Act
            Math.Round(c.perimetro, 1);
        }

        [TestMethod]
        [DataRow(null, null, 5.5, 95)]
        public void Test_CalcularAreaCirculo_OK(double? ladoInferior, double? altura, double? radio, double esperado)
        {
            Circulo c = new Circulo(ladoInferior, altura, radio);
            double actual = Math.Round(c.area, 1);
            Assert.AreEqual(esperado, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        [DataRow(null, 5.5, null)]
        [DataRow(5.5, null, null)]
        [DataRow(5.5, 5.5, null)]
        public void Test_CalcularAreaCirculo_Exception(double? ladoInferior, double? altura, double? radio)
        {
            Circulo c = new Circulo(ladoInferior, altura, radio);
            Math.Round(c.area, 1);
        }
        #endregion

        #region Cuadrado
        [TestMethod]
        [DataRow(5.0, null, null, 25)]
        [DataRow(-5.0, null, null, 25)]
        public void Test_CalcularAreaCuadrado_OK(double? ladoInferior, double? altura, double? radio, double esperado)
        {
            Cuadrado c = new Cuadrado(ladoInferior, altura, radio);
            double actual = Math.Round(c.area, 1);
            Assert.AreEqual(esperado, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        [DataRow(null, null, 5.0)]
        [DataRow(null, 5.0, null)]
        [DataRow(null, 5.0, 5.0)]
        public void Test_CalcularAreaCuadrado_Exception(double? ladoInferior, double? altura, double? radio)
        {
            Cuadrado c = new Cuadrado(ladoInferior, altura, radio);
            Math.Round(c.area, 1);
        }
        #endregion

        #region Rectángulo
        [TestMethod]
        [DataRow(5.0, 6.0, null, 22)]
        [DataRow(-5.0, 6.0, null, 22)]
        public void Test_CalcularPerimetroRectangulo_OK(double? ladoInferior, double? altura, double? radio, double esperado)
        {
            //Arrange
            Rectangulo r = new Rectangulo(ladoInferior, altura, radio);
            //Act
            double actual = Math.Round(r.perimetro, 1);
            //Assert
            Assert.AreEqual(esperado, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        [DataRow(null, null, 5.5)]
        [DataRow(null, 5.5, null)]
        [DataRow(5.5, null, null)]
        [DataRow(5.5, null, 5.5)]
        [DataRow(null, 5.5, 5.5)]
        public void Test_CalcularPerimetroRectangulo_Exception(double? ladoInferior, double? altura, double? radio)
        {
            //Arrange
            Rectangulo r = new Rectangulo(ladoInferior, altura, radio);
            //Act
            Math.Round(r.perimetro, 1);
        }

        [TestMethod]
        [DataRow(5.0, 6.0, null, 30)]
        [DataRow(-5.0, 6.0, null, 30)]
        public void Test_CalcularAreaRectangulo_OK(double? ladoInferior, double? altura, double? radio, double esperado)
        {
            Rectangulo r = new Rectangulo(ladoInferior, altura, radio);
            double actual = Math.Round(r.area, 1);
            Assert.AreEqual(esperado, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        [DataRow(null, null, 5.5)]
        [DataRow(null, 5.5, null)]
        [DataRow(5.5, null, null)]
        [DataRow(5.5, null, 5.5)]
        [DataRow(null, 5.5, 5.5)]
        public void Test_CalcularAreaRectangulo_Exception(double? ladoInferior, double? altura, double? radio)
        {
            Rectangulo r = new Rectangulo(ladoInferior, altura, radio);
            Math.Round(r.area, 1);
        }
        #endregion

        #region Hexágono

        [TestMethod]
        [DataRow(5.5, null, null, 78.6)]
        [DataRow(-5.5, null, null, 78.6)]
        public void Test_CalcularAreaHexagono_OK(double? ladoInferior, double? altura, double? radio, double esperado)
        {
            Hexagono h = new Hexagono(ladoInferior, altura, radio);
            double actual = Math.Round(h.area, 1);
            Assert.AreEqual(esperado, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        [DataRow(null, null, 5.0)]
        [DataRow(null, 5.0, null)]
        [DataRow(null, 5.0, 5.0)]
        public void Test_CalcularAreaHexagono_Exception(double? ladoInferior, double? altura, double? radio)
        {
            Hexagono h = new Hexagono(ladoInferior, altura, radio);
            Math.Round(h.area, 1);
        }

        #endregion

        #region Pentágono

        [TestMethod]
        [DataRow(5.5, null, null, 52.0)]
        [DataRow(-5.5, null, null, 52.0)]
        public void Test_CalcularAreaPentagono_OK(double? ladoInferior, double? altura, double? radio, double esperado)
        {
            Pentagono p = new Pentagono(ladoInferior, altura, radio);
            double actual = Math.Round(p.area, 1);
            Assert.AreEqual(esperado, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        [DataRow(null, null, 5.0)]
        [DataRow(null, 5.0, null)]
        [DataRow(null, 5.0, 5.0)]
        public void Test_CalcularAreaPentagono_Exception(double? ladoInferior, double? altura, double? radio)
        {
            Pentagono p = new Pentagono(ladoInferior, altura, radio);
            Math.Round(p.area, 1);
        }

        #endregion

        #region Triangulo

        [TestMethod]
        [DataRow(5.5, 6.0, null, 16.5)]
        [DataRow(-5.5, 6.0, null, 16.5)]
        public void Test_CalcularAreaTriangulo_OK(double? ladoInferior, double? altura, double? radio, double esperado)
        {
            Triangulo t = new Triangulo(ladoInferior, altura, radio);
            double actual = Math.Round(t.area, 1);
            Assert.AreEqual(esperado, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        [DataRow(null, null, 5.0)]
        [DataRow(null, 5.0, null)]
        [DataRow(null, 5.0, 5.0)]
        public void Test_CalcularAreaTriangulo_Exception(double? ladoInferior, double? altura, double? radio)
        {
            Triangulo t = new Triangulo(ladoInferior, altura, radio);
            Math.Round(t.area, 1);
        }

        #endregion

        #region Trapecio
        [TestMethod]
        [DataRow(5.0, 5.5, null, 4.0, 5.5, 5.5, 20.0)]
        [DataRow(-5.0, 5.5, null, 4.0, -5.5, 5.5, 20.0)]
        public void Test_CalcularPerimetroTrapecio_OK(double? ladoInferior, double? altura, double? radio, double? ladoSuperior, double? ladoIzquierdo, double? ladoDerecho, double esperado)
        {
            //Arrange
            Trapecio t = new Trapecio(ladoInferior, altura, radio, ladoSuperior, ladoIzquierdo, ladoDerecho);
            //Act
            double actual = Math.Round(t.perimetro, 1);
            //Assert
            Assert.AreEqual(esperado, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        [DataRow(null, 5.0, 5.0, 5.0, 5.0, 5.0)]
        [DataRow(5.0, null, 5.0, 5.0, 5.0, 5.0)]
        [DataRow(5.0, 5.0, 5.0, null, 5.0, 5.0)]
        [DataRow(5.0, 5.0, 5.0, 5.0, null, 5.0)]
        [DataRow(5.0, 5.0, 5.0, 5.0, 5.0, null)]
        [DataRow(null, null, 5.0, 5.0, 5.0, 5.0)]
        [DataRow(5.0, null, null, 5.0, 5.0, 5.0)]
        [DataRow(5.0, 5.0, null, null, 5.0, 5.0)]
        [DataRow(5.0, 5.0, 5.0, null, null, 5.0)]
        [DataRow(5.0, 5.0, 5.0, 5.0, null, null)]
        [DataRow(null, null, null, 5.0, 5.0, 5.0)]
        [DataRow(5.0, null, null, null, 5.0, 5.0)]
        [DataRow(5.0, 5.0, null, null, null, 5.0)]
        [DataRow(5.0, 5.0, 5.0, null, null, null)]
        [DataRow(null, null, null, null, 5.0, 5.0)]
        [DataRow(null, null, null, 5.0, 5.0, null)]
        [DataRow(null, null, 5.0, 5.0, null, null)]
        [DataRow(null, 5.0, 5.0, null, null, null)]
        [DataRow(5.0, 5.0, null, null, null, null)]
        [DataRow(null, null, null, null, null, 5.0)]
        [DataRow(null, null, null, null, 5.0, null)]
        [DataRow(null, null, null, 5.0, null, null)]
        [DataRow(null, null, 5.0, null, null, null)]
        [DataRow(null, 5.0, null, null, null, null)]
        [DataRow(5.0, null, null, null, null, null)]
        [DataRow(null, null, null, null, null, null)]
        public void Test_CalcularPerimetroTrapecio_Exception(double? ladoInferior, double? altura, double? radio, double? ladoSuperior, double? ladoIzquierdo, double? ladoDerecho)
        {
            //Arrange
            Trapecio t = new Trapecio(ladoInferior, altura, radio, ladoSuperior, ladoIzquierdo, ladoDerecho);
            //Act
            Math.Round(t.perimetro, 1);
        }

        [TestMethod]
        [DataRow(5.0, 5.5, null, 4.0, 5.5, 5.5, 24.8)]
        [DataRow(-5.0, 5.5, null, 4.0, -5.5, 5.5, 24.8)]
        public void Test_CalcularAreaTrapecio_OK(double? ladoInferior, double? altura, double? radio, double? ladoSuperior, double? ladoIzquierdo, double? ladoDerecho, double esperado)
        {
            Trapecio t = new Trapecio(ladoInferior, altura, radio, ladoSuperior, ladoIzquierdo, ladoDerecho);
            double actual = Math.Round(t.area, 1);
            Assert.AreEqual(esperado, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        [DataRow(null, 5.0, 5.0, 5.0, 5.0, 5.0)]
        [DataRow(5.0, null, 5.0, 5.0, 5.0, 5.0)]
        [DataRow(5.0, 5.0, 5.0, null, 5.0, 5.0)]
        [DataRow(5.0, 5.0, 5.0, 5.0, null, 5.0)]
        [DataRow(5.0, 5.0, 5.0, 5.0, 5.0, null)]
        [DataRow(null, null, 5.0, 5.0, 5.0, 5.0)]
        [DataRow(5.0, null, null, 5.0, 5.0, 5.0)]
        [DataRow(5.0, 5.0, null, null, 5.0, 5.0)]
        [DataRow(5.0, 5.0, 5.0, null, null, 5.0)]
        [DataRow(5.0, 5.0, 5.0, 5.0, null, null)]
        [DataRow(null, null, null, 5.0, 5.0, 5.0)]
        [DataRow(5.0, null, null, null, 5.0, 5.0)]
        [DataRow(5.0, 5.0, null, null, null, 5.0)]
        [DataRow(5.0, 5.0, 5.0, null, null, null)]
        [DataRow(null, null, null, null, 5.0, 5.0)]
        [DataRow(null, null, null, 5.0, 5.0, null)]
        [DataRow(null, null, 5.0, 5.0, null, null)]
        [DataRow(null, 5.0, 5.0, null, null, null)]
        [DataRow(5.0, 5.0, null, null, null, null)]
        [DataRow(null, null, null, null, null, 5.0)]
        [DataRow(null, null, null, null, 5.0, null)]
        [DataRow(null, null, null, 5.0, null, null)]
        [DataRow(null, null, 5.0, null, null, null)]
        [DataRow(null, 5.0, null, null, null, null)]
        [DataRow(5.0, null, null, null, null, null)]
        [DataRow(null, null, null, null, null, null)]
        public void Test_CalcularAreaTrapecio_Exception(double? ladoInferior, double? altura, double? radio, double? ladoSuperior, double? ladoIzquierdo, double? ladoDerecho)
        {
            Trapecio t = new Trapecio(ladoInferior, altura, radio, ladoSuperior, ladoIzquierdo, ladoDerecho);
            Math.Round(t.area, 1);
        }
        #endregion
    }
}
