using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using wholesale.MODEL;
using wholesale.UI;

namespace wholesale
{
    partial class Inventory : Form
    {
        public static List<Order_cus> customer = new List<Order_cus>();

        DataSet ds = new DataSet();
        // int selectedNum = -1;
        public Inventory()
        {
            InitializeComponent();

        }

        private void Inventory_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = DB_Wholesale.DB_select();
            dataGridView1.DataMember = "WS_TABLE";

            DB_Wholesale.DB_select();

        }
        private void refresh()
        {
            ds = DB_Wholesale.DBset("WS_TABLE");
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "WS_TABLE";
        }


        private void order_Click(object sender, EventArgs e)
        {
            /* InventoryData idata = new InventoryData("반팔", "123", "s", "블랙");
             InventoryData idata2 = new InventoryData();



             //item.Text = idata.Item;
             label_id.Text = idata.Id;
             size.Text = idata.Size;
             color.Text = idata.Color;

             label_item.Text = idata2.Color;*/

        }

        private void dtrefresh()
        {
            refresh();

            textBox_item.Text = "";
            textBox_id.Text = "";
            textBox_color.Text = "";
            textBox_size.Text = "";
            textBox_stock.Text = "";
        }


        private void update_b_Click(object sender, EventArgs e)
        {
            try
            {

                if (textBox_id.Text.Trim() == "")
                {
                    MessageBox.Show("수정할 행을 선택해주세요");
                }
                else
                {
                    DB_Wholesale.DB_update(textBox_item.Text, textBox_id.Text, textBox_size.Text, textBox_color.Text, textBox_stock.Text);
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

        private void insertB_Click(object sender, EventArgs e) //추가버튼을 누르면 텍스트박스에 있는 내용들을 가지고 추가
        {
            try
            {
                InventoryData inventoryDatas = new InventoryData(textBox_item.Text, textBox_id.Text, textBox_size.Text, textBox_color.Text, textBox_stock.Text);

                DB_Wholesale.DB_insert(inventoryDatas); //inventoryDatas를 가지고 DB_insert메소드를 수행
                MessageBox.Show("추가되었습니다");

                dtrefresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("추가 실패");
                MessageBox.Show(ex.Message);
                MessageBox.Show(ex.StackTrace);
                //throw;
            }
            finally
            {
                DB_Wholesale.conn.Close();  //무조건 실행되든지 안되든지간에 마지막은 연동을 닫아줘서 다시 실행할수있도록
            }

        }

        private void del_b_Click(object sender, EventArgs e)
        {
            try
            {

                if (textBox_id.Text.Trim() == "")
                {
                    MessageBox.Show("삭제할 행을 선택해주세요");
                }
                else
                {
                    DB_Wholesale.DB_delete(textBox_id.Text);

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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var data = dataGridView1.CurrentRow;
                // selectedNum = data.Cells[0].Value.ToString();
                textBox_item.Text = data.Cells[0].Value.ToString();
                textBox_id.Text = data.Cells[1].Value.ToString();
                textBox_size.Text = data.Cells[2].Value.ToString();
                textBox_color.Text = data.Cells[3].Value.ToString();
                textBox_stock.Text = data.Cells[4].Value.ToString();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                MessageBox.Show(ex.StackTrace);
            }


        }

        private void cust_Click(object sender, EventArgs e)
        {

            Customers cust = new Customers();
            cust.ShowDialog();


        }

        private void textBox_item_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBox_id.Focus();
            }
        }

        private void textBox_id_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBox_size.Focus();
            }
        }

        private void textBox_size_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBox_color.Focus();
            }
        }

        private void textBox_color_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBox_stock.Focus();
            }
        }

        

        private void orders_Click(object sender, EventArgs e)
        {
            Order or = new Order();
            or.Show();
        }

      
    }
}
