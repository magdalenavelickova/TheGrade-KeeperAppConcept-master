using Microsoft.AspNetCore.Mvc;
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
    public class StudentRepository : Repository<Student>, IStudentRepository
    {
        private readonly GradeSystemContext _context;
        public StudentRepository(GradeSystemContext context)
          : base(context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Student>> GetAllStudents()
        {
            var studenti = await _context.Student.ToListAsync();
            return studenti;
        }

        public async Task<Student> GetStudent(int id)
        {
            return await _context.Student.SingleOrDefaultAsync(a => a.Id == id);
        }
    }
}
