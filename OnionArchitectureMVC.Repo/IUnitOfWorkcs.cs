using OnionArchitectureMVC.Repo.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionArchitectureMVC.Repo
{
    public interface IUnitOfWork:IDisposable
    {
        IRegistrationsRepository Registrations { get; }
        IStudentsRepository Students{ get; }
        ICoursesRepository Courses { get; }
        IDepartmentsRepository Departments { get; }
        int Complete();
        
    }
}
