using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @new
{
    class Program
    {
        static void Main(string[] args)
        {

            //java실행법 = ctrl + f11 / c# = ctrl+f5
            //syso~("Hello") = cw탭탭("Hello"); 한줄 띄기
            Console.WriteLine("Hello 하고 한줄 띈다.");

            //sys.print("Hello"); = console~write("Hello") 한줄 안띄기
            Console.Write("Hello 한줄 안띄기");

            //syso. println(); = cw(탭탭) ();
            Console.WriteLine(); //여기서 한줄 띄움

            //변수 자바와 동일

            int example = 100;
            //단 string변수는 s 대소문자 구분 안해도됨 c#에서는 보통 소문자로 적음
            string ex1 = "하이";
            String ex2 = "헬로";
            string 이런것도됨 = "신기하쥬?";
            Console.WriteLine(이런것도됨);

            //문자열과 숫자 혼합하기
            string ex3 = example + "더하기" + example + "은" + (example + example) + "이다.";
            string ex4 = $"{example} 더하기 {example}은 {example + example}이다.";
            string ex5 = string.Format("{0} 더하기 {1}은 {2}이다.", example, example, example + example);

            Console.WriteLine(ex3);
            Console.WriteLine(ex4);
            Console.WriteLine(ex5);

            //조건문
            //자바와 동일
            if (example > 50)
            {
                Console.WriteLine("example은 50이상");
            }
            if (example > 30)
            {
                Console.WriteLine("30이상");
            }
            else
            {
                Console.WriteLine("30미만");
            }
            if (example == 10)
            {
                Console.WriteLine("10");
            }
            else if (example == 20)
            {
                Console.WriteLine("20");
            }
            if (example == 10)
            {
                Console.WriteLine("20");
            }//끝에 꼭 else 안붙여도됨
            if (example == 10)
            {
                Console.WriteLine("10");
            }
            else if (example == 20)
            {
                Console.WriteLine("10이랑 20은 아님");
            }
            //switch문도 자바와 동일
            switch (example)
            {
                case 10:
            Console.WriteLine("10");
            break;
        case 20:
            Console.WriteLine("20");
            break;
            default :
                Console.WriteLine("10이랑 20은 아님");
                    break;
        }
            //반복문도 자바와 동일
            //단 foreach 라는 특수 문법이있는데 이건 나중에
            for (int i = 0; i<10; i++)
            {
                Console.WriteLine("같은말 10번 반복하기");
            }
            int temp = 10;

            while (temp > 0)
            {
                temp--;
            }
                do
                {
                    temp++;
                } while (temp < 10);
            }//한번은 실행하는데 거짓이면 바로 빠져나감 그냥 와일은 ㅈ건이 거짓이면 한번도 실행안함

        //값을 입력받는 경우
        //java : 
        //scanner s = new scanner(system.in);
        // int test2 = s.nextInt();
        /*c#
         * string test = console.readline();
         * int test2 = int.parse(console.readline));
         */

        string test = Console.ReadLine();
        int test2 = int.Parse(Console.ReadLine());
            }
        }
    }

