using System;

namespace adressTest0218
{
    class Student
    {
        private static Student inst;

        public static Student getInst()
        {

            if (inst == null)
            {
                inst = new Student();
            }

            return inst;
        }

        public Student() { }

        public Student(string name, string tel,
            string address, string email)
        {
            this.Name = name;
            this.Tel = tel;
            this.Address = address;
            this.Email = email;
        }

        public Student(string id, string name, string tel,
            string address, string email)
            : this(name, tel, address, email)
        {
            this.Id = id;
        }

        public string Name { get; set; }
        public string Tel { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Id { get; set; }

        //private int ex
        //public int Ex { get { return ex } set { ex = value}


        public void showAddress()
        {
            Console.WriteLine("이름: {0}", Name);
            Console.WriteLine("전화: " + Tel);
            Console.WriteLine("주소: " + Address);
            Console.WriteLine("이메일: " + Email);
            Console.WriteLine("-----------------");
        }
    }
}
