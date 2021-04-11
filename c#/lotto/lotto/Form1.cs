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
        public Form1()
        {
            InitializeComponent();
        }

        private void clickButton_Click(object sender, EventArgs e)
        {

            int[] lotto = new int[6];
            Random r = new Random();
            for (int i = 0; i < lotto.Length; i++)
            {
                lotto[i] = r.Next(1, 46);
                for (int j = 0; j < i; j++)
                {
                    if (lotto[i] == lotto[j])
                        i--;

                    num1.Text = r.Next(1, 45).ToString();
                    num2.Text = r.Next(1, 45).ToString();
                    num3.Text = r.Next(1, 45).ToString();
                    num4.Text = r.Next(1, 45).ToString();
                    num5.Text = r.Next(1, 45).ToString();
                    num6.Text = r.Next(1, 45).ToString();
                }
            }
        }
    }
}
