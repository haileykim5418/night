using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace getset
{
    class Circle
    {
        private int r;
        public int R { get { return this.r; } set { this.r = value; } }

        public int radius { get; set; }  //public 변수 만들때 {get;set;}을 쓸것. 표준

        public int radi
        {

            get { return this.r; }
            set
            {
                if (value < 0)
                    this.r = 0;
                else
                {
                    this.r = value;
                }
            }
        }
    }

}

