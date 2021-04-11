using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp123
{
    class Number
    {
        private int sum;
        private int avg;

        public Number(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            avg = sum / arr.Length;
        }

        public int Sum
        {
            get { return sum; }
            set { sum = value; }
        }
        public int Avg
        {
            get { return avg; }
            set { avg = value; }
        }
        public void showInfo()
        {
            Console.WriteLine("합:" + sum);
            Console.WriteLine("평균:" + avg);
        }


    }

    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };

            Number number = new Number(arr);
            number.showInfo();
        }
    }
}

