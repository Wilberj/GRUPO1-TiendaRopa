using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CAPA_DATOS;

namespace Capa_Negocio
{
    public class Proveedores
    {

    public string TableName = "Tproveedores";
    public int id_proveedor { get; set; }
    public string proveedor { get; set; }
    public  string Descripcion { get; set; }
    public string correo { get; set; }
    public string dirreccion { get; set; }
    public int telefono { get; set; }
    public bool estado { get; set; }


        public object save(Proveedores inst)
        {
            try
            {
                SqlADOConexion.IniciarConexion("sa", "1234");


                if (inst.id_proveedor == -1)
                {
                    return SqlADOConexion.SQLM.InserObject(TableName, inst);

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
        public object delete(Proveedores inst)
        {
            try
            {

                SqlADOConexion.IniciarConexion("sa", "1234");
                if (inst.id_proveedor < 0)
                {

                    throw new Exception("Favor identifique del ");

                }
                else
                {

                    return SqlADOConexion.SQLM.DeleteObject(TableName, "id-proveedor", inst);

                }




            }

            catch (Exception e)
            {
                throw;
            }
        }

        public void actualizar_proveedores(int id_proveedor)
        {

        }
        public void buscar_proveedores(int id_proveedor)
        {

        }

        public void actualizar_descripcion(int id_proveedor)
        {

        }

        public void mostrar_proveedores()
        {

        }

        public void cambiar_estado(int id_proveedor)
        {

        }



    }
}
