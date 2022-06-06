using CodingChallenge.Data.Classes.Shapes;
using NUnit.Framework;

namespace CodingChallenge.Data.Tests.Classes.Shapes
{
    public class TestRectangulo
    {
        Rectangulo _rectangulo1 = new Rectangulo(3,2);
        Rectangulo _rectangulo2 = new Rectangulo(4,5);
        Rectangulo _rectangulo3 = new Rectangulo(5,8);

        [TestCase]
        public void TestAreaDeRectangulos()
        {
            decimal areaRectangulo1 = _rectangulo1.CalcularArea();
            decimal areaRectangulo2 = _rectangulo2.CalcularArea();
            decimal areaRectangulo3 = _rectangulo3.CalcularArea();

            Assert.AreEqual(6m, areaRectangulo1);
            Assert.AreEqual(20m, areaRectangulo2);
            Assert.AreEqual(40m, areaRectangulo3);
        }

        [TestCase]
        public void TestPerimetroDeRectangulos()
        {
            decimal perimetroRectangulo1 = _rectangulo1.CalcularPerimetro();
            decimal perimetroRectangulo2 = _rectangulo2.CalcularPerimetro();
            decimal perimetroRectangulo3 = _rectangulo3.CalcularPerimetro();

            Assert.AreEqual(10m, perimetroRectangulo1);
            Assert.AreEqual(18m, perimetroRectangulo2);
            Assert.AreEqual(26m, perimetroRectangulo3);
        }

        [TestCase]
        public void TestRectanguloValorCero()
        {
            Rectangulo circulo = new Rectangulo(0,0);
            decimal area = circulo.CalcularArea();
            decimal perimetro = circulo.CalcularPerimetro();

            Assert.AreEqual(0m, area);
            Assert.AreEqual(0m, perimetro);
        }
    }
}
