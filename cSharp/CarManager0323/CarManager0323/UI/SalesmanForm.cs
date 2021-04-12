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
    partial class SalesmanForm : MaterialForm
    {
        private DaoOracle oracle;
        private DealHandler dHandler;

        public SalesmanForm()
        {
            InitializeComponent();
        }
        public SalesmanForm(DaoOracle oracle)
        {
            InitializeComponent();
            this.oracle = oracle;
        }
        public SalesmanForm(DaoOracle oracle, DealHandler dHandler)
        {
            InitializeComponent();
            this.oracle = oracle;
            this.dHandler = dHandler;
        }

        private void addOk_Click(object sender, EventArgs e)
        {
            if (sa_name.Text == "" || sa_tel.Text == "" ||
                sa_positoion.Text == "" || sa_email.Text == "" ||
               sa_branch.Text == "")
            {
                MessageBox.Show("누락된 정보가 있습니다. 올바르게 입력하세요");
                return;
            }

            List<Deal> list = dHandler.GetDealList();

            try
            {
                Seller seller = new Seller(
                    sa_name.Text,
                    sa_tel.Text,
                    sa_positoion.Text,
                    sa_email.Text,
                    sa_branch.Text);
                list[0].Seller = seller;
                oracle.insertsalesman(seller);
                Close();
            }
            catch (FormatException ex)
            {
                Console.WriteLine("가격을 올바른 숫자로 입력하세요");
            }
        }

        private void SalesmanForm_Load(object sender, EventArgs e)
        {

        }
    }
}
