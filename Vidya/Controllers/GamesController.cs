using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidya.Models;
using Vidya.ViewModels;

namespace Vidya.Controllers
{
    public class GamesController : Controller
    {
        // games
        public ActionResult Index()
        {
            var games = new List<Game>
            {
                new Game { Id = 1, Name = "Shrek" },
                new Game { Id = 2, Name = "Wall-e" }
            };

            var viewModel = new GameViewModel
            {
                Games = games
            };

            return View(viewModel);
        }

        // GET: Games/Random
        //public ActionResult Random()
        //{
        //    var game = new Game() { Name = "Shrek!" };
        //    var customers = new List<Customer>
        //    {
        //        new Customer { Id = 1, Name = "John Smith" },
        //        new Customer { Id = 2, Name = "Mary Williams" }
        //    };

        //    var viewModel = new RandomGameViewModel
        //    {
        //        Game = game,
        //        Customers = customers
        //    };

        //    return View(viewModel);
        //}

        //[Route("games/released/{year}/{month:regex(\\d{4}):range(1, 12)}")]
        //public ActionResult ByReleaseDate(int year, byte month)
        //{
        //    return Content(year + "/" + month);
        //}

        //public ActionResult Edit(int id)
        //{
        //    return Content("id=" + id);
        //}



        // games
        //public ActionResult Index(int? pageIndex, string sortBy)
        //{
        //    if (!pageIndex.HasValue)
        //        pageIndex = 1;
        //    if (String.IsNullOrWhiteSpace(sortBy))
        //        sortBy = "Name";

        //    return Content(String.Format("pageIndex={0}&sortBy={1}", pageIndex, sortBy));
        //}
    }
}