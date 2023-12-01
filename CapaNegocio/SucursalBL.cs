using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class SucursalBL
    {
        public List<SucursalCLS> listarSucursal()
        {
            SucursalDAL obj = new SucursalDAL();
            return obj.listarSucursal();
        }

        public List<SucursalCLS> filtrarSucursal(string nombresucursal)
        {
            SucursalDAL obj = new SucursalDAL();
            return obj.filtrarSucursal(nombresucursal);
        }
    }
}
