using Microsoft.AspNetCore.Mvc;

namespace FirstWebApplication.Controllers
{
    public class TipoMedicamentoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Inicio()
        {
            return View();
        }
       
        public IActionResult SinMenu()
        {
            return View();
        }

    }
}
