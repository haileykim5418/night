using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _0407
{
    class Program
    {
        static void Main(string[] args)
        {
            //반복문
            for (int i = 0; i < 4; i++)
                Console.WriteLine("안녕" + (i + 1));


            Console.WriteLine("안녕하세요"[0]);
            Console.WriteLine("안녕하세요"[1]);
            Console.WriteLine("안녕하세요"[2]);
            Console.WriteLine("안녕하세요"[3]);
            for (int i = 0; i < 4; i++)
                Console.WriteLine("안녕하세요"[i]);


            //배열 = 한개의 변수가 동일한 타입의 여러값을 가짐

            string name = "김동혁";
            string[] names = { "김동혁", "정연우", "임수환" };

            for (int i = 0; i < name.Length; i++) //하나를 짜갈라서 문자 하나씩 나옴
            {
                Console.WriteLine(name[i]);
            }

            for (int i = 0; i < names.Length; i++) //""하나씩
            {
                Console.WriteLine(names[i]);
            }

            string[] handsome = new string[10];  //변수의 크기만 잡아놓음
            for (int i = (int)'A'; i < (int)'z'; i++)
                Console.Write((char)i);
            for (int i = (int)'가'; i < (int)'하'; i++)
            {

                Console.Write((char)i);
                if (i == (int)'냐')
                    break; //i가'냐'를 만났을때 끝내줘. 특수한 문자를 만났을때 끝내고싶을때 사용
                if (i == (int)'하')
                    i = (int)'가';
            }

            //무한대로 도는 반복문 쓰기에 적합한 while

            while (false) //무한반복문 아예 안쓰고싶을때
            {
                Console.WriteLine(new Random().Next(int.MaxValue));
            }


            //for do-while while foreach(c#에서만 존재)
            do //while안의 조건이 false이더라도 한번은 실행
            {
                Console.WriteLine("이동준");
            } while (false);


            while (false) //while안의 조건이false이면 한번도 실행하지 않음
            {
                Console.WriteLine("이동준");
            }

            int count = 100;  //조건 부적합해서 한번도 실행 안함
            while (count < 100)
            {
                Console.WriteLine("카운트값은" + count + "입니다");
            }

            do //부적합해도 일단 한번 실행함
            {
                Console.WriteLine("do while count" + count);
            } while (count < 100);

            //1에서 100까지의 합
            int sum = 0;
            for (int i = 0; i <= 100; i++)
            {
                // if (i % 2 == 0) 짝수만 더할때
                //  sum += i;

                //짝수인 경우에는 아무것도 안하고 홀수인 경우에만 더한다
                if (i % 2 != 0)
                    continue;
                sum += i;
            }
            Console.WriteLine(sum);


            //foreach  배열이나 문자열에 있는걸 하나하나 순차적으로 다 쓰고싶을때
            foreach (var item in names)
            {
                Console.WriteLine(item + "is good man");
            }



            int countIndex = 0;
            foreach (var item in names)
            {
                if (countIndex == 0) //인덱스값이 0일때는 안함
                {
                    countIndex++;
                    continue;
                }
                Console.WriteLine(item + "is good man");
            }


            for (int i = 0; i < names.Length; i++)
            {
                if (i != 0)
                    Console.WriteLine(names[i] + "is good man");
            }
            for (int i = 1; i < names.Length; i++)
            {
                Console.WriteLine(names[i] + "is good man");
            }
            for (int i = 0; i < names.Length; i++)
            {
                if (i == 0)
                    continue;
                Console.WriteLine(names[i] + "is good man");
            }

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            for (int i = 0; i < 10; i++)
            {
                for (int j = 10; j > i; j--)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            for (int i = 0; i < 10; i++)
            {
                for (int j = 10; j > i; j--)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("**");
                }
                Console.WriteLine();
            }


            for (int i = 0; i < 10; i++)
            {
                for (int j = 10; j > i; j--)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("**");
                }
                Console.WriteLine();
            }
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 10; j > i; j--)
                {
                    Console.Write("**");
                }

                Console.WriteLine();
            }

            Console.WriteLine("피라미드");
            for (int i = 0; i < 10; i++)
            {
                for (int j = 10; j > i; j--)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < 2 * i + 1; j++) //2n+1
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            Console.WriteLine("다이아"); //피라미드 코드 2개 복붙. 별의개수가 늘어야함

            for (int i = 1; i <= 5; i++)
            {
                for (int j = 5; j > i; j--)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < 2 * i - 1; j++) //2n+1
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            for (int i = 4; i > 0; i--)//공백의 개수가 늘어야함
            {
                for (int j = 5; j > i; j--)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < 2 * i - 1; j++) //2n+1
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            
            //goto문
            for(int i=0; i<10; i++)
            {
                Console.WriteLine("외부반복문");
                for(int j=0; j<10; j++)
                {
                    Console.WriteLine("내부반복문");
                    goto Example;
                }
            }
            Example:
            Console.WriteLine("go to");


            string teacher = Console.ReadLine();
            if (teacher == "이동준")
                goto Example;

            //ToUpper, ToLower
            string example = "exAmPle";
            Console.WriteLine(example.ToUpper()); //대문자
            Console.WriteLine(example.ToLower()); //소문자
            Console.WriteLine(example); //원본
            example = example.ToUpper();

            //split
            string guys = "김,장,정,임";
            string[] guys_array = guys.Split(','); //콤마를 기준으로 자르겠다
            foreach (var item in guys_array)
            {
                Console.WriteLine(item+"하이");
            }

            //join - split반대
            string guys2 = string.Join(",", guys_array);
            Console.WriteLine(guys2);

            string trim = "안녕 ji everyone";
            Console.WriteLine("!"+trim+"i");
            Console.WriteLine(" !안녕 hi everyone())zzzzzzzzz");



            /*     Console.WriteLine("숫자 5개 입력:");
                 int[] num1 = new int*/

            /*int num1 = int.Parse(Console.ReadLine());
           

            int max = 0;
            int min = 0;
            for (int i = 0; i < 5; i++)
            {
                if(num1 > max)
                {
                    max = num1[i]
                }
                if (num1 < min)
                {
                    min = num1[i]
                }
            }*/

            Console.WriteLine("숫자 5개 입력:");

            string num1 = Console.ReadLine();
            string[] num1 = num1.Split(',');
            int[] numbers = Array.ConvertAll(num1, int.Parse);

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
