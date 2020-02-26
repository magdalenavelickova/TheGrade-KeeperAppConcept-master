using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TheGrade_KeeperAppConcept.Models;

namespace TheGrade_KeeperAppConcept.Interfaces
{
    public interface IStudentRepository : IRepository<Student>
    {
        public Task<IEnumerable<Student>> GetAllStudents();
        public Task<Student> GetStudent(int id);
    }
}
