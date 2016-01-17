using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cookbook.Models
{
    public class RecipeLocalization
    {
        public string Culture { get; set; }

        public string Description { get; set; }

        public string Notes { get; set; }

        public IEnumerable<string> Tags { get; set; }

        public string Title { get; set; }
    }
}
