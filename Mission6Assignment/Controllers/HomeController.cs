using System.Diagnostics;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Mission6Assignment.Models;

namespace Mission6Assignment.Controllers;

public class HomeController : Controller
{
    private readonly MovieContext _context;

    public HomeController(MovieContext context)
    {
        _context = context;
    }
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult GetToKnowJoel()
    {
        return View();
    }

    [HttpGet]
    public IActionResult EnterAMovie()
    {
        return View();
    }
    
    [HttpPost]
    public IActionResult EnterAMovie(Collection response)
    {
        _context.Collections.Add(response);
        _context.SaveChanges();
        return View("Confirmation", response);
    }
    
    public IActionResult MovieList()
    {
        var movies = _context.Collections.ToList();
        return View("MovieList" , movies);
    }
}