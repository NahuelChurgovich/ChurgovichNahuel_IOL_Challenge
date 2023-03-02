using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CodingChallenge.Data.Interfaces;

namespace CodingChallenge.Data.Classes
{
    public class Hexagono : FormaGeometrica, IFiguraGeometrica
    {
        static Hexagono()
        {
            Tipo = Enums.EnumTipoFigura.Hexagono;
            CantidadLados = 6;
        }
        public Hexagono(decimal? ladoInferior, decimal? altura, decimal? radio)
            : base(ladoInferior, altura, radio)
        {
        }

        public decimal CalcularArea()
        {
            return (CalcularPerimetro() * Base.Value) / 2;
        }
    }
}
