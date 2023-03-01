/*
 * Refactorear la clase para respetar principios de programación orientada a objetos. Qué pasa si debemos soportar un nuevo idioma para los reportes, o
 * agregar más formas geométricas?
 *
 * Se puede hacer cualquier cambio que se crea necesario tanto en el código como en los tests. La única condición es que los tests pasen OK.
 *
 * TODO: Implementar Trapecio/Rectangulo, agregar otro idioma a reporting.
 * */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CodingChallenge.Data.Enums;

namespace CodingChallenge.Data.Classes
{
    public abstract class FormaGeometrica
    {
        protected EnumTipoFigura Tipo { get; set; }
        public int CantidadLados { get; set; }
        public decimal Perimetro { get; set; }
        public decimal Area { get; set; }
        public decimal? Base { get; set; }
        public decimal? Altura { get; set; }
        public decimal? Radio { get; set; }
        
    }
}
