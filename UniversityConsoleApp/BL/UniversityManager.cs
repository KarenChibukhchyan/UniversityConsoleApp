using UniversityConsoleApp.Models;
namespace UniversityConsoleApp.BL
{
    public class UniversityManager
    {
        public static Teacher[] SwapWithStudents(Teacher[] teachers,Student[] students)
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


        public static Student SwapWithTeacher(Student student,Teacher teacher)
        {
            student.Teacher = teacher;
            return student;
        }
        public static Student[] SwapWithTeachers(Student[] students, Teacher[] teachers)
        {
            for (int i = 0; i < students.Length; i++)
            {
                students[i].Teacher = teachers[i % teachers.Length];
            }

            return students;
        }
        public static Teacher SwapWithStudent(Teacher teacher,Student[] students)
        {
            teacher._students = students;
            return teacher;
        }

   }
}


