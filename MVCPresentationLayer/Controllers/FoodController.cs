using AutoMapper;
using BusinessLogicalLayer;
using Microsoft.AspNetCore.Authorization;
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
        private readonly FoodBLL foodBLL;

        public FoodController(IMapper mapper, FoodBLL foodBLL)
        {
            this.mapper = mapper;
            this.foodBLL = foodBLL;
        }

        public IActionResult Index()
        {
            return View();
        }

        [Authorize(Roles ="Adm,Doctor")]
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
