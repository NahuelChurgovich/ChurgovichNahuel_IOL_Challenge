﻿using CodingChallenge.Data.Enums;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CodingChallenge.Data.Interfaces
{
    public interface IImprimible
    {
        string Imprimir(EnumIdiomas idioma);
    }
}
