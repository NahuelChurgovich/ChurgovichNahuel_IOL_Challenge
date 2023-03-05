using System;

using CodingChallenge.Data.Enums;
using CodingChallenge.Data.Interfaces;

namespace CodingChallenge.Data.Classes
{
    public class Rectangulo : FormaGeometrica, IImprimible
    {
        static Rectangulo()
        {
        }
        public Rectangulo(double? ladoInferior, double? altura, double? radio)
            : base(ladoInferior, altura, radio)
        {
            Tipo = Enums.EnumTipoFigura.Rectangulo;
            CantidadLados = 4;
            Radio = null;
            CalcularPerimetro();
            CalcularArea();
        }

        protected override void CalcularPerimetro()
        {
            try
            {
                Perimetro = (Math.Abs(Base.Value) * 2) + (Math.Abs(Altura.Value) * 2);
            }
            catch (Exception)
            {
                Area = 0;
                throw new InvalidOperationException("Solo el primer  y segundo parámetro se admiten para el rectángulo. El ultimo debe ser nulos.");
            }
        }
        protected override void CalcularArea()
        {
            try
            {
                Area = Math.Abs(Base.Value) * Math.Abs(Altura.Value);
            }
            catch (Exception)
            {
                Area = 0;
                throw new InvalidOperationException("Solo el primer  y segundo parámetro se admiten para el rectángulo. El ultimo debe ser nulos.");
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
