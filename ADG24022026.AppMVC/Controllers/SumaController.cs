using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ADG24022026.AppMVC.Controllers
{
    using Microsoft.AspNetCore.Mvc;

    namespace ADG24022026.Controllers
    {
        public class SumaController : Controller
        {
            // Muestra el formulario al cargar la página
            public IActionResult Index()
            {
                return View();
            }

            // Recibe los números y realiza la suma
            [HttpPost]
            public IActionResult Index(double num1, double num2)
            {
                double resultado = num1 + num2;
                ViewBag.Resultado = resultado; // Enviamos el dato a la vista
                return View();
            }
        }
    }


}
    