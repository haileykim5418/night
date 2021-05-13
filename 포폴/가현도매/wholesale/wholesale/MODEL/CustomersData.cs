using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wholesale
{
    class CustomersData
    {
        public string customer;
        public string addr;
        public string phone;
        public string mail;
        public string bnum;

        public CustomersData(string customer, string bnum, string addr, string phone, string mail )
        {
            this.Customer = customer;
            this.Bnum = bnum;
            this.Addr = addr;
            this.Phone = phone;
            this.Mail = mail;
        }

        public string Customer { get => customer; set => customer = value; }
        public string Bnum { get => bnum; set => bnum = value; }
        public string Addr { get => addr; set => addr = value; }
        public string Phone { get => phone; set => phone = value; }
        public string Mail { get => mail; set => mail = value; }


    }
}
