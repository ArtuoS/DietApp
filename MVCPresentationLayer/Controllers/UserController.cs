using AutoMapper;
using BusinessLogicalLayer;
using Common;
using Entities;
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
    public class UserController : Controller
    {

        private readonly IMapper mapper;
        private readonly UserBLL userBLL;

        public UserController(IMapper mapper, UserBLL userBLL)
        {
            this.mapper = mapper;
            this.userBLL = userBLL;
        }

        public IActionResult Index()
        {
            return View();
        }


        public IActionResult Insert()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Insert(UserInsertViewModel model)
        {
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
            User user = mapper.Map<User>(model);

            Response response = await userBLL.Update(user);

            return View();
        }

        public async Task<IActionResult> Users()
        {
            QueryResponse<User> response = await userBLL.GetAll();

            if (!response.Success)
            {
                return View();
            }

            List<UserQueryViewModel> data = mapper.Map<List<UserQueryViewModel>>(response.Data);
            return View(data);
        }
    }
}
