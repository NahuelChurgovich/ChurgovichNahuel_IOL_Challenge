using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CodingChallenge.Data.Interfaces;

namespace CodingChallenge.Data.Classes
{
    public class Cuadrado : FormaGeometrica, IFiguraGeometrica
    {
        static Cuadrado()
        {
            Tipo = Enums.EnumTipoFigura.Cuadrado;
            CantidadLados = 4;
        }
        public Cuadrado(decimal? ladoInferior, decimal? altura, decimal? radio)
            : base(ladoInferior, altura, radio)
        {
        }

        public decimal CalcularArea()
        {
            return Base.Value * Altura.Value == 0 ? (Base.Value * Base.Value == 0 ? Altura.Value * Altura.Value : Base.Value * Base.Value) : Base.Value * Altura.Value;
        }
    }
}
