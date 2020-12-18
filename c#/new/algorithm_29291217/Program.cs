using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algorithm_29291217
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("문제풀이시작");
            Console.WriteLine("1번");
            int sum = 0;
            for (int i = 0; i < 100; i++)
            {
                if (i % 3 == 0)
                    sum += i;
            }
            Console.WriteLine($"1부터 100까지의 수 중 3의 배수의 합은" + $"{sum}이다");
            Console.WriteLine("2번문제");
            int inputsecond = int.Parse(Console.ReadLine());
            Console.WriteLine($"{inputsecond / 60}분 { inputsecond % 60}초");

            Console.WriteLine("3번 문제");
            Console.WriteLine("몇층까지 쌓을것인가");
            int floor = int.Parse(Console.ReadLine());

            for (int i = 0; i < floor; i++)
            {
                //공백 찍는 부분
                for (int j = floor; j > i; j--) //각 층 출력 (공백)
                {
                    Console.Write(' ');
                }
                //별찍는 부분 각층 출력(별)
                for (int k = 0; k < (2 * i) + 1; k++)
                {
                    Console.Write('*');
                }
                Console.WriteLine();
            }
            Console.WriteLine("4번");
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Console.WriteLine($"{i}x{j}={i * j}");
                }
            }
            Console.WriteLine("5번");
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
                default:
                    Console.WriteLine("잘못된 값입니다.");
                    break;

            }
            Console.WriteLine("6번");
            int input1 = int.Parse(Console.ReadLine());
            int input2 = int.Parse(Console.ReadLine());

            if (input1 > 0 && input2 > 0)
                Console.WriteLine("1");
            else if (input1 < 0 && input2 < 0)
                Console.WriteLine("2");
            else if (input1 < 0 && input2 < 0)
                Console.WriteLine("3");
            else if (input1 > 0 && input2 < 0)
                Console.WriteLine("4");
            else //둘다 0인경우
                Console.WriteLine("0");

            Console.WriteLine("7번");
            string start = "1";
            for (int i = 0; i < 20; i++)
            {
                int count = 0;//각자리 숫자의 개수
                string end = "";//문자열을 누적시키는 변수
                Console.WriteLine($"{i + 1}번째 : {start}"); //말하기
                char number = start[0]; //내가 가리키는 숫자

                for (int j = 0; j < start.Length; j++) //읽어들이기
                {
                    if (number != start[j])
                    {
                        end = end + number + count;  //end = ""+'1'+1
                        number = start[j];
                        count = 1;
                    }
                    else
                    {
                        count++;
                    }
                }
                end = end + number + count;
                start = end;

               /* Console.WriteLine("8번");
                int input = int.Parse(Console.ReadLine());
                int max = 1; //각 벌집의 최대값
                int count = 0; //임의의 카운트 변수
                while (true)
                {
                    max=max + (6 * count);
                    if (max<input)
                    {
                        count++;
                        continue;
                    }
                    else
                        Console.WriteLine($"{input}은 { count+1}전체 벌집에 속함");
                     break*/
            }
                int input_dj = int.Parse(Console.ReadLine());
                //패턴정리
                //1       -1번벌집 -
                //2~7     -2번벌집 -6
                //8~19    -3번벌집 -12
                //20~37   -4번벌집  -18
                //36~61   -5번벌집  -24

                if(input_dj == 1)
                    Console.WriteLine("1번벌집");
                else if(input_dj <= 7)//input이 2부터7인 경우
                    Console.WriteLine("2번벌집");
                else
                {
                    int tempcount = 1;
                    int sub = 6;
                    while (input_dj > 0)
                    {
                        input_dj = input_dj - sub;
                        sub = sub + 6;
                        tempcount++;
                        if (input_dj <= 1)
                            break;
                    }
                    Console.WriteLine(tempcount);
                    //Console.WriteLine(tempcount.tostring());
                }
            }
        } }
