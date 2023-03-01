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
        public Circulo()
        {
            Tipo = Enums.EnumTipoFigura.Circulo;
            CantidadLados = 0;
        }
        public Circulo(decimal radio):this()
        {
            this.Radio = radio;
        }

        public decimal CalcularArea()
        {
            return 0;
        }

        public decimal CalcularPerimetro()
        {
            return 0;
        }

    }
}
