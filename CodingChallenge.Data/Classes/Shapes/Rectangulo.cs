using CodingChallenge.Data.Interfaces;

namespace CodingChallenge.Data.Classes.Shapes
{
    public class Rectangulo : IFormaGeometrica
    {
        private decimal _lado1;
        private decimal _lado2;

        public Rectangulo(decimal lado1, decimal lado2)
        {
            _lado1 = lado1;
            _lado2 = lado2;
        }

        public decimal CalcularArea()
        {
            return _lado1 * _lado2;
        }

        public decimal CalcularPerimetro()
        {
            return _lado1 * 2 + _lado2 * 2;
        }
    }
}
