using Microsoft.AspNetCore.Mvc;

namespace Mvc.Controllers{
    public class PrestamoController : Controller{
        public IActionResult Index(){
            return View();
        }
        public IActionResult Prestamo(){
            return View();
        }
        public IActionResult Renovar(){
            return View();
        }
    }
}