using OnionArchitectureMVC.Data.Data;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionArchitectureMVC.Repo.Repositories
{
    public class DepartmentsRepository : GenericRepository<Department>, IDepartmentsRepository
    {
        public DepartmentsRepository(DbContext context) : base(context)
        {
        }
    }
}
