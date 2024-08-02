using Money.Clases;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Money.Modelos
{
    public class TipoIngreso
    {
        public int IdTipoIngreso { get; set; }
        public string Denominacion { get; set; }

        public static bool Guardar(TipoIngreso tipoIngreso, bool editar)
        {
            List<Parametro> parametros = new List<Parametro>
            {
                new Parametro("@Denominacion", tipoIngreso.Denominacion),
                new Parametro("@IdTipoIngreso", tipoIngreso.IdTipoIngreso),
                new Parametro("@Editar", editar)
            };

           return DBDatos.Ejecutar("TipoIngreso_Agregar", parametros);
        }

        public static DataTable Listar()
        {
           return DBDatos.Listar("TipoIngreso_Listar");
        }
    }
}
