using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cookbook.Models
{
    public class Ingredient
    {
        public string Alternative { get; set; }

        public string Comment { get; set; }

        public string Element { get; set; }

        public bool IsOptional { get; set; }

        public string Quantity { get; set; }

        public string Unit { get; set; }
    }
}
