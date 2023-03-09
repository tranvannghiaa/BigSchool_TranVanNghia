using BigSchool_TranVanNghia.Models;
using BigSchool_TranVanNghia.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BigSchool_TranVanNghia.Controllers
{
    public class CoursesController : Controller
    {
        // GET: Courses
        private readonly ApplicationDbContext _context;
        public CoursesController() { 
            _context=new ApplicationDbContext();
        }
        public ActionResult Create()
        {
            var viewModel = new CourseViewModel
            {
                Categories = _context.Categories.ToList()

            };
            
            return View(viewModel);
        }
    }
}