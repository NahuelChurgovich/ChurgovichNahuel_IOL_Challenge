using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CodingChallenge.Data.Enums;

namespace CodingChallenge.Data.Interfaces
{
    public interface IFiguraGeometrica
    {
        EnumTipoFigura GetTipo();
        decimal GetCantidadLados();
        decimal GetPerimetro();
        decimal GetArea();
        decimal? GetBase();
        decimal? GetAltura();
        decimal? GetRadio();
    }
}
