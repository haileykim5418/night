using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chap07
{
    class NewCat :Animal //상속
    {
        public void Meow()
        {
            System.Windows.Forms.MessageBox.Show("냐옹");
        }
        public override void Fight()
        {
            System.Windows.Forms.MessageBox.Show("할퀴기");

        }
    }
}
