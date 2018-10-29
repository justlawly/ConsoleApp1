using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("math");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("eng");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("phyz");
            double c = double.Parse(Console.ReadLine());
            double d;
            double dd;
            a = a * 0.4;
            b = b * 0.2;
            c = c * 0.4;
            d = (a + b + c) / 3;
            
            Console.WriteLine("sum is="+d);
            Console.WriteLine("oreh");
            double e = double.Parse(Console.ReadLine());
            Console.WriteLine("rohav");
            double f = double.Parse(Console.ReadLine());
            d = 2*(e+f);
            dd = e * f;
            Console.WriteLine("hekef is= "+d+"shetah is "+dd);

            int i = 1;
            int sum = 1;
            Console.WriteLine("enter number");
            int n = int.Parse(Console.ReadLine());
            while(i<=n)
            {
                sum *=i;
                i++;
            }
            Console.WriteLine("blabla is= " + sum);




        }
    }
}
