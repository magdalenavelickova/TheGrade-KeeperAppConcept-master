using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TheGrade_KeeperAppConcept.Models;

namespace TheGrade_KeeperAppConcept.Interfaces
{
    public interface IStudentService 
    {
        Student GPA { get; }

        Task<Student> NewStudent(Student newStudent);
        Task UpdateStudent(Student studentUpdate, Student student);
        Task DeleteStudent(Student student);
    }
}
