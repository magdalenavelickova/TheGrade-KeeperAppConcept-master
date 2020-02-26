using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TheGrade_KeeperAppConcept.Models.ViewModels
{
    public class StudentViewModel
    {
        public string Id { get; set; }

        [StringLength(255)]
        public string StudentName { get; set; }

        [StringLength(255)]
        public string StudentEmail { get; set; }

        [StringLength(255)]
        public string StudentIndex { get; set; }

        public decimal GPA { get; set; }

    }
}
