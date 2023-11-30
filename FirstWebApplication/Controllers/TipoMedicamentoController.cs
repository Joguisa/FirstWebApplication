using Microsoft.AspNetCore.Mvc;
using CapaEntidad;
using CapaNegocio;

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

        public List<TipoMedicamentoCLS> listarTipoMedicamento()
        {
            TipoMedicamentoBL obj = new TipoMedicamentoBL();
            return obj.listarMedicamentos();
        }

    }
}
