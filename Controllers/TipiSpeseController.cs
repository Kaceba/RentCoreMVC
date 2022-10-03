using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using RentCore.Models;

namespace RentCore.Controllers;

public class TipiSpeseController : Controller
{   
    public readonly ITipiSpeseService tipiSpeseService;

    public TipiSpeseController(ITipiSpeseService tipiSpeseService)
    {
        this.tipiSpeseService = tipiSpeseService;
    }


    public IActionResult Index()
    {
        return View();
    }
}