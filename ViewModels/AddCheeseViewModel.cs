using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using CheeseMVC.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CheeseMVC.ViewModels
{
    public class AddCheeseViewModel
    {
        [Required]
        [Display(Name = "Cheese Name")]
        public string Name { get; set; }
        [Required(ErrorMessage="You must give your cheese a description.")]
        public string Description { get; set; }
        public CheeseType Type { get; set; }
        public List<SelectListItem> CheeseTypes { get; set; }

        public AddCheeseViewModel()
        {
            CheeseTypes = new List<SelectListItem>();
            foreach(CheeseType cheeseType in Enum.GetValues(typeof(CheeseType)))
            {
                CheeseTypes.Add(new SelectListItem
                {
                    Value = ((int)cheeseType).ToString(),
                    Text = cheeseType.ToString()
                });
            }
        }
    }
    
}
