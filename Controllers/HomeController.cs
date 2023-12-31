﻿using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Encuesta.Models;

namespace Encuesta.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }



    [HttpPost]
    [Route("/result")]
    public IActionResult Submission(Survey survey)
    {   
        Console.WriteLine(survey);
        return View("Privacy", survey);
    }

    
    public IActionResult Privacy()
    {
        

        return View(); 
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
