using AutoMapper;
using Common;
using Entities;
using Entities.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MVCPresentationLayer.Models.InsertModels;
using MVCPresentationLayer.Models.QueryModels;
using MVCPresentationLayer.Models.UpdateModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCPresentationLayer.Controllers
{
    public class MealController : Controller
    {
        private readonly IMapper mapper;
        private readonly IMealService mealService;

        public MealController(IMapper mapper, IMealService mealService)
        {
            this.mapper = mapper;
            this.mealService = mealService;
        }

        public IActionResult Index()
        {
            return View();
        }

        [AllowAnonymous]
        public IActionResult Insert()
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Insert(MealInsertViewModel model)
        {
            Meal meal = mapper.Map<Meal>(model);
            //meal.SetStatus(true);
                
            Response response = await mealService.Insert(meal);

            return View();
        }

        public IActionResult Update()
        {
            return View();
        }

        //[FromBody] UserUpdateViewModel model
        [HttpPost]
        public async Task<IActionResult> Update([FromBody] MealUpdateViewModel model)
        {
            Meal meal = mapper.Map<Meal>(model);

            Response response = await mealService.Update(meal);

            if (response.Success)
            {
                return Json(new { Sucesso = true });
            }

            return View("Index");
        }

        public async Task<IActionResult> Users()
        {
            QueryResponse<Meal> response = await mealService.GetAll();

            if (!response.Success)
            {
                return View();
            }

            List<MealQueryViewModel> data = mapper.Map<List<MealQueryViewModel>>(response.Data);
            return View(data);
        }
    }
}
