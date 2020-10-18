using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Сircle : GeometricFigures // Круг 
    {
        public Сircle(params double[] arr)
        {
            this.type = "Circle";
            this.hs = new double[1];
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
            return Math.PI * Math.Pow(hs[0], 2);
        }

        public override double getPerimeter()
        {
            return 2 * Math.PI * hs[0];
        }
    }
}
