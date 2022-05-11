using System;

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
        public Teacher(string firstName,string lastName,int age, Student[] students) : base(firstName, lastName, age)
        {
            Students = students;
        }
        public Teacher(string firstName,string lastName,int age, Student[] students, Group @group) : base(firstName, lastName, age)
        {
            Students = students;
            Group = group;
        }
        public Group Group { set; get; }
        public Student[] Students { set; get; }
    }
}
