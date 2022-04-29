using System;

namespace UniversityConsoleApp.Models
{
    public class Student
    {
        public Student()
        {

        }

        public Student(string firstName,string lastName,int age)
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
        public Teacher _teacher;
    }
}
