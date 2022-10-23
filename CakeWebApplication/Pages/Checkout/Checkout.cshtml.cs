using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CakeWebApplication.Pages.Checkout
{
    [BindProperties(SupportsGet =true)]

    public class CheckoutModel : PageModel
    {
        public string CakeName { get; set; }

        public float CakePrice { get; set; }
        
        public void OnGet()
        {
            if(string.IsNullOrWhiteSpace(CakeName))
            {
                CakeName = "Custom Cake";
            }
        }
    }
}
