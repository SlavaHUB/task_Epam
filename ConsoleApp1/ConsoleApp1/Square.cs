using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Squares : GeometricFigures // Квадрат
    {
        public Squares(params double [] arr)
        {
            this.type = "Square";
            this.hs = new double[1];
            hs[0] = arr[0];
        }

        public override string getType()
        {
            return type;
        }

        public override double getArea()
        {
            return hs[0] * 2;
        }

        public override double getPerimeter()
        {
            return hs[0] * 4;
        }
    }
}
