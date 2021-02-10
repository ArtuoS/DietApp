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
        private readonly IFoodService foodService;
        private readonly IFood_CategoryService foodCategoryService;

        public FoodController(IMapper mapper, IFoodService foodService, IFood_CategoryService foodCategoryService)
        {
            this.mapper = mapper;
            this.foodService = foodService;
            this.foodCategoryService = foodCategoryService;
        }

        public IActionResult Index()
        {
            return View();
        }

        [Authorize(Roles = "Admin,Doctor")]
        public IActionResult Insert()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Insert([FromBody] FoodInsertViewModel model)
        {
            Food food = new Food();
            SingleResponse<FoodCategory> category = await foodCategoryService.GetByName(model.Category);

            food.Category = category.Data;
            food = mapper.Map<Food>(model);
            //food.CategoryID= category.Data.ID;


            Response response = await foodService.Insert(food);

            return View();
        }

    }
}
