using CapaEntidad;
using System.Collections.Generic;
using System.ComponentModel;

namespace CapaDatos
{
    public class TipoMedicamentoDAL
    {
        public List<TipoMedicamentoCLS> listarMedicamentos()
        {
            List<TipoMedicamentoCLS> lista = new List<TipoMedicamentoCLS>();
            lista.Add(new TipoMedicamentoCLS { 
                idTipomedicamento=1,
                nombre="Jona", 
                descripcion="Des 1"
            });
            lista.Add(new TipoMedicamentoCLS
            {
                idTipomedicamento = 2,
                nombre = "Maru",
                descripcion = "Des 2"
            });
            lista.Add(new TipoMedicamentoCLS
            {
                idTipomedicamento = 3,
                nombre = "Ali",
                descripcion = "Des 3"
            });
            return lista;
        }

    }
}
