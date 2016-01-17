using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using Cookbook.Models;
using Cookbook.ViewModels.Recipe;

namespace Cookbook.Controllers
{
    public class RecipeController : Controller
    {
        public IActionResult Create()
        {
            var model = new CreateViewModel();
            return View(model);
        }
    }
}
