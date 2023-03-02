using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CodingChallenge.Data.Interfaces;

namespace CodingChallenge.Data.Classes
{
    public class Trapecio : FormaGeometrica, IFiguraGeometrica
    {
        private decimal? ladoSuperior;
        public decimal? BaseSuperior { get => ladoSuperior; set => this.ladoSuperior = value; }
        static Trapecio()
        {
            Tipo = Enums.EnumTipoFigura.Trapecio;
            CantidadLados = 4;
        }
        public Trapecio(decimal? ladoInferior, decimal? altura, decimal? radio, decimal? ladoSuperior)
            : base(ladoInferior, altura, radio)
        {
            this.ladoSuperior = ladoSuperior;
        }

        public decimal CalcularArea()
        {
            return (decimal)((ladoSuperior + Base.Value) * Altura.Value) / 2;
        }

        public override decimal CalcularPerimetro()
        {
            return (decimal)Math.Sqrt((double)((Altura.Value * Altura.Value) + Math.Abs((decimal)ladoSuperior - Base.Value)));
        }

    }
}
