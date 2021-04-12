using adressTest0218;
using adressTest0218.control;
using adressTest0218.util;
using MaterialSkin.Controls;
using System;
using System.Windows.Forms;

namespace addrWin0302.UI
{
    // public partial class AddForm : MaterialForm
    partial class SalesmanInsForm : MaterialForm
    {
        StudentCtrl sc;
        //public AddForm()
        //{
        //    InitializeComponent()
        //}//싱글톤 사용

        public SalesmanInsForm()
        {
            InitializeComponent();
        }

        public SalesmanInsForm(StudentCtrl sc)
        {
            InitializeComponent();
            this.sc = sc;
        } //싱글톤 아닐때 사용

        private void addOk_Click(object sender, EventArgs e)
        {
            if (addName.Text == "")
            {
                MessageBox.Show("이름을 입력하세요.");
            }

            if (addTel.Text == "")
            {
                MessageBox.Show("전화번호를 입력하세요.");
            }

            if (addAddress.Text == "")
            {
                MessageBox.Show("주소를 입력하세요.");
            }

            if (addEmail.Text == "")
            {
                MessageBox.Show("이메일을 입력하세요.");
            }
            Close();

            //sc.getList().Add(new Student(new RandData(r).getId(), addName.Text, addTel.Text, addAddress.Text, addEmail.Text))
            //MessageBox.Show("정상적으로 데이터가 입력되었습니다")
            //Close()

            /*sc.getList().Add(
            rand = new Randata(new Random())

            new Student(new RandData(r).getId(), addName.Text, addTel.Text, addAddress.Text, addEmail.Text))*/
            Random r = new Random();

            sc.getList().Add(new Student(new RandData(r).getId(), addName.Text, addTel.Text, addAddress.Text, addEmail.Text));
            Console.WriteLine("정보가 정상적으로 입력되었습니다.");
        }

        private void addCancle_Click(object sender, EventArgs e)
        {
            Close();
        }

       
    }
}
