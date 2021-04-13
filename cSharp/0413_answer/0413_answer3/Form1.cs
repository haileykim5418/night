using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _0413_answer3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<string> textList = new List<string>();
            textList.Add("안녕");
            textList.Add("hello");
            textList.Add("올라");
            textList.Add("니하오");

            label1.Text = ""; //원래있던 텍스트 내용 리셋
            label1.Text = textList[new Random().Next(textList.Count)]; //랜덤
         


        }
    }
}
