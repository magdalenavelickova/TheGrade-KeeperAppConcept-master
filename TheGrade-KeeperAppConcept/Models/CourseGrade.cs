using System;
using System.Collections.Generic;

namespace TheGrade_KeeperAppConcept.Models
{
    public partial class CourseGrade
    {
        public int CourseGradeId { get; set; }
        public int? StudentId { get; set; }
        public int? CouseId { get; set; }
        public int? Grade { get; set; }

        public virtual Course Course { get; set; }
        public virtual Student Student { get; set; }
    }
}
