using E_TicktsCinma.Models;
using E_TicktsCinma.Repository.IRepository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace E_TicktsCinma.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IMovieRepository movieRepository;
        private readonly IActorRepository actorRepository;

        public HomeController(ILogger<HomeController> logger, IMovieRepository movieRepository,IActorRepository actorRepository)
        {
            _logger = logger;
            this.movieRepository = movieRepository;
            this.actorRepository = actorRepository;
        }

       

        public IActionResult Index()
        {
            var resualt=movieRepository.GetAll("Category");
            //List<Cinema> cinemas= new List<Cinema>();
            //ViewBag.cinema = cinemas;
            return View(model:resualt);
        }

        public IActionResult Details(int MovieId)
        {
            var result = movieRepository.GetOne(M=>M.Id==MovieId);
            Movie movie = new Movie();
           

            if (movie != null)
            {
                return View(model: result);
            }
            else
            {
                return RedirectToAction(nameof(NotFoundPage));
            }
        }
        public IActionResult NotFoundPage()
        {
            return View();
        }

        public IActionResult Actores(int? ActorId)
        {
            var result = actorRepository.GetOne(e=>e.Id==ActorId);
            Actor actor = new Actor();
            if (actor != null)
            {
                return View(model: result);
            }
            else
            {
                return RedirectToAction(nameof(NotFoundPage));
            }
            // ViewBag.Actor=actor.ProfilePicture;
            
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
}
