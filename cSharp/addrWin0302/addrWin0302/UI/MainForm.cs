using addrWin0302.UI;
using adressTest0218.control;
using adressTest0218.NewFolder1;
using MaterialSkin.Controls;
using System;
using System.Drawing;
using System.Drawing.Text;
using System.Windows.Forms;


namespace addrWin0302
{
    public partial class MainForm : MaterialForm
    {
        MyMenu menu = new MyMenu();
        StudentCtrl sc = new StudentCtrl();

        public MainForm()
        {
            InitializeComponent();
        }

        private void addrExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void addrHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Upate 2021년3월2일 by gh");
        }

        private void addrAdd_Click(object sender, EventArgs e)
        {
            new AddForm(sc).ShowDialog();
            //sc.addItem();
        }

        private void addrView_Click(object sender, EventArgs e)
        {
            // StudentCtrl.getInst().viewItem();
            sc.viewItem();
            new ViewForm(sc).ShowDialog();
        }

        private void addrAddRand_Click(object sender, EventArgs e)
        {
            string cnt = myInputBox("랜덤데이터 생성", "랜덤하게 데이터를 생성할 갯수를 입력하세요", "0");
            sc.randData(Convert.ToInt32(cnt));
        }

        private void addrDel_Click(object sender, EventArgs e)
        {
            sc.delItem("홍길동");
            new DelForm(sc).ShowDialog();
        }

        private void addrDelAll_Click(object sender, EventArgs e)
        {
            sc.delItemAll();
        }

        private void addrUpdate_Click(object sender, EventArgs e)
        {
            //   StudentCtrl.getInst().updateItem();
            // sc.updateItem();
            new UpdateForm(sc).ShowDialog();
        }

        private string myInputBox(string title, string body, string prompt)
        {
            string input = Microsoft.VisualBasic.Interaction.InputBox(title, body, prompt, -1, -1);
            return input;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            initFont();
        }

        private void initFont()
        {
            PrivateFontCollection pFont = new PrivateFontCollection();
            pFont.AddFontFile("NanumGothicCoding.ttf");
            Font font = new Font(pFont.Families[0], 18f);
            addrAdd.Font = font;
            addrView.Font = font;
            addrAddRand.Font = font;
            addrDel.Font = font;
            addrDelAll.Font = font;
            addrUpdate.Font = font;
        }
    }
}