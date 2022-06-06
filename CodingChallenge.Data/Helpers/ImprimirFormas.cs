using CodingChallenge.Data.Classes.Shapes;
using CodingChallenge.Data.Interfaces;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Text;
using System.Threading;

namespace CodingChallenge.Data.Helpers
{
    public class ImprimirFormas
    {
        #region Lenguajes

        public const int Castellano = 1;
        public const int Ingles = 2;
        public const int Italiano = 3;

        #endregion

        #region Formas

        public const int Cuadrado = 1;
        public const int Circulo = 2;
        public const int TrianguloEquilatero = 3;
        public const int Rectangulo = 4;
        public const int Trapecio = 5;

        #endregion

        public string Imprimir(List<IFormaGeometrica> formas, int idioma)
        {
            SetLanguage(idioma);

            var sb = new StringBuilder();
            Traductor _traductor = new Traductor();

            string header = _traductor.TraducirHeader(formas.Count);
            sb.Append(header);

            if (formas.Any())
            {
                int numeroCuadrados = 0;
                int numeroCirculos = 0;
                int numeroTriangulos = 0;
                int numeroRectangulos = 0;
                int numeroTrapecios = 0;

                var areaCuadrados = 0m;
                var areaCirculos = 0m;
                var areaTriangulos = 0m;
                var areaRectangulos = 0m;
                var areaTrapecio = 0m;

                var perimetroCuadrados = 0m;
                var perimetroCirculos = 0m;
                var perimetroTriangulos = 0m;
                var perimetroRectangulos = 0m;
                var perimetroTrapecio = 0m;

                foreach (var forma in formas)
                {

                    if (forma.GetType() == typeof(Cuadrado))
                    {
                        numeroCuadrados++;
                        areaCuadrados += forma.CalcularArea();
                        perimetroCuadrados += forma.CalcularPerimetro();
                    }

                    if (forma.GetType() == typeof(Circulo))
                    {
                        numeroCirculos++;
                        areaCirculos += forma.CalcularArea();
                        perimetroCirculos += forma.CalcularPerimetro();
                    }

                    if (forma.GetType() == typeof(TrianguloEquilatero))
                    {
                        numeroTriangulos++;
                        areaTriangulos += forma.CalcularArea();
                        perimetroTriangulos += forma.CalcularPerimetro();
                    }

                    if (forma.GetType() == typeof(Rectangulo))
                    {
                        numeroRectangulos++;
                        areaRectangulos += forma.CalcularArea();
                        perimetroRectangulos += forma.CalcularPerimetro();
                    }

                    if (forma.GetType() == typeof(Trapecio))
                    {
                        numeroTrapecios++;
                        areaTrapecio += forma.CalcularArea();
                        perimetroTrapecio += forma.CalcularPerimetro();
                    }
                }

                sb.Append(_traductor.TraducirLinea(numeroCuadrados, areaCuadrados, perimetroCuadrados, Cuadrado));
                sb.Append(_traductor.TraducirLinea(numeroCirculos, areaCirculos, perimetroCirculos, Circulo));
                sb.Append(_traductor.TraducirLinea(numeroTriangulos, areaTriangulos, perimetroTriangulos, TrianguloEquilatero));
                sb.Append(_traductor.TraducirLinea(numeroRectangulos, areaRectangulos, perimetroRectangulos, Rectangulo));
                sb.Append(_traductor.TraducirLinea(numeroTrapecios, areaTrapecio, perimetroTrapecio, Trapecio));


                sb.Append("TOTAL:<br/>");
                sb.Append(_traductor.TraducirCantidades(formas.Count));
                sb.Append(_traductor.TraducirPerimetro(perimetroCuadrados + perimetroCirculos + perimetroTriangulos + perimetroRectangulos + perimetroTrapecio));
                sb.Append(_traductor.TraducirArea(areaCuadrados + areaCirculos + areaTriangulos + areaRectangulos + areaTrapecio));
            }

            return sb.ToString();
        }

        private void SetLanguage(int lang)
        {
            switch (lang)
            {
                case Castellano: Thread.CurrentThread.CurrentUICulture = CultureInfo.CreateSpecificCulture("es-AR"); break;
                case Ingles: Thread.CurrentThread.CurrentUICulture = CultureInfo.CreateSpecificCulture("en-US"); break;
                case Italiano: Thread.CurrentThread.CurrentUICulture = CultureInfo.CreateSpecificCulture("it-IT"); break;
                    default: Thread.CurrentThread.CurrentUICulture = CultureInfo.CreateSpecificCulture("en-US"); break;
            }
        }
    }
}
