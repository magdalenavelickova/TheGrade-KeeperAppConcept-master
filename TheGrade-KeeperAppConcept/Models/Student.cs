using System;
using System.Collections.Generic;

namespace TheGrade_KeeperAppConcept.Models
{
    public partial class Student
    {
        public int Id { get; set; }
        public string StudentName { get; set; }
        public string StudentEmail { get; set; }
        public string StudentIndex { get; set; }
        public decimal? Gpa { get; set; }

        public virtual ICollection<CourseGrade> Grades { get; set; }
    }

}
