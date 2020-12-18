using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wierdcsharp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1번.1부터 100까지의 합 구하고 3의 배수에 해당하는 것 ");

            int sum = 0;
            for (int i = 0; i < 100; i++)
            {
                if (i % 3 == 0)
                {
                    sum += i;
                    Console.WriteLine(i);
                }
            }


            Console.WriteLine("2번 ");
            Console.Write("숫자 입력하세요: ");
            int aa = int.Parse(Console.ReadLine());

            {
                Console.WriteLine($"{aa / 60}분{aa % 60}초");
            }
            //Console.WriteLine("3번. 별모양 피라미드");
            //{
            //for (int i = 0; i < 50; i++)
            //if (i > 0)
            // }

            Console.WriteLine("4번.");
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    Console.WriteLine($"{i + 1}x{j + 1}={(i + 1) * (j + 1)}");
                }
            }
            Console.WriteLine("5번.");
            Console.Write("숫자 입력하세요: ");
            int w = int.Parse(Console.ReadLine());

            switch (w)
            {
                case 12:
                case 1:
                case 2:
                    Console.WriteLine("겨울입니다");
                    break;
                case 3:
                case 4:
                case 5:
                    Console.WriteLine("봄입니다");
                    break;
                case 6:
                case 7:
                case 8:
                    Console.WriteLine("여름입니다");
                    break;
                case 9:
                case 10:
                case 11:
                    Console.WriteLine("겨울입니다");
                    break;


            }
            Console.WriteLine("3번.");
            int q, r = 0;
            for (q=0; q<=4; q++)
            {
                for (r = 0; r <= q; r++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");

                //근데 이건 인터넷 베낀거예요..저 이거 만들줄 몰라요.....
            }



                }
            }
        }
   


