using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TheGrade_KeeperAppConcept.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IStudentRepository Student { get; }

        ICourseRepository Course { get; }

        ICourseGradeRepository CourseGrade { get; }

        Task<int> CommitAsync();
    }
}
