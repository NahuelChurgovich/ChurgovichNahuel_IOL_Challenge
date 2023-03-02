using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CodingChallenge.Data.Interfaces;

namespace CodingChallenge.Data.Classes
{
    public class Circulo : FormaGeometrica, IFiguraGeometrica
    {
        static Circulo()
        {
            Tipo = Enums.EnumTipoFigura.Circulo;
            CantidadLados = 0;
        }
        public Circulo(decimal? ladoInferior, decimal? altura, decimal? radio)
            : base(ladoInferior, altura, radio)
        {
        }

        public decimal CalcularArea()
        {
            return (decimal)Math.PI * Radio.Value * Radio.Value;
        }

        public override decimal CalcularPerimetro()
        {
            return (decimal)Math.PI * Radio.Value * 2;
        }

    }
}
