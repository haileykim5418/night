using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20210405
{
    class answer
    {
        static void Main(string[] args)
        {
            //inch를 입력받아서 cm단위를 구하는 코드 쓰기
            //1inch = 2.54cm

            double inch = double.Parse(Console.ReadLine()); //값을 입력받아서 그걸 double로 형변환하고 inch변수에 넣어라
            Console.WriteLine(inch * 2.54+"cm");
            Console.WriteLine(string.Format("{0}cm", inch * 2.54));
            Console.WriteLine($"{inch * 2.54}cm");

            //킬로그램 단위를 입력받아 파운드 단위를 구하는 코드작성

            double pound = double.Parse(Console.ReadLine());
            Console.WriteLine(pound * 2.20462262 + "pound");

            //원의 반지름을 입력받아서 원의 둘레와 넓이 구하기
            double r = double.Parse(Console.ReadLine());
            const double PI = 3.14; //const = Final 상수
            Console.WriteLine("둘레:"+(r*PI*2));
            Console.WriteLine("넓이:" + (r * PI * r));

            //4번
            int one = int.Parse(Console.ReadLine());
            int two = int.Parse(Console.ReadLine());

            Console.WriteLine(one * two%10); //첫번째 숫자 곱하기 두번째숫자의1의자리 -- 10으로 나누면 38.5니까 나머지가 5
            Console.WriteLine(one * two); //첫번째 숫자 곱하기 두번째숫자의10의자리
            Console.WriteLine(one * two / 100); //첫번째 숫자 곱하기 두번째숫자의100의자리
            Console.WriteLine(one * two); //첫번째숫자 곱하기 두번째숫자


            string sTwo = two.ToString();

            Console.WriteLine(one * int.Parse(sTwo[2].ToString()));
            Console.WriteLine(one * (sTwo[1]-'0'));
            Console.WriteLine(one * (sTwo[0] - '0'));




        }
    }
}
