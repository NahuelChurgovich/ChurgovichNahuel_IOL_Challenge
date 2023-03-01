using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CodingChallenge.Data.Interfaces;

namespace CodingChallenge.Data.Classes
{
    public class Rectangulo : FormaGeometrica, IFiguraGeometrica
    {
        public Rectangulo()
        {
            Tipo = Enums.EnumTipoFigura.Rectangulo;
            CantidadLados = 4;
        }
        public Rectangulo(decimal ladoInferio, decimal altura):this()
        {
            this.Base = ladoInferio;
            this.Altura = altura;
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
