﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chap07
{
    class NewDog : Animal  //상속
    {
        public void Bark()
        {
            System.Windows.Forms.MessageBox.Show("멍멍");
        }
        public override void Fight()
        {
            System.Windows.Forms.MessageBox.Show("애교팡팡");

        }
    }
}
