using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lotto
{
    public partial class Form1 : Form
    {
        Random r = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void clickButton_Click(object sender, EventArgs e)
        {

            int[] lotto = new int[7];            
            int rand = 0;
            int sum = 0;
            lotto1 :
            for (int i = 0; i < lotto.Length; i++)
            {
                rand = r.Next(1, 46);
                lotto[i] = rand;
                sum += lotto[i];
                Console.WriteLine(lotto[i]);
               

                for (int j = 0; j < i; j++)
                {
                    if (lotto[i] == lotto[j])
                    {
                        i--;
                        sum -= lotto[i];
                    }
                    if (lotto[0] > 34)
                    {
                        i = -1;
                        sum = 0;
                        break;
                    }
                    if (lotto[1] <3 && lotto[1] > 39)
                    {
                        i = 0;
                        sum = 0;
                        break;
                    }
                    if (lotto[2] <4 && lotto[2] > 45)
                    {
                        i = 1;
                        sum = 0;
                        break;
                    }
                    if (lotto[3] < 5 && lotto[3] > 45)
                    {
                        i = 2;
                        sum = 0;
                        break;
                    }
                    if (lotto[4] < 6 && lotto[4] > 45)
                    {
                        i = 3;
                        sum = 0;
                        break;
                    }
                    if (lotto[5] < 7 && lotto[5] > 45)
                    {
                        i = 4;
                        sum = 0;
                        break;
                    }
                }
            }

            //숫자순서 정렬방법1
            // Array.Sort(lotto);

            //숫자순서 정렬방법2
            int temp = 0;
            for (int i = 0; i < lotto.Length; i++)
            {
                for (int j = i+1; j < lotto.Length-1; j++)
                {
                    if (lotto[i] > lotto[j])
                    {
                        temp = lotto[i];
                        lotto[i] = lotto[j];
                        lotto[j] = temp;
                    }
                    if (lotto[i] < 100 && lotto[i] > 200  )
                    {
                        sum = 0;
                        i = 0;
                        goto lotto1;
                    }                    
                }
                Console.WriteLine(lotto[0] + lotto[1] + lotto[2] + lotto[3] + lotto[4] + lotto[5]);
            }

            // 출력
            num1.Text = lotto[0].ToString();
            num2.Text = lotto[1].ToString();
            num3.Text = lotto[2].ToString();
            num4.Text = lotto[3].ToString();
            num5.Text = lotto[4].ToString();
            num6.Text = lotto[5].ToString();
            num7.Text = lotto[6].ToString();
        }
    }
}
