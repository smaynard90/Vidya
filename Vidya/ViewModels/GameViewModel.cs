using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vidya.Models;

namespace Vidya.ViewModels
{
    public class GameViewModel
    {
        public Game Game { get; set; }
        public List<Game> Games { get; set; }
    }
}