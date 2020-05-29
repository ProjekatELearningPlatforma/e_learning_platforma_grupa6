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

    public IActionResult Error()
    {
      return View();
    }
  }
}
