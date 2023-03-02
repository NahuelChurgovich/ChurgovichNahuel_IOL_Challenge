using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CodingChallenge.Data.Interfaces;

namespace CodingChallenge.Data.Classes
{
    public class Pentagono : FormaGeometrica, IFiguraGeometrica
    {
        static Pentagono()
        {
            Tipo = Enums.EnumTipoFigura.Pentagono;
            CantidadLados = 5;
        }
        public Pentagono(decimal? ladoInferior, decimal? altura, decimal? radio)
            : base(ladoInferior, altura, radio)
        {
        }

        public decimal CalcularArea()
        {
            return (CalcularPerimetro() * Base.Value) / 2;
        }
    }
}
