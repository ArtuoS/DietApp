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
        public async Task<IActionResult> GenareteDiet(int id)
        {
            SingleResponse<Diet> responseGenaration = await dietService.GenareteDiet(id);
            Response responseInsert = await dietService.Insert(responseGenaration.Data);
            if (responseInsert.Success)
            {
                return Json(responseGenaration.Data);

            }
            return Json(null);

        }

    }
}
