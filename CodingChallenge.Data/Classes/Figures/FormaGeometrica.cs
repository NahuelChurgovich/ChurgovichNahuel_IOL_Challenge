using System;
using CodingChallenge.Data.Enums;

namespace CodingChallenge.Data.Classes
{
    public abstract class FormaGeometrica
    {
        #region Atributos
        public EnumTipoFigura tipo;
        public double perimetro;
        public double area;
        public double? ladoInferior; // este atributo representa la base, pero dicha nomenclatura no se puede utilizar por se una palabra reservada.
        public double? altura;
        public double? radio;
        #endregion

        #region Propiedades

        protected EnumTipoFigura Tipo { get => tipo; set => this.tipo = value; }
        protected int CantidadLados { get; set; }
        protected double Perimetro { get => perimetro; set => this.perimetro = Math.Abs(value); }
        protected double Area { get => area; set => this.area = Math.Abs(value); }
        protected double? Base { get => ladoInferior; set => this.ladoInferior = value; }
        protected double? Altura { get => altura; set => this.altura = value; }
        protected double? Radio { get => radio; set => this.radio = value; }
        #endregion

        #region Constructores
        public FormaGeometrica(double? ladoInferior, double? altura, double? radio)
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
            double perimetro = 0;
            try
            {
                for (int i = 0; i < CantidadLados; i++)
                {
                    perimetro += Math.Abs((double)this.ladoInferior);
                }
                Perimetro = perimetro;
            }
            catch (Exception)
            {
            throw new InvalidOperationException($"Solo el parámetro de lado inferior se admite para el {tipo}. Los otros deben ser nulos.");
            }
        }
        /// <summary>
        /// Se utiliza este método para que sea implementado en cada clase derivada realizando el calculo correspondiente a la figura representada.
        /// </summary>
        protected virtual void CalcularArea()
        {
        }

        #endregion

    }
}
