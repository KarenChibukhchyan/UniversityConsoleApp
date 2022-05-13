namespace UniversityConsoleApp.Models
{
    public class Group : BaseModel
    {
        public string Name { get; set; }
        public Group()
        {
        }

        public Group(string name)
        {
            Name = name;
        }
    }
}