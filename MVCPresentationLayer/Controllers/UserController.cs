using AutoMapper;
using BusinessLogicalLayer;
using Common;
using Entities;
using Microsoft.AspNetCore.Mvc;
using MVCPresentationLayer.Models.InsertModels;
using MVCPresentationLayer.Models.UpdateModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCPresentationLayer.Controllers
{
    public class UserController : Controller
    {

        private readonly IMapper mapper;

        public UserController(IMapper mapper)
        {
            this.mapper = mapper;
        }

        public async Task<IActionResult> Index()
        {
            return View();
        }


        public async Task<IActionResult> Insert()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Insert(UserInsertViewModel model)
        {
            UserBLL userBLL = new UserBLL();

            User user = mapper.Map<User>(model);
            user.SetStatus(true);

            Response response = await userBLL.Insert(user);

            return View();
        }

        public IActionResult Update()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Update(UserUpdateViewModel model)
        {
            UserBLL userBLL = new UserBLL();

            User user = mapper.Map<User>(model);

            Response response = await userBLL.Update(user);

            return View();
        }

        /*
        public IActionResult Users()
        {
            return View();
        }

        public IActionResult Users()
        {
            QueryResponse<User> users = new QueryResponse<User>();
        }
        */
    }
}
