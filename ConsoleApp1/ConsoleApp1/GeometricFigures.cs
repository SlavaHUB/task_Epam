using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    abstract class GeometricFigures
    {
        public abstract double getArea();
        
        public abstract double getPerimeter();
        public abstract string getType();

        public double[] hs;

        public string type;

    }
}
