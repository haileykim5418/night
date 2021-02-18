using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace addressTest0218
{
    class Program
    {
        const int MENU_ADD_ITEM = 1;
        const int MENU_VIEW = 2;
        const int MENU_RANDOM_ADD = 3;
        const int MENU_DELETE = 4;
        const int MENU_DELETE_ALL = 5;
        const int MENU_EXIT = 6;

        static List<Student> addrList = new List<Student>();


        static void Main(string[] args)
        {

            while (true)
            {
                switch (getMenu())
                {
                    case MENU_ADD_ITEM:
                        addItem();
                        break;
                    case MENU_VIEW:
                        viewItem();
                        break;
                    case MENU_RANDOM_ADD:
                        randData();
                        break;
                    case MENU_DELETE:
                        delItem();
                        break;
                    case MENU_DELETE_ALL:
                        delItemAll();
                        break;
                    case MENU_EXIT:
                        viewItem();
                        break;
                        Console.WriteLine("프로그램 종료");
                        Environment.Exit(0);
                        break;
                }
            }
        }


        public static void addItem()
        {
            Console.WriteLine("------------------------");
            Console.WriteLine("1. 주소록 정보 추가");
            Console.WriteLine("------------------------");
            Console.WriteLine("이름:");
            string name = Console.ReadLine();
            Console.WriteLine("전화:");
            string tel = Console.ReadLine();
            Console.WriteLine("주소:");
            string address = Console.ReadLine();
            Console.WriteLine("이메일:");
            string email = Console.ReadLine();

            addrList.Add(new Student(name, tel, address, email));
            Console.WriteLine("정보가 정상적으로 입력되었습니다.");
        }

        public static void viewItem()
        {
            for (int i = 0; i < addrList.Count; i++)
            {
                Console.WriteLine("번호:" + (i + 1));
                Console.WriteLine("이름:" + addrList[i].Name);
                Console.WriteLine("전화:" + addrList[i].Tel);
                Console.WriteLine("주소:" + addrList[i].Address);
                Console.WriteLine("이메일:" + addrList[i].Email);
                Console.WriteLine("------------------------");

            }
        }
        public static int getMenu()
        {

            Console.WriteLine("------------------------");
            Console.WriteLine("1. 주소록 정보 추가");
            Console.WriteLine("2. 주소록 정보 보기");
            Console.WriteLine("3.랜덤 데이터 추가");
            Console.WriteLine("4. 종료");
            Console.WriteLine("------------------------");
            Console.WriteLine("메뉴선택");
            int menu = Convert.ToInt32(Console.ReadLine());
            return menu;

        }
        public static void randData()
        {
            string[] name = { "홍길동", "이길동", "김길동", "박길동", "최길동" };
            string[] tel = { "010-1111-1111", "010-1111-1112", "010-1111-1113", "010-1111-1114", "010-1111-1115" };
            string[] address = { "대구", "서울", "부산", "대전", "광주" };
            string[] email = { "hong@namer.com", "lee@namer.com", "kim@namer.com", "park@namer.com", "choi@namer.com", };

            Random r = new Random();
            for (int i = 0; i < 100; i++)
            {
                addrList.Add(new Student(
                    name[r.Next(0, 5)],
                    tel[r.Next(0, 5)],
                    address[r.Next(0, 5)],
                    email[r.Next(0, 5)]));
            }
        }
        static void delItem()
        {
            Console.WriteLine("-------------------------");
            Console.WriteLine("주소록 정보 삭제");
            Console.WriteLine("-------------------------");
            Console.WriteLine("삭제할 이름:");
            string name = Console.ReadLine();
            for(int i=0; i < addrList.Count; i++)
            {
                if (name.Equals(addrList[i].Name))
                {
                    addrList.RemoveAt(i--);
                }
            }

        }
        static void delItemAll()
        {
            addrList.Clear();
        }
    }
}



