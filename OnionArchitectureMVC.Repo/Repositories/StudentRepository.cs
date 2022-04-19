using OnionArchitectureMVC.Data.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionArchitectureMVC.Repo.Repositories
{
    public class StudentRepository : GenericRepository<Students>, IStudentsRepository
    {
        public StudentRepository(TestDBEntities testDBEntities) : base(testDBEntities)
        {

        }
        
        public TestDBEntities TestDBEntities { get { return Context as TestDBEntities; } }

        public IEnumerable<Students> GetCoursesByCourseID(int courseID)
        {
            throw new NotImplementedException();  // customs logic here to get st
        }
    }
}
