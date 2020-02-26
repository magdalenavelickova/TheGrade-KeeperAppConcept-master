using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TheGrade_KeeperAppConcept.Models;

namespace TheGrade_KeeperAppConcept.Interfaces
{
    public interface ICourseRepository : IRepository<Course>
    {
        public Task<IEnumerable<Course>> GetAll();
        public Task<Course> Get(int id);

      //  public Task<IEnumerable<CourseGrade>> GetCourseGrade();
    }
}
