using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace car
{
    class CarClass
    {
        public static string branch = "동대구영업소";

        private string manu;
        private string color;
        private string price;
        private string model;


        public CarClass()
        {
            manu = "기아";
            color = "블랙";
            price = "사천만원";
            model = "k7";
        }

        public string Manu
        {
            get { return manu; }
            set { manu = value; }
        }
        public string Color
        {
            get { return color; }
            set { color = value; }
        }
        public string Price
        {
            get { return price; }
            set { color  = value; }
        }
        public string Model
        {
            get { return model; }
            set { color = value; }
        }

        public void carInfo()
        {
            Console.WriteLine("대리점:"+CarClass.branch);
            Console.WriteLine("제조사:"+manu);
            Console.WriteLine("색상:" + color);
            Console.WriteLine("가격:" + price);
            Console.WriteLine("이름:" + model);
        }
    }
}
