using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarManager0323.Model
{
    class Seller
    {
        string name;
        string tel;
        string position;
        string email;        
        string branch;

        public Seller(string name, string tel, string position, string email, string branch)
        {
            this.name = name;
            this.tel = tel;
            this.position = position;
            this.email = email;            
            this.branch = branch;
        }

        public string Name { get => name; set => name = value; }
        public string Tel { get => tel; set => tel = value; }
        public string Position { get => position; set => position = value; }
        public string Email { get => email; set => email = value; }        
        public string Branch { get => branch; set => branch = value; }
    }
}
