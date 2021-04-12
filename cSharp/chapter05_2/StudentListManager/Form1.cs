using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentListManager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            List<Student> students = new List<Student>();
            students.Add(new Student() { name = "이동준", grade = 1 });
            Student s = new Student() { name = "동준", grade = 2 };
            students.Add(s);
            Student ss = new Student();
            ss.name = "동준이";
            ss.grade = 3;
            students.Add(ss);
            students.Add(new Student() { name = "김동준", grade = 4 });
            students.Add(new Student() { name = "최동준", grade = 1 });
            students.Add(new Student() { name = "박동준", grade = 2 });

          //  string names = ""; //names변수 만들고 각칸의ㅐ 값들을 더해서 실행
            for (int i = 0; i < students.Count; i++)   //일반적 for문
            {
                //  names += students[i].name + " " + students[i].grade + "\n";
                Label label = new Label(); //코드로 디자인창 라벨 생성
                label.Text = $"{students[i].grade}학년 {students[i].name}학생";
                label.AutoSize = true;
                label.Location = new Point(13, 13 + (26 * i));
                Controls.Add(label);  //이게 있어야 label이 윈폼에 보여짐
            }
            // MessageBox.Show(names);

            for (int i = students.Count-1; i >=0; i--) //역for문
            {
                if (students[i].grade > 1)
                    students.RemoveAt(i);
            }

            for (int i = 0; i < students.Count; i++)   //일반적 for문
            {
                //  names += students[i].name + " " + students[i].grade + "\n";
                Label label = new Label(); //코드로 디자인창 라벨 생성
                label.Text = $"{students[i].grade}학년 {students[i].name}학생";
                label.AutoSize = true;
                label.Location = new Point(130, 13 + (26 * i));
                Controls.Add(label);  //이게 있어야 label이 윈폼에 보여짐
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
