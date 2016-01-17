using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cookbook.Models
{
    public class Recipe
    {
        public int CostIndex { get; set; }

        public int DifficultyIndex { get; set; }

        public int Id { get; set; }

        public IEnumerable<RecipeLocalization> Localizations { get; set; }

        public IEnumerable<RecipePart> Parts { get; set; }

        public string PrivateNotes { get; set; }

        public int ServingCount { get; set; }
    }
}
