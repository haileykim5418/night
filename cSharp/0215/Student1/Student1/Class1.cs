using System;
using System.Collections.Generic;
using System.Text;

namespace Student1
{
    class Class1
    {
        private string name;
        private int age;
        private char gender;
        private string address;

        public string Name { get => name; set => name = value; }
        public int Age { get => age; set => age = value; }
        public char Gender { get => gender; set => gender = value; }
        public string Address { get => address; set => address = value; }

        public Class1(string name, int age, char gender, string address)
        {
            this.name = name;
            this.age = age;
            this.gender = gender;
            this.address = address;
        }

        public void showStudent()
        {
            Console.WriteLine("이름:" + Name);
            Console.WriteLine("나이:"+ Age);
            Console.WriteLine("성별:"+ Gender);
            Console.WriteLine("주소:"+ Address);
        }
    }
}
