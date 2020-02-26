using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TheGrade_KeeperAppConcept.Interfaces;
using TheGrade_KeeperAppConcept.Models;

namespace TheGrade_KeeperAppConcept.Services
{
    public class StudentService : IStudentService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IStudentRepository _student;
        private readonly ICourseGradeRepository _grade;

        public StudentService(IStudentRepository student, ICourseGradeRepository grade)
        {
            _student = student;
            _grade = grade;

        }

        public async Task DeleteStudent(Student student)
        {
            _unitOfWork.Student.Remove(student);

            await _unitOfWork.CommitAsync();
        }

        public Student GPA
        {
            get
            {
                Student student = new Student();
                var stud = _student.GetAllStudents();
                var grad = _grade.GetCourseGrade();

                //student.Gpa = grad.Sum(x => x.Grade) / grad.Count(grad);
                return student;
            }
        }

        public async Task<Student> NewStudent(Student newStudent)
        {
            await _unitOfWork.Student.AddAsync(newStudent);

            return newStudent;
        }

        public async Task UpdateStudent(Student studentUpdate, Student student)
        {
            studentUpdate.StudentName = student.StudentName;

            await _unitOfWork.CommitAsync();
        }
    }
}
