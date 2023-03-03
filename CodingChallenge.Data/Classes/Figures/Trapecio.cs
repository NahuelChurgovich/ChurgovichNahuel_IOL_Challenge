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
        private decimal? BaseSuperior { get => ladoSuperior; set => this.ladoSuperior = value; }
        static Trapecio()
        {
            CantidadLados = 4;
        }
        public Trapecio(decimal? ladoInferior, decimal? altura, decimal? radio, decimal? ladoSuperior)
            : base(ladoInferior, altura, radio)
        {
            Tipo = Enums.EnumTipoFigura.Trapecio;
            Radio = null;
            this.ladoSuperior = ladoSuperior;
            CalcularPerimetro();
            CalcularArea();
        }
        protected override void CalcularPerimetro()
        {
            Perimetro = Math.Round(Altura.Value + Base.Value + BaseSuperior.Value + ((decimal)Math.Sqrt((double)((Altura.Value * Altura.Value) +
              (Math.Abs((decimal)ladoSuperior - Base.Value) * Math.Abs((decimal)ladoSuperior - Base.Value))))),2);

        }
        protected override void CalcularArea()
        {
            Area = (decimal)((ladoSuperior + Base.Value) * Altura.Value) / 2;
        }

        public decimal? GetBaseSuperior() { return BaseSuperior; }

    }
}
