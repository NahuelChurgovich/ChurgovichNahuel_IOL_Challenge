using System;

using CodingChallenge.Data.Enums;
using CodingChallenge.Data.Interfaces;

namespace CodingChallenge.Data.Classes
{
    public class Circulo : FormaGeometrica, IImprimible
    {
        static Circulo()
        {
        }
        public Circulo(double? ladoInferior, double? altura, double? radio)
            : base(ladoInferior, altura, radio)
        {
            Tipo = Enums.EnumTipoFigura.Circulo;
            CantidadLados = 0;
            Base = null;
            Altura = null;
            CalcularPerimetro();
            CalcularArea();
        }

        protected override void CalcularPerimetro()
        {
            try
            {
                Perimetro = Math.Abs(Math.Round(Math.PI * Radio.Value * 2, 2));
            }
            catch (Exception)
            {
                Perimetro = 0;
                throw new InvalidOperationException("Solo el parámetro de radio se admite para el circulo. Los otros deben ser nulos.");
            }
        }
        protected override void CalcularArea()
        {
            try
            {
                Area = Math.Abs(Math.Round(Math.PI * Radio.Value * Radio.Value, 2));
            }
            catch (Exception)
            {
                Perimetro = 0;
                throw new InvalidOperationException("Solo el parámetro de radio se admite para el circulo. Los otros deben ser nulos.");
            }
        }

        public string Imprimir(EnumIdiomas idioma)
        {
            return $"{Traductor.Traducir($"{this.tipo}", idioma)} | {Traductor.Traducir("Área", idioma)} {this.area:#.##} | " +
                    $"{Traductor.Traducir("Perímetro", idioma)} {this.perimetro:#.##} | {Traductor.Traducir("Radio", idioma)} {this.radio:#.##}<br/>";
        }
    }
}
