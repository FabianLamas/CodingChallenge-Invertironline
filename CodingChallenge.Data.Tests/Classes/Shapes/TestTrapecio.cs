using CodingChallenge.Data.Classes.Shapes;
using NUnit.Framework;
using System;

namespace CodingChallenge.Data.Tests.Classes.Shapes
{
    public class TestTrapecio
    {
        Trapecio _trapecio1 = new Trapecio(15, 12, 10, 8);
        Trapecio _trapecio2 = new Trapecio(16, 11, 7, 6);
        Trapecio _trapecio3 = new Trapecio(13, 11, 6, 5);

        [TestCase]
        public void TestAreaDeTrapecios()
        {
            decimal areaTrapecio1 = _trapecio1.CalcularArea();
            decimal areaTrapecio2 = _trapecio2.CalcularArea();
            decimal areaTrapecio3 = _trapecio3.CalcularArea();

            Assert.AreEqual(14.52m, Math.Round(areaTrapecio1, 2));
            Assert.AreEqual(26.98m, Math.Round(areaTrapecio2, 2));
            Assert.AreEqual(12.97m, Math.Round(areaTrapecio3, 2));
        }

        [TestCase]
        public void TestPerimetroDeTrapecios()
        {
            decimal perimetroTrapecio1 = _trapecio1.CalcularPerimetro();
            decimal perimetroTrapecio2 = _trapecio2.CalcularPerimetro();
            decimal perimetroTrapecio3 = _trapecio3.CalcularPerimetro();

            Assert.AreEqual(45m, perimetroTrapecio1);
            Assert.AreEqual(40m, perimetroTrapecio2);
            Assert.AreEqual(35m, perimetroTrapecio3);
        }

        [TestCase]
        public void TestTrapecioValorCero()
        {
            Trapecio circulo = new Trapecio(0, 0, 0, 0);
            decimal area = circulo.CalcularArea();
            decimal perimetro = circulo.CalcularPerimetro();

            Assert.AreEqual(0m, area);
            Assert.AreEqual(0m, perimetro);
        }
    }
}
