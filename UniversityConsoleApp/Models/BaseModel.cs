using System;

namespace UniversityConsoleApp.Models
{
    public class BaseModel
    {
        public Guid ID { get; }
        public BaseModel()
        {
            ID = Guid.NewGuid();
        }
    }
}