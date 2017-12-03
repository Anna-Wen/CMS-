using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClassManagementSystem.Models
{
    public class SeminarClasses
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string CourseName { get; set; }
        public string StartTime { get; set; }
        public string EndTime { get; set; }
        public List<Class> Classes { get; set; } 
    }
}
