using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            List<GeometricFigures> Figures = new List<GeometricFigures>() { new Сircle(30),
                                                                            new Squares(19),
                                                                            new Rectangle(2.20, 3.13),
                                                                            new Trapezoid(145, 5.12, 4.12, 9.562, 13) };
            Console.WriteLine("1: Calculate the average perimeter and area of ​​all shapes");
            Console.WriteLine("2: Find the shape with the largest area");
            Console.WriteLine("3: Find the type of shape with the largest average perimeter among all other types of shapes");
            Console.WriteLine("4: Exit");

            bool flag = true;
            while(flag == true)
            {
                int key = int.Parse(Console.ReadLine());
                switch (key)
                {
                    case 1:
                        {
                            double averagePerimeter = 0;
                            double averageArea = 0;

                            foreach (var figure in Figures)
                            {
                                averagePerimeter += figure.getPerimeter();
                                averageArea += figure.getArea();
                            }
                            int count = Figures.Count;
                            averagePerimeter = averagePerimeter / count;
                            averageArea = averageArea / count;           

                            Console.WriteLine();
                            Console.WriteLine($"Average perimeter: {averagePerimeter:f3} Average area: {averageArea:f3}");

                            break;
                        }
                    case 2:
                        {
                            double tmp = 0;
                            string strtmp = "";

                            foreach (var figure in Figures)
                            {
                                if (figure.getArea() > tmp)
                                {
                                    tmp = figure.getArea();
                                    strtmp = figure.getType();
                                }
                            }

                            Console.WriteLine();
                            Console.WriteLine($"Largest area: {tmp:f3}" + " " + "Figure: " + strtmp);

                            break;
                        }
                    case 3:
                        {
                            double[] AveragePerimetrOfFigures = new double[4] { 0, 0, 0, 0 };
                            int[] arr = new int[4] {0, 0, 0, 0};
                            Console.WriteLine();
                            foreach (var figure in Figures)
                            {
                                if(figure.getType() == "Circle")
                                {
                                    AveragePerimetrOfFigures[0] += figure.getPerimeter();
                                    arr[0]++;
                                }

                                if (figure.getType() == "Square")
                                {
                                    AveragePerimetrOfFigures[1] += figure.getPerimeter();
                                    arr[1]++;
                                }

                                if (figure.getType() == "Rectangle")
                                {
                                    AveragePerimetrOfFigures[2] += figure.getPerimeter();
                                    arr[2]++;
                                }

                                if (figure.getType() == "Trapezoid")
                                {
                                    AveragePerimetrOfFigures[3] += figure.getPerimeter();
                                    arr[3]++;
                                }
                            }

                            for (int i = 0; i < 4; i++)
                            {
                                AveragePerimetrOfFigures[i] = AveragePerimetrOfFigures[i] / arr[i];
                            }

                            double max = 0;
                            int tmp = -1;
                            int j;
                            for (j = 0; j < 4; j++)
                            {
                                if (max < AveragePerimetrOfFigures[j])
                                {
                                    max = AveragePerimetrOfFigures[j];
                                    tmp = j;
                                }
                            }

                            Console.Write("Figures: ");
                            if(tmp == 0) Console.WriteLine("Circle");
                            else if (tmp == 1) Console.WriteLine("Squares");
                            else if (tmp == 2) Console.WriteLine("Rectangles");
                            else if(tmp == 3) Console.WriteLine("Trapezoids");

                            Console.WriteLine($"with meaning {max:f3}");

                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine("The end :) ");
                            flag = false;
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Try again");
                            break;
                        }
                }

            }

            Console.ReadKey();
        }
    }
}
