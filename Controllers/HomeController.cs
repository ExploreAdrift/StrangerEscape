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
        if(HttpContext.Session.GetString("SwitchesFlipped") == null)
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
        //Fail Attempts Session Tracker
        if(HttpContext.Session.GetInt32("PuzzleFails") == null)
        {
            HttpContext.Session.SetInt32("PuzzleFails", 0);
        }
        //Fail Counter
        if(HttpContext.Session.GetInt32("FailCount") == null)
        {
            HttpContext.Session.SetInt32("FailCount", 0);
        }



        return View("Description");
    }

    [HttpGet("LivingRoom")]
    public IActionResult LivingRoom(string bulbCode, string Difficulty)
    {
        if(HttpContext.Session.GetInt32("userid") == null)
        {
            return RedirectToAction("Landing", "LoginAndReg");
        }

        //Difficulty Levels
        if(HttpContext.Session.GetInt32("Difficulty") == null)
        {
            if(Difficulty == "Easy" || Difficulty == null)
            {
                HttpContext.Session.SetInt32("Difficulty", 3);
            }
            if(Difficulty == "Medium")
            {
                HttpContext.Session.SetInt32("Difficulty", 2);
            }
            if(Difficulty == "Hard")
            {
                HttpContext.Session.SetInt32("Difficulty", 1);
            }
        }

        if(!String.IsNullOrEmpty(bulbCode))
        {
            string LightsKey = HttpContext.Session.GetString("LightsKey");
            if(bulbCode == LightsKey)
            {
                HttpContext.Session.SetString("LightsRed", "true");
                HttpContext.Session.SetInt32("FailCount", 0);
            }
            else
            {
                int count = (int)HttpContext.Session.GetInt32("FailCount");
                count++;
                HttpContext.Session.SetInt32("FailCount", count);
            }
        }
        if(HttpContext.Session.GetInt32("FailCount") == HttpContext.Session.GetInt32("Difficulty"))
        {
            return RedirectToAction("JumpScare");
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
        if(HttpContext.Session.GetInt32("userid") == null)
        {
            return RedirectToAction("Landing", "LoginAndReg");
        }
        if(HttpContext.Session.GetString("LightsRed") == "true")
        {
            return View("LivingRoomDark");
        }
        return RedirectToAction("LivingRoom");
    }

    [HttpGet("Basement")]
    public IActionResult Basement(string lightriddle)
    {
        if(HttpContext.Session.GetInt32("userid") == null)
        {
            return RedirectToAction("Landing", "LoginAndReg");
        }
        if(HttpContext.Session.GetString("LightsRed") == "false")
        {
            return RedirectToAction("LivingRoom");
        }
        if(!String.IsNullOrEmpty(lightriddle))
        {
            string SwitchKey = HttpContext.Session.GetString("SwitchKey");
            if(lightriddle == SwitchKey)
            {
                HttpContext.Session.SetString("SwitchesFlipped", "true");
                HttpContext.Session.SetInt32("FailCount", 0);
            }
            else
            {
                int count = (int)HttpContext.Session.GetInt32("FailCount");
                count++;
                HttpContext.Session.SetInt32("FailCount", count);
            }
            if(HttpContext.Session.GetInt32("FailCount") == HttpContext.Session.GetInt32("Difficulty"))
            {
                return RedirectToAction("JumpScare");
            }
        }

        if(HttpContext.Session.GetString("SwitchesFlipped") == "true")
        {
            return RedirectToAction("BasementLight");
        }
        return View("Basement");
    }
    
    [HttpGet("BasementLight")]
    public IActionResult BasementLight()
    {
        if(HttpContext.Session.GetInt32("userid") == null)
        {
            return RedirectToAction("Landing", "LoginAndReg");
        }
        if(HttpContext.Session.GetString("SwitchesFlipped") == "true")
        {
            return View("BasementLight");
        }
        return RedirectToAction("Basement");
    }

    [HttpGet("LivingRoom2")]
    public IActionResult LivingRoom2(string booktitle)
    {
        if(HttpContext.Session.GetInt32("userid") == null)
        {
            return RedirectToAction("Landing", "LoginAndReg");
        }
        if(HttpContext.Session.GetString("SwitchesFlipped") == "false")
        {
            return RedirectToAction("Basement");
        }
        if(!String.IsNullOrEmpty(booktitle))
        {
            string BookKey = HttpContext.Session.GetString("BookKey");
            if(booktitle.ToLower() == BookKey)
            {
                HttpContext.Session.SetString("TitleNamed", "true");
                HttpContext.Session.SetInt32("FailCount", 0);
            }
            else
            {
                int count = (int)HttpContext.Session.GetInt32("FailCount");
                count++;
                HttpContext.Session.SetInt32("FailCount", count);
            }
            if(HttpContext.Session.GetInt32("FailCount") == HttpContext.Session.GetInt32("Difficulty"))
            {
                return RedirectToAction("JumpScare");
            }
        }

        if(HttpContext.Session.GetString("TitleNamed") == "true")
        {
            return RedirectToAction("LivingRoom3");
        }
        return View("LivingRoom2");
    }

    [HttpGet("LivingRoom3")]
    public IActionResult LivingRoom3(string safecode)
    {
        if(HttpContext.Session.GetInt32("userid") == null)
        {
            return RedirectToAction("Landing", "LoginAndReg");
        }
        if(HttpContext.Session.GetString("TitleNamed") == "false")
        {
            return RedirectToAction("LivingRoom2");
        }
        if(!String.IsNullOrEmpty(safecode))
        {
            string SafeKey = HttpContext.Session.GetString("SafeKey");
            if(safecode == SafeKey)
            {
                HttpContext.Session.SetString("SafeUnlock", "true");
                HttpContext.Session.SetInt32("FailCount", 0);
            }
            else
            {
                int count = (int)HttpContext.Session.GetInt32("FailCount");
                count++;
                HttpContext.Session.SetInt32("FailCount", count);
            }
            if(HttpContext.Session.GetInt32("FailCount") == HttpContext.Session.GetInt32("Difficulty"))
            {
                return RedirectToAction("JumpScare");
            }
        }

        if(HttpContext.Session.GetString("SafeUnlock") == "true")
        {
            return RedirectToAction("LivingRoom4");
        }
        return View("LivingRoom3");
    }

    [HttpGet("LivingRoom4")]
    public IActionResult LivingRoom4()
    {
        if(HttpContext.Session.GetInt32("userid") == null)
        {
            return RedirectToAction("Landing", "LoginAndReg");
        }
        if(HttpContext.Session.GetString("SafeUnlock") == "false")
        {
            return RedirectToAction("LivingRoom3");
        }
        return View("LivingRoom4");
    }

    [HttpGet("BasementFinal")]
    public IActionResult BasementFinal()
    {
        if(HttpContext.Session.GetInt32("userid") == null)
        {
            return RedirectToAction("Landing", "LoginAndReg");
        }
        if(HttpContext.Session.GetString("SafeUnlock") == "false")
        {
            return RedirectToAction("LivingRoom3");
        }
        return View("BasementFinal");
    }

    [HttpGet("Success")]
    public IActionResult JumpScare()
    {
        return View("JumpScare");
    }

    [HttpPost("StartOver")]
    public IActionResult StartOver()
    {
        int seshid = (int)HttpContext.Session.GetInt32("userid");
        HttpContext.Session.Clear();
        HttpContext.Session.SetInt32("userid", seshid);
        return RedirectToAction("Dashboard");
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
