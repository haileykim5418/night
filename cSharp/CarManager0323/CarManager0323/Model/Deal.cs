using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarManager0323.Model
{
    class Deal  //deal클래스가 생성될때 각각의 객체들을 가지고오도록
    {
        string date;
        Customer customer;
        Car car;
        Seller seller;

        public Deal(string date, Customer customer, Car car, Seller seller)
        {
            this.date = date;
            this.customer = customer;
            this.car = car;
            this.seller = seller;
        }

        public string Date { get => date; set => date = value; }
        internal Customer Customer { get => customer; set => customer = value; }
        internal Car Car { get => car; set => car = value; }
        internal Seller Seller { get => seller; set => seller = value; }
    }
}
