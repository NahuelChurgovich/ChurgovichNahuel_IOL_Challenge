using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CodingChallenge.Data.Interfaces;

namespace CodingChallenge.Data.Classes
{
    public class Trapecio : FormaGeometrica, IFiguraGeometrica
    {
        public Trapecio()
        {
            Tipo = Enums.EnumTipoFigura.Trapecio;
            CantidadLados = 4;
        }
        public Trapecio(decimal ladoInferio, decimal altura):this()
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
