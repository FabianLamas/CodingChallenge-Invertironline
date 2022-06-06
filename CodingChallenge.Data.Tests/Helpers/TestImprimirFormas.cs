using CodingChallenge.Data.Classes.Shapes;
using CodingChallenge.Data.Helpers;
using CodingChallenge.Data.Interfaces;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Data.Tests.Helpers
{
    [TestFixture]
    public class TestImprimirFormas
    {
        ImprimirFormas _imprenta = new ImprimirFormas();

        [TestCase]
        public void TestImprimirListaCastellano()
        {
            List<IFormaGeometrica> formas = new List<IFormaGeometrica> 
            {
                new Circulo(3),
                new Circulo(7),
                new Cuadrado(2),
                new TrianguloEquilatero(5),
                new TrianguloEquilatero(8),
                new TrianguloEquilatero(12),
            };

            string resultado = _imprenta.Imprimir(formas, 1);

            Assert.AreEqual("<h1> Reporte de Formas </h1>1 Cuadrado | Area 4 |  Perimetro 8 <br/>2 Círculos | Area 182.21 |  Perimetro 62.83 <br/>3 " +
                "Triángulos | Area 100.89 |  Perimetro 75 <br/>TOTAL:<br/>6 formas Perimetro 145.83 Area 287.1 ", resultado);
        }

        [TestCase]
        public void TestImprimirListaVaciaCastellano()
        {
            Assert.AreEqual("<h1> Lista vacía de formas! </h1>", _imprenta.Imprimir(new List<IFormaGeometrica>(), 1));
        }

        [TestCase]
        public void TestResumenListaConUnCuadradoCastellano()
        {
            List<IFormaGeometrica> formas = new List<IFormaGeometrica> { new Cuadrado(2) };

            var resultado = _imprenta.Imprimir(formas, 1);

            Assert.AreEqual("<h1> Reporte de Formas </h1>1 Cuadrado | Area 4 |  Perimetro 8 <br/>TOTAL:<br/>1 formas Perimetro 8 Area 4 ", resultado);
        }


        [TestCase]
        public void TestImprimirListaVaciaIngles()
        {
            Assert.AreEqual("<h1> EmptyList </h1>", _imprenta.Imprimir(new List<IFormaGeometrica>(), 2));
        }

        [TestCase]
        public void TestImprimirListaIngles()
        {
            List<IFormaGeometrica> formas = new List<IFormaGeometrica>
            {
                new Circulo(3),
                new Circulo(7),
                new Cuadrado(2),
                new TrianguloEquilatero(5),
                new TrianguloEquilatero(8),
                new TrianguloEquilatero(12),
            };

            string resultado = _imprenta.Imprimir(formas, 2);

            Assert.AreEqual("<h1> Shapes Report </h1>1 Square | Area 4 |  Perimeter 8 <br/>2 Circles | Area 182.21 |  Perimeter 62.83 <br/>3" +
                " Triangles | Area 100.89 |  Perimeter 75 <br/>TOTAL:<br/>6 shapes Perimeter 145.83 Area 287.1 ", resultado);
        }

        [TestCase]
        public void TestResumenListaConUnCuadradoIngles()
        {
            List<IFormaGeometrica> formas = new List<IFormaGeometrica>{new Cuadrado(2)};

            var resultado = _imprenta.Imprimir(formas, 2);

            Assert.AreEqual("<h1> Shapes Report </h1>1 Square | Area 4 |  Perimeter 8 <br/>TOTAL:<br/>1 shapes Perimeter 8 Area 4 ", resultado);
        }

        [TestCase]
        public void TestImprimirListaVaciaItaliano()
        {
            Assert.AreEqual("<h1> Elenco vuoto </h1>", _imprenta.Imprimir(new List<IFormaGeometrica>(), 3));
        }

        [TestCase]
        public void TestImprimirListaItaliano()
        {
            List<IFormaGeometrica> formas = new List<IFormaGeometrica>
            {
                new Circulo(3),
                new Circulo(7),
                new Cuadrado(2),
                new TrianguloEquilatero(5),
                new TrianguloEquilatero(8),
                new TrianguloEquilatero(12),
            };

            string resultado = _imprenta.Imprimir(formas, 3);

            Assert.AreEqual("<h1> Rapporto sulle forme </h1>1 Piazza | Area 4 |  Perimetro 8 <br/>2 Cerchi | Area 182.21 |  Perimetro 62.83 <br/>3" +
                " Triangoli | Area 100.89 |  Perimetro 75 <br/>TOTAL:<br/>6 forme Perimetro 145.83 Area 287.1 ", resultado);
        }

        [TestCase]
        public void TestResumenListaConUnCuadradoItaliano()
        {
            List<IFormaGeometrica> formas = new List<IFormaGeometrica> { new Cuadrado(2) };

            var resultado = _imprenta.Imprimir(formas, 3);

            Assert.AreEqual("<h1> Rapporto sulle forme </h1>1 Piazza | Area 4 |  Perimetro 8 <br/>TOTAL:<br/>1 forme Perimetro 8 Area 4 ", resultado);
        }
    }
}
