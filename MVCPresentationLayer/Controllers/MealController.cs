using AutoMapper;
using Common;
using Entities;
using Entities.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Hosting;
using MVCPresentationLayer.Models.InsertModels;
using MVCPresentationLayer.Models.QueryModels;
using MVCPresentationLayer.Models.UpdateModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace MVCPresentationLayer.Controllers
{
    public class MealController : Controller
    {
        private readonly IMapper mapper;
        private readonly IMealService mealService;
        private readonly IHostEnvironment environment;
        private readonly IFoodService foodService;
        private readonly IFood_CategoryService foodCategoryService;


        public MealController(IMapper mapper, IMealService mealService, IHostEnvironment environment, IFood_CategoryService foodCategoryService, IFoodService foodService)
        {
            this.environment = environment;
            this.mapper = mapper;
            this.mealService = mealService;
            this.foodCategoryService = foodCategoryService;
            this.foodService = foodService;
        }

        public IActionResult Index()
        {
            return View();
        }

        [AllowAnonymous]
        public async Task<IActionResult> Insert()
        {

            QueryResponse<FoodCategory> categories = await foodCategoryService.GetAll();
            QueryResponse<Food> foods = await foodService.GetAll();
            QueryResponse<Meal> meals = await mealService.GetAll();

            ViewBag.Path = environment.ContentRootPath + "//wwwroot//img//refeicao//";
            ViewBag.Categories = categories.Data;
            ViewBag.Foods = foods.Data;
            ViewBag.Meals = meals.Data;

            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Insert(MealInsertViewModel model)
        {
            Meal meal = mapper.Map<Meal>(model);

            string[] qtds = Request.Form["qtds"].ToString().Split(",");
            string[] foods = Request.Form["foods"].ToString().Split(",");
            for (int i = 0; i < qtds.Length; i++)
            {
                FoodAmountPerMeal foodAmountPerMeal = new FoodAmountPerMeal()
                {
                    FoodID = Convert.ToInt32(foods[i]),
                    Quantity = Convert.ToDouble(qtds[i])
                };
                meal.Foods.Add(foodAmountPerMeal);
            }



            //meal.SetStatus(true);

            SingleResponse<int> response = await mealService.Insert(meal);

            if (!response.Success)
            {
                ViewBag.Errors = response.Message;
                return View();
            }

            //Validar formatos válidos de imagem
            //verifica qual o tipo de arquivo : jpg, gif, png, pdf ou tmp
            var archieve = model.Image;
            string archievePath = environment.ContentRootPath + "//wwwroot//img//refeicao//";
            string extension = "";
            if (model.Image.FileName.Contains(".jpg"))
                extension += ".jpg";
            else if (archieve.FileName.Contains(".gif"))
                extension += ".gif";
            else if (archieve.FileName.Contains(".png"))
                extension += ".png";
            else if (archieve.FileName.Contains(".pdf"))
                extension += ".pdf";
            else if (archieve.FileName.Contains(".jpeg"))
                extension += ".jpeg";
            else
                extension += ".tmp";

            string urlFinal = archievePath + response.Data + extension;
            // monta o caminho onde vamos salvar o arquivo : 
            // ~\wwwroot\Arquivos\Arquivos_Usuario\Recebidos
            //copia o arquivo para o local de destino original
            using (var stream = new FileStream(urlFinal, FileMode.Create))
            {
                await archieve.CopyToAsync(stream);
            }

            return await Insert();
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

        [HttpGet]
        public async Task<IActionResult> GetFoodById(int id)
        {
            SingleResponse<Food> queryFood = await foodService.GetById(id);
            return Json(queryFood.Data);
        }
        [HttpGet]
        public async Task<IActionResult> GetById(int id)
        {
            SingleResponse<Meal> querymeal = await mealService.GetById(id);
            return Json(querymeal.Data);
        }

        [AllowAnonymous]
        [HttpGet]
        public async Task<IActionResult> GetFoodOfCategory(int id)
        {
            QueryResponse<Food> queryFood = await foodService.GetByCategoryId(id);
            return Json(queryFood.Data.ToList());
        }

        [HttpGet]
        public async Task<IActionResult> GetMealFoodsById(int id)
        {
            QueryResponse<FoodAmountPerMeal> queryFood = await mealService.GetMealFoodsById(id);

            return Json(queryFood.Data.ToList());
        }
    }
}
