using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CakeWebApplication.Models
{
    public class CakeModel
    {
        public string CakeName { get; set; }
        public bool Chocolate { get; set; }
        public bool Cheese { get; set; }
        public bool Pineapple { get; set; }
        public float BasePrice { get; set; } = 10;
    }
}
