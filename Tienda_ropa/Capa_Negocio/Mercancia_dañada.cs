using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CAPA_DATOS;

namespace Capa_Negocio
{
    internal class Mercancia_dañada
    {
    int id_mercancia_dañada { get; set; }
    int id_usuario { get; set; }
    DateTime fecha { get; set; }
    int id_articulo { get; set; }
    int cantidad { get; set; }
    string daños { get; set; }
    bool estado { get; set; }
    string descripcion { get; set; }
    }
}
