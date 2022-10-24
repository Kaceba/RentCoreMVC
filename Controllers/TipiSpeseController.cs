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
        var TipiSpese = tipiSpeseService.GetTipiSpese();
        ViewData["Title"] = "Tipi Spese";
        return View(TipiSpese);
    }

    public IActionResult Insert()
    {
        //Son bloccato
        string Descrizione;

        var TipiSpese = tipiSpeseService.GetTipiSpese();
        ViewData["Title"] = "Tipi Spese";
        return View(TipiSpese);
    }

    public IActionResult Update()
    {
        return View("TipiSpeseUpdate");
    }
}