using System;

using CodingChallenge.Data.Enums;
using CodingChallenge.Data.Interfaces;

namespace CodingChallenge.Data.Classes
{
    public class Triangulo : FormaGeometrica, IImprimible
    {
        static Triangulo()
        {
        }
        public Triangulo(double? ladoInferior, double? altura, double? radio)
            : base(ladoInferior, altura, radio)
        {
            Tipo = Enums.EnumTipoFigura.Triangulo;
            CantidadLados = 3;
            Radio = null;
            CalcularPerimetro();
            CalcularArea();
        }

        protected override void CalcularArea()
        {
            try
            {
                Area = Math.Abs((Base.Value * Altura.Value) / 2);
            }
            catch (Exception)
            {
                Area = 0;
                throw new InvalidOperationException("Solo el primer se admite para el triangulo. Los otros deben ser nulos.");
            }
        }
        public string Imprimir(EnumIdiomas idioma)
        {
            return $"{Traductor.Traducir($"{this.tipo}", idioma)} | {Traductor.Traducir("Área", idioma)} {this.area:#.##} | " +
                    $"{Traductor.Traducir("Perímetro", idioma)} {this.perimetro:#.##} | {Traductor.Traducir("Base", idioma)} {this.ladoInferior:#.##} | " +
                    $"{Traductor.Traducir("Altura", idioma)} {this.altura:#.##}<br/>";
        }
    }
}
