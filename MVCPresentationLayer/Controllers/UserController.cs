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
        UserBLL userBLL = new UserBLL();

        public UserController(IMapper mapper, IUserService userService)
        {
            this.mapper = mapper;
            this.userService = userService;
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
        public async Task<IActionResult> Insert(UserInsertViewModel model)
        {
            User user = mapper.Map<User>(model);
            user.SetStatus(true);

            Response response = await userService.Insert(user);

            return View();
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
    }
}
