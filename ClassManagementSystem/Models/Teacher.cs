using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClassManagementSystem.Models
{
    public class Teacher : User
    {
        public Teacher() => Type = "teacher";
    }
}
