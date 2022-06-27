using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using StrangerEscape.Models;
using Microsoft.AspNetCore.Identity;
using System.Globalization;

namespace StrangerEscape.Controllers;

public class LoginController : Controller
{

    private MyContext _context;

    public LoginController(MyContext context)
    {
        _context = context;
    }

    [HttpGet("")]
    public IActionResult LoginandReg()
    {
        if(HttpContext.Session.GetInt32("userid") != null){
            return RedirectToAction("Dashboard", "Home");
        }
        return View();
    }

    [HttpPost("access")]
    public IActionResult Access(UserInLogin userSubmission)
    {
        if(HttpContext.Session.GetInt32("userid") != null){
            return RedirectToAction("Dashboard", "Home");
        }
        if(ModelState.IsValid)
        {
            var userInDb = _context.Users.FirstOrDefault(u => u.Email == userSubmission.LoginEmail);
            if(userInDb == null)
            {
                ModelState.AddModelError("UserName", "Invalid Username/Password");
                return View("LoginandReg");
            }
            else 
            {
                var hasher = new PasswordHasher<User>();
                var result = hasher.VerifyHashedPassword(userInDb, userInDb.Password, userSubmission.LoginPassword);
                if(result == 0)
                {
                    ModelState.AddModelError("Email", "Invalid Username/Password");
                    return View("LoginandReg");
                }
                else {
                    if(HttpContext.Session.GetInt32("userid") == null)
                    {
                        HttpContext.Session.SetInt32("userid", userInDb.UserId);
                    }
                    return RedirectToAction("Dashboard", "Home");
                }
            }
        }
        else
        {
            ModelState.AddModelError("UserName", "Something went wrong");
            return View("LoginandReg");
        }
    }

    [HttpPost("register")]
    public IActionResult Register(User user)
    {
        HttpContext.Session.Clear();
        if(ModelState.IsValid)
        {
            if(_context.Users.Any(u => u.Email == user.Email))
            {
                ModelState.AddModelError("UserName", "Username is already in use!");
                return View("LoginandReg");
            }
            else
            {
                PasswordHasher<User> Hasher = new PasswordHasher<User>();
                user.Password = Hasher.HashPassword(user, user.Password);
                _context.Add(user);
                _context.SaveChanges();
                var newuser = _context.Users.FirstOrDefault(u => u.Email == user.Email);
                if(HttpContext.Session.GetInt32("userid") == null && newuser != null)
                {
                    HttpContext.Session.SetInt32("userid", newuser.UserId);
                }
                return RedirectToAction("Dashboard", "Home");
            }
        }
        else
        {
            return View("LoginandReg");
        }  
    }

    [HttpGet("logout")]
    public IActionResult logout()
    {
        HttpContext.Session.Clear();
        return RedirectToAction("LoginandReg");
    }
}