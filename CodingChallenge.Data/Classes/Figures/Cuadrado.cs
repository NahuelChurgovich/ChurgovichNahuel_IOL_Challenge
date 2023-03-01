using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CodingChallenge.Data.Interfaces;

namespace CodingChallenge.Data.Classes
{
    public class Cuadrado : FormaGeometrica, IFiguraGeometrica
    {
        public Cuadrado()
        {
            Tipo = Enums.EnumTipoFigura.Cuadrado;
            CantidadLados = 4;
        }
        public Cuadrado(decimal ladoInferio):this()
        {
            this.Base = ladoInferio;
            this.Altura = ladoInferio;
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
