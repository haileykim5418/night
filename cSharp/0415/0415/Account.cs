using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0415
{
    class Account
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
