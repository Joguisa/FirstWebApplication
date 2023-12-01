using CapaEntidad;
using CapaNegocio;
using Microsoft.AspNetCore.Mvc;

namespace FirstWebApplication.Controllers
{
    public class SucursalController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        // Crearé un método que se comunique con la capa de negocio
        public List<SucursalCLS> listarSucursal()
        {
            SucursalBL obj = new SucursalBL();
            return obj.listarSucursal();
        }
    }
}
