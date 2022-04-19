using OnionArchitectureMVC.Data.Data;
using OnionArchitectureMVC.Repo.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionArchitectureMVC.Repo
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly TestDBEntities _context;
        public UnitOfWork(TestDBEntities context)
        {
            _context = context;
             Courses = new CoursesRepository(_context);
             Students = new StudentRepository(_context);
             Registrations = new RegistrationsRepository(_context);
             Departments = new DepartmentsRepository(_context);
        }

        public ICoursesRepository Courses { get; set; }
        public IStudentsRepository Students { get; set; }
        public IRegistrationsRepository Registrations { get; set; }

        public IDepartmentsRepository Departments { get; set; }

        
        public int Complete(){
          return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
