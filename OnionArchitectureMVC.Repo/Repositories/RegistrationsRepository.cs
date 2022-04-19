using OnionArchitectureMVC.Data.Data;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionArchitectureMVC.Repo.Repositories
{
    public class RegistrationsRepository : GenericRepository<Registrations>, IRegistrationsRepository
    {
        public RegistrationsRepository(DbContext context) : base(context)
        {

        }
    }
}
