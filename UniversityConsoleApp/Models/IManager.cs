using System.Collections.Generic;

namespace UniversityConsoleApp.Models
{
    public interface IManager
    {
        const short maxAge = 139;
        Person Create(string firstName, string lastName, int age);
        List<Person> Create(int count, int minAge);
    }
}