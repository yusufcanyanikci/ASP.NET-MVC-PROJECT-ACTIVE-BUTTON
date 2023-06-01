﻿using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using project.Models;

namespace project.Controllers;

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

    public IActionResult Features()
    {
        return View();
    }
     public IActionResult Pricing()
    {
        return View();
    }
     public IActionResult Testimonials()
    {
        return View();
    }
     public IActionResult Help()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
