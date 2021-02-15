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

        public async Task<IActionResult> Insert(DietInsertViewModel model)
        {
            Diet diet = mapper.Map<Diet>(model);

            Response response = await dietService.Insert(diet);

            return View();
        }

    }
}
