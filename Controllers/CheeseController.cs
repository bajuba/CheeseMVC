using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CheeseMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace CheeseMVC.Controllers
{
    public class CheeseController : Controller
    {
        

        public IActionResult Index()
        {
    
            ViewBag.cheeses = CheeseData.GetAll();

            return View();
        }
        public IActionResult Add()
        {
            return View();
        }
        [Route("Cheese/Add")]
        [HttpPost]
        public IActionResult NewCheese(Cheese newCheese)
        {   
            /* Cheese newCheese = new Cheese 
            {
                Name = name,
                Description = description
            }; */
            CheeseData.Add(newCheese);
            return Redirect("/Cheese");
        }
        public IActionResult Remove()
        {
            ViewBag.title = "Remove Cheeses";
            ViewBag.cheeses = CheeseData.GetAll();
            return View();
        }
        [HttpPost]
        public IActionResult Remove(int[] cheeseIDs)
        {
            foreach ( int cheeseID in cheeseIDs)
            {
                CheeseData.Remove(cheeseID);
            }
            return Redirect("/");
        }
    }
}
