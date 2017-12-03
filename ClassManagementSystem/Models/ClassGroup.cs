using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ClassManagementSystem.Models
{
    public class ClassGroup
    {
        public User Leader { get; set; }
        public List<User> Members { get; set; }
    }
}