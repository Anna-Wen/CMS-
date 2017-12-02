using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ClassManagementSystem.Models
{
    public class Class
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int NumStudent { get; set; }
        public ClassTime[] TimeSite { get; set; }
        public bool Calling { get; set; }
        public string Roster { get; set; }
        public int[] Proportions { get; set; }
    }
}