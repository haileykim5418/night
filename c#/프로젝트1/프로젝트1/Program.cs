using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 프로젝트1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello World"); //cw하고 탭탭

            int a = 100;

            if(a>50)
            {
                Console.WriteLine("a는 50을 넘는다");
            }
            else
            {
                Console.WriteLine("a는 50을 넘지 않는다");
            }
            //스캐너
            //int aa = s.nextInt();

            string ss = Console.ReadLine();
            String sa = Console.ReadLine();
            int aa = int.Parse(Console.ReadLine());

            switch(aa)
            {
                case 1:
                    Console.WriteLine("1");
                    break;
                case 2:
                    break;
                default:
                    break;
            }

            for (int i = 0; i <10; i++)
            {

            }
            int temp = 10;
            while (temp>0)
            {
                temp--;
            }
            do
            {
                temp++;
            } while (temp < 0);

            int abc = 100;
            if (abc == 100)
            {

            }
            else
            {

            }
        }
    }
}
