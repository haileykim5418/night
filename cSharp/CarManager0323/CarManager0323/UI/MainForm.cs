
using CarManager0323.DB;
using CarManager0323.Handler;
using CarManager0323.Model;
using CarManager0323.UI;
using MaterialSkin.Controls;
using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarManager0323
{
    partial class MainForm : MaterialForm
    {
        //DaoOracle dao;
        DaoOracle ora = new DaoOracle();  //하고 밑에 바로 dao.~하는거랑 똑같음 먼저 객체 생성을 하느냐 나중에 하느냐의 차이
        DealHandler dHandler = new DealHandler();

        public MainForm()
        {
            InitializeComponent();
        }

        public MainForm(DaoOracle oracle)
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
          /*  dao = new DaoOracle();
            dao.dbConnect();*/
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
          //  dao.dbClose();
        }

        private void createTB_Click(object sender, EventArgs e)
        {
            ora.createAllTB();
        }

        private void dropTB_Click(object sender, EventArgs e)
        {
            ora.dropALLTB();
        }

        private void createTable_Click(object sender, EventArgs e)
        {

        }

        private void insertAll_Click(object sender, EventArgs e)
        {
            //ora.insertCar();
            ora.insertCustomer();
            ora.insertsalesman();
            ora.insertDeal();
        }

        private void insertCar_Click(object sender, EventArgs e)
        {
            new CarInsForm(ora, dHandler).ShowDialog();
        }

        private void insertCustomer_Click(object sender, EventArgs e)
        {
            List<Deal> list = dHandler.GetDealList();
            if (list[0].Customer != null) 
            {
                MessageBox.Show("고객 정보가 이미 저장되었습니다");
                return;
            }
            new CustInsForm(ora, dHandler).ShowDialog();
        }

        private void insertSalesman_Click(object sender, EventArgs e)
        {
            List<Deal> list = dHandler.GetDealList();
            if (list[0].Seller != null)
            {
                MessageBox.Show("판매자 정보가 이미 저장되었습니다");
                return;
            }
            new SalesmanForm(ora, dHandler).ShowDialog();
        }

        private void insertDeal_Click(object sender, EventArgs e)
        {
            List<Deal> list = dHandler.GetDealList();
            if (list[0].Car == null || list[0].Customer == null || list[0].Seller == null)
            {
                MessageBox.Show("구매 내역 정보가 누락되었습니다.");
                return;
            }
            // ora.insertDeal(list[0]); // Deal클래스의 객체 정보
            ora.insertDeal(list[0].Seller,
                list[0].Car, list[0].Customer);
            dHandler.dealListClear();
       
        }

        private void exitProgram_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void appHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("프로그램 문의는 010-1111-2222(담당자: 홍길동)으로 연락 바랍니다");
        }

        private void select_deal_Click(object sender, EventArgs e)
        {
            new DealView(ora, dHandler).ShowDialog();
        }

        private void insertData_Click(object sender, EventArgs e)
        {

        }
    }
}
