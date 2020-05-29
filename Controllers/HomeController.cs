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
    private readonly SchoolServices _schoolservices;
    
    public HomeController(CourseServices courseservices, SchoolServices schoolservice)
    {
      _courseservices = courseservices;
      _schoolservices = schoolservice;
      
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
    
    [Authorize]
    [HttpGet]
    public IActionResult Schools()
    {
      var ListSchools = _schoolservices.AllSchools();
      return View(ListSchools);
    }
   

    public IActionResult Error()
    {
      return View();
    }
  }
}
