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
            for (int i = 0; i < lotto.Length; i++)
            {
                rand = r.Next(1, 46);
                lotto[i] = rand;
                sum += lotto[i];
                Console.WriteLine(lotto[i]);
                /*Console.WriteLine(lotto[1]);
                Console.WriteLine(lotto[2]);
                Console.WriteLine(lotto[3]);
                Console.WriteLine(lotto[4]);
                Console.WriteLine(lotto[5]);*/

                for (int j = 0; j < i; j++)
                {
                    if (lotto[i] == lotto[j])
                    i--;
                    sum -= lotto[i];
                }
            }

            //숫자순서 정렬방법1
            // Array.Sort(lotto);

            //숫자순서 정렬방법2
            for (int i = 0; i < lotto.Length; i++)
            {
                for (int j = 0; j < i-1; j++)
                {
                    if (lotto[j] > lotto[j + 1])
                    {
                        int temp2 = lotto[j];
                        lotto[j] = lotto[j + 1];
                        lotto[j + 1] = temp2;
                    }
                }
            }

            num1.Text = lotto[0].ToString();
            num2.Text = lotto[1].ToString();
            num3.Text = lotto[2].ToString();
            num4.Text = lotto[3].ToString();
            num5.Text = lotto[4].ToString();
            num6.Text = lotto[5].ToString();
            label7.Text = lotto[6].ToString();
        }
    }
}
