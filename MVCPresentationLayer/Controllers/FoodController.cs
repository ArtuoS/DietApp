using AutoMapper;
using BusinessLogicalLayer;
using Common;
using Entities;
using Entities.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MVCPresentationLayer.Models.InsertModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCPresentationLayer.Controllers
{
    [Authorize]
    public class FoodController : Controller
    {
        private readonly IMapper mapper;
        private readonly IFoodService foodBLL;

        public FoodController(IMapper mapper, IFoodService foodBLL)
        {
            this.mapper = mapper;
            this.foodBLL = foodBLL;
        }

        public IActionResult Index()
        {
            return View();
        }

        [Authorize(Roles ="Admin,Doctor")]
        public IActionResult Insert()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Insert(FoodInsertViewModel model)
        {
            Food food = mapper.Map<Food>(model);

            Response response = await foodBLL.Insert(food);

            return View();
        }
    }
}
