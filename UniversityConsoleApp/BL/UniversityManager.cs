using UniversityConsoleApp.Models;
namespace UniversityConsoleApp.BL
{
    public class UniversityManager
    {
        public Teacher[] SwapWithStudents(Teacher[] teachers,Student[] students)
        {
            int minStCount = students.Length / teachers.Length;
            int lastStCount = minStCount + students.Length % teachers.Length;
            for (int i = 0; i < teachers.Length-1; i++)
            {
                teachers[i]._students = new Student[minStCount];
                for (int j = 0; j < minStCount; j++)
                {
                    teachers[i]._students[j] = students[i*minStCount +j];
                }
            }
            teachers[teachers.Length - 1]._students = new Student[lastStCount];
            for (int i = 0 ; i < lastStCount; i++)
            {
                teachers[teachers.Length - 1]._students[i] = students[minStCount*(teachers.Length - 1) + i];
            }
            return teachers;
        }


        public Student SwapWithTeacher(Student student,Teacher teacher)
        {
            student._teacher = teacher;
            return student;
        }
        public Student[] SwapWithTeachers(Student[] students, Teacher[] teachers)
        {
            for (int i = 0; i < students.Length; i++)
            {
                students[i]._teacher = teachers[i % teachers.Length];
            }

            return students;
        }
        public Teacher SwapWithStudent(Teacher teacher,Student[] students)
        {
            teacher._students = students;
            return teacher;
        }

   }
}


