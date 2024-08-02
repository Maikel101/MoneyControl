using Money.Clases;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Money.Modelos
{
    public class TipoGasto
    {
        public int IdTipoGasto { get; set; }
        public string Denominacion { get; set; }

        public static bool Guardar(TipoGasto tipoGasto, bool editar)
        {
            List<Parametro> parametros = new List<Parametro>
            {
                new Parametro("@Denominacion", tipoGasto.Denominacion),
                new Parametro("@IdTipoGasto", tipoGasto.IdTipoGasto),
                new Parametro("@Editar", editar)
            };

           return DBDatos.Ejecutar("TipoGasto_Agregar", parametros);
        }

        public static DataTable Listar()
        {
            return DBDatos.Listar("TipoGasto_Listar");
        }
    }
}
