using System;

namespace class0215
{
    class Program
    {
        static void Main(string[] args)
        {
            /*  int[] arr = { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };
              Array1Test1 at1 = new Array1Test1(arr);
              Array1Test1 at2 = new Array1Test1();
              Array1Test1 at3 = new Array1Test1();
              at2.sumAvg(arr);
              at3.setArray(arr);
              at3.sumAvg();*/

            int[,] arr = new int[5, 3]
            {
                {100,90,80 },
                {90,90,80},
                {70,80,90 },
                { 80,70,90 },
                {80,80,80 }
            };
          /*  StudentScore st = new StudentScore(
                arr[i, j], arr[i, j], arr[i, j]);
            st.calculator();*/

            StudentScore[] arrSt = new StudentScore[5];
            for(int i =0; i<5; i++)
            {
                arrSt[i] = new StudentScore();
                    for(int j = 0; j < 3; j++)
                {
                    if (j == 0) { arrSt[i].Kor = arr[i, j]; }
                  else if (j == 1)
                    {
                        arrSt[i].Eng = arr[i, j];
                    }
                   else if (j == 2)
                    {
                        arrSt[i].Math = arr[i, j];
                    }
                   
                }
            }
        }
    }
}
