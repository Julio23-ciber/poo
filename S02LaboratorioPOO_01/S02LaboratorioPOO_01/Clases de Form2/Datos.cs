using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S02LaboratorioPOO_01.Clases_de_Form2
{
    class Datos
    {
        private double lCuadrado, bRect, hRect, bTri, hTri;

        public double LCuadrado { get => lCuadrado; set => lCuadrado = value; }
        public double BRect { get => bRect; set => bRect = value; }
        public double HRect { get => hRect; set => hRect = value; }
        public double BTri { get => bTri; set => bTri = value; }
        public double HTri { get => hTri; set => hTri = value; }

        public double aCuadrado(double l)
        {
            l = lCuadrado;
            return l * l;
        }

        public double aRectangulo(double b, double h)
        {
            b = bRect; h = hRect;
            return b * h;
        }
        public double aTriangulo(double b, double h)
        {
            b = bTri; h = hTri;
            return (b * h) / 2;
        }
    }
}
