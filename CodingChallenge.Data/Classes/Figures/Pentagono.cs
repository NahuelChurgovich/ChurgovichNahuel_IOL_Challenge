using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CodingChallenge.Data.Interfaces;

namespace CodingChallenge.Data.Classes
{
    public class Pentagono : FormaGeometrica, IFiguraGeometrica
    {
        public Pentagono()
        {
            Tipo = Enums.EnumTipoFigura.Pentagono;
            CantidadLados = 5;
        }
        public Pentagono(decimal ladoInferio) : this()
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
