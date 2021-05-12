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

        public Order()
        {
            InitializeComponent();
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
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

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var data1 = dataGridView2.CurrentRow;
                textBox_cust.Text = data1.Cells[0].Value.ToString();


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                MessageBox.Show(ex.StackTrace);
            }

        }

        private void orderB_Click(object sender, EventArgs e)
        {
            MessageBox.Show(textBox_cust.Text.ToString() + "님께" + textBox_item + "(" + textBox_color + "," + textBox_stock.ToString() + ")개가 주문 되었습니다") ; 
        }
    }
}

