using System;

namespace UniversityConsoleApp.Models
{
    public class Teacher
    {
        public Teacher()
        {

        }

        public Teacher(string firstName,string lastName,int age)
        {
            _id = Guid.NewGuid();
            _firstName = firstName;
            _lastName = lastName;
            _age = age;
        }

        public Guid _id;
        public string _firstName;
        public string _lastName;
        public int _age;
        public Student[] _students;
    }
}
