using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleProg
{
    internal class Program
    {
        public void Calc(double r)
        {
            double area = 3.14 * r * r;
            double cir = 2 * 3.14 * r;
            Console.WriteLine("Area of circle = "+area);
            Console.WriteLine("Circumference of circle = "+cir);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter radius");
            double rad = Convert.ToDouble(Console.ReadLine());
            Program program = new Program();
            program.Calc(rad);
        }
    }
}
