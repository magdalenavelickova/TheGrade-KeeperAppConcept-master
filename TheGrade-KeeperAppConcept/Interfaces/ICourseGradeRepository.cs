using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TheGrade_KeeperAppConcept.Models;
using TheGrade_KeeperAppConcept.Repository;

namespace TheGrade_KeeperAppConcept.Interfaces
{
    public interface ICourseGradeRepository : IRepository<CourseGrade>
    {
        public Task<IEnumerable<CourseGrade>> GetCourseGrade();

       // public Task<IEnumerable<CourseGrade>> GetStudentGrade(int id);


    }
}
