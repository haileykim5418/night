using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _0413_answer2
{

    enum Scissors_Rock_Paper
    {
        Gawi, Bawi, Bo
    }
    enum Fruit  //사용자 정의 자료형. 숫자를 글자로 표현
    {
        Banana,Kiwi,Apple=3,Strawberry
    }

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


            /*string[] product = {"바나나","키위","고구마","감자","사과","딸기"};
            //배열 선언할때 내용물 뭔지 미리 알면 new필요없이 이렇게 선언해도됨

            MessageBox.Show(product[0]);
            MessageBox.Show(product[(int)Fruit.Banana]);
            MessageBox.Show(Fruit.Banana.ToString());
            if ((Fruit)0 == Fruit.Banana)
                MessageBox.Show("숫자0은 banana, banana는 0");
*/

            scissors.Text = "가위";
            rock.Text = "바위";
            paper.Text = "보";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int myChoice = 0; //0=가위 1=바위 2=보 라고 약속한것
            int pcChoice = new Random().Next(3);
            label_myR.Text = "가위";
            if (pcChoice ==0)
            {
                label_pcR.Text = "가위";
                label_R.Text = "비김";
            }
            else if (pcChoice == 1)
            {
                label_pcR.Text = "바위";
                label_R.Text = "짐";
            }
            else
            {
                label_pcR.Text = "보";
                label_R.Text = "이김";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Scissors_Rock_Paper mychoice = Scissors_Rock_Paper.Bawi;
            Scissors_Rock_Paper pcchoice = (Scissors_Rock_Paper)new Random().Next(3);
            //0,1,2중 하나가 들어가는데 그게 s_r_p로 변환됨

            label_myR.Text = mychoice.ToString();
            label_pcR.Text = pcchoice.ToString();

            if (mychoice == pcchoice)
            {
                label_R.Text = "비김";
            }
           else if (pcchoice == Scissors_Rock_Paper.Bo)
            {
                label_R.Text = "짐";
            }
            else
            {
                label_R.Text = "이김";
            }

        }

        private void button3_Click(object sender, EventArgs e) 
        {
            string[] GBB = { "가위", "바위", "보" };
            Scissors_Rock_Paper mychoice = Scissors_Rock_Paper.Bo;
            Scissors_Rock_Paper pcchoice = (Scissors_Rock_Paper)new Random().Next(3);

            label_myR.Text = GBB[(int)mychoice];
            label_pcR.Text = GBB[(int)pcchoice];

            if (mychoice == pcchoice) //보
            {
                label_R.Text = "비김";
            }
            else if (pcchoice ==Scissors_Rock_Paper.Gawi) //가위
            {
                label_R.Text = "짐";
            }
            else //바위
            {
                label_R.Text = "이김";
            }

        }
    }
}
