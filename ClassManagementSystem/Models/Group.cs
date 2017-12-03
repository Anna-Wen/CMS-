using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ClassManagementSystem.Models
{
    public class Group
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public User Leader { get; set; }
        public List<User> Members { get; set; }
        public List<Topic> Topics { get; set; }
        public string Report { get; set; }
        public SeminarGrade Grade { get; set; }
    }
}