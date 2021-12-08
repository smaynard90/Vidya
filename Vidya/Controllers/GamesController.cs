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
        private ApplicationDbContext _context;
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
               
    }
}