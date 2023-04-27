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
}
