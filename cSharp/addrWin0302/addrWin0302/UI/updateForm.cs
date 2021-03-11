using adressTest0218;
using adressTest0218.control;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace addrWin0302.UI
{
    partial class UpdateForm : MaterialForm
    {
        StudentCtrl sc;

        public UpdateForm()
        {
            InitializeComponent();
        }
        public UpdateForm(StudentCtrl sc)  //오버로딩
        {
            InitializeComponent();
            this.sc = sc;
        }

        private void showList()
        {
            int cnt = sc.getList().Count;
            for (int i = 0; i < cnt; i++)
            {
                List<Student> addrList = sc.getList();
                upList.Items.Add(new ListViewItem(new string[]{
                        (i + 1).ToString(),
                        addrList[i].Name,
                        addrList[i].Tel,
                        addrList[i].Address,
                        addrList[i].Email,}));
            }
            setRowColor(upList, Color.White, Color.LightGray);
            int index = upList.Items.Count - 1;
            // listView.Items[index].Selected = true;
            // upList.Items[index].Focused = true;
            // upList.EnsureVisible(index);
        }
        private void setRowColor(ListView list, Color color1, Color color2)
        {
            foreach (ListViewItem item in list.Items)
            {
                if ((item.Index % 2) == 0)
                {
                    item.BackColor = color1;
                }
                else
                {
                    item.BackColor = color2;
                }
            }
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            showList();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void addCancle_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void uiSymbolLabel1_Click(object sender, EventArgs e)
        {

        }

        private void uiSymbolLabel2_Click(object sender, EventArgs e)
        {

        }

        private void addName_TextChanged(object sender, EventArgs e)
        {

        }

        private void addTel_TextChanged(object sender, EventArgs e)
        {

        }

        private void upList_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (upList.SelectedItems.Count != 0)
            {
                int n = upList.SelectedItems[0].Index;
                string name = upList.Items[n].SubItems[1].Text;
                string tel = upList.Items[n].SubItems[2].Text;
                string addr = upList.Items[n].SubItems[3].Text;
                string email = upList.Items[n].SubItems[4].Text;
                Console.WriteLine("이름: {0}", name);
                Console.WriteLine("전화: {0}", tel);
                Console.WriteLine("주소: {0}", addr);
                Console.WriteLine("메일: {0}", email);
                upName.Text = name;
                upTel.Text = tel;
                upAddress.Text = addr;
                upEmail.Text = email;
            }

        }


        private void addOk_Click(object sender, EventArgs e)
        {








            int cnt = sc.getList().Count;
            {
                for (int i = 0; i < cnt; i++)
                {
                    List<Student> addrList = sc.getList();
                    upList.Items.Add(new ListViewItem(new string[]{
                        (i + 1).ToString(),
                        addrList[i].Name,
                        addrList[i].Tel,
                        addrList[i].Address,
                        addrList[i].Email,}));
                }
            }

            /* string e = Console.ReadLine();
                 string updateOne = Console.ReadLine();
 */
            /* if (menu == 1)
             {
                 for (int i = 0; i < addrList.Count; i++)
                 {
                     if (addrList[i].Name.Equals(e))
                     {
                         addrList[i].Name = updateOne;
                     }
                 }
                 Console.WriteLine("수정이름 : " + updateOne);
             }
             else if (menu == 2)
             {
                 for (int i = 0; i < addrList.Count; i++)
                 {
                     if (addrList[i].Tel.Equals(e))
                     {
                         addrList[i].Tel = updateOne;
                     }
                 }
             }
             else if (menu == 3)
             {
                 for (int i = 0; i < addrList.Count; i++)
                 {
                     if (addrList[i].Address.Equals(e))
                     {
                         addrList[i].Address = updateOne;
                     }
                 }
             }
             else if (menu == 4)
             {
                 for (int i = 0; i < addrList.Count; i++)
                 {
                     if (addrList[i].Email.Equals(e))
                     {
                         addrList[i].Email = updateOne;
                     }
                 }
             }*/
        }
    }
}

