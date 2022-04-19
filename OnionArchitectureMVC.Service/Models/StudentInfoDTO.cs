using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionArchitectureMVC.Service.Models
{
    public class StudentInfoDTO
    {
        public int StudentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string CourseName { get; set; }
        public string Grades { get; set; }
    }
}
