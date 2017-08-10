using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolB
{
    class B10
    {
        static void Main()
        {
            Console.Write("Please enter a:");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Please enter b:");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Please enter c:");
            double c = Convert.ToDouble(Console.ReadLine());

            double s = (a + b + c) / 2;

            if (s<a || s<b || s < c)
            {
                Console.WriteLine("That is not a triangle.");
            } else
            {
                Console.WriteLine(Math.Sqrt(s * (s - a) * (s - b) * (s - c)));
            }

        }
    }
}
