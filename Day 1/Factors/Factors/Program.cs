using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factors
{
    internal class Program
    {
        public void Show(int n)
        {
            Console.WriteLine("Factors of "+n+" are ");
            for(int i = 1; i <= n; i++)
            {
                if(n%i == 0)
                    Console.WriteLine(i);
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("enter a number");
            int n = Convert.ToInt32(Console.ReadLine());
            Program obj = new Program();
            obj.Show(n);
        }
    }
}
