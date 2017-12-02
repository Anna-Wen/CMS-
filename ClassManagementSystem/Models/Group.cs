using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ClassManagementSystem.Models
{
    public class Group
    {
        public string Id { get; set; }
        public User Leader { get; set; }
        public User[] Members { get; set; }
        public Topic[] Topics { get; set; }
        public string Report { get; set; }
        public SeminarGrade Grade { get; set; }
    }
}