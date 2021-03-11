using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace override_overloading
{
    class Program
    {
        static void Main(string[] args)
        {
            helloWorld();
            helloWorld(10);
            helloWorld(10.5);

            Cat c = new Cat();
            c.eat();

            Animal a = new Animal();
            a.eat();
        }

        static int add(int a, int b)
        {
            return a + b;
        }
        static string add(string a, int b)
        {
            return a + b;
        }

        static int add_int(int a, int b)
        {
            return a + b;

        }
        static string add_string (string a, int b)
        {
            return a + b;
        }

        static void helloWorld()
        {
            Console.WriteLine("ㅎㅇ");
        }
        static void helloWorld(int a)
        {
            Console.WriteLine("ㅎㅇ"+a);

        }
        static void helloWorld(double a)
        {
            Console.WriteLine("ㅎㅇ" + a);
        }
        //static int helloWorld(double a)
        //{
        //    Console.WriteLine("ㅎㅇ" + a);
        //    return 0;
        //}
    }
}
