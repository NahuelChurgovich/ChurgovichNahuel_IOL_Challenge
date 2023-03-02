using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CodingChallenge.Data.Interfaces;

namespace CodingChallenge.Data.Classes
{
    public class Rectangulo : FormaGeometrica, IFiguraGeometrica
    {
        static Rectangulo()
        {
            Tipo = Enums.EnumTipoFigura.Rectangulo;
            CantidadLados = 4;
        }
        public Rectangulo(decimal? ladoInferior, decimal? altura, decimal? radio)
            : base(ladoInferior, altura, radio)
        {
        }

        public decimal CalcularArea()
        {
            return Base.Value * Altura.Value;
        }

        public override decimal CalcularPerimetro()
        {
            return (Base.Value * 2) + (Altura.Value * 2);
        }

    }
}
