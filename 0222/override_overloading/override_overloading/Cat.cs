using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace override_overloading
{
    class Cat : Animal
    {
        public string color;


        public override void eat()
        {
            Console.WriteLine("냐옹 냐옹 촵촵");
        }
    }
}
