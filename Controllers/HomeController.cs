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
        if(HttpContext.Session.GetInt32("userid") == null)
        {
            return RedirectToAction("Landing", "LoginAndReg");
        }
        //First Puzzle - Lights to Red
        if (HttpContext.Session.GetString("LightsRed") == null)
        {
            HttpContext.Session.SetString("LightsRed", "false");
        }
        if(HttpContext.Session.GetString("LightsKey") == null)
        {
            HttpContext.Session.SetString("LightsKey", "1111111111"); 
        }
        //Second Puzzle - Switches in Order
        if (HttpContext.Session.GetString("SwitchKey") == null)
        {
            HttpContext.Session.SetString("SwitchKey", "3124");
        }
        if(HttpContext.Session.GetString("SwitchsFlipped") == null)
        {
            HttpContext.Session.SetString("SwitchesFlipped", "false");
        }
        //Third Puzzle - BookShelf Input
        if(HttpContext.Session.GetString("BookKey") == null)
        {
            HttpContext.Session.SetString("BookKey", "michael choi");
        }
        if(HttpContext.Session.GetString("TitleNamed") == null)
        {
            HttpContext.Session.SetString("TitleNamed", "false");
        }
        //Final Puzzle - Safe Code
        if(HttpContext.Session.GetString("SafeKey") == null)
        {
            HttpContext.Session.SetString("SafeKey", "1047");
        }
        if(HttpContext.Session.GetString("SafeUnlock") == null)
        {
            HttpContext.Session.SetString("SafeUnlock", "false");
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
    public IActionResult LivingRoom(string bulbCode)
    {
        if(HttpContext.Session.GetInt32("userid") == null)
        {
            return RedirectToAction("Landing", "LoginAndReg");
        }
        if(!String.IsNullOrEmpty(bulbCode))
        {
            string LightsKey = HttpContext.Session.GetString("LightsKey");
            if(bulbCode == LightsKey)
            {
                HttpContext.Session.SetString("LightsRed", "true");
            }
        }

        if(HttpContext.Session.GetString("LightsRed") == "true")
        {
            return RedirectToAction("LivingRoomDark");
        }

        return View("LivingRoom");
    }

    [HttpGet("LivingRoomDark")]
    public IActionResult LivingRoomDark()
    {
        return View("LivingRoomDark");
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
