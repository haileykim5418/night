using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace chapter05_2
{
    public partial class Form1 : Form   //partial = Form1이라는 클래스 하나 생성하는데 한개 클래스를 두개로 정의(디자이너.cs하나, 그냥.cs하나)
    {
        public Form1()
        {
            InitializeComponent();
            button1.Text = "안녕하세요";
            int abc = 100;
            if (abc == 100)
                button1.Enabled = false; //abc값이 100인데 abc값이 100일 경우 버튼을 비활성화

            Button b = new Button(); //코드만으로도 버튼 생성가능
            b.Text = "버튼이야"; //b라는 변수의 텍스트 속성은 "~"이다
            b.Location = new Point(50, 50); //form원을 기준으로  x,y축 설정하여 위치
            Controls.Add(b); //form1 안에있는 모든게 controls. 이걸 해야지만 내가 만든 변수가 form1창에 나타남


            //list = 배열의 크기를 미리 지정하지 않음. 동적으로 움직이는 배열. 내가 배열 만들긴할건데 몇개넣을지 안정해졌으면 사용함

            List<int> iList = new List<int>();
            iList.Add(10);
            iList.Add(50);
            iList.Add(123);
            for (int i = 0; i < iList.Count; i++)  //iList안에 들어가있는 만큼 반복
            {
                Console.WriteLine(iList[i]);
            }
            iList.Add(1000);
            MessageBox.Show(iList.Count + "개");

            List<string> sList = new List<string>();  //list안에 string타입도 가능
            sList.Add("김가현");
            sList.Add("박지민");
            sList.Add("양화영");
            sList.Add("서정빈");
            MessageBox.Show(sList.Count + "명");
            sList.Remove("서정빈"); //지우기.  특정 순서의 값을 지우고싶을때는 removeAt

            string names = string.Empty;  // = " "
            for (int i = 0; i < sList.Count; i++)
            {
                names += sList[i];
            }
            MessageBox.Show(names);


            Label l = new Label();
            l.Text = "절댓값:" + Math.Abs(-1000);
            l.Location = new Point(100, 100);
            Controls.Add(l);

            Product p = new Product();  //product라는 클래스가 있는데 그걸 이용해 p라는 변수 선언을 함. 내가 만든 클래스로 만든 변수 = 인스턴스 즉. 인스턴스=p
            p.name = "감자";
            p.price = 1000;
            Product.count++;  //클래스변수는 (클래스이름.변수) 이렇게밖에 접근할수없음!
            MessageBox.Show("제품명:" + p.name);
            MessageBox.Show("제품가격:" + p.price);
            MessageBox.Show("제품개수:" + Product.count);

            Product p2 = new Product();  
            p2.name = "고구마";
            p2.price = 5000;
            MessageBox.Show("제품명:" + p2.name);
            MessageBox.Show("제품가격:" + p2.price);


            //변수선언과 동시에 값들 지정
            Product p3 = new Product() { name = "파", price = 50 };

            Dog dj = new Dog("도비", 17);  //인스턴스변수값을 지정
            MessageBox.Show(dj.name + dj.age);
            Dog abcd = new Dog("꼬꼬", 0);
            MessageBox.Show("개의 수: " + Dog.theNumberofDog);

            //클래스변수는 프로그램 시작과 동시에 메모리에 할당이 됨, 인스턴스변수는 선언(class a = new class();) 할때 할당
            


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
