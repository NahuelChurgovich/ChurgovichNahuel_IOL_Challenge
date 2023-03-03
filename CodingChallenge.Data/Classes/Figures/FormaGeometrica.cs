/*
 * Refactorear la clase para respetar principios de programación orientada a objetos. Qué pasa si debemos soportar un nuevo idioma para los reportes, o
 * agregar más formas geométricas?
 *
 * Se puede hacer cualquier cambio que se crea necesario tanto en el código como en los tests. La única condición es que los tests pasen OK.
 *
 * TODO: Implementar Trapecio/Rectángulo, agregar otro idioma a reporting.
 * */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using CodingChallenge.Data.Enums;

namespace CodingChallenge.Data.Classes
{
    public abstract class FormaGeometrica
    {
        #region Atributos
        private EnumTipoFigura tipo;
        private decimal perimetro;
        private decimal area;
        private decimal? ladoInferior; // este atributo representa la base, pero dicha nomenclatura no se puede utilizar por se una palabra reservada.
        private decimal? altura;
        private decimal? radio;
        #endregion

        #region Propiedades

        protected EnumTipoFigura Tipo { get => tipo; set => this.tipo = value; }
        protected static int CantidadLados { get; set; }
        protected decimal Perimetro { get => perimetro; set => this.perimetro = value; }
        protected decimal Area { get => area; set => this.area = value; }
        protected decimal? Base { get => ladoInferior; set => this.ladoInferior = value; }
        protected decimal? Altura { get => altura; set => this.altura = value; }
        protected decimal? Radio { get => radio; set => this.radio = value; }
        #endregion

        #region Constructores
        public FormaGeometrica(decimal? ladoInferior, decimal? altura, decimal? radio)
        {
            this.ladoInferior = ladoInferior;
            this.altura = altura;
            this.radio = radio;
        }
        #endregion

        #region Métodos

        /// <summary>
        /// Calculara el perímetro de cualquier figura geométrica equilatera, sabiendo cual es su base y seteara su atributo homónimo.
        /// </summary>
        /// <exception cref="Exception"></exception>
        protected virtual void CalcularPerimetro()
        {
            decimal perimetro = 0;
            try
            {
                for (int i = 0; i < CantidadLados; i++)
                {
                    perimetro += Base.Value;
                }
                Perimetro = perimetro;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocurrió un error al calcular el perímetro", ex);
            }
        }
        /// <summary>
        /// Se utiliza este método para que sea implementado en cada clase derivada realizando el calculo correspondiente a la figura representada.
        /// </summary>
        protected virtual void CalcularArea()
        {
        }

        public EnumTipoFigura GetTipo() { return Tipo; }
        public decimal GetCantidadLados() { return CantidadLados; }
        public decimal GetPerimetro() { return Perimetro; }
        public decimal GetArea() { return Area; }
        public decimal? GetBase() { return Base; }
        public decimal? GetAltura() { return Altura; }
        public decimal? GetRadio() { return Radio; }

        #endregion

    }
}
