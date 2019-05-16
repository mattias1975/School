using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace School.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string  studentfirstName { get; set; }
        public string studentlastName { get; set; }
        public string course { get; set; }
        public int grade { get; }
    }