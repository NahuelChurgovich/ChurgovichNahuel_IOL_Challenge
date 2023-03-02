using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CodingChallenge.Data.Interfaces;

namespace CodingChallenge.Data.Classes
{
    public class Triangulo : FormaGeometrica, IFiguraGeometrica
    {
        static Triangulo()
        {
            Tipo = Enums.EnumTipoFigura.Triangulo;
            CantidadLados = 3;
        }
        public Triangulo(decimal? ladoInferior, decimal? altura, decimal? radio)
            : base(ladoInferior, altura, radio)
        {
        }

        public decimal CalcularArea()
        {
            return (Base.Value * Altura.Value) / 2;
        }


    }
}
