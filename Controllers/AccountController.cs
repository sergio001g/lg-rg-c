using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using LoginApp.Models;

namespace LoginApp.Controllers
{
    public class AccountController : Controller
    {
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                // Aquí iría la lógica de autenticación real
                if (model.Email == "usuario@ejemplo.com" && model.Password == "password")
                {
                    return RedirectToAction("Index", "Home");
                }
                
                ModelState.AddModelError("", "Credenciales inválidas");
            }
            
            return View(model);
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(RegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                // Aquí iría la lógica de registro real
                return RedirectToAction("Login");
            }
            
            return View(model);
        }
    }
}