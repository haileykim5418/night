using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0407gh
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("피라미드");
            for (int i = 0; i < 10; i++)
            {
                for (int j = 10; j > i; j--)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < 2 * i + 1; j++) 
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            Console.WriteLine("다이아"); 

            for (int i = 1; i <= 5; i++)
            {
                for (int j = 5; j > i; j--)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < 2 * i - 1; j++) 
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            for (int i = 4; i > 0; i--)
            {
                for (int j = 5; j > i; j--)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < 2 * i - 1; j++) 
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            Console.WriteLine("숫자 5개 입력:");
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());
            int num4 = int.Parse(Console.ReadLine());
            int num5 = int.Parse(Console.ReadLine());

            int[] numbers = { num1, num2, num3, num4, num5 };


            int max = numbers[0];
            int min = numbers[0];

            for (int i = 0; i < 5; i++)
            {
                if (numbers[i] > max)
                    max = numbers[i];
                if (numbers[i] < min)
                    min = numbers[i];
            }
            Console.WriteLine("최소값: " + min + "최대값: " + max);
        }
    }
}
