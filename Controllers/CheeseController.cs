using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CheeseMVC.Models;
using CheeseMVC.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace CheeseMVC.Controllers
{
    public class CheeseController : Controller
    {
        

        public IActionResult Index()
        {
            List<Cheese> cheeses = CheeseData.GetAll();
            //ViewBag.cheeses = CheeseData.GetAll();
            ViewBag.Title = "Hello";
            return View(cheeses);
        }
        public IActionResult Add()
        {
            AddCheeseViewModel addCheeseVM = new AddCheeseViewModel();
            return View(addCheeseVM);
        }
        [HttpPost]
        public IActionResult Add(AddCheeseViewModel addCheeseVM)
        {   
            if(ModelState.IsValid)
            {
                Cheese newCheese = new Cheese 
                {
                    Name = addCheeseVM.Name,
                    Description = addCheeseVM.Description,
                    Type = addCheeseVM.Type
                };
                CheeseData.Add(newCheese);
                return Redirect("/");
            }
            return View(addCheeseVM);
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
