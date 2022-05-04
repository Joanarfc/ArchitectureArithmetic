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
            double floorPlan = Circle(375) + Triangle(750, 500) + Rectangle(1500, 2500);
            Console.WriteLine($"The area of the floor plan is: {floorPlan}");

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
