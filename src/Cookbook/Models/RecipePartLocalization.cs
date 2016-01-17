using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cookbook.Models
{
    public class RecipePartLocalization
    {
        public string Culture { get; set; }

        public string Description { get; set; }

        public IEnumerable<Ingredient> Ingredients { get; set; }

        public string Instructions { get; set; }

        public string Name { get; set; }
    }
}
