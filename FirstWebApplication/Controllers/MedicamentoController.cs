using Microsoft.AspNetCore.Mvc;

namespace FirstWebApplication.Controllers
{
    public class MedicamentoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        

    }
}
