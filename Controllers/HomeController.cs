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

    //INDEX
    public IActionResult Index()
    {
      return View();
    }
   

    public IActionResult Error()
    {
      return View();
    }
  }
}
