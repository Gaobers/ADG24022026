using Microsoft.AspNetCore.Mvc;

namespace ADG24022026.AppMVC.Controllers
{
    public class MultiplicacionController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(double numero1, double numero2)
        {
            double resultado = numero1 * numero2;
            ViewBag.Resultado = resultado;
            return View();
        }
    }
}
