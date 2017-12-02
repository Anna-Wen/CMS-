using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ClassManagementSystem.Models
{
    public class ClassTime
    {
        public int Week { get; set; }       //只能为0、1、2
        public int Day { get; set; }
        public int[] Lesson { get; set; }
        public string Site { get; set; }
    }
}