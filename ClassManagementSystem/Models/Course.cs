using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ClassManagementSystem.Models
{
    public class Course
    {
        public int Id { get; set; }
        public User Teacher { get; set; }
        //public Teacher Teacher { get; set; }
        public string Name { get; set; }
        public int NumClass { get; set; }
        public int NumStudent { get; set; }
        public string StartTime { get; set; }
        public string EndTime { get; set; }
        public string Description { get; set; }
        public GradeProportion Proportions { get; set; }
    }
}