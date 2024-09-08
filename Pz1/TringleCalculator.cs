using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pz1
{
    internal class TringleCalculator
    {
        private int _aN;

        public void CalculateTringleCharacteristic(Tringle tringle)
        {
            int side1 = 5, side2 = 5, side3 = 10;


            float perimeter = CalculatePerimeter(tringle);
            double square = Square(side1, side2, side3);

            Console.WriteLine($"P: {perimeter}\nS: {square}");

            if (IsTriangleExist(side1, side2, side3))
            {
                if (side1 == side2 && side1 == side3)
                {
                    Console.WriteLine("Equilateral");
                }
                else if (side1 == side2 || side2 == side3 || side3 == side1)
                {
                    Console.WriteLine("Isosceles");
                }
                else
                {
                    Console.WriteLine("Different sides");
                }
            }
            else
            {
                Console.WriteLine("Doesnt exist");
            }
        }

        private static bool IsTriangleExist(int side1, int side2, int side3)
        {
            return side1 + side2 >= side3 && side2 + side3 >= side1 && side1 + side3 >= side2;
        }

        public float CalculatePerimeter(Tringle tringle)
        {
            return tringle.A + tringle.B + tringle.C;
        }
        private static double Square(int side1, int side2, int side3)
        {
            float p = (side1 + side2 + side3) / 2;
            double res = Math.Sqrt(p * (p + side1) * (p + side2) * (p + side3));

            return res;
        }




    }
}
