using OnionArchitectureMVC.Data.Data;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionArchitectureMVC.Repo.Repositories
{
    public class CoursesRepository : GenericRepository<Courses>, ICoursesRepository
    {
        public CoursesRepository(TestDBEntities testDBEntities) : base(testDBEntities)
        {
            
        }
        


        public TestDBEntities TestDBEntities { get { return Context as TestDBEntities; } }

       
    }
}
