using CodingChallenge.Data.Interfaces;
using System;

namespace CodingChallenge.Data.Classes.Shapes
{
    public class Trapecio : IFormaGeometrica
    {
        private decimal _lado1;
        private decimal _lado2;
        private decimal _base1;
        private decimal _base2;

        public Trapecio(decimal lado1, decimal lado2, decimal base1, decimal base2)
        {
            _lado1 = lado1;
            _lado2 = lado2;
            _base1 = base1;
            _base2 = base2;
        }

        public decimal CalcularArea()
        {
            if(_base1 == 0 || _base2 == 0 || _lado1 == 0 || _lado2 == 0) return 0;
            decimal firstTerm = (_base1 + _base2) / (4 * Math.Abs(_base1 + _base2));
            decimal secondTerm = (-_base1 + _base2 + _lado1 + _lado2) * (-_base1 - _base2 + _lado1 + _lado2) *
                                 (-_base1 - _base2 + _lado1 - _lado2) * (_base1 - _base2 - _lado1 + _lado2);
            decimal raizSecondTerm = (decimal)Math.Sqrt((double)secondTerm);

            decimal result = firstTerm * raizSecondTerm;

            return result;


            //decimal baseMayor = _base1 > _base2 ? _base1 : _base2;
            //decimal baseMenor = _base2 > _base1 ? _base1 : _base2; 

            //var baseMayorXbaseMenorAlCuadrado = (baseMayor - baseMenor) * (baseMayor - baseMenor);
            //var lado1Cuaadrado = _lado1 * _lado1;
            //var lado2Cuaadrado = _lado2 * _lado2;
            //var firstTerm = 4 * baseMayorXbaseMenorAlCuadrado * lado1Cuaadrado;
            //var secondTerm = (lado1Cuaadrado + baseMayorXbaseMenorAlCuadrado - lado2Cuaadrado) * (lado1Cuaadrado + baseMayorXbaseMenorAlCuadrado - lado2Cuaadrado);
            //var dividendo = 2 * (baseMayor - baseMenor);

            //var altura = (Math.Sqrt((double)firstTerm - (double)secondTerm))/(double)dividendo;

            //return ((baseMayor+baseMenor)/2)*(decimal)altura;
        }

        public decimal CalcularPerimetro()
        {
            return _lado1 + _lado2 + _base1 + _base2;
        }
    }
}
