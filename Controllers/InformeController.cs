using Microsoft.AspNetCore.Mvc;

namespace Mvc.Controllers{
    public class InformeController : Controller{
        public IActionResult Index(){
            return View();
        }
    }
}