using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0406gh
{
    class Program
    {
        static void Main(string[] args)
        {
            //1번 띠

            int year = int.Parse(Console.ReadLine());
            switch (year % 12)
            {
                case 0:
                    Console.WriteLine("원숭이");
                    break;

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

                default:
                    Console.WriteLine("올바르지 않은 입력");
                    break;
            }

            int month = int.Parse(Console.ReadLine());
            switch (month)
            {
                case 12:
                case 1:
                case 2:
                    Console.WriteLine("봄");
                    break;
                case 3:
                case 4:
                case 5:
                    Console.WriteLine("여름");
                    break;
                case 6:
                case 7:
                case 8:
                    Console.WriteLine("가을");
                    break;
                case 9:
                case 10:
                case 11:
                    Console.WriteLine("겨울");
                    break;

                default:
                    Console.WriteLine(month + "는 잘못된 입력");
                    break;
            }

            //3번 알람
            Console.WriteLine("시:");
            int h = int.Parse(Console.ReadLine());
            Console.WriteLine("분:");
            int m = int.Parse(Console.ReadLine());
            Console.WriteLine($"내가 맞춘 시간: {h}시{m}분");
            if (m < 45)
            {
                h -= 1;
                m += 60;
                m -= 45;
                if (h < 0)
                    h += 24;
            }
            else
            {
                m -= 45;
            }          
            
            Console.WriteLine(h + "시" + m + "분에 알람이 울립니다");



        }
    }
}
