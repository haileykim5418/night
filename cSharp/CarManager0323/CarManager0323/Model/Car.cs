using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarManager0323.Model
{
    class Car
    {
        string model;
        int price;
        string color;
        string manu;
        string year;

        public Car(string model, int price, string color, string manu, string year)
        {
            this.model = model;
            this.price = price;
            this.color = color;
            this.manu = manu;
            this.year = year;
        }

        public string Model { get => model; set => model = value; }
        public int Price { get => price; set => price = value; }
        public string Color { get => color; set => color = value; }
        public string Manu { get => manu; set => manu = value; }
        public string Year { get => year; set => year = value; }
    }
}
