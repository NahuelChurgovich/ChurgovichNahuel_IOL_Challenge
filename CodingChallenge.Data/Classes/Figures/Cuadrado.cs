using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CodingChallenge.Data.Interfaces;

namespace CodingChallenge.Data.Classes
{
    public class Cuadrado : FormaGeometrica, IImprimible
    {
        static Cuadrado()
        {
            CantidadLados = 4;
        }
        public Cuadrado(decimal? ladoInferior, decimal? altura, decimal? radio)
            : base(ladoInferior, altura, radio)
        {
            Tipo = Enums.EnumTipoFigura.Cuadrado;
            Radio = null;
            CalcularPerimetro();
            CalcularArea();
        }

        protected override void CalcularArea()
        {
            if (Base.HasValue && Altura.HasValue && Base.Value==Altura.Value )
            {
                Area = Base.Value * Altura.Value;
            }
            else if (Base.HasValue)
            {
                Area = Base.Value * Base.Value;
            }
            else
            {
                Area = Altura.Value * Altura.Value;
            }
        }

        public string Imprimir() { return $"{this.tipo} | Área {this.area:#.##} | Perímetro {this.perimetro:#.##} | Base {this.ladoInferior:#.##}<br/>"; }
    }
}
