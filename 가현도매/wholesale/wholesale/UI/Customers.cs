using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wholesale
{
    public partial class Customers : Form
    {
        DataSet ds = new DataSet();

        public Customers()
        {
            InitializeComponent();
        }

        private void refresh()
        {
            ds = DB_Wholesale.DBset("WS_CUS_TABLE");
            dataGridView_cus.DataSource = ds;
            dataGridView_cus.DataMember = "WS_CUS_TABLE";
        }

        private void dtrefresh()
        {
            refresh();

            textBox_name.Text = "";
            textBox_bnum.Text = "";
            textBox_addr.Text = "";
            textBox_phone.Text = "";
            textBox_mail.Text = "";
        }
        private void c_insertB_Click(object sender, EventArgs e)
        {
            try
            {
                CustomersData CusDatas = new CustomersData(textBox_name.Text, textBox_bnum.Text, textBox_addr.Text, textBox_phone.Text, textBox_mail.Text);

                DB_Wholesale.C_DB_insert(CusDatas); //inventoryDatas를 가지고 DB_insert메소드를 수행
                                                    // MessageBox.Show("추가되었습니다");

                dtrefresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("추가 실패");
                MessageBox.Show(ex.Message);
                MessageBox.Show(ex.StackTrace);
                //throw;
            }
        }

        private void c_delB_Click(object sender, EventArgs e)
        {
            try
            {

                if (textBox_bnum.Text.Trim() == "")
                {
                    MessageBox.Show("삭제할 행을 선택해주세요");
                }
                else
                {
                    DB_Wholesale.DB_delete_cus(textBox_bnum.Text);

                    MessageBox.Show("삭제되었습니다");
                    dtrefresh();
                }

            }
            catch (Exception ee)
            {
                MessageBox.Show("삭제 실패");
                MessageBox.Show(ee.Message);
                MessageBox.Show(ee.StackTrace);
            }
        }

        private void Customers_Load(object sender, EventArgs e)
        {
            dataGridView_cus.DataSource = DB_Wholesale.C_DB_select();
            dataGridView_cus.DataMember = "WS_CUS_TABLE";

            DB_Wholesale.C_DB_select();
        }

        public void dataGridView_cus_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var data1 = dataGridView_cus.CurrentRow;
                string cusVal = data1.Cells[0].Value.ToString();
                textBox_name.Text = /*data1.Cells[0].Value.ToString();*/ cusVal;
                textBox_bnum.Text = data1.Cells[1].Value.ToString();
                textBox_addr.Text = data1.Cells[2].Value.ToString();
                textBox_phone.Text = data1.Cells[3].Value.ToString(); 
                textBox_mail.Text = data1.Cells[4].Value.ToString();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                MessageBox.Show(ex.StackTrace);
            }
        }

        private void c_dbupdateB_Click(object sender, EventArgs e)
        {
            try
            {

                if (textBox_bnum.Text.Trim() == "")
                {
                    MessageBox.Show("수정할 행을 선택해주세요");
                }
                else
                {
                    DB_Wholesale.C_DB_update(textBox_name.Text, textBox_bnum.Text, textBox_addr.Text, textBox_phone.Text, textBox_mail.Text);
                    MessageBox.Show("정보가 수정 되었습니다");
                    dtrefresh();
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("수정 실패");
                MessageBox.Show(ex.Message);
                MessageBox.Show(ex.StackTrace);
                //throw;
            }
        }
    }
}
