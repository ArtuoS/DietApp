using AutoMapper;
using Common;
using Entities;
using Entities.Interfaces;
using Microsoft.AspNetCore.Mvc;
using MVCPresentationLayer.Models.InsertModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCPresentationLayer.Controllers
{
    public class RestrictionController : Controller
    {
        private readonly IMapper mapper;
        private readonly IRestrictionService restrictionService;

        public RestrictionController(IMapper mapper, IRestrictionService restrictionService)
        {
            this.mapper = mapper;
            this.restrictionService = restrictionService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> Insert()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Insert(RestrictionInsertViewModel model)
        {
            Restriction restriction = mapper.Map<Restriction>(model);

            Response response = await restrictionService.Insert(restriction);

            return View();
        }
    }
}
