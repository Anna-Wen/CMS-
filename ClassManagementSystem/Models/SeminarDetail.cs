using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClassManagementSystem.Models
{
    public class SeminarDetail
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Site { get; set; }
        public string StartTime { get; set; }
        public string EndTime { get; set; }
        public string TeacherName { get; set; }
        public string TeacherEmail { get; set; }
    }
}
