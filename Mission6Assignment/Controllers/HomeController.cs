using System.Diagnostics;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Mission6Assignment.Models;
using Microsoft.EntityFrameworkCore;

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
        ViewBag.Categories = _context.Categories
            .OrderBy(x => x.CategoryName)
            .ToList();
        return View("EnterAMovie", new Movie());
    }

    [HttpPost]
    public IActionResult EnterAMovie(Movie response)
    {
        if (ModelState.IsValid)
        {
            _context.Movies.Add(response);
            _context.SaveChanges();
            return View("Confirmation", response);
        }
        else
        {
            ViewBag.Categories = _context.Categories
                .OrderBy(x => x.CategoryName)
                .ToList();
            return View(response);
        }

    }

    public IActionResult MovieList()
    {
        var movies = _context.Movies
            .Include(m => m.Category)
            .ToList();
        return View("MovieList", movies);
    }

    [HttpGet]

    public IActionResult Edit(int id)
    {
        var recordToEdit = _context.Movies
            .Include(m => m.Category)
            .Single(x => x.MovieId == id);
        
        ViewBag.Categories = _context.Categories
            .OrderBy(x => x.CategoryName)
            .ToList();
        return View("EnterAMovie", recordToEdit);
    }
    
    [HttpPost]
    public IActionResult Edit(Movie updatedInfo)
    {
        _context.Update(updatedInfo);
        _context.SaveChanges();
        
        return RedirectToAction("MovieList");
    }
    
    [HttpGet]
    public IActionResult Delete(int id)
    {
        var recordToDelete = _context.Movies
            .Single(x => x.MovieId == id);
        
        return View(recordToDelete);
    }
    
    [HttpPost]
    public IActionResult Delete(Movie movie)
    {
        _context.Movies.Remove(movie);
        _context.SaveChanges();
        return RedirectToAction("MovieList");
    }

}