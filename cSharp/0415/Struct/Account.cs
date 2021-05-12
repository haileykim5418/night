using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct
{
    struct Account  //클래스는 주소값 저장 스트럭트는 값을 저장
    {
        public int myMoney;
        public string name;

        public Account(int money, string name)
        {
            myMoney = money;
            this.name = name;  //저위에 인스턴스변수 name임
        }
        //입금
        public void deposit(int money)
        {
            myMoney += money; //내계좌에 돈 더 추가
        }
        //출금
        public void withdraw(int money)
        {
            myMoney -= money; //내계좌에서 돈 빼기
        }
    }
}
