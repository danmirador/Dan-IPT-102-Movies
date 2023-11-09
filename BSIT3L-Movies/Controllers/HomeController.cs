using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using BSIT3L_Movies.Models;
using System.Collections.Generic;

namespace BSIT3L_Movies.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly List<MovieViewModel> _movies;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
        _movies = new List<MovieViewModel>
        {
          new MovieViewModel { Id = 1, Name = "American Made ", Rating = "7.1", ReleaseYear = 2017, Genre = "Action, Comedy, Crime", Imagelnk = "/images/AmericanMade.jpg" },
            new MovieViewModel { Id = 2, Name = "The Dark Knight", Rating = "9.0", ReleaseYear = 2008, Genre = "Action, Crime, Drama", Imagelnk = "/images/TheDarkKnight.jpg" },
            new MovieViewModel { Id = 3, Name = "Inside Out", Rating = "8.1", ReleaseYear = 2015, Genre = "Animation, Adventure, Comedy", Imagelnk = "/images/InsideOut.jpg" },
            new MovieViewModel { Id = 4, Name = "Hotel Transylvania", Rating = "7.0", ReleaseYear = 2012, Genre = "Animation, Adventure, Comedy", Imagelnk = "/images/HotelTransylvania.jpg" },
            new MovieViewModel { Id = 5, Name = "The Lion King", Rating = "8.5", ReleaseYear = 1994, Genre = "Action, Adventure, Drama", Imagelnk = "/images/TheLionKing.jpg" },
            new MovieViewModel { Id = 6, Name = "Coco", Rating = "8.4", ReleaseYear = 2017, Genre = "Action, Adventure, Drama", Imagelnk = "/images/Coco.jpg" },
            new MovieViewModel { Id = 7, Name = "Ratatouille", Rating = "8.1", ReleaseYear = 2021, Genre = "Action, Adventure, Comedy", Imagelnk = "/images/Ratatouille.jpg" },
            new MovieViewModel { Id = 8, Name = "Haunted Mansion", Rating = "6.1", ReleaseYear = 2023, Genre = "Comedy, Drama, Family", Imagelnk = "/images/HauntedMansion.jpg" },
            new MovieViewModel { Id = 9, Name = "Trick 'r Treat", Rating = "6.7", ReleaseYear = 2007, Genre = "Comedy, Horror", Imagelnk = "/images/TrickRTreat.jpg" },
            new MovieViewModel { Id = 10, Name = "The Lost Boys", Rating = "7.2", ReleaseYear = 1987, Genre = "Comedy, Horror", Imagelnk = "/images/TheLostBoys.jpg" },
            new MovieViewModel { Id = 11, Name = "The Nun", Rating = "5.3", ReleaseYear = 2018, Genre = "Horror, Mystery, Thriller", Imagelnk = "/images/TheNun.jpg" },
            new MovieViewModel { Id = 12, Name = "Renfield", Rating = "6.4", ReleaseYear = 2023, Genre = "Comedy, Fantasy, Horror", Imagelnk = "/images/Renfield.jpg" },
            new MovieViewModel { Id = 13, Name = "Saving Private Ryan", Rating = "8.6", ReleaseYear = 1998, Genre = "Drama, War", Imagelnk = "/images/SavingPrivateRyan.jpg" },
            new MovieViewModel { Id = 14, Name = "Sisu", Rating = "6.9", ReleaseYear = 2022, Genre = "Action, War", Imagelnk = "~/images/Sisu.jpg" },
            new MovieViewModel { Id = 15, Name = "Black Hawk Down", Rating = "7.7", ReleaseYear = 2001, Genre = "Action, Drama, History", Imagelnk = "/images/BlackHawkDown.jpg" },
            new MovieViewModel { Id = 16, Name = "Hacksaw Ridge", Rating = "8.1", ReleaseYear = 2016, Genre = "Biography, Drama, History", Imagelnk = "/images/HacksawRidge.jpg" },
            new MovieViewModel { Id = 17, Name = "Braveheart", Rating = "8.3", ReleaseYear = 1995, Genre = "Biography, Drama, History", Imagelnk = "/images/Braveheart.jpg" },
            new MovieViewModel { Id = 18, Name = "John Wick: Chapter 4", Rating = "7.8", ReleaseYear = 2023, Genre = "Action, Crime, Thriller", Imagelnk = "/images/JohnWick4.jpg" },
            new MovieViewModel { Id = 19, Name = "Dune", Rating = "8.0", ReleaseYear = 2021, Genre = "Action, Adventure, Drama", Imagelnk = "/images/Dune.jpg" },
            new MovieViewModel { Id = 20, Name = "The Equalizer", Rating = "7.2", ReleaseYear = 2014, Genre = "Action, Crime, Thriller", Imagelnk = "/images/TheEqualizer.jpg" },
        };
    }

    public IActionResult Index()
    {
        return View(_movies);
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

