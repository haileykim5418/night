using System;

namespace Student1
{
    class Student
    {
        public Student(string strName, int intAge, char charGender, string strAddress)
        {
            StrName = strName;
            IntAge = intAge;
            CharGender = charGender;
            StrAddress = strAddress;
        }

        public string StrName { get; }
        public int IntAge { get; }
        public char CharGender { get; }
        public string StrAddress { get; }

        static void Main(string[] args)
        {
            string[] name = { "홍길동", "김길동", "박길동", "이길동", "최길동" };
            int[] age = { 20, 25, 30, 35, 40 };
            char[] gender = { '남', '여' };
            string[] address = { "대구", "서울", "부산", "인천", "광주" };

            Random r = new Random();
            Student[] st = new Student[10];
            for(int i=0; i < st.Length; i++)
            {
                string strName = name[r.Next(0, 5)];
                int intAge = age[r.Next(0, 5)];
                char charGender = gender[r.Next(0, 2)];
                string strAddress = address[r.Next(0, 5)];

                st[i] = new Student(strName, intAge, charGender, strAddress);
                st[i].showStudent();

            }

        }
    }
}
