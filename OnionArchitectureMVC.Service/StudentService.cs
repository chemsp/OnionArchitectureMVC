using OnionArchitectureMVC.Data.Data;
using OnionArchitectureMVC.Repo;
using OnionArchitectureMVC.Service.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionArchitectureMVC.Service
{
    public class StudentService
    {
        public UnitOfWork uow { get; set; }
        public StudentService()
        {
            TestDBEntities testDbEnties = new TestDBEntities();
            uow = new UnitOfWork(testDbEnties);
        }

        public IEnumerable<StudentInfoDTO> StudentInfoByID (int id)
        {
            var courses = uow.Courses.GetAll();
            var registrations = uow.Registrations.GetAll();
            var students = uow.Students.GetAll();

            var result = (from s in students
                          join r in registrations on s.StudentId equals r.StudentId
                          join c in courses on r.CourseId equals c.CourseId
                          where s.StudentId == id
                          select new StudentInfoDTO
                          {
                              StudentId = s.StudentId,
                              FirstName = s.FirstName,
                              LastName = s.LastName,
                              Email = s.Email,
                              CourseName = c.CourseName,
                              Grades = r.Grades
                          }).ToList();
            return result;
        }
    }
}
