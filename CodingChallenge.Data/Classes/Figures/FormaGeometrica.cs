/*
 * Refactorear la clase para respetar principios de programación orientada a objetos. Qué pasa si debemos soportar un nuevo idioma para los reportes, o
 * agregar más formas geométricas?
 *
 * Se puede hacer cualquier cambio que se crea necesario tanto en el código como en los tests. La única condición es que los tests pasen OK.
 *
 * TODO: Implementar Trapecio/Rectangulo, agregar otro idioma a reporting.
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
        private int cantidadLados;
        private decimal perimetro;
        private decimal area;
        private decimal? ladoInferior; // este atributo representa la base, pero dina nomenclatura no se puede utilizar por se una palabra reservada.
        private decimal? altura;
        private decimal? radio;
        #endregion

        #region Propiedades

        public static EnumTipoFigura Tipo { get; set; }
        public static int CantidadLados { get; set; }
        public decimal Perimetro { get; set; }
        public decimal Area { get; set; }
        public decimal? Base { get; set; }
        public decimal? Altura { get; set; }
        public decimal? Radio { get; set; }
        #endregion

        #region Constructores
        public FormaGeometrica(decimal? ladoInferior, decimal? altura, decimal? radio)
        {
            this.ladoInferior = ladoInferior;
            this.altura = altura;
            this.radio = radio;
        }
        #endregion

        #region Metodos
        /// <summary>
        /// Calculara el perimetro de cualquier figura geometrica equilatera, sabiendo cual es su base.
        /// </summary>
        /// <returns>El perimetro calculado</returns>
        /// <exception cref="Exception"></exception>
        public virtual decimal CalcularPerimetro()
        {
            decimal perimetro = 0;
            try
            {
                for (int i = 0; i < CantidadLados; i++)
                {
                    perimetro += Base.Value;
                }
                return perimetro;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocurrio un error al calcular el perimetro", ex);
            }
        }

        #endregion

    }
}
