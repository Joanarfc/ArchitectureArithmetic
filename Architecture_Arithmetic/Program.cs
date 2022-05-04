using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Architecture_Arithmetic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"The area of the Rectangle is: {Rectangle(4, 5)}");
            Console.WriteLine($"The area of the Rectangle is: {Circle(4)}");
            Console.WriteLine($"The area of the Rectangle is: {Triangle(10, 9)}");
        }

        public static double Rectangle(double length, double width)
        {
            double area = length * width;
            return area;
        }

        public static double Circle(double radius)
        {
            double area = Math.PI * Math.Pow(radius, 2);
            return area;
        }

        public static double Triangle(double bottom, double height)
        {
            double area = 0.5 * bottom * height;
            return area;
        }
    }
}
