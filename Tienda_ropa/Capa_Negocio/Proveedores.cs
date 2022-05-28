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

    public string TableName = "Tproveedores";
    int id_proveedor { get; set; }
    string proveedor { get; set; }
    string Descripcion { get; set; }
    string correo { get; set; }
    string dirreccion { get; set; }
    int telefono { get; set; }
    bool estado { get; set; }


        public object save(Proveedores inst)
        {
            try
            {
                SqlADOConexion.IniciarConexion("sa", "1234");


                if (inst.id_proveedor == -1)
                {
                    return SqlADOConexion.SQLM.InsertObject(TableName, inst);

                }
                else
                {
                    return SqlADOConexion.SQLM.UpdateObject(TableName, inst, "id-proveedor");
                }

            }
            catch (Exception e)
            {
                throw;
            }
        }





    }
}
