using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0416
{//abstract 애니멀을 상속받으면 eat을 구체적으로 구현해
    class Cat : Animal, IRunnable, IFight
    {
        public override void Eat()
        { //eat이라는 함수가 cat에서 비로소 구현이 된것.
            System.Windows.Forms.MessageBox.Show("밥줘");
            //구현이 안되어있다는 에러 띄우는것
            //throw new NotImplementedException();
        }

        public 
    }
}
