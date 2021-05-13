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

namespace wholesale.UI
{
    partial class Order : Form
    {
        DataSet ds = new DataSet();
        DataSet dss = new DataSet();

        public Order()
        {
            InitializeComponent();
        }

        private void refresh()
        {
            ds = DB_Wholesale.DBset("WS_TABLE");
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "WS_TABLE";

            dss = DB_Wholesale.DBset("WS_CUS_TABLE");
            dataGridView2.DataSource = dss;
            dataGridView2.DataMember = "WS_CUS_TABLE";
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
        private void dtrefresh_cus()
        {
            refresh();

            textBox_cust.Text = "";
        }


        private void order_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = DB_Wholesale.DB_select();
            dataGridView1.DataMember = "WS_TABLE";

            DB_Wholesale.DB_select();

            dataGridView2.DataSource = DB_Wholesale.C_DB_CUST();
            dataGridView2.DataMember = "WS_CUS_TABLE";

            DB_Wholesale.C_DB_CUST();

        }


        private void orderB_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show(textBox_cust.Text + "님께" + textBox_item.Text + "(" + textBox_color.Text + "," + textBox_stock.Text + ")개가 주문 되었습니다");
                dtrefresh();
                dtrefresh_cus();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                MessageBox.Show(ex.StackTrace);
            } 
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                //dtrefresh();
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

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                // dtrefresh_cus();
                var data1 = dataGridView2.CurrentRow;
                textBox_cust.Text = data1.Cells[0].Value.ToString();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                MessageBox.Show(ex.StackTrace);
            }
        }
    }
}

