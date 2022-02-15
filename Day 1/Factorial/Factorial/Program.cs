using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial
{
    internal class Program
    {
        public void Fact(int n)
        {
            int p = 1;
            for(int i=1; i <= n; i++)
            {
                p = p * i;
            }
            Console.WriteLine(p);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int n = Convert.ToInt32(Console.ReadLine());
            Program obj = new Program();
            obj.Fact(n);
        }
    }
}
