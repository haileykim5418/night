using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ManagingCar_Program
{
    class DataManager
    {

        public static List<ParkingCar> Cars = new List<ParkingCar>();
        static DataManager()
        {
            Load();
        }
        public static void Load()//static 붙은애들은  static붙은애들끼리만 호출됨
        {//xml을 불러들이는 함수. 파일이 없을때를 대비해 트라이캐치 사용
            Cars.Clear();
            try
            {
                string carsOutput = File.ReadAllText(@"./Cars.xml"); //ReadAllText=같은 exe파일에 xml형식의 파일이 있냐 묻는거
                XElement carsXElement = XElement.Parse(carsOutput);//괄호안의 스트링 데이터를 XElement타입의 데이터로 변환하고 인식시킨다
                                                                   //carsXElement안에는 모든 정보가 들어가있고
                foreach (var item in carsXElement.Descendants("car")) //태그이름이 car인것만 모으고 그 하나하나들이 item임
                {
                    int tempParkingSpot = int.Parse(item.Element("parkingSpot").Value);
                    string tempCarNumber = item.Element("carNumber").Value;
                    string tempDriverName = item.Element("driverName").Value;
                    string tempPhoneNumber = item.Element("phoneNumber").Value;
                    DateTime tempParkingTime = item.Element("parkingTime").Value == "" ?
                        DateTime.Now : DateTime.Parse(item.Element("parkingTime").Value);

                    ParkingCar tempCar = new ParkingCar()  //임시변수에 넣은것들을 내가만은 인스턴스의 변수에 넣어
                    {
                        parkingSpot = tempParkingSpot,
                        carNumber = tempCarNumber,
                        driverName = tempDriverName,
                        phoneNumber = tempPhoneNumber,
                        parkingTime = tempParkingTime
                    };
                    Cars.Add(tempCar);

                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                printLog(ex.Message);
                printLog(ex.StackTrace);

                //만약 파일이 없어서 여기로 진입한 경우라면 
                CreateFile();//파일 다시만들고
                save();//그 파일 저장한 다음
                Load();//다시 불러들여본다
                //단 로드함수자체가 잘못된거면 이 코드 무한루프에 빠짐

            }

        }
        private static void CreateFile() //이 클래스를 벗어나는순간 얘는 호출 못함. 이 안에서만 쓰는애
        {
            //Cars.xml파일 만드는거
            string fileName = @"./Cars.xml";
            StreamWriter writer = File.CreateText(fileName); //파일 없으면 해당파일 생성
            writer.Dispose(); //메모리 해제
        }
        public static void save() //이 클래스를 벗어나도 호출할수있는애
        {
            string booksOutput = "";
            booksOutput += "<cars>\n"; //\n 대신 Envirioment.newLine써도됨
            if (Cars.Count>0)
            {
                foreach (var item in Cars)
                {
                    booksOutput += "<car>\n";
                    booksOutput += $" <parkingSpot>{item.parkingSpot}</parkingSpot>";
                    booksOutput += $" <carNumber>{item.carNumber}</carNumber>";
                    booksOutput += $" <driverName>{item.driverName}</driverName>";
                    booksOutput += $" <phoneNumber>{item.phoneNumber}</phoneNumber>";
                    booksOutput += $" <parkingTime>{item.parkingTime}</parkingTime>";
                    booksOutput += "</car>\n";


                }
            }
            else //xml파일에 아무것도 없는 경우
            {
                for (int i = 1; i <= 5; i++)
                {
                    booksOutput += "<car>\n";
                    booksOutput += $" <parkingSpot>{i}</parkingSpot>";
                    booksOutput += " <carNumber></carNumber>";
                    booksOutput += " <driverName></driverName>";
                    booksOutput += " <phoneNumber></phoneNumber>";
                    booksOutput += " <parkingTime></parkingTime>";
                    booksOutput += "</car>\n";


                }
            }
            booksOutput += "</cars>";
            File.WriteAllText(@"./Cars.xml", booksOutput);
        }

        //두번째 파라미터 넣지않으면 name에는 파킹히스토리 들어감
        public static void printLog(string contents, string name="parkingHistory")  //데이터매니저가 갖는 공통기능
        {
            DirectoryInfo di = new DirectoryInfo("parkingHistory");
            if (!di.Exists)  //di가 존재하지 않으면 = if(di.exists == false)
            {
                di.Create(); //폴더만들기
            }
            //using (StreamWriter writer = new StreamWriter(@"parkingHistory\parkingHistory.txt", true))
            using (StreamWriter writer = new StreamWriter(@"parkingHistory\"+name+".txt", true))//true 적으면 글자 여러개입력됨. true안적으면 디폴트값=false 
            {//@가 없으면 \\이렇게 두개 해줘야하는데 @있으면 하나만 해도됨
                writer.WriteLine(contents);
            }
        }
    }
}
