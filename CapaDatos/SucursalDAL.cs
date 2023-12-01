using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class SucursalDAL : CadenaDAL
    {

        public List<SucursalCLS> filtrarSucursal(string nombresucursal)
        {
            List<SucursalCLS> lista = null;
            using (SqlConnection db = new SqlConnection(cadena))
            {
                try
                {
                    db.Open();
                    using (SqlCommand cmd = new SqlCommand("uspFiltrarSucursal", db))
                    {
                        // le indico que es un procedure
                        cmd.CommandType = CommandType.StoredProcedure;
                        // Esta linea define un parámetro
                        cmd.Parameters.AddWithValue("@nombresucursal", nombresucursal==null? "" : nombresucursal);
                        SqlDataReader drd = cmd.ExecuteReader(CommandBehavior.SingleResult);
                        if (drd != null)
                        {
                            lista = new List<SucursalCLS>();

                            int postId = drd.GetOrdinal("IIDSUCURSAL");
                            int postNombre = drd.GetOrdinal("NOMBRE");
                            int postDireccion = drd.GetOrdinal("DIRECCION");

                            SucursalCLS oSucursalCLS;
                            while (drd.Read())
                            {
                                oSucursalCLS = new SucursalCLS();
                                oSucursalCLS.iidsucursal = drd.IsDBNull(postId) ? 0 : drd.GetInt32(postId);
                                oSucursalCLS.nombre = drd.IsDBNull(postNombre) ? "" : drd.GetString(postNombre);
                                oSucursalCLS.direccion = drd.IsDBNull(postDireccion) ? "" : drd.GetString(postDireccion);
                                lista.Add(oSucursalCLS);
                            }
                            db.Close();
                        }
                    }

                }
                catch (Exception ex)
                {
                    db.Close();
                    lista = null;
                }
            }
            return lista;
        }


        public List<SucursalCLS> listarSucursal()
        {
            List<SucursalCLS> lista = null;
            using (SqlConnection db = new SqlConnection(cadena))
            {
                try
                {
                    db.Open();
                    using (SqlCommand cmd=new SqlCommand("uspListarSucursal", db))
                    {
                        // le indico que es un procedure
                        cmd.CommandType = CommandType.StoredProcedure;
                        SqlDataReader drd = cmd.ExecuteReader(CommandBehavior.SingleResult);
                        if (drd != null )
                        {
                            lista = new List<SucursalCLS>();

                            int postId = drd.GetOrdinal("IIDSUCURSAL");
                            int postNombre = drd.GetOrdinal("NOMBRE");
                            int postDireccion = drd.GetOrdinal("DIRECCION");

                            SucursalCLS oSucursalCLS;
                            while (drd.Read())
                            {
                                oSucursalCLS = new SucursalCLS();
                                oSucursalCLS.iidsucursal = drd.IsDBNull(postId) ? 0 : drd.GetInt32(postId);
                                oSucursalCLS.nombre = drd.IsDBNull(postNombre) ? "" : drd.GetString(postNombre);
                                oSucursalCLS.direccion = drd.IsDBNull(postDireccion) ? "" : drd.GetString(postDireccion);
                                lista.Add(oSucursalCLS);
                            }
                            db.Close();
                        }
                    }

                } catch(Exception ex)
                {
                    db.Close();
                    lista = null;
                }
            }
            return lista;
        }
        
    }
}
