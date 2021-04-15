using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chap07
{
    class Dog
    {
        public string name { get; set; }
        public int age { get; set; }
        public string breedName { get; set; }
        public string masterName { get; set; }


        public void Eat()
        {
            System.Windows.Forms.MessageBox.Show("챱챱");
        }
        public void Bark()
        {
            System.Windows.Forms.MessageBox.Show("멍멍");
        }
    }
}
