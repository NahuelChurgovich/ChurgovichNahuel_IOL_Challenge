using System;

using CodingChallenge.Data.Enums;
using CodingChallenge.Data.Interfaces;

namespace CodingChallenge.Data.Classes
{
    public class Cuadrado : FormaGeometrica, IImprimible
    {
        static Cuadrado()
        {
        }
        public Cuadrado(double? ladoInferior, double? altura, double? radio)
            : base(ladoInferior, altura, radio)
        {
            Tipo = Enums.EnumTipoFigura.Cuadrado;
            CantidadLados = 4;
            Radio = null;
            CalcularPerimetro();
            CalcularArea();
        }

        protected override void CalcularArea()
        {
            try
            {
                Area = Math.Abs(Base.Value * Base.Value);
            }
            catch (Exception)
            {
                Area = 0;
                throw new InvalidOperationException("Solo el primer parámetro se admite para el cuadrado. Los otros deben ser nulos.");
            }
        }

        public string Imprimir(EnumIdiomas idioma)
        {
            return $"{Traductor.Traducir($"{this.tipo}", idioma)} | {Traductor.Traducir("Área", idioma)} {this.area:#.##} | " +
                    $"{Traductor.Traducir("Perímetro", idioma)} {this.perimetro:#.##} | {Traductor.Traducir("Base", idioma)} {this.ladoInferior:#.##}<br/>";
        }
    }
}
