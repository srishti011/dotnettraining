using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo3
{
    internal class Program
    {
        public void Sum(int a, int b)
        {
            Console.WriteLine("Sum is "+(a + b));
        }

        public void Sub(int a, int b)
        {
            Console.WriteLine("Sub is "+(a-b));
        }
        static void Main(string[] args)
        {
            int a, b;
            Console.WriteLine("Enter 1st number");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter 2nd number");
            b = Convert.ToInt32(Console.ReadLine());
            Program obj = new Program();
            obj.Sum(a, b);
            obj.Sub(a, b);
        }
    }
}
