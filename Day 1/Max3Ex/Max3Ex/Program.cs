using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Max3Ex
{
    internal class Program
    {
        public void Max(int a, int b, int c)
        {
            int m = a;
            if(m < b)
                m = b;
            if(m < c)
                m = c;
            Console.WriteLine("Maximum = "+m);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 3 numbers");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine()); 
            int c = Convert.ToInt32(Console.ReadLine());
            Program obj = new Program();
            obj.Max(a, b, c);
        }
    }
}
