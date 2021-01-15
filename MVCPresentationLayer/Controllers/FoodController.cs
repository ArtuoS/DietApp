using Microsoft.AspNetCore.Mvc;
using MVCPresentationLayer.Models.InsertModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCPresentationLayer.Controllers
{
    public class FoodController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public async Task<IActionResult> Insert()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Insert(FoodInsertViewModel model)
        {
            return View();
        }
    }
}
