using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0416
{
    class Dog : Animal
    {
        public override void Eat()
        {
            System.Windows.Forms.MessageBox.Show("냠냠");
            // throw new NotImplementedException();
        }
    }
}
