using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodingChallenge.Data.Classes;

namespace CodingChallenge.Data.Tests
{
    [TestClass]
    public class TestClaseAbstracta
    {
        #region Triangulo

        [TestMethod]
        [DataRow(5.0, 5.0, null, 15)]
        [DataRow(-5.0, 5.0, null, 15)]
        public void Test_PerimetroFiguraRegularTriangulo_OK(double? ladoInferior, double? altura, double? radio, double esperado)
        {
            //Arrange
            Triangulo t = new Triangulo(ladoInferior, altura, radio);
            //Act
            double actual = Math.Round(t.perimetro, 0);
            //Assert
            Assert.AreEqual(esperado, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        [DataRow(null, null, 5.0)]
        [DataRow(5.0, null, 5.0)]
        [DataRow(null, 5.0, null)]
        [DataRow(null, 5.0, 5.0)]
        public void Test_PerimetroFiguraRegulaTriangulo_Exception(double? ladoInferior, double? altura, double? radio)
        {
            //Arrange
            Triangulo t = new Triangulo(ladoInferior, altura, radio);
            //Act
            Math.Round(t.perimetro, 1);
        }
        #endregion

        #region Cuadrado

        [TestMethod]
        [DataRow(5.0, null, null, 20)]
        [DataRow(-5.0, null, null, 20)]
        public void Test_PerimetroFiguraRegularCuadrado_OK(double? ladoInferior, double? altura, double? radio, double esperado)
        {
            //Arrange
            Cuadrado c = new Cuadrado(ladoInferior, altura, radio);
            //Act
            double actual = Math.Round(c.perimetro, 0);
            //Assert
            Assert.AreEqual(esperado, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        [DataRow(null, null, 5.0)]
        [DataRow(null, 5.0, null)]
        [DataRow(null, 5.0, 5.0)]
        public void Test_PerimetroFiguraRegulaCuadrado_Exception(double? ladoInferior, double? altura, double? radio)
        {
            //Arrange
            Cuadrado c = new Cuadrado(ladoInferior, altura, radio);
            //Act
            Math.Round(c.perimetro, 1);
        }


        #endregion


    }
}
