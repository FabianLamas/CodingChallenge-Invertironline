using CodingChallenge.Data.Interfaces;

namespace CodingChallenge.Data.Classes.Shapes
{
    public class Cuadrado : IFormaGeometrica
    {
        private decimal _lado;

        public Cuadrado(decimal lado)
        {
            _lado = lado;
        }

        public decimal CalcularArea()
        {
            return _lado * _lado;
        }

        public decimal CalcularPerimetro()
        {
            return _lado * 4;
        }
    }
}
