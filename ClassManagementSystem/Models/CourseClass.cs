using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClassManagementSystem.Models
{
    public class CourseClass
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int NumStudent { get; set; }
        public string Time { get; set; }
        public string Site { get; set; }
        public int CourseId { get; set; }
        public string CourseName { get; set; }
        public Teacher CourseTeacher { get; set; }
    }
}
