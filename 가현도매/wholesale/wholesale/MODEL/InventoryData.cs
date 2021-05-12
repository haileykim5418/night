using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wholesale
{
    class InventoryData
    {
        private string item;
        private string id;
        private string size;
        private string color;
        private string stock;

        public InventoryData(string item, string id, string size, string color, string stock)
        {
            Item = item;
            Id = id;
            Size = size;
            Color = color;
            Stock = stock;
        }
        public InventoryData(string item, string id, string size, string color)
        {
            Item = item;
            Id = id;
            Size = size;
            Color = color;
           
        }

        public InventoryData()
        {
        }

        public string Item { get => item; set => item = value; }
        public string Id { get => id; set => id = value; }
        public string Size { get => size; set => size = value; }
        public string Color { get => color; set => color = value; }
        public string Stock { get => stock; set => stock = value; }


        public static int Cal(int a, int b)
        {
            int re = a * b;
            return re;
        }
    }
}
