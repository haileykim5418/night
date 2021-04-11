using System;

namespace adressTest0218.NewFolder1
{
    class MyMenu
    {
        public const int MENU_MAIN_FORMAT_ERROR = 0;
        public const int MENU_MAIN_ADD = 1;
        public const int MENU_MAIN_VIEW = 2;
        public const int MENU_MAIN_RANDOM_ADD = 3;
        public const int MENU_MAIN_DELETE = 4;
        public const int MENU_MAIN_DELETE_ALL = 5;
        public const int MENU_MAIN_UPDATE = 6;
        public const int MENU_MAIN_EXIT = 7;

        public const int MENU_UPDATE_NAME = 1;
        public const int MENU_UPDATE_TEL = 2;
        public const int MENU_UPDATE_ADDR = 3;
        public const int MENU_UPDATE_EMAIL = 4;
        public const int MENU_UPDATE_EXIT = 5;

        public int mainMenu()
        {
            //공용으로 쓰는 부분은  static에. 굳이 객체를 생성하지 않아도 접근할 수 있음
            Console.WriteLine("------------------");
            Console.WriteLine("### 메인메뉴 ###");
            Console.WriteLine("-----------------");
            Console.WriteLine("1.주소록 정보 추가");
            Console.WriteLine("2.주소록 정보 보기");
            Console.WriteLine("3.랜덤 데이터 추가");
            Console.WriteLine("4.주소록 정보 삭제");
            Console.WriteLine("5. 전체 데이터 삭제");
            Console.WriteLine("6. 주소록 정보 수정");
            Console.WriteLine("7.종료");
            Console.WriteLine("-----------------");
            Console.Write("메뉴 선택: ");
            int menu = 0;
            try
            {
                menu = Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException e)
            {

                Console.WriteLine("에러:" + e.Message);
            }
            return menu;
        }


        public string delMenu()
        {
            Console.WriteLine("-----------------");
            Console.WriteLine("주소록 정보 삭제");
            Console.WriteLine("-----------------");
            Console.Write("삭제할 이름: ");
            /*string name = Console.ReadLine();
            return name;*/
            return Console.ReadLine();
        }


        public int updateMenu()
        {
            Console.WriteLine("------------------");
            Console.WriteLine("### 메인메뉴 ###");
            Console.WriteLine("-----------------");
            Console.WriteLine("1. 이름 수정");
            Console.WriteLine("2. 전화번호 수정");
            Console.WriteLine("3. 주소 수정");
            Console.WriteLine("4. 이메일 수정");
            Console.WriteLine("5.종료");
            Console.WriteLine("-----------------");
            Console.Write("메뉴 선택: ");
            int menu =
                Convert.ToInt32(Console.ReadLine());
            return menu;
        }

    }
}
