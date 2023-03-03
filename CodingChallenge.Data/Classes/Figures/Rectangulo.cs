using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CodingChallenge.Data.Interfaces;

namespace CodingChallenge.Data.Classes
{
    public class Rectangulo : FormaGeometrica, IImprimible
    {
        static Rectangulo()
        {
            CantidadLados = 4;
        }
        public Rectangulo(decimal? ladoInferior, decimal? altura, decimal? radio)
            : base(ladoInferior, altura, radio)
        {
            Tipo = Enums.EnumTipoFigura.Rectangulo;
            Radio = null;
            CalcularPerimetro();
            CalcularArea();
        }

        protected override void CalcularPerimetro()
        {
            Perimetro = (Base.Value * 2) + (Altura.Value * 2);
        }
        protected override void CalcularArea()
        {
            Area = Base.Value * Altura.Value;
        }

        public string Imprimir() { return $"{this.tipo} | Área {this.area:#.##} | Perímetro {this.perimetro:#.##} | Base {this.ladoInferior:#.##}| Altura {this.altura:#.##}<br/>"; }
    }
}
