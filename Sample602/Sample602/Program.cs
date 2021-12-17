using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample602
{
    class Program
    {
        static void Main(string[] args)
        {
            Calc calc = new Calc();
            int num1 = 1,
                num2 = 2,
                num3 = 3;

            int ans1 = calc.Add(num1, num2);
            int ans2 = calc.Add(num1, num2, num3);

            Console.WriteLine("{0} + {1} = {2}", num1, num2, ans1);
            Console.WriteLine("{0} + {1} + {2} = {3}", num1, num2, num3, ans2);
        }
    }
}