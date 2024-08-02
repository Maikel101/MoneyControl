using Money.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Money.Modelos
{
    public class Ingreso
    {
        public int IdIngreso { get; set; }
        public string Fecha { get; set; }
        public string IdTipoIngreso { get; set; }
        public decimal Monto { get; set; }
        public string Descripcion { get; set; }

        public static bool Agregar(Ingreso ingreso, bool Editar)
        {
            List<Parametro> parametro = new List<Parametro>
            {

            };
        }
    }
}
