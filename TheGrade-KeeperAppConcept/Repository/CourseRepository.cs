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
    public class CourseRepository : Repository<Course>, ICourseRepository
    {
        private readonly GradeSystemContext _context;
        public CourseRepository(GradeSystemContext context)
          : base(context)
        {
            _context = context;
        }

        public async Task<Course> Get(int id)
        {
            return await _context.Course.SingleOrDefaultAsync(a => a.Id == id);
        }

        public async Task<IEnumerable<Course>> GetAll()
        {
            return await _context.Course.ToListAsync();
        }  
    }
}
