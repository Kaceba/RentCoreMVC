using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using RentCore.Models;

namespace RentCore.Controllers;

public class UserController : Controller
{
    public IActionResult Login()
    {
        return View();
    }
}