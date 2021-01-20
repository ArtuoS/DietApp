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
            if (!ModelState.IsValid)
            {

            }
            else
            {
                UserBLL userBLL = new UserBLL();

                var configuration = new MapperConfiguration(cfg =>
                {
                    cfg.CreateMap<UserInsertViewModel, User>();
                });

                var mapper = configuration.CreateMapper();
                User user = mapper.Map<User>(model);

                Response response = userBLL.Insert(user);
            }

            return View();
        }
    }
}
