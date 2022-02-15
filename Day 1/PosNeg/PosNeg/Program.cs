using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PosNeg
{
    internal class Program
    {
        public void Check(int n)
        {
            if (n >= 0)
                Console.WriteLine("Positive number");
            else
                Console.WriteLine("Negative number");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int n = Convert.ToInt32(Console.ReadLine());
            Program obj = new Program();
            obj.Check(n);
        }
    }
}
