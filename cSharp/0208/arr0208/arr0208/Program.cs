using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arr0208
{
    class ArrClass
    {
        private int sum;
        private int avg;

        public ArrClass(int[] arr)
        {
            sum = 0;
            avg = 0;
            Console.WriteLine();
           for(int i =0; i < arr.Length; i++)
            {
                // Console.WriteLine(arr[i]);
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


        /* public int Sum1 { get => sum; set => sum = value; }
         public int Avg { get => avg; set => avg = value; }*/
    }

    class Program 
    {
        static void Main(string[] args)
        {
            int[] arr = { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };
            ArrClass arr1 = new ArrClass(arr);
            arr1.showInfo();
        }
    }
}
