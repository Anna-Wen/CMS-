using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ClassManagementSystem.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Type { get; set; }        //只能是student、teacher
        public string Number { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Gender { get; set; }      //只能是male、female
        public School School { get; set; }
        public string Title { get; set; }
        public string Password { get; set; }
        public string UnionId { get; set; }
        public string Avatar { get; set; }
    }
}