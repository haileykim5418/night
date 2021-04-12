using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0405
{
    class classTest
    {
        static void Main(string[] args)
        {
            // 숫자의 기본값은 정수
            Console.WriteLine(1 / 2); // 둘 다 정수라서 소수점X

            // 실수로 표기했기 때문에 0.5로 출력
            Console.WriteLine(1 / 2.0); // 0.5
            Console.WriteLine(1.0 / 2); // 0.5

            // 덧셈 뺄셈 곱셈 나눗셈 나머지
            Console.WriteLine(5 + 3);
            Console.WriteLine(5 - 3);
            Console.WriteLine(5 * 3);
            Console.WriteLine(5 / 3);
            Console.WriteLine(5 % 3);

            // () : 우선순위
            Console.WriteLine(5 + 3 * 5 - 2); // 18
            Console.WriteLine((5 + 3) * (5 - 2)); // 24

            // 음수와 나머지 연산자
            Console.WriteLine(4 % 3);
            Console.WriteLine(-4 % 3);
            Console.WriteLine(4 % -3);
            Console.WriteLine(-4 % -3);

            // [] : 문자 선택자
            Console.WriteLine("안녕하세요"[0]); // 안
            Console.WriteLine("안녕하세요"[4]); // 요
            //Console.WriteLine("안녕하세요"[5]); // error

            Console.WriteLine((int)"안녕하세요"[0]);

            /* int a == 10; 같다는 의미
              int ab = 10; 지정변수에 값 할당*/

            Console.WriteLine(1==1);
            Console.WriteLine(1!=1);
            bool result = true;
            bool result2 = false;

            Console.WriteLine(!result);  //논리부정연산자
            Console.WriteLine(!result2);


            Console.WriteLine(long.MaxValue);
            Console.WriteLine(int.MaxValue);
            Console.WriteLine(1+1); //default값은 int로 지정되어있음

            int a = int.MaxValue;
            int b = int.MaxValue;
            Console.WriteLine(a+b); //overflow
            Console.WriteLine((long)a+b); //정상적인 값

            uint c = uint.MaxValue;  //정해지지않은 타입 (양수만)
            Console.WriteLine(c);

            //복합대입연산자 a+=10  == a=a+10

            int example = 100;
            Console.WriteLine(example++); //100  
            Console.WriteLine(++example); //102

            int exex = 100;
            Console.WriteLine(exex);
            exex = exex + 1;    //100

            exex = exex + 1;
            Console.WriteLine(exex);  //102

          /*  int conclusion = 100;
            conclusion++;
            Console.WriteLine(exex);
            conclusion++;
            Console.WriteLine(exex);

            Console.ReadLine();*/
/*
            string input = Console.ReadLine();  //내가 쓴 문자가 input안에 들어간다
            Console.WriteLine("안녕 나는 "+ input +"이야");*/

            //숫자입력받기
/*
            int number = int.Parse(Console.ReadLine());  //정수
            double num = double.Parse(Console.ReadLine());  //실수
            Console.WriteLine(number / num);
*/
          

            double inch = double.Parse(Console.ReadLine());         
            Console.WriteLine(inch*2.54+"cm");


            double kg = double.Parse(Console.ReadLine());
            double p = kg * 2.20462262;
            Console.WriteLine(kg + "kg=" + p + "pound");


            double r = double.Parse(Console.ReadLine());
            double pi = 3.14;
            double c1 = (2*pi*r);
            Console.WriteLine("둘레:" + c1);
            Console.WriteLine("넓이:" + pi*r*r);


            int num1 = 472;
            int num2 = 385;
        
            Console.WriteLine("num3:"+ num1 * (num2%10));
            Console.WriteLine("num4:"+ num1 * (num2%100/10));
            Console.WriteLine("num5:" + num1 * (num2/100));

            int num6 = num1 * num2;
            Console.WriteLine("num6 :" + num6);
            

        }
    }
}
