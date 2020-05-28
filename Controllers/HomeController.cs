using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using E_Learning_Platforma.Models;
using E_Learning_Platforma.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace E_Learning_Platforma.Controllers
{
  public class HomeController : Controller
  {  
    private readonly CourseServices _courseservices;
    
    public HomeController(CourseServices courseservices)
    {
      _courseservices = courseservices;
      
    }

    //INDEX
    public IActionResult Index()
    {
      return View();
    }
    
    //COURSES
    // get all courses in index view page
    [Authorize]
    [HttpGet]
    public IActionResult Courses()
    {
      var ListCourses = _courseservices.AllCourses();
      return View(ListCourses);
    }
   

    public IActionResult Error()
    {
      return View();
    }
  }
}
