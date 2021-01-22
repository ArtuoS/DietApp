using AutoMapper;
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
        private readonly IMapper mapper;

        public FoodController(IMapper mapper)
        {
            this.mapper = mapper;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Insert()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Insert(FoodInsertViewModel model)
        {
            return View();
        }
    }
}
