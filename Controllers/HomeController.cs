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
    
    // filter courses by category
    [Authorize]
    [HttpPost]
    public IActionResult FilterCourses(string categoryName)
    {    

      var ListCourseCategories = _courseservices.AllCoursesByCategory(categoryName);
      return View(ListCourseCategories);

    }
    
    //create course get    
    [Authorize(Roles = "Admin")]
    [HttpGet]
    public IActionResult CreateCourse()
    {
      return View();
    }
    //create course post to server
    [Authorize(Roles = "Admin")]
    [HttpPost]
    public IActionResult CreateCourse(CourseModel model)
    {
      if (ModelState.IsValid)
      {
        _courseservices.CreateCourse(model);
        return RedirectToAction("Index");
      }

      return View(model);
    }
    
     //edit course get request
    [Authorize(Roles = "Admin")]
    [HttpGet]
    public IActionResult EditCourse(string Id)
    {
      if (Id == null)
      {
        return NotFound();
      }

      var course = _courseservices.GetOneCourse(Id);

      if (course == null)
      {
        return NotFound();
      }

      return View(course);
    }
    //edit course post request
    [Authorize(Roles = "Admin")]
    [HttpPost]
    public IActionResult EditCourse(string id, CourseModel model)
    {
      if (id != model.CourseId)
      {
        return NotFound();
      }

      if (ModelState.IsValid)
      {
        _courseservices.EditCourse(id, model);
        return RedirectToAction("Index");
      }

      return View(model);
    }
    // delete course data in mongo db
    [Authorize(Roles = "Admin")]
    public ActionResult DeleteCourse(string id)
    {
      if (id == null)
      {
        return NotFound();
      }

      var course = _courseservices.GetOneCourse(id);

      if (course == null)
      {
        return NotFound();
      }
      _courseservices.DeleteCourse(course);
      return RedirectToAction("Index");
    }
    //SCHOOLS
    [Authorize]
    [HttpGet]
    public IActionResult Schools()
    {
      var ListSchools = _schoolservices.AllSchools();
      return View(ListSchools);
    }
    
    //create schools get
    [Authorize(Roles = "Admin")]
    [HttpGet]
    public IActionResult CreateSchool()
    {
      return View();
    }
    //create school post to server
    [Authorize(Roles = "Admin")]
    [HttpPost]
    public IActionResult CreateSchool(SchoolModel model)
    {
      if (ModelState.IsValid)
      {
        _schoolservices.CreateSchool(model);
        return RedirectToAction("Index");
      }

      return View(model);
    }
   
//edit school get request
    [Authorize(Roles = "Admin")]
    [HttpGet]
    public IActionResult EditSchool(string Id)
    {
      if (Id == null)
      {
        return NotFound();
      }

      var school = _schoolservices.GetOneSchool(Id);

      if (school == null)
      {
        return NotFound();
      }

      return View(school);
    }
    //edit school post request
    [Authorize(Roles = "Admin")]
    [HttpPost]
    public IActionResult EditSchool(string id, SchoolModel model)
    {
      if (id != model.SchoolId)
      {
        return NotFound();
      }

      if (ModelState.IsValid)
      {
        _schoolservices.EditSchool(id, model);
        return RedirectToAction("Index");
      }

      return View(model);
    }
    // delete school data in mongo db
    [Authorize(Roles = "Admin")]
    public ActionResult DeleteSchool(string id)
    {
      if (id == null)
      {
        return NotFound();
      }

      var school = _schoolservices.GetOneSchool(id);

      if (school == null)
      {
        return NotFound();
      }
      _schoolservices.DeleteSchool(school);
      return RedirectToAction("Index");
    }
    
     //MAPA KURSEVA
    public IActionResult CoursesMap()
    {
      return View();
    }

    public IActionResult Error()
    {
      return View();
    }
  }
}
