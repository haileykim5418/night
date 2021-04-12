using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test0412
{
    public partial class randNumber : Form
    {
        Random rand = new Random();

        public randNumber()
        {
            InitializeComponent();         

        }

        private void test_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] numbers = new int[10];
            int a = 0;

           
            for (int i = 0; i < numbers.Length; i++)
            {
                a = rand.Next(1, 11);
                numbers[i] = a;
                Console.WriteLine(numbers[i]);
                if (textbox.Text == numbers[i].ToString())
                {
                    MessageBox.Show("정답");
                    break;
                }
                else if (Convert.ToInt32(textbox.Text) > Convert.ToInt32(numbers[i].ToString()))
                {
                    MessageBox.Show("입력한 값보다 작습니다");
                    break;
                }
                else if (Convert.ToInt32(textbox.Text) < Convert.ToInt32(numbers[i].ToString()))
                {
                    MessageBox.Show("입력한 값보다 큽니다");
                    break;
                }

            }

          
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
     
        }
    }
}
