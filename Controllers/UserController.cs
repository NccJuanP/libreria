using Microsoft.AspNetCore.Mvc;

namespace Mvc.Controllers{
    public class UserController: Controller{
        public IActionResult Index(){
            return View();
        }
        public IActionResult Create(){
            return View();
        }

        public IActionResult Edit(){
            return View();
        }
    }
}