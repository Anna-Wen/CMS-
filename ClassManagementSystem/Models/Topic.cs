using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ClassManagementSystem.Models
{
    public class Topic
    {
        public int Id { get; set; }
        public string Serial { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int GroupLimit { get; set; }
        public int GroupMemberLimit { get; set; }
        public int GroupLeft { get; set; }
    }
}