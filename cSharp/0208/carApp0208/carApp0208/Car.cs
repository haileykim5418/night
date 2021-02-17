using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carApp0208
{
    class Car
    {
        //클래스 상수 변수 static=const
        public const string DAERI = "동대구영업소";
        //인스턴스변수
        private string company;
        private string color;
        private string price;
        private string model;

        //기본생성자를 사용하여 객체 만들 때. 안의 값은 변경할 수 없음
        public Car()
        {
            company = "기아";
            color = "블랙";
            model = "k7";
            price = "4천만원";
        }
        //오버로딩
        //매개변수가 있는 생성자
        public Car(string company, string color, string model, string price)
        {
            this.company = company;
            this.color = color;
            this.model = model;
            this.price = price;
        }

        //propfull 탭 =>람다식
        //첫글자 대문자
        public string Company { get => company; set => company = value; }
        public string Color { get => color; set => color = value; }
        public string Price { get => price; set => price = value; }
        public string Model { get => model; set => model = value; }
        public string Price1 { get => price; set => price = value; }

        /* {
get { return company; }
set { company = value; }
}
public string Color
{
get { return color; }
set { color = value; }
}
public string Model
{
get { return model; }
set {model = value; }
}
public string Price
{
get { return price; }
set { price = value; }
}*/

        //모든 속성정보를 출력하는 
        public void showCarInfo()
        {
            Console.WriteLine("제조사:"+company);
            Console.WriteLine("색상:" + color);
            Console.WriteLine("모델:" + model);
            Console.WriteLine("가격:" + price);
            Console.WriteLine("영업소:" + DAERI);
            Console.WriteLine("------------------");
        }
    }
}
