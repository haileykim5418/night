using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chapter05_2
{
    class Dog
    {
        public string name = "이동준";
        public int age = 33;
        public static int theNumberofDog = 0;

        public Dog(string name, int age)  //생성자. 내가 만든 클래스를 가지고 변수들을 만들때 그 변수들의 속성이 생성되게 함
        {
            this.name = name;
            this.age = age;
            theNumberofDog++; //클래스변수(공통으로 쓰이는 변수)

           
        }
    }
}
