using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cookbook.Models
{
    public class RecipePart
    {
        public int CookingTime { get; set; }

        public IEnumerable<RecipePartLocalization> Localizations { get; set; }

        public int PreparationTime { get; set; }
    }
}
