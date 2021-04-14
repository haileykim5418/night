using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DescriptFunction
{
    class Circle
    {
        public int r; //인스턴스변수
        public static double PI = 3.1415; //클래스변수


        //static의 유무로 판단함. static 붙으면 클래스변수,클래스메소드/ 안붙으면 인스턴스변수,인스턴스메소드

        public double doolle()  //this = 저위에 선언한 인스턴스변수r을 표시하려고
        {
            return this.r * PI * 2;
        }
        public double area()
        {
            return this.r * this.r * PI;
        }
        public static void setPi(double pi)
        {
            PI = pi;
        }

        public static double getPi()
        {
            return PI;
        }
        public static void showPi()  //클래스함수는 인스턴스별로 다르게 호출되는게 아니라 공통적으로 쓸수있는 기능을 넣는 함수
        {
            System.Windows.Forms.MessageBox.Show("현재PI 값은" + PI + "입니다");
        }
    }
}
