using CodingChallenge.Data.Classes.Shapes;
using NUnit.Framework;

namespace CodingChallenge.Data.Tests.Classes.Shapes
{
    public class TestCuadrado
    {
        Cuadrado _cuadrado1 = new Cuadrado(3);
        Cuadrado _cuadrado2 = new Cuadrado(4);
        Cuadrado _cuadrado3 = new Cuadrado(5);

        [TestCase]
        public void TestAreaDeCuadrados()
        {
            decimal areaCuadrado1 = _cuadrado1.CalcularArea();
            decimal areaCuadrado2 = _cuadrado2.CalcularArea();
            decimal areaCuadrado3 = _cuadrado3.CalcularArea();

            Assert.AreEqual(9m, areaCuadrado1);
            Assert.AreEqual(16m, areaCuadrado2);
            Assert.AreEqual(25m, areaCuadrado3);
        }

        [TestCase]
        public void TestPerimetroDeCuadrados()
        {
            decimal perimetroCuadrado1 = _cuadrado1.CalcularPerimetro();
            decimal perimetroCuadrado2 = _cuadrado2.CalcularPerimetro();
            decimal perimetroCuadrado3 = _cuadrado3.CalcularPerimetro();

            Assert.AreEqual(12m, perimetroCuadrado1);
            Assert.AreEqual(16m, perimetroCuadrado2);
            Assert.AreEqual(20m, perimetroCuadrado3);
        }

        [TestCase]
        public void TestCuadradoValorCero()
        {
            Cuadrado circulo = new Cuadrado(0);
            decimal area = circulo.CalcularArea();
            decimal perimetro = circulo.CalcularPerimetro();

            Assert.AreEqual(0m, area);
            Assert.AreEqual(0m, perimetro);
        }
    }
}
