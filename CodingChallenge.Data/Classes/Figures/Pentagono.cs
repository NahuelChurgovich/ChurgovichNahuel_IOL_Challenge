﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CodingChallenge.Data.Interfaces;

namespace CodingChallenge.Data.Classes
{
    public class Pentagono : FormaGeometrica, IFiguraGeometrica
    {
        static Pentagono()
        {
            CantidadLados = 5;
        }
        public Pentagono(decimal? ladoInferior, decimal? altura, decimal? radio)
            : base(ladoInferior, altura, radio)
        {
            Tipo = Enums.EnumTipoFigura.Pentagono;
            Radio = null;
            CalcularPerimetro();
            CalcularArea();
        }
        protected override void CalcularArea()
        {
            Area = (GetPerimetro() * Base.Value) / 2;
        }
    }
}
