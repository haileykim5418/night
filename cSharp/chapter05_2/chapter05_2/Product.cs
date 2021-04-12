using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chapter05_2
{
    class Product
    {
        public string name;  //static이 없으면 인스턴스변수. 내가 선언한 변수마다 다 다른 값이 들어감
        public int price;   //static이 없으면 인스턴스변수
        public static int count;  //static이 있으면 클래스변수. 프로덕트타입의 모든 변수가 갖는 공통된 변수
    }
}
