using AutoMapper;
using BusinessLogicalLayer;
using Common;
using Entities;
using Entities.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MVCPresentationLayer.Models.InsertModels;
using MVCPresentationLayer.Models.QueryModels;
using MVCPresentationLayer.Models.UpdateModels;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCPresentationLayer.Controllers
{
    [Authorize]
    public class UserController : Controller
    {

        private readonly IMapper mapper;
        private readonly IUserService userService;
        private readonly IFoodService foodService;
        private readonly IFood_CategoryService foodCategoryService;
        private readonly IDietService dietService;

        public UserController(IMapper mapper, IUserService userService, IFoodService foodService, IFood_CategoryService categoryService, IDietService dietService)
        {
            this.mapper = mapper;
            this.userService = userService;
            this.foodService = foodService;
            this.foodCategoryService = categoryService;
            this.dietService = dietService;
        }

        public IActionResult Index()
        {
            return View();
        }

        [AllowAnonymous]
        public async Task<IActionResult> Insert()
        {
            QueryResponse<FoodCategory> categories = await foodCategoryService.GetAll();

            ViewBag.Categories = categories.Data;
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Insert(UserInsertViewModel model)
        {
            Restriction r = new Restriction();
            List<Food> foodsRestriction = new List<Food>();
            Response response = new Response();

            if (model.FoodSelect != null)
            {
                model.FoodSelect.ForEach(c => foodsRestriction.Add(
                new Food()
                {
                    ID = c
                }));
                r.Foods = foodsRestriction;
                User user = mapper.Map<User>(model);
                user.Restriction = r;
                user.SetStatus(true);
                user.SetRole();
                response = await userService.Insert(user);

            }
            else
            {
                User user = mapper.Map<User>(model);
                user.SetStatus(true);
                user.SetRole();
                response = await userService.Insert(user);

            }

            if (response.Success)
            {
                return Index();
            }
            else
            {
                return View();

            }
        }

        public IActionResult Update()
        {
            return View();
        }

        //[FromBody] UserUpdateViewModel model
        [HttpPost]
        public async Task<IActionResult> Update([FromBody] UserUpdateViewModel model)
        {
            User user = mapper.Map<User>(model);

            Response response = await userService.Update(user);

            if (response.Success)
            {
                return Json(new { Sucesso = true });
            }

            return View("Index");
        }

        public async Task<IActionResult> Users()
        {
            QueryResponse<User> response = await userService.GetAll();

            if (!response.Success)
            {
                return View();
            }

            List<UserQueryViewModel> data = mapper.Map<List<UserQueryViewModel>>(response.Data);
            return View(data);
        }

        public async Task<IActionResult> GetDailyNeeds(double calories, double proteins, double carbohydrates, double fats, DateTime age)
        {
            User user = new User();
            //user.CalculateDailyNeeds();
            return View();
        }
        [AllowAnonymous]
        [HttpGet]
        public async Task<IActionResult> GetFoodOfCategory(int id)
        {
            QueryResponse<Food> queryFood = await foodService.GetByCategoryId(id);
            return Json(queryFood.Data.ToList());
        }

        
    }
}
