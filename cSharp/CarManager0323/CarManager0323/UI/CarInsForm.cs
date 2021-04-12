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
    partial class CarInsForm : MaterialForm
    {
        private DaoOracle oracle;
        private DealHandler dHandler;
        private DaoOracle ora;

        public CarInsForm()
        {
            InitializeComponent();
        }

        public CarInsForm(DaoOracle ora)
        {
            this.ora = ora;
        }

        public CarInsForm(DaoOracle oracle, DealHandler dHandler)
        {
            InitializeComponent();
            this.oracle = oracle;
            this.dHandler = dHandler;
        }

        private void addOk_Click(object sender, EventArgs e)
        {
            if (carModel.Text == "" || carPrice.Text == "" ||
               carColor.Text == "" || carPrice.Text == "" ||
                carYear.Text == "")
            {
                MessageBox.Show("누락된 정보가 있습니다. 올바르게 입력하세요");
                return;
            }

            List<Deal> list = dHandler.GetDealList();
            try
            {
                Car car = new Car(   //car객체 생성
                    carModel.Text,
                    Int32.Parse(carPrice.Text),
                    carColor.Text,
                    carCompany.Text,
                    carYear.Text);

                if(list[0].Car == null)
                {
                    list[0].Car = car;
                    oracle.insertCar(car);
                }
                else
                {
                    MessageBox.Show("차량정보가 이미 저장되었습니다");
                }                
                Close();
            }
            catch (FormatException ex)
            {
                Console.WriteLine("가격을 올바른 숫자로 입력하세요");
            }
        }


        private void carCancle_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
