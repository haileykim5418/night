using CarManager0323.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarManager0323.Handler
{
    class DealHandler
    {
        List<Deal> dealList = new List<Deal>();

        public DealHandler()
        {
            dealList.Add(new Deal("0000", null, null, null));  //리스트 안에 더미 넣음
        }
        public List<Deal> GetDealList()
        {
            return dealList;
        }
        public void dealListClear()  //입력후 안의 정보를 초기화시키는 메소드
        {
            dealList[0].Car = null;
            dealList[0].Customer = null;
            dealList[0].Seller = null;
            dealList[0].Date = "0000";
        }
    }
}
