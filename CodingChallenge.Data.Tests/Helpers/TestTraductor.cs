using CodingChallenge.Data.Helpers;
using NUnit.Framework;
using System.Globalization;
using System.Threading;

namespace CodingChallenge.Data.Tests.Helpers
{
    [TestFixture]
    public class TestTraductor
    {
        #region TestCastellano
        [TestCase]
        public void TestTraducirFormaCastellano()
        {
            Thread.CurrentThread.CurrentUICulture = CultureInfo.CreateSpecificCulture("es-AR");
            Traductor _traductor = new Traductor();
            string unCuadrado = _traductor.TraducirForma(1, 1);
            string dosTriangulos = _traductor.TraducirForma(3, 2);
            string tresTrapezoides = _traductor.TraducirForma(5, 3);
            string unRectangulo = _traductor.TraducirForma(4, 1);
            string vacio = _traductor.TraducirForma(6, 0);

            Assert.AreEqual("Cuadrado", unCuadrado);
            Assert.AreEqual("Triángulos", dosTriangulos);
            Assert.AreEqual("Trapecios", tresTrapezoides);
            Assert.AreEqual("Rectángulo", unRectangulo);
            Assert.AreEqual(string.Empty, vacio);
        }

        [TestCase]
        public void TestTraducirLineaCastellano()
        {
            Thread.CurrentThread.CurrentUICulture = CultureInfo.CreateSpecificCulture("es-AR");
            Traductor _traductor = new Traductor();

            string lineaTriangulo = _traductor.TraducirLinea(5, 20m, 10m, 3);
            string lineaCuadrado = _traductor.TraducirLinea(1, 10m, 15m, 1);
            string lineaTrapecios = _traductor.TraducirLinea(7, 12m, 16m, 5);

            Assert.AreEqual("5 Triángulos | Area 20 |  Perimetro 10 <br/>", lineaTriangulo);
            Assert.AreEqual("1 Cuadrado | Area 10 |  Perimetro 15 <br/>", lineaCuadrado);
            Assert.AreEqual("7 Trapecios | Area 12 |  Perimetro 16 <br/>", lineaTrapecios);
        }

        [TestCase]
        public void TestTraducirHeaderCastellano()
        {
            Thread.CurrentThread.CurrentUICulture = CultureInfo.CreateSpecificCulture("es-AR");
            Traductor _traductor = new Traductor();

            string case1 = _traductor.TraducirHeader(5);
            string case2 = _traductor.TraducirHeader(0);

            Assert.AreEqual("<h1> Reporte de Formas </h1>", case1);
            Assert.AreEqual("<h1> Lista vacía de formas! </h1>", case2);
        }

        [TestCase]
        public void TestTraducirCantidadesCastellano()
        {
            Thread.CurrentThread.CurrentUICulture = CultureInfo.CreateSpecificCulture("es-AR");
            Traductor _traductor = new Traductor();

            string case1 = _traductor.TraducirCantidades(5);
            string case2 = _traductor.TraducirCantidades(7);

            Assert.AreEqual("5 formas ", case1);
            Assert.AreEqual("7 formas ", case2);
        }

        [TestCase]
        public void TestTraducirPerimetroCastellano()
        {
            Thread.CurrentThread.CurrentUICulture = CultureInfo.CreateSpecificCulture("es-AR");
            Traductor _traductor = new Traductor();

            string case1 = _traductor.TraducirPerimetro(30);
            string case2 = _traductor.TraducirPerimetro(17);

            Assert.AreEqual("Perimetro 30 ", case1);
            Assert.AreEqual("Perimetro 17 ", case2);
        }

        [TestCase]
        public void TestTraducirAreaCastellano()
        {
            Thread.CurrentThread.CurrentUICulture = CultureInfo.CreateSpecificCulture("es-AR");
            Traductor _traductor = new Traductor();

            string case1 = _traductor.TraducirArea(15);
            string case2 = _traductor.TraducirArea(12);

            Assert.AreEqual("Area 15 ", case1);
            Assert.AreEqual("Area 12 ", case2);
        }
        #endregion

        #region TestIngles
        [TestCase]
        public void TestTraducirFormaIngles()
        {
            Thread.CurrentThread.CurrentUICulture = CultureInfo.CreateSpecificCulture("en-US");
            Traductor _traductor = new Traductor();
            string unCuadrado = _traductor.TraducirForma(1, 1);
            string dosTriangulos = _traductor.TraducirForma(3, 2);
            string tresTrapezoides = _traductor.TraducirForma(5, 3);
            string unRectangulo = _traductor.TraducirForma(4, 1);
            string vacio = _traductor.TraducirForma(6, 0);

            Assert.AreEqual("Square", unCuadrado);
            Assert.AreEqual("Triangles", dosTriangulos);
            Assert.AreEqual("Trapezoids", tresTrapezoides);
            Assert.AreEqual("Rectangle", unRectangulo);
            Assert.AreEqual(string.Empty, vacio);
        }

        [TestCase]
        public void TestTraducirLineaIngles()
        {
            Thread.CurrentThread.CurrentUICulture = CultureInfo.CreateSpecificCulture("en-US");
            Traductor _traductor = new Traductor();

            string lineaTriangulo = _traductor.TraducirLinea(5, 20m, 10m, 3);
            string lineaCuadrado = _traductor.TraducirLinea(1, 10m, 15m, 1);
            string lineaTrapecios = _traductor.TraducirLinea(7, 12m, 16m, 5);

            Assert.AreEqual("5 Triangles | Area 20 |  Perimeter 10 <br/>", lineaTriangulo);
            Assert.AreEqual("1 Square | Area 10 |  Perimeter 15 <br/>", lineaCuadrado);
            Assert.AreEqual("7 Trapezoids | Area 12 |  Perimeter 16 <br/>", lineaTrapecios);
        }

        [TestCase]
        public void TestTraducirHeaderIngles()
        {
            Thread.CurrentThread.CurrentUICulture = CultureInfo.CreateSpecificCulture("en-US");
            Traductor _traductor = new Traductor();

            string case1 = _traductor.TraducirHeader(5);
            string case2 = _traductor.TraducirHeader(0);

            Assert.AreEqual("<h1> Shapes Report </h1>", case1);
            Assert.AreEqual("<h1> EmptyList </h1>", case2);
        }

        [TestCase]
        public void TestTraducirCantidadesIngles()
        {
            Thread.CurrentThread.CurrentUICulture = CultureInfo.CreateSpecificCulture("en-US");
            Traductor _traductor = new Traductor();

            string case1 = _traductor.TraducirCantidades(5);
            string case2 = _traductor.TraducirCantidades(7);

            Assert.AreEqual("5 shapes ", case1);
            Assert.AreEqual("7 shapes ", case2);
        }

        [TestCase]
        public void TestTraducirPerimetroIngles()
        {
            Thread.CurrentThread.CurrentUICulture = CultureInfo.CreateSpecificCulture("en-US");
            Traductor _traductor = new Traductor();

            string case1 = _traductor.TraducirPerimetro(30);
            string case2 = _traductor.TraducirPerimetro(17);

            Assert.AreEqual("Perimeter 30 ", case1);
            Assert.AreEqual("Perimeter 17 ", case2);
        }

        [TestCase]
        public void TestTraducirAreaIngles()
        {
            Thread.CurrentThread.CurrentUICulture = CultureInfo.CreateSpecificCulture("en-US");
            Traductor _traductor = new Traductor();

            string case1 = _traductor.TraducirArea(15);
            string case2 = _traductor.TraducirArea(12);

            Assert.AreEqual("Area 15 ", case1);
            Assert.AreEqual("Area 12 ", case2);
        }
        #endregion

        #region TestItaliano
        [TestCase]
        public void TestTraducirFormaItaliano()
        {
            Thread.CurrentThread.CurrentUICulture = CultureInfo.CreateSpecificCulture("it-IT");
            Traductor _traductor = new Traductor();
            string unCuadrado = _traductor.TraducirForma(1, 1);
            string dosTriangulos = _traductor.TraducirForma(3, 2);
            string tresTrapezoides = _traductor.TraducirForma(5, 3);
            string unRectangulo = _traductor.TraducirForma(4, 1);
            string vacio = _traductor.TraducirForma(6, 0);

            Assert.AreEqual("Piazza", unCuadrado);
            Assert.AreEqual("Triangoli", dosTriangulos);
            Assert.AreEqual("Trapezi", tresTrapezoides);
            Assert.AreEqual("Rettangolo", unRectangulo);
            Assert.AreEqual(string.Empty, vacio);
        }

        [TestCase]
        public void TestTraducirLineaItaliano()
        {
            Thread.CurrentThread.CurrentUICulture = CultureInfo.CreateSpecificCulture("it-IT");
            Traductor _traductor = new Traductor();

            string lineaTriangulo = _traductor.TraducirLinea(5, 20m, 10m, 3);
            string lineaCuadrado = _traductor.TraducirLinea(1, 10m, 15m, 1);
            string lineaTrapecios = _traductor.TraducirLinea(7, 12m, 16m, 5);

            Assert.AreEqual("5 Triangoli | Area 20 |  Perimetro 10 <br/>", lineaTriangulo);
            Assert.AreEqual("1 Piazza | Area 10 |  Perimetro 15 <br/>", lineaCuadrado);
            Assert.AreEqual("7 Trapezi | Area 12 |  Perimetro 16 <br/>", lineaTrapecios);
        }

        [TestCase]
        public void TestTraducirHeaderItaliano()
        {
            Thread.CurrentThread.CurrentUICulture = CultureInfo.CreateSpecificCulture("it-IT");
            Traductor _traductor = new Traductor();

            string case1 = _traductor.TraducirHeader(5);
            string case2 = _traductor.TraducirHeader(0);

            Assert.AreEqual("<h1> Rapporto sulle forme </h1>", case1);
            Assert.AreEqual("<h1> Elenco vuoto </h1>", case2);
        }

        [TestCase]
        public void TestTraducirCantidadesItaliano()
        {
            Thread.CurrentThread.CurrentUICulture = CultureInfo.CreateSpecificCulture("it-IT");
            Traductor _traductor = new Traductor();

            string case1 = _traductor.TraducirCantidades(5);
            string case2 = _traductor.TraducirCantidades(7);

            Assert.AreEqual("5 forme ", case1);
            Assert.AreEqual("7 forme ", case2);
        }

        [TestCase]
        public void TestTraducirPerimetroItaliano()
        {
            Thread.CurrentThread.CurrentUICulture = CultureInfo.CreateSpecificCulture("it-IT");
            Traductor _traductor = new Traductor();

            string case1 = _traductor.TraducirPerimetro(30);
            string case2 = _traductor.TraducirPerimetro(17);

            Assert.AreEqual("Perimetro 30 ", case1);
            Assert.AreEqual("Perimetro 17 ", case2);
        }

        [TestCase]
        public void TestTraducirAreaItaliano()
        {
            Thread.CurrentThread.CurrentUICulture = CultureInfo.CreateSpecificCulture("it-IT");
            Traductor _traductor = new Traductor();

            string case1 = _traductor.TraducirArea(15);
            string case2 = _traductor.TraducirArea(12);

            Assert.AreEqual("Area 15 ", case1);
            Assert.AreEqual("Area 12 ", case2);
        }
        #endregion
    }
}
