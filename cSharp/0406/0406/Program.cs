using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0406
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            if (name == "박보검") //괄호 안의 내용이 참일 경우에 중괄호 안 내용 실행
            {
                Console.WriteLine("존잘");
            }
            else
            {//지금처럼 실행문이 하나면 중괄호로 안묶어도되는데 두개 이상이면 묶어주는게 좋음
                Console.WriteLine("오징어");
            }

            int a = 100;
            if (a > 50)
            {
                Console.WriteLine("크다");
                a = -100;
            }
            else
            {
                Console.WriteLine("작다");
            }
            a = 100;
            //조건 한번 체크
            if (a > 50)
            {
                Console.WriteLine("크다");
                a = -100;
            }
            if (a < 50)
            {
                Console.WriteLine("작다");
            }
            //조건 두번 체크

            //int num = Convert.ToInt32(Console.ReadLine());
            int num = int.Parse(Console.ReadLine()); //Console.ReadLine()이 원래는 문자열을 인식하는거라 숫자로 변환하게 해줘야함 = int.parse
            if (num % 2 == 0)
            {
                Console.WriteLine("짝수");
            }
            else
            {
                Console.WriteLine("홀수");
            }


            //조건문의 중첩
            if (a > 0)
            {
                Console.WriteLine("a의 값이 양수");
                if (a > 50)
                {
                    Console.WriteLine("a의 값이 50초과");
                }
                else
                {
                    Console.WriteLine("a의 값이 50미만");
                }
            }
            else
            {
                Console.WriteLine("a는 음수");
                if (a > -50)
                {
                    Console.WriteLine("a는 -50보다 큼");
                }
                else
                {
                    Console.WriteLine("a는 -50보다 작음");
                }

                int b = 100;
                if (b < 50)
                {
                    Console.WriteLine("b는 50보다 작다");
                }
                else if (b < 70) //else if는 계속해서 추가 가능
                {
                    Console.WriteLine("b는 70보다 작다");
                }
                else if (b < 90)
                {
                    Console.WriteLine("b는 90보다 작다");
                }
                else
                {
                    Console.WriteLine("b의 값은 " + b + "이다");
                }

                int dice = 3;
                switch (dice)
                {
                    case 1:
                        Console.WriteLine("주사위:1");
                        break;
                    case 2:
                        Console.WriteLine("주사위:2");
                        break;
                    case 3:
                    case 4:
                    case 5:
                    case 6:
                        Console.WriteLine("주사위:3,4,5,6");
                        break;
                    default:
                        Console.WriteLine("1,2,3,4,5,6 중 하나가 아님");
                        break;
                }

                if (dice == 1)
                {
                    Console.WriteLine("주사위1");
                }
                else if (dice == 2)
                {
                    Console.WriteLine("주사위1");
                }
                else if (dice == 3)
                {

                }
                else if (dice == 4 || dice == 5 || dice == 6)
                {
                    Console.WriteLine("주사위 4,5,6");
                }
                else
                {
                    Console.WriteLine("1,2,3,4,5,6 중 하나가 아님");
                }

                //범위지정하기
                int keyCm = 173;
                //키가 180-180 애매, if(170 <= keyCm <180) 이렇게 적으면 안됨
                if (keyCm < 180)
                {
                    Console.WriteLine("루저");
                }
                if (keyCm >= 170 && keyCm < 180) //논리곱 하나라도  false면 다 f
                    Console.WriteLine("루저");

                if (keyCm < 170 || keyCm > 200)//논리합 하나라도 true면 다 t
                    Console.WriteLine("너무 작거나 크다");

                if (keyCm >= 100 ^ keyCm >= 200) //둘다 t이거나 둘다f이면 무조건 f. 하나라도 다른게 있어야 t
                    Console.WriteLine("");


                //삼항연산자. 간단한 조건식은 한줄로 다 표현

                int c = a % 2 == 0 ? -1 : 0;  //a가 짝수면 그 값을  c에 넣고 홀수면 0

                if (a % 2 == 0)
                    c = -1;
                else
                    c = 0;

                //string에 특정한 문장 혹은 글자가 있을때

                string dj = "이동준";
                if (dj.Contains("동"))  //Contains = 특정한 글자가 포함하는지 아닌지 체크
                    Console.WriteLine("동태");

                if (dj.Contains("이동"))
                    Console.WriteLine("move준");





                //문제
                int year = int.Parse(Console.ReadLine());
                switch (year % 12)
                {
                    case 1:
                        Console.WriteLine("닭");
                        break;
                    case 2:
                        Console.WriteLine("개");
                        break;
                    case 3:
                        Console.WriteLine("돼지");
                        break;
                    case 4:
                        Console.WriteLine("쥐");
                        break;
                    case 5:
                        Console.WriteLine("소");
                        break;
                    case 6:
                        Console.WriteLine("호랑이");
                        break;
                    case 7:
                        Console.WriteLine("토끼");
                        break;
                    case 8:
                        Console.WriteLine("용");
                        break;
                    case 9:
                        Console.WriteLine("뱀");
                        break;
                    case 10:
                        Console.WriteLine("말");
                        break;
                    case 11:
                        Console.WriteLine("양");
                        break;
                    case 12:
                        Console.WriteLine("원숭이");
                        break;

                }

                int month = int.Parse(Console.ReadLine());
                switch (month)
                {
                    case 12:
                    case 1:
                    case 2:
                        Console.WriteLine("겨울");
                        break;
                    case 3:
                    case 4:
                    case 5:
                        Console.WriteLine("봄");
                        break;
                    case 6:
                    case 7:
                    case 8:
                        Console.WriteLine("여름");
                        break;
                    case 9:
                    case 10:
                    case 11:
                        Console.WriteLine("가을");
                        break;

                }
            }
        }
    }
}
