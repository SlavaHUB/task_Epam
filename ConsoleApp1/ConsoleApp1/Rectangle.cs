using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Rectangle : GeometricFigures // Прямоугольник
    {
        public Rectangle(params double [] arr)
        {
            this.type = "Rectangle";
            this.hs = new double[2];
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
            return hs[0] * hs[1];
        }

        public override double getPerimeter()
        {
            return 2 * (hs[0] + hs[1]);
        }
    }
}
