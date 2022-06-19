using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FrontToEnd.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FrontToEnd.Controllers
{
    public class HomeController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            ViewBag.Name = "Bukayo";
            ViewData["Surname"] = "Saka";
            TempData["Age"] = 20;

            List<Student> students = new List<Student>
            {
                new Student{Id=1, Name="Martin", Surname="Odegaard"},
                new Student{Id=2, Name="Eddie", Surname="Nketiah"}
            };

            //ViewBag.Students = students;

            //return RedirectToAction("About");
            //return RedirectToAction(nameof(About));
            //return Content($"{name} {surname} {age} {id}");
            return View(students)
;        }
        public IActionResult About()
        {
            return View();
        }
    }
}
