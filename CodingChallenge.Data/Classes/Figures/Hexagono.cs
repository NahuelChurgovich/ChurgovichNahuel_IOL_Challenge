using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CodingChallenge.Data.Interfaces;

namespace CodingChallenge.Data.Classes
{
    public class Hexagono : FormaGeometrica, IFiguraGeometrica
    {
        public Hexagono()
        {
            Tipo = Enums.EnumTipoFigura.Hexagono;
            CantidadLados = 6;
        }
        public Hexagono(decimal ladoInferio) : this()
        {
            this.Base = ladoInferio;
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
