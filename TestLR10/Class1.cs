using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLR10
{
    public class Geometry
    {
        public int RectangleArea(int a, int b)
        {
            return a * b;
        }

        public double CylinderVolume(double r, double h)
        {
            return Math.Round(Math.PI * Math.Pow(r, 2) * h, 2);
        }
    }

    //Квадратное уравнение (Дополнение)
    public class Addition
    {
        public (string, string) SolvingTheQuadraticEquation(double a, double b, double c)
        {
            double D = Math.Pow(b, 2) - 4 * a * c;
            double x1, x2;
            if (D > 0)
            {
                x1 = Math.Round((-b - Math.Sqrt(D)) / (2 * a), 2);
                x2 = Math.Round((-b + Math.Sqrt(D)) / (2 * a), 2);
                return (x1.ToString(), x2.ToString());
            }
            if (D == 0)
            {
                x1 = Math.Round((-b) / (2 * a), 2);
                return (x1.ToString(), null);
            } 
            return (null, null);

        }
    }
}
