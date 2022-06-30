using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using StrangerEscape.Models;

namespace StrangerEscape.Controllers;

public class HomeController : Controller
{
    private MyContext _context;

    public HomeController(MyContext context)
    {
        _context = context;
    }
// this is a test comment 
    [HttpGet("GetStarted")]
    public IActionResult Dashboard()
    {
        if (HttpContext.Session.GetString("LightsRed") == null)
        {
            HttpContext.Session.SetString("LightsRed", "false");
        }
        if (HttpContext.Session.GetString("SwitchKey") == null)
        {
            HttpContext.Session.SetString("SwitchKey", "3124");
        }
        return View("Description");
    }


    // [HttpGet("GetStarted/Instructions/Scores")]
    // public IActionResult Instructions()
    // {
    //     List<User> users = _context.Users.

    // }

    // public TimeSpan getTimeSpan()
    // {
    //     //Timer Calculations - Calculating the difference from start to current;

    //     string startTime = HttpContext.Session.GetString("StartTime");
    //     DateTime start = Convert.ToDateTime(startTime);
    //     string currentTime = DateTime.Now.Hour.ToString() + ":" + DateTime.Now.Minute.ToString() + ":" + DateTime.Now.Second.ToString();
    //     DateTime current = Convert.ToDateTime(currentTime);
    //     var timeLength = current - start;

    //     //Display Timer

    //     string time1 = "16:00:00";
    //     string time2 = "16:05:00";
    //     DateTime t1 = Convert.ToDateTime(time1);
    //     DateTime t2 = Convert.ToDateTime(time2);
    //     var timer = t2 - t1;
    //     var timerleft = timer - timeLength;
    //     string end1 = "00:00:00";
    //     string end2 = "00:00:00";
    //     DateTime e1 = Convert.ToDateTime(end1);
    //     DateTime e2 = Convert.ToDateTime(end2);
    //     var endgame = e2 - e1;
    //     if (timerleft < endgame)
    //     {
    //         return endgame;
    //     }
    //     else return timerleft;
    // }

    [HttpGet("LivingRoom")]
    public IActionResult LivingRoom()
    {
        // if (HttpContext.Session.GetString("StartTime") == null)
        // {
        //     string now = DateTime.Now.Hour.ToString() + "." + DateTime.Now.Minute.ToString() + "." + DateTime.Now.Second.ToString();
        //     HttpContext.Session.SetString("StartTime", now);
        // }
        // bool stringlights = Convert.ToBoolean(HttpContext.Session.GetString("LightsRed"));
        // ViewBag.lights = stringlights;
        // ViewBag.SwitchKey = HttpContext.Session.GetString("SwitchKey");

        // ViewBag.timer = getTimeSpan();

        return View("LivingRoom");
    }

    [HttpGet("LivingRoomDark")]
    public IActionResult LivingRoomDark()
    {
        return View("LivingRoomDark");
    }

    [HttpGet("LivingRoom2")]
    public IActionResult LivingRoom2()
    {
        return View("LivingRoom2");
    }

    [HttpGet("LivingRoom3")]
    public IActionResult LivingRoom3()
    {
        return View("LivingRoom3");
    }

    [HttpGet("LivingRoom4")]
    public IActionResult LivingRoom4()
    {
        return View("LivingRoom4");
    }

    [HttpGet("Basement")]
    public IActionResult Basement()
    {
        return View("Basement");
    }

    [HttpGet("BasementLight")]
    public IActionResult BasementLight()
    {
        return View("BasementLight");
    }

    [HttpGet("BasementFinal")]
    public IActionResult BasementFinal()
    {
        return View("BasementFinal");
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
