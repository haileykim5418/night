using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace override_overloading
{
    class Animal
    {
        public string name;
        public int age;
        public int price;

        public virtual void eat()
        {
            Console.WriteLine("촤랍 촤랍");
        }
    }
}
