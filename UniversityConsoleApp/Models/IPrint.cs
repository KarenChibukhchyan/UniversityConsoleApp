using System.Collections.Generic;

namespace UniversityConsoleApp.Models
{
    public interface IPrint
    {
        void Print(Person person);
        void Print(List<Person> persons);
    }
}