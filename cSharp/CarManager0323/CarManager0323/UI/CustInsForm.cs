using CarManager0323.DB;
using CarManager0323.Handler;
using CarManager0323.Model;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarManager0323.UI
{
    partial class CustInsForm : MaterialForm
    {
        private DaoOracle oracle;   //인스턴스변수 선언
        private DealHandler dHandler;

        public CustInsForm()
        {
            InitializeComponent();
        }
        public CustInsForm(DaoOracle oracle)
        {
            InitializeComponent();
            this.oracle = oracle;
        }
        public CustInsForm(DaoOracle oracle,DealHandler dHandler)
        {
            InitializeComponent();
            this.oracle = oracle;
            this.dHandler = dHandler;
        }

        private void addOk_Click(object sender, EventArgs e)
        {

            if (cu_name.Text == "" || cu_tel.Text == "" ||
               cu_address.Text == "" || cu_email.Text == "")
            {
                MessageBox.Show("누락된 정보가 있습니다. 올바르게 입력하세요");
                return;
            }

            List<Deal> list = dHandler.GetDealList();

            try
            {
                Customer cust = new Customer(
                    cu_name.Text,
                    cu_tel.Text,
                    cu_address.Text,
                    cu_email.Text);
                list[0].Customer = cust;
                oracle.insertCustomer(cust);
                Close();
            }
            catch (FormatException ex)
            {
                Console.WriteLine("가격을 올바른 숫자로 입력하세요");

            }
        }

        private void CustInsForm_Load(object sender, EventArgs e)
        {

        }
    }
}
