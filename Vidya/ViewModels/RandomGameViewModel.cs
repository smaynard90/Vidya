using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vidya.Models;

namespace Vidya.ViewModels
{
    public class RandomGameViewModel
    {
        public Game Game { get; set; }
        public List<Customer> Customers { get; set; }
    }
}