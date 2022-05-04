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
            Console.WriteLine("********List of monuments********");
            Console.WriteLine("What monument would you like to work with?");
            Console.WriteLine("1 - Taj Mahal");
            Console.WriteLine("2 - Great Mosque");
            Console.WriteLine("3 - Pantheon\n");

            Console.WriteLine("What monument would you like to work with? (1-3)");

            string monumentChoice = Console.ReadLine().ToUpper();

            switch (monumentChoice)
            {
                case "1":
                    CalculateTotalCostTajMahal(monumentChoice, Triangle(24, 24), Rectangle(90.5, 90.5));
                    break;
                case "2":
                    CalculateTotalCostGreatMosque(monumentChoice, Rectangle(284,264), Triangle(84, 264), Rectangle(180, 106));
                    break;
                case "3":
                    CalculateTotalCost(monumentChoice, Circle(375), Triangle(750, 500), Rectangle(2500, 1500));
                    break;
                default:
                    Console.WriteLine("Not a valid choice");
                    break;
            }


            //CalculateTotalCost(Circle(375), Triangle(750, 500), Rectangle(2500, 1500));

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

        public static void CalculateTotalCost(string choice, double circle, double triangle, double rectangle)
        {
            double costMaterial = 180;

            double floorPlanCost = Math.Round((rectangle + circle + triangle) * costMaterial, 2);

            Console.WriteLine($"The cost of the monument {choice} is: {floorPlanCost}");

        }

        public static void CalculateTotalCostTajMahal(string choice, double triangle, double rectangle)
        {
            double costMaterial = 180;

            double floorPlanCost = Math.Round((rectangle - (4*triangle)) * costMaterial, 2);

            Console.WriteLine($"The cost of the monument {choice} is: {floorPlanCost}");

        }

        public static void CalculateTotalCostGreatMosque(string choice, double rectangle1, double triangle, double rectangle2)
        {
            double costMaterial = 180;

            double floorPlanCost = Math.Round(((rectangle1 - triangle) + rectangle2) * costMaterial, 2);

            Console.WriteLine($"The cost of the monument {choice} is: {floorPlanCost}");

        }

    }
}
