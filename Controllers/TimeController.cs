using System.Reflection.PortableExecutable;
using System;
using Microsoft.AspNetCore.Mvc;

namespace TimeDisplay.Controllers
{
  public class TimeController : Controller
  {
    [HttpGet("")]
    public ViewResult Index()
    {
      string time = DateTime.Now.ToString("MMMM dd, yyyy hh:mm tt");
      ViewBag.time = time;
      return View();
    }
  }
}