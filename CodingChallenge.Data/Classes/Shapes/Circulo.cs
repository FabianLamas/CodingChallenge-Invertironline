using CodingChallenge.Data.Interfaces;
using System;

namespace CodingChallenge.Data.Classes.Shapes
{
    public class Circulo : IFormaGeometrica
    {
        private decimal _radio;

        public Circulo(decimal radio)
        {
            _radio = radio;
        }

        public decimal CalcularArea()
        {
            return (decimal)Math.PI * (_radio * _radio);
        }

        public decimal CalcularPerimetro()
        {
            return (decimal)Math.PI * _radio * 2;
        }
    }
}
