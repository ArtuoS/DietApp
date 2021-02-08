using AutoMapper;
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

namespace MVCPresentationLayer.Controllers {
    public class FoodCategoryController : Controller {
        private readonly IMapper mapper;
        private readonly IFood_CategoryService foodCategoryService;

        public FoodCategoryController(IMapper mapper, IFood_CategoryService foodCategoryService) {
            this.mapper = mapper;
            this.foodCategoryService = foodCategoryService;
        }

        public IActionResult Index() {
            return View();
        }

        [Authorize(Roles = "Admin,Doctor")]
        public IActionResult Insert() {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Insert(FoodCategoryInsertViewModel model) {
            FoodCategory foodCategory = mapper.Map<FoodCategory>(model);

            Response response = await foodCategoryService.Insert(foodCategory);

            return View();
        }

    }
}
