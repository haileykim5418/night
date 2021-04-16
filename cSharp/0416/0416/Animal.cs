using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0416
{
    abstract class Animal : IRunnable, IFight  //인터페이스는 일종의 규칙이라 여러개 늘어놓을수있음. 뭐 할지 미리 알려주는 용도?
                                               //fight()  Run() 를 구현해야된다고 명시해준것.
    {
        public abstract void Eat();//abstract : 애니멀을 상속받으면 eat을 구체적으로 구현해

        public void fight()
        {
            throw new NotImplementedException("퍽퍽");
        }

        public void Run()
        {
            throw new NotImplementedException("달려달려");
        }

        public void sleep()
        {
        System.Windows.Forms.MessageBox.Show("잘자");
        }
    }
}
