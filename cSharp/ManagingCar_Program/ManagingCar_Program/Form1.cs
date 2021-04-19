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
           writeLog("주차버튼클릭");

            if (textBox1.Text.Trim() == "") //trim은 공백제거함수.  만약 공간번호 텍스트박스가 공백일 경우
            {
                MessageBox.Show("주차공간을 입력하세요");
                writeLog("주차공간을 입력하세요");
            }
            else if (textBox2.Text.Trim() == "")  //차량번호를 입력하지 않은 경우
            {
                MessageBox.Show("차 번호를 입력하세요");
                writeLog("차 번호를 입력하세요");
            }
            else //본격적으로 입력하는 작업
            {
                try
                {
                    //참조변수와 람다(함수를 변수화시킬때)개념
                    //싱글이라는 메소드 안에 이후 함수를 넣어. x=cars리스트에 있는 각 요소와 내가 입력한 값이 일치하면 그걸 비교
                    ParkingCar car = DataManager.Cars.Single((x) => x.parkingSpot.ToString() == textBox1.Text);
                    if (car.carNumber.Trim() != "") //carNumber가 공백이 아니라는건 이미 차 정보가 저장되어있다는것
                    {
                        MessageBox.Show("해당공간에는 이미 차 있음" + textBox1.Text);
                        writeLog("해당공간에는 이미 차 있음" + textBox1.Text);
                    }
                    else //아직 차 정보 없음
                    {

                        car.parkingSpot = int.Parse(textBox1.Text);
                        car.carNumber = textBox2.Text;
                        car.driverName = textBox3.Text;
                        car.phoneNumber = textBox4.Text;
                        car.parkingTime = DateTime.Now;

                        dataGridView1.DataSource = null;
                        dataGridView1.DataSource = DataManager.Cars;
                        DataManager.save();

                        string contents = $"주차공간 {textBox1.Text}에 {textBox2.Text}차를 주차함";
                        MessageBox.Show(contents);
                        writeLog(contents, DateTime.Now.ToString("yyyy_MM_dd"));

                    }

                }
                catch (Exception ex)
                {

                    string contents = "주차할 수 없습니다" + textBox1.Text;
                    MessageBox.Show(contents);
                    writeLog(contents);
                    writeLog(ex.Message);
                    writeLog(ex.StackTrace);
                }
               
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            writeLog("출차버튼클릭");
            if (textBox1.Text.Trim() =="")
            {
                MessageBox.Show("주차공간번호를 입력해주세요");
                return;
            }

            //single없이 조회하고 해당하는 데이터 변경
            try
            {
                for (int i = 0; i < DataManager.Cars.Count; i++)
                {
                    if (DataManager.Cars[i].parkingSpot.ToString()==textBox1.Text)
                    {
                        if (DataManager.Cars[i].carNumber.Trim()=="")
                        {
                            MessageBox.Show("아직 차 없음");
                            writeLog("아직 차 없음");
                            break;
                        }
                        else
                        {
                            DataManager.Cars[i].carNumber = "";
                            DataManager.Cars[i].driverName = "";
                            DataManager.Cars[i].phoneNumber = "";
                            DataManager.Cars[i].parkingTime = DateTime.Now;
                            string contents = $"주차공간 {textBox1.Text}에 {textBox2.Text}차량출차";
                            MessageBox.Show(contents);
                            writeLog(contents);
                            dataGridView1.DataSource = null; //dataGridView1의 데이터를 한번 지워주고
                            dataGridView1.DataSource = DataManager.Cars; //다시 리셋
                            DataManager.save();
                            break;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                writeLog("출차안됨");
                writeLog(ex.Message);
                writeLog(ex.StackTrace);
            }
            
        }
        private void button3_Click(object sender, EventArgs e)
        {
            //writeLog("3번버튼클릭");
            writeLog("조회버튼클릭", DateTime.Now.ToString("yyyy_MM_dd")); //매개변수 값 아무거나 해주면 그대로 파일 만들어진다
            if (textBox5.Text.Trim() == "")
            {
                MessageBox.Show("주차공간번호를 입력해주세요");
                return;
            }
            else
            {
                for (int i = 0; i < DataManager.Cars.Count; i++)
                {
                    if (DataManager.Cars[i].parkingSpot.ToString() == textBox5.Text) 
                    {
                        if (DataManager.Cars[i].carNumber.Trim() == "")
                        {
                            MessageBox.Show("차량이 없습니다.");
                            break;
                        }
                        else
                        {
                            string contents = $"주차공간 {DataManager.Cars[i].parkingSpot}에 {DataManager.Cars[i].carNumber}차량이 있음";
                            MessageBox.Show(contents);
                            writeLog(contents);
                            break;
                        }                    
                    }
                }               
            }
           /* else
            {
                string contents = $"주차공간 {textBox1.Text}에 {textBox2.Text}차량이 있음";
                MessageBox.Show(contents);
                writeLog(contents);
            }*/
        
        
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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        { //셀 클릭할때마다 정보가 텍스트에 들어감
            try
            {//dataGridView1에서 내가현재 클릭한 행의 아이템을 파킹카의 데이터로 넣어
                ParkingCar temp = dataGridView1.CurrentRow.DataBoundItem as ParkingCar;
                textBox1.Text = temp.parkingSpot.ToString();
                textBox2.Text = temp.carNumber;
                textBox3.Text = temp.driverName;
                textBox4.Text = temp.phoneNumber;
                
                textBox5.Text = temp.parkingSpot.ToString(); //그리드뷰에서 내가 클릭한 번호가 조회쪽 텍스트박스에 들어가게
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                MessageBox.Show(ex.StackTrace);
                writeLog(ex.Message);
                writeLog(ex.StackTrace);
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
