using System;

using CodingChallenge.Data.Enums;
using CodingChallenge.Data.Interfaces;

namespace CodingChallenge.Data.Classes
{
    public class Pentagono : FormaGeometrica, IImprimible
    {
        const double factorArea = (double)1.720477;
        static Pentagono()
        {
        }
        public Pentagono(double? ladoInferior, double? altura, double? radio)
            : base(ladoInferior, altura, radio)
        {
            Tipo = Enums.EnumTipoFigura.Pentagono;
            CantidadLados = 5;
            Radio = null;
            CalcularPerimetro();
            CalcularArea();
        }
        protected override void CalcularArea()
        {
            try
            {
                Area = Math.Round((factorArea) * (double)(ladoInferior * ladoInferior), 2);
            }
            catch (Exception)
            {
                Area = 0;
                throw new InvalidOperationException("Solo el primer se admite para el pentágono. Los otros deben ser nulos.");
            }
        }

        public string Imprimir(EnumIdiomas idioma)
        {
            return $"{Traductor.Traducir($"{this.tipo}", idioma)} | {Traductor.Traducir("Área", idioma)} {this.area:#.##} | " +
                    $"{Traductor.Traducir("Perímetro", idioma)} {this.perimetro:#.##} | {Traductor.Traducir("Base", idioma)} {this.ladoInferior:#.##}<br/>";
        }
    }
}
