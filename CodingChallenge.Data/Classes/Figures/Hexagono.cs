using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CodingChallenge.Data.Interfaces;

namespace CodingChallenge.Data.Classes
{
    public class Hexagono : FormaGeometrica, IImprimible
    {
        static Hexagono()
        {
            CantidadLados = 6;
        }
        public Hexagono(decimal? ladoInferior, decimal? altura, decimal? radio)
            : base(ladoInferior, altura, radio)
        {
            Tipo = Enums.EnumTipoFigura.Hexagono;
            Radio = null;
            CalcularPerimetro();
            CalcularArea();
        }

        protected override void CalcularArea()
        {
            Area = (this.perimetro * Base.Value) / 2;
        }

        public string Imprimir() { return $"{this.tipo} | Área {this.area:#.##} | Perímetro {this.perimetro:#.##} | Base {this.ladoInferior:#.##}<br/>"; }
    }
}
