using System.Reflection;
using System.Resources;

namespace CodingChallenge.Data.Helpers
{
    public class Traductor
    {
        ResourceManager rm = new ResourceManager("CodingChallenge.Data.Resources.Lang", Assembly.GetExecutingAssembly());

        public string TraducirForma(int tipo, int cantidad)
        {
            switch (tipo)
            {
                case 1: return cantidad == 1 ? rm.GetString("Square") : rm.GetString("Squares");
                case 2: return cantidad == 1 ? rm.GetString("Circle") : rm.GetString("Circles");
                case 3: return cantidad == 1 ? rm.GetString("Triangle") : rm.GetString("Triangles");
                case 4: return cantidad == 1 ? rm.GetString("Rectangle") : rm.GetString("Rectangles");
                case 5: return cantidad == 1 ? rm.GetString("Trapezoid") : rm.GetString("Trapezoids");
                default: return string.Empty;
            }
        }

        public string TraducirLinea(int cantidad, decimal area, decimal perimetro, int tipo)
        {
            return cantidad > 0 ? $"{cantidad} {TraducirForma(tipo, cantidad)} | {rm.GetString("Area")} {area:#.##} |  {rm.GetString("Perimeter")} {perimetro:#.##} <br/>" : string.Empty;
        }

        public string TraducirHeader(int cantidad)
        {
            return cantidad > 0 ? $"<h1> {rm.GetString("ShapesReport")} </h1>" : $"<h1> {rm.GetString("EmptyList")} </h1>";
        }

        public string TraducirCantidades(int cantidad)
        {
            return $"{cantidad} {rm.GetString("Shapes")} ";
        }

        public string TraducirPerimetro(decimal perimetro)
        {
            return $"{rm.GetString("Perimeter")} {perimetro.ToString("#.##")} ";
        }

        public string TraducirArea(decimal area)
        {
            return $"{rm.GetString("Area")} {area.ToString("#.##")} ";
        }
    }
}
