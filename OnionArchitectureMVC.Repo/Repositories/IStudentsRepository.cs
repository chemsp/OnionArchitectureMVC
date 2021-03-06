using OnionArchitectureMVC.Data.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionArchitectureMVC.Repo.Repositories
{
    public interface IStudentsRepository: IGenericRepository<Students>
    {
        IEnumerable<Students> GetCoursesByCourseID(int courseID);
       
    }
}
