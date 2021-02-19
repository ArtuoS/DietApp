using Common;
using Entities;
using Entities.Enums;
using Entities.Interfaces;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MVCPresentationLayer.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace MVCPresentationLayer.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IUserService _userService;

        public HomeController(ILogger<HomeController> logger, IUserService service)
        {
            _logger = logger;
            _userService = service;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(string email, string senha)
        {
            SingleResponse<User> response = await _userService.Authenticate(email, senha);

            if (!response.Success)
            {
                ViewBag.Erros = "Usuario e/ou senha inválidos.";
                return View();
            }

            var userClaims = new List<Claim>()
                {
                    new Claim(ClaimTypes.Name, response.Data.First_Name),
                    new Claim(ClaimTypes.Email, email),
                    new Claim(ClaimTypes.Role, response.Data.Role),
                    new Claim(type: "Daily_Calories", value: response.Data.Daily_Calories.ToString()),
                    new Claim(type: "Role", value: response.Data.Role.ToString()),
                    new Claim(type: "ID", value: response.Data.ID.ToString()),
                    new Claim(type: "Daily_Carbohydrates", value: response.Data.Daily_Carbohydrates.ToString()),
                    new Claim(type: "Daily_Fats", value: response.Data.Daily_Fats.ToString()),
                    new Claim(type: "Daily_Protein", value: response.Data.Daily_Protein.ToString()),
                    new Claim(type: "User_Weight_Progress", value: (response.Data.Weight - response.Data.Weight_Objective).ToString()),
                    new Claim(type: "Weight", value: response.Data.Weight.ToString()),
                    new Claim(type: "BodyFat", value: response.Data.BodyFat.ToString()),
                    new Claim(type: "Height", value: response.Data.Height.ToString()),
                    new Claim(type: "Email", value: response.Data.Email.ToString()),
                    new Claim(type: "Weight_Objective", value: response.Data.Weight_Objective.ToString()),
                    new Claim(type: "Objective", value: Enum.GetName(typeof(Objective), response.Data.Objective).Replace('_',' ')),
                    new Claim(type: "Days_To_Reach_Goal", value: response.Data.Days_To_Reach_Goal.ToString()),
                    new Claim(type: "Last_Name", value: response.Data.Last_Name.ToString())
                };

            var myIdentity = new ClaimsIdentity(userClaims, "Usuario");
            var userPrincipal = new ClaimsPrincipal(new[] { myIdentity });

            await HttpContext.SignInAsync(userPrincipal);

            return RedirectToAction("Index", "User");
        }


        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
