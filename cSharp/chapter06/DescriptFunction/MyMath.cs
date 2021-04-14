using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DescriptFunction
{
    class MyMath
    {
        public int Power(int input)  //인스턴스메소드
        {
            int a = (input * input);
            return a;
        }
        public static int Power(int input, int count)  //클래스메소드
        {
            int a = count * (input * input);
            return a;
        }
    }
}
