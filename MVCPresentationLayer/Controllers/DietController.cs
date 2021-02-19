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

namespace MVCPresentationLayer.Controllers
{
    public class DietController : Controller
    {
        private readonly IDietService dietService;
        private readonly IMealService mealService;
        private readonly IFoodService foodService;
        private readonly IMapper mapper;

        public DietController(IDietService dietService, IMapper mapper, IMealService mealService, IFoodService foodService)
        {
            this.dietService = dietService;
            this.mealService = mealService;
            this.foodService = foodService;
            this.mapper = mapper;
        }
        [HttpGet]
        public async Task<IActionResult> GetByDate(string date)
        {
            DateTime formatedDate = DateTime.ParseExact(date.Replace('"', ' ').Replace(" ", ""), "dd/MM/yyyy", null);
            SingleResponse<Diet> response = await dietService.GetByDate(formatedDate);
            if (response.Data != null)
            {
                List<int> mealsids = new List<int>();
                foreach (Meal meal in response.Data.Meals)
                {
                    mealsids.Add(meal.ID);
                }

                return Json(mealsids);

            }
            return Json(null);
        }
        [HttpGet]
        public async Task<IActionResult> GenerateDiet(string date, string id)
        {
            DateTime data = DateTime.ParseExact(date.Replace('"', ' ').Replace(" ", ""), "dd/MM/yyyy", null);
            SingleResponse<Diet> responseGenaration = await dietService.GenerateDiet(Convert.ToInt32(id), data);
            Response responseInsert = await dietService.Insert(responseGenaration.Data);
            if (responseInsert.Success)
            {
                List<int> mealsids = new List<int>();
                foreach (Meal meal in responseGenaration.Data.Meals)
                {
                    mealsids.Add(meal.ID);
                }

                return Json(mealsids);

            }
            return Json(null);
        }

        [HttpGet]
        public async Task<IActionResult> GetFoodsDataByMealId(int id)
        {
            List<Food> foods = new List<Food>();
            QueryResponse<FoodAmountPerMeal> Mealfoods = await mealService.GetMealFoodsById(id);
            foreach (FoodAmountPerMeal item in Mealfoods.Data)
            {
                SingleResponse<Food> foodAmountfoods = await foodService.GetById(item.FoodID);
                foodAmountfoods.Data.Alcohol = foodAmountfoods.Data.Alcohol * item.Quantity;
                foodAmountfoods.Data.Calories = foodAmountfoods.Data.Calories * item.Quantity;
                foodAmountfoods.Data.Carbohydrate = foodAmountfoods.Data.Carbohydrate * item.Quantity;
                foodAmountfoods.Data.Copper = foodAmountfoods.Data.Copper * item.Quantity;
                foodAmountfoods.Data.Fiber = foodAmountfoods.Data.Fiber * item.Quantity;
                foodAmountfoods.Data.Lipid = foodAmountfoods.Data.Lipid * item.Quantity;
                foodAmountfoods.Data.Magnesium = foodAmountfoods.Data.Magnesium * item.Quantity;
                foodAmountfoods.Data.Phosphor = foodAmountfoods.Data.Phosphor * item.Quantity;
                foodAmountfoods.Data.Potassium = foodAmountfoods.Data.Potassium * item.Quantity;
                foodAmountfoods.Data.Protein = foodAmountfoods.Data.Protein * item.Quantity;
                foodAmountfoods.Data.Selenium = foodAmountfoods.Data.Selenium * item.Quantity;
                foodAmountfoods.Data.Sodium = foodAmountfoods.Data.Sodium * item.Quantity;
                foodAmountfoods.Data.Vitamin_A = foodAmountfoods.Data.Vitamin_A * item.Quantity;
                foodAmountfoods.Data.Vitamin_B12 = foodAmountfoods.Data.Vitamin_B12 * item.Quantity;
                foodAmountfoods.Data.Vitamin_C = foodAmountfoods.Data.Vitamin_C * item.Quantity;
                foodAmountfoods.Data.Vitamin_D = foodAmountfoods.Data.Vitamin_D * item.Quantity;
                foodAmountfoods.Data.Vitamin_E = foodAmountfoods.Data.Vitamin_E * item.Quantity;
                foodAmountfoods.Data.Zinc = foodAmountfoods.Data.Zinc * item.Quantity;
                foods.Add(foodAmountfoods.Data);
            }
            Food foodsTotalData = new Food();
            foodsTotalData.Alcohol = foods.Sum(c => c.Alcohol);
            foodsTotalData.Calories = foods.Sum(c => c.Calories);
            foodsTotalData.Carbohydrate = foods.Sum(c => c.Carbohydrate);
            foodsTotalData.Copper = foods.Sum(c => c.Copper);
            foodsTotalData.Fiber = foods.Sum(c => c.Fiber);
            foodsTotalData.Lipid = foods.Sum(c => c.Lipid);
            foodsTotalData.Magnesium = foods.Sum(c => c.Magnesium);
            foodsTotalData.Phosphor = foods.Sum(c => c.Phosphor);
            foodsTotalData.Potassium = foods.Sum(c => c.Potassium);
            foodsTotalData.Protein = foods.Sum(c => c.Protein);
            foodsTotalData.Selenium = foods.Sum(c => c.Selenium);
            foodsTotalData.Sodium = foods.Sum(c => c.Sodium);
            foodsTotalData.Vitamin_A = foods.Sum(c => c.Vitamin_A);
            foodsTotalData.Vitamin_B12 = foods.Sum(c => c.Vitamin_B12);
            foodsTotalData.Vitamin_B6 = foods.Sum(c => c.Vitamin_B6);
            foodsTotalData.Vitamin_C = foods.Sum(c => c.Vitamin_C);
            foodsTotalData.Vitamin_D = foods.Sum(c => c.Vitamin_D);
            foodsTotalData.Vitamin_E = foods.Sum(c => c.Vitamin_E);
            foodsTotalData.Zinc = foods.Sum(c => c.Zinc);

            return Json(foodsTotalData);

        }
    }
}
