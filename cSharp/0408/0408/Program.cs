using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0408
{
    class Program
    {
        static void Main(string[] args)
        {
            //1번 최대최소
            //가장 첫번째 숫자를 MAX이자MIN으로 가정하기 - 배열의 칸만큼 반복 수행
            /* int[] numbers = new int[5]; //5칸 배열 생성

             for (int i = 0; i < numbers.Length; i++)
             {
                 numbers[i] = int.Parse(Console.ReadLine()); //숫자 하나하나 넣기
             }
             int min = numbers[0];
             int max = numbers[0];

             for (int i = 0; i < numbers.Length; i++)
             {
                 if (numbers[i] < min)
                     min = numbers[i];
                 if (numbers[i] > max)
                     max = numbers[i];
             }
             Console.WriteLine("min:"+min+"max:"+max);
 */


            //2번 개미수열
            string start = "1";
            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine((i+1)+"번째 수열:"+start);
                char number = start[0];
                int count = 0;
                string end = "";

                for (int j = 0; j <start.Length; j++)
                {
                    if (number == start[j])
                    {
                        count++; //몇개 읽었는지 추가
                    }
                    else
                    {
                        end = end + number + count;
                        number = start[j];
                        count = 1;
                    }
                }
                end = end + number + count;
                start = end;
            }

            //3번 별찍기
            int inputFloor = int.Parse(Console.ReadLine());
            int flag = 0; //별 공백 뭐부터 시작할지 구분짓는거
           if(inputFloor == 1)
                Console.WriteLine("*");
            else
            {
                for (int i = 0; i < inputFloor*2; i++) //전체 층 수
                {
                    for (int j = 0; j < inputFloor; j++) //한 줄에 입력되는 갯수를 입력하는 반복문
                    {
                        if (flag % 2 == 0)
                            Console.Write("*");
                        else
                            Console.Write(" ");
                        
                        flag++;
                    }
                    if (inputFloor % 2 == 0) //입력값이 짝수이면 flag값을 한번 더 증가시켜서 한번 더 출력되게
                        flag++;
                   Console.WriteLine();
                }
               


            }

            //4번 배달


            int totalSugar = int.Parse(Console.ReadLine());
            int podae = 0;

            while (true)
            {
                if (totalSugar % 5 == 0)  //포대 갯수가 5의 배수인지 확인하고 5로 나눈 값을 더해줌 예를들어 15 입력하면 15/5 해서 3을 더해줌
                { 
                    podae += totalSugar / 5;
                    break;
                }
                totalSugar -= 3;
                podae++;

                if (totalSugar < 0)
                {
                    podae = -1;
                    break;
                }
            }
            Console.WriteLine(podae);
        }
    }
}
