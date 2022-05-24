using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CAPA_DATOS;

namespace Capa_Negocio
{
    internal class Proveedores
    {
    int id_proveedor { get; set; }
    string proveedor { get; set; }
    string Descripcion { get; set; }
    string correo { get; set; }
    string dirreccion { get; set; }
    int telefono { get; set; }
    bool estado { get; set; }

    }
}
