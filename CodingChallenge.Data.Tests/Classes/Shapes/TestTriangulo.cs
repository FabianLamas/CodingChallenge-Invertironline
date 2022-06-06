using CodingChallenge.Data.Classes.Shapes;
using NUnit.Framework;
using System;

namespace CodingChallenge.Data.Tests.Classes.Shapes
{
    public class TestTriangulo
    {
        TrianguloEquilatero _cuadrado1 = new TrianguloEquilatero(3);
        TrianguloEquilatero _cuadrado2 = new TrianguloEquilatero(4);
        TrianguloEquilatero _cuadrado3 = new TrianguloEquilatero(5);

        [TestCase]
        public void TestAreaDeTriangulosEquilateros()
        {
            decimal areaTrianguloEquilatero1 = _cuadrado1.CalcularArea();
            decimal areaTrianguloEquilatero2 = _cuadrado2.CalcularArea();
            decimal areaTrianguloEquilatero3 = _cuadrado3.CalcularArea();

            Assert.AreEqual(3.9m, Math.Round(areaTrianguloEquilatero1, 2));
            Assert.AreEqual(6.93m, Math.Round(areaTrianguloEquilatero2, 2));
            Assert.AreEqual(10.83m, Math.Round(areaTrianguloEquilatero3, 2));
        }

        [TestCase]
        public void TestPerimetroDeTriangulosEquilateros()
        {
            decimal perimetroTrianguloEquilatero1 = _cuadrado1.CalcularPerimetro();
            decimal perimetroTrianguloEquilatero2 = _cuadrado2.CalcularPerimetro();
            decimal perimetroTrianguloEquilatero3 = _cuadrado3.CalcularPerimetro();

            Assert.AreEqual(9m, Math.Round(perimetroTrianguloEquilatero1, 2));
            Assert.AreEqual(12m, Math.Round(perimetroTrianguloEquilatero2, 2));
            Assert.AreEqual(15m, Math.Round(perimetroTrianguloEquilatero3, 2));
        }

        [TestCase]
        public void TestTrianguloEquilateroValorCero()
        {
            TrianguloEquilatero circulo = new TrianguloEquilatero(0);
            decimal area = circulo.CalcularArea();
            decimal perimetro = circulo.CalcularPerimetro();

            Assert.AreEqual(0m, area);
            Assert.AreEqual(0m, perimetro);
        }
    }
}
