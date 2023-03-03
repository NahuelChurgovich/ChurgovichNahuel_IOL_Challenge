using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CodingChallenge.Data.Interfaces;

namespace CodingChallenge.Data.Classes
{
    public class Circulo : FormaGeometrica, IFiguraGeometrica
    {
        static Circulo()
        {            
            CantidadLados = 0;
        }
        public Circulo(decimal? ladoInferior, decimal? altura, decimal? radio)
            : base(ladoInferior, altura, radio)
        {
            Tipo = Enums.EnumTipoFigura.Circulo;
            Base = null;
            Altura = null;
            CalcularPerimetro();
            CalcularArea();
        }

        protected override void CalcularPerimetro()
        {
            Perimetro = Math.Round((decimal)Math.PI * Radio.Value * 2, 2);
        }
        protected override void CalcularArea()
        {
            Area = Math.Round((decimal)Math.PI * Radio.Value * Radio.Value,2); 
        }


    }
}
