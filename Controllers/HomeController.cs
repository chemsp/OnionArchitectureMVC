using AutoMapper;

using OnionArchitectureMVC.Models;

using OnionArchitectureMVC.Service;
using OnionArchitectureMVC.Service.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OnionArchitectureMVC.Controllers
{
    public class HomeController : Controller
    {
        MapperConfiguration config;
        IMapper mapper;
        StudentService studentService;
        public HomeController()
        {
            studentService = new StudentService();
            config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<StudentInfoDTO, StudentInfoVM>();

            });
            mapper = config.CreateMapper();
        }
        public ActionResult StudentInfoByID(int id = 1)
        {
            var students = studentService.StudentInfoByID(id);
            var studentInfoVMs = mapper.Map<IEnumerable<StudentInfoDTO>, IEnumerable<StudentInfoVM>>(students);

           return View("Index", studentInfoVMs);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            

            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}