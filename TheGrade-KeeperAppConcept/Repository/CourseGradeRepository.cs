using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TheGrade_KeeperAppConcept.Data;
using TheGrade_KeeperAppConcept.Interfaces;
using TheGrade_KeeperAppConcept.Models;

namespace TheGrade_KeeperAppConcept.Repository
{
    public class CourseGradeRepository : Repository<CourseGrade>, ICourseGradeRepository
    {
        private readonly GradeSystemContext _context;
        public CourseGradeRepository(GradeSystemContext context)
          : base(context)
        {
            _context = context;
        }

        public async Task<IEnumerable<CourseGrade>> GetCourseGrade()
        {
            return await _context.CourseGrade.ToListAsync();
        }

        public Task<IEnumerable<CourseGrade>> GetStudentGrade(int id)
        {
            throw new NotImplementedException();
        }
    }
   
}
