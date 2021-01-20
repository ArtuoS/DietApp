using AutoMapper;
using BusinessLogicalLayer;
using Common;
using Entities;
using Microsoft.AspNetCore.Mvc;
using MVCPresentationLayer.Models.InsertModels;
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

        public IActionResult Index()
        {
            return View();
        }


        public IActionResult Insert()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Insert(UserInsertViewModel model)
        {
            UserBLL userBLL = new UserBLL();

            User user = mapper.Map<User>(model);

            user.SetStatus(true);
            Response response = userBLL.Insert(user);

            return View();
        }
    }
}
