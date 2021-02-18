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
        private readonly IMapper mapper;

        public DietController(IDietService dietService, IMapper mapper)
        {
            this.dietService = dietService;
            this.mapper = mapper;
        }
        [HttpGet]
        public async Task<IActionResult> GetByDate(string date)
        {
            DateTime formatedDate = DateTime.ParseExact(date.Replace('"', ' ').Replace(" ", ""), "dd/MM/yyyy", null);
            SingleResponse<Diet> response = await dietService.GetByDate(formatedDate);
            return Json(response.Data);
        }
        [HttpGet]
        public async Task<IActionResult> GenareteDiet(string date, string id)
        {
            DateTime data = DateTime.ParseExact(date.Replace('"', ' ').Replace(" ", ""), "dd/MM/yyyy", null);
            SingleResponse<Diet> responseGenaration = await dietService.GenareteDiet(Convert.ToInt32(id), data);
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

    }
    /*
    public class MyClass
    {
        public string date { get; set; }
        public int id { get; set; }

    }
    */
}
