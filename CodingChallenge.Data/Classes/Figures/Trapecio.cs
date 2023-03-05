using System;

using CodingChallenge.Data.Enums;
using CodingChallenge.Data.Interfaces;

namespace CodingChallenge.Data.Classes
{
    public class Trapecio : FormaGeometrica, IImprimible
    {
        private double? ladoSuperior;
        private double? ladoIzquierdo;
        private double? ladoDerecho;

        static Trapecio()
        {
        }
        public Trapecio(double? ladoInferior, double? altura, double? radio, double? ladoSuperior, double? ladoIzquierdo, double? ladoDerecho)
            : base(ladoInferior, altura, radio)
        {
            Tipo = Enums.EnumTipoFigura.Trapecio;
            CantidadLados = 4;
            Radio = null;
            this.ladoSuperior = ladoSuperior;
            this.ladoIzquierdo = ladoIzquierdo;
            this.ladoDerecho = ladoDerecho;
            CalcularPerimetro();
            CalcularArea();
        }
        protected override void CalcularPerimetro()
        {
            try
            {
                Perimetro = Math.Abs((double)ladoInferior) + Math.Abs((double)ladoSuperior) + Math.Abs((double)ladoIzquierdo) + Math.Abs((double)ladoDerecho);
            }
            catch (Exception)
            {
                Perimetro = 0;
                throw new InvalidOperationException("El tercer parámetro debe ser nulo en el Trapecio, el resto deben contener un valor.");
            }

        }
        protected override void CalcularArea()
        {
            try
            {
                Area = Math.Abs(((Math.Abs((double)ladoInferior) + Math.Abs((double)ladoSuperior)) * Math.Abs((double)altura)) / 2);
            }
            catch (Exception)
            {
                Area = 0;
                throw new InvalidOperationException("El tercer parámetro debe ser nulo en el Trapecio, el resto deben contener un valor.");
            }
        }

        public string Imprimir(EnumIdiomas idioma)
        {
            return $"{Traductor.Traducir($"{this.tipo}", idioma)} | {Traductor.Traducir("Área", idioma)} {this.area:#.##} | " +
                    $"{Traductor.Traducir("Perímetro", idioma)} {this.perimetro:#.##} | {Traductor.Traducir("Base", idioma)} {this.ladoInferior:#.##} | " +
                    $"{Traductor.Traducir("Altura", idioma)} {this.altura:#.##} | {Traductor.Traducir("Base Superior", idioma)} {this.ladoSuperior:#.##}<br/>";
        }
    }
}
