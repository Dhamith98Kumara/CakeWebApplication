using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CakeWebApplication.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CakeWebApplication.Pages.Forms
{
    public class CustomCakeModel : PageModel
    {
        [BindProperty]
        public CakeModel Cakes { get; set; }
        public float CakePrice { get; set; }
        
        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            CakePrice = Cakes.BasePrice;
            if (Cakes.Chocolate) CakePrice += 8;
            if (Cakes.Cheese) CakePrice += 5;
            if (Cakes.Pineapple) CakePrice += 12;

            return RedirectToPage("/Checkout/Checkout", new { Cakes.CakeName, CakePrice });
        }
    }
}
