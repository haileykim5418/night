using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();  //디자인창에 만들어진 모든 디자인들
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


      
        private void label1_num1_Click(object sender, EventArgs e)
        {

        }

        private void image_Click(object sender, EventArgs e)
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


                    /*num1.Text = r.Next(1, 45).ToString();                    
                    num2.Text = r.Next(1, 45).ToString();
                    num3.Text = r.Next(1, 45).ToString();
                    num4.Text = r.Next(1, 45).ToString();
                    num5.Text = r.Next(1, 45).ToString();
                    num6.Text = r.Next(1, 45).ToString();*/


                }
            }


            //숫자 순서 정렬 방법
            Array.Sort(r);
        }

    
    }
}

