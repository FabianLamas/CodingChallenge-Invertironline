using CodingChallenge.Data.Classes.Shapes;
using NUnit.Framework;
using System;

namespace CodingChallenge.Data.Tests
{
    [TestFixture]
    public class TestCirulo
    {
        Circulo _circulo1 = new Circulo(3);
        Circulo _circulo2 = new Circulo(4);
        Circulo _circulo3 = new Circulo(5);

        [TestCase]
        public void TestAreaDeCirculos()
        {
            decimal areaCircle1 = _circulo1.CalcularArea();
            decimal areaCircle2 = _circulo2.CalcularArea();
            decimal areaCircle3 = _circulo3.CalcularArea();

            Assert.AreEqual(28.27m, Math.Round(areaCircle1, 2));
            Assert.AreEqual(50.27m, Math.Round(areaCircle2, 2));
            Assert.AreEqual(78.54m, Math.Round(areaCircle3, 2));
        }

        [TestCase]
        public void TestPerimetroDeCirculos()
        {
            decimal perimetroCircle1 = _circulo1.CalcularPerimetro();
            decimal perimetroCircle2 = _circulo2.CalcularPerimetro();
            decimal perimetroCircle3 = _circulo3.CalcularPerimetro();

            Assert.AreEqual(18.85m, Math.Round(perimetroCircle1, 2));
            Assert.AreEqual(25.13m, Math.Round(perimetroCircle2, 2));
            Assert.AreEqual(31.42m, Math.Round(perimetroCircle3, 2));
        }

        [TestCase]
        public void TestCirculoValorCero()
        {
            Circulo circulo = new Circulo(0);
            decimal area = circulo.CalcularArea();
            decimal perimetro = circulo.CalcularPerimetro();

            Assert.AreEqual(0m, area);
            Assert.AreEqual(0m, perimetro);
        }
    }
}
