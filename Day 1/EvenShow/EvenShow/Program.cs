using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenShow
{
    internal class Program
    {
        public void Show(int n)
        {
            for(int i = 2; i <= n; i+=2)
            {
                Console.WriteLine(i+" ");
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int n = Convert.ToInt32(Console.ReadLine());
            Program obj = new Program();
            obj.Show(n);
        }
    }
}
