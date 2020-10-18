using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Trapezoid : GeometricFigures // Трапеция
    {
        private double height { get; set; }

        public Trapezoid(params double[] arr)
        {
            this.type = "Trapezoid";
            this.hs = new double[5];
            for (int i = 0; i < arr.Length; i++)
            {
                hs[i] = arr[i];
            }
        }

        public override string getType()
        {
            return type;
        }

        public override double getArea()
        {
            return ((hs[0] + hs[1]) / 2) * hs[4];
        }

        public override double getPerimeter()
        {
            return hs[0] + hs[1] + hs[2] + hs[3];
        }
    }
}
