using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManagingCar_Program
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //DataManager.Load();
            dataGridView1.DataSource = DataManager.Cars;
            textBox1.Text = DataManager.Cars[0].parkingSpot.ToString();
            textBox2.Text = DataManager.Cars[0].carNumber.ToString();
            textBox3.Text = DataManager.Cars[0].driverName.ToString();
            textBox4.Text = DataManager.Cars[0].phoneNumber.ToString();

            /* List<ParkingCar> cars = new List<ParkingCar>();
             cars.Add(new ParkingCar() { parkingStpot = 1, carNumber = "30고9484", 
                 DriverName = "이동준", PhoneNumber = "010-2940-1613", parkingTime = DateTime.Now });
             dataGridView1.DataSource = cars;
             //datasource는 cars의 주소지를 가리킴
             cars.Add(new ParkingCar());*/

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            WhatTime.Text = "지금은 :" + DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss") + "입니다";
        }
    

        private void button1_Click(object sender, EventArgs e)
        {
            writeLog("1번버튼클릭");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            writeLog("2번버튼클릭");
        }
        private void button3_Click(object sender, EventArgs e)
        {
            //writeLog("3번버튼클릭");
            writeLog("3번버튼클릭", DateTime.Now.ToString("yyyy_MM_dd")); //매개변수 값 아무거나 해주면 그대로 파일 만들어진다
        }
        private void writeLog(string contents)
        {
            string logContents = $"[{DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")}]{contents}";

            //옛날것이 가장 위에 올라가는 방식으로 새로운게 뒤에 추가되어서 새로운방식 보려면 밑으로 스크롤 내려야됨
            // listBox1.Items.Add(logContents); //현재시간값을 string 화 시키고 리스트박스에 추가

            //새로운게 가장 위에 올라오는 방식으로 새로운게 가장 앞에 있도록
            listBox1.Items.Insert(0, logContents);  //0번째 인덱스에 이 내용을 넣어. add는 무조건 뒤에 추가, insert는 원하는곳에 추가


            /* int a = 1;
             MessageBox.Show(a.ToString("00")); 01이라고 출력됨.무조건 2자리 출력, 3자리 이상 입력하면 그대로 출력됨*/

            DataManager.printLog(logContents);
        }
        //writelog함수 오버로딩
        private void writeLog(string contents, string date)
        {
            string logContents = $"[{DateTime.Now.ToString("yyy/MM/dd HH:mm:ss")}]{contents}";

            
            listBox1.Items.Insert(0, logContents);  

            DataManager.printLog(logContents,date);
        }
    }
}
