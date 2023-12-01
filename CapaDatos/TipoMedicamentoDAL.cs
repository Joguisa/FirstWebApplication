using CapaEntidad;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq.Expressions;

namespace CapaDatos
{
    public class TipoMedicamentoDAL : CadenaDAL
    {
        public List<TipoMedicamentoCLS> listarMedicamentos()
        {
            List<TipoMedicamentoCLS> lista = null;

            using (SqlConnection db = new SqlConnection(cadena))
            {
                try
                {
                    db.Open();
                    using(SqlCommand cmd = new SqlCommand("select IIDTIPOMEDICAMENTO, DESCRIPCION, NOMBRE from TipoMedicamento where BHABILITADO=1", db)) 
                    {
                        cmd.CommandType = CommandType.Text;
                        SqlDataReader drd = cmd.ExecuteReader(CommandBehavior.SingleResult); // con esto le digo solo guarda memoria para un select
                        if (drd != null)
                        {
                            TipoMedicamentoCLS oTipoMedicamentoCLS;
                            lista = new List<TipoMedicamentoCLS>();
                            int postId = drd.GetOrdinal("IIDTIPOMEDICAMENTO");
                            int postNombre = drd.GetOrdinal("NOMBRE");
                            int postDescripcion = drd.GetOrdinal("DESCRIPCION");
                            while (drd.Read())
                            {
                                oTipoMedicamentoCLS=new TipoMedicamentoCLS();
                                oTipoMedicamentoCLS.idTipomedicamento = drd.IsDBNull(postId) ? 0 : drd.GetInt32(postId);
                                oTipoMedicamentoCLS.nombre = drd.IsDBNull(postNombre) ? "" : drd.GetString(postNombre);
                                oTipoMedicamentoCLS.descripcion = drd.IsDBNull(postDescripcion) ? "" : drd.GetString(postDescripcion);
                                lista.Add(oTipoMedicamentoCLS);
                            }
                            db.Close();
                        }
                    }
                }
                catch(Exception ex)
                {
                    db.Close();
                    lista = null;
                }
            }
            return lista;
        }
    }
}

