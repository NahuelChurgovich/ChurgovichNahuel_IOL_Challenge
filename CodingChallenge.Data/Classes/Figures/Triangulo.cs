using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CodingChallenge.Data.Enums;
using CodingChallenge.Data.Interfaces;

namespace CodingChallenge.Data.Classes
{
    public class Triangulo : FormaGeometrica, IImprimible
    {
        static Triangulo()
        {
            CantidadLados = 3;
        }
        public Triangulo(decimal? ladoInferior, decimal? altura, decimal? radio)
            : base(ladoInferior, altura, radio)
        {
            Tipo = Enums.EnumTipoFigura.Triangulo;
            Radio = null;
            CalcularPerimetro();
            CalcularArea();
        }

        protected override void CalcularArea()
        {
            Area = (Base.Value * Altura.Value) / 2;
        }
        public string Imprimir(EnumIdiomas idioma)
        {
            return $"{Traductor.Traducir($"{this.tipo}", idioma)} | {Traductor.Traducir("Área", idioma)} {this.area:#.##} | " +
                    $"{Traductor.Traducir("Perímetro", idioma)} {this.perimetro:#.##} | {Traductor.Traducir("Base", idioma)} {this.ladoInferior:#.##} | " +
                    $"{Traductor.Traducir("Altura", idioma)} {this.altura:#.##}<br/>";
        }
    }
}
