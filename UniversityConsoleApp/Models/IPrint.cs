namespace UniversityConsoleApp.Models
{
    public interface IPrint
    {
        void Print(Person person);
        void Print(Person[] persons);
    }
}