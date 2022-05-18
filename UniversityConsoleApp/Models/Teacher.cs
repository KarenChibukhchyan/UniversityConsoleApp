using System;
using System.Collections.Generic;

namespace UniversityConsoleApp.Models
{
    public class Teacher : Person
    {
        public Teacher()
        {

        }

        public Teacher(string firstName,string lastName,int age) : base(firstName, lastName, age)
        {
        }
        public Teacher(string firstName,string lastName,int age, List<Student> students) : base(firstName, lastName, age)
        {
            Students = students;
        }
        public Teacher(string firstName,string lastName,int age, List<Student> students, Group @group) : base(firstName, lastName, age)
        {
            Students = students;
            Group = group;
        }
        public Group Group { set; get; }
        public List<Student> Students { set; get; }
    }
}
