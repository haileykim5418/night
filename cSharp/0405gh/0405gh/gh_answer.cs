using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0405gh
{
    class gh_answer
    {
        static void Main(string[] args)
        {

            //1번
           
            double inch = double.Parse(Console.ReadLine());
            Console.WriteLine(inch * 2.54 + "cm");

            //2번
            double kg = double.Parse(Console.ReadLine());
            Console.WriteLine(kg * 2.20462262 + "pound");

            //3번
            double r = double.Parse(Console.ReadLine());
            double pi = 3.14;
            double c1 = (2 * pi * r);
            Console.WriteLine("둘레:" + c1);
            Console.WriteLine("넓이:" + pi * r * r);

            //4번
            int num1 = 472;
            int num2 = 385;

            Console.WriteLine("num3:" + num1 * (num2 % 10));
            Console.WriteLine("num4:" + num1 * (num2 % 100 / 10));
            Console.WriteLine("num5:" + num1 * (num2 / 100));

            int num6 = num1 * num2;
            Console.WriteLine("num6 :" + num6);
        }
    }
}
