using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;


namespace Vidly.Controllers
{
    public class MovieController : Controller
    {
        private ApplicationDbContext _context;

        //Constructor:
        public MovieController()
        {
            _context = new ApplicationDbContext();
        }
        //Disposal (or Destructor, if you will)
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }


        public ViewResult Index()
        {
            var movies = _context.Movies.Include(m => m.Genre).ToList();

            return View(movies);
        }

        public ActionResult New()
        {
            //Get genre list
            var viewModel = new MovieFormViewModel
            {
                //Populate genre list
                //Genres = 
            };

            return View(viewModel);
        }

        public ActionResult Edit(int id)
        {
            var movie = _context.Movies.SingleOrDefault(m => m.Id == id);
            if (movie == null)
            {
                return HttpNotFound();
            }

            var viewmodel = new MovieFormViewModel
            {
                Movie = movie,
                //Populate genre list
                //Genres = 
            };



            return View();
        }

        [HttpPost]
        public ActionResult Save(Movie movie)
        {
            if (movie.Id == 0)
            {
                _context.Movies.Add(movie);
            }
            else
            {
                //Explicit data writing to avoid malicious activity
                var movieInDb = _context.Movies.Single(c => c.Id == movie.Id);
                movieInDb.Name = movie.Name;
                movieInDb.Genre = movie.Genre;
                movieInDb.ReleaseDate = movie.ReleaseDate;
                movieInDb.Rating = movie.Rating;
                movieInDb.NumberInStock = movie.NumberInStock;
                movieInDb.DateAdded = movie.DateAdded;
            }

            _context.SaveChanges();

            return RedirectToAction("Index", "Movies");
        }

        public ActionResult Details(int id)
        {
            var movie = _context.Movies.Include(m => m.Genre).SingleOrDefault(c => c.Id == id);

            if (movie == null)
                return HttpNotFound();

            return View(movie);
        }

    }
}