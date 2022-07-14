using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CAPA_DATOS;

namespace CAPA_NEGOCIO
{
    public class Proveedores
    {

    private string TableName = "Proveedores";
    public int Id_proveedor { get; set; }
    public string Nombre { get; set; }
    public string Dirreccion { get; set; }
    public int Telefono { get; set; }
    public string Correo { get; set; }
    public string Descripcion { get; set; }
    public int Estado { get; set; }


        public Object Save(Proveedores Inst)
        {
            try
            {
                SqlADOConexion.IniciarConexion("sa", "1234");


                if (Inst.Id_proveedor == -1)
                {
                    return SqlADOConexion.SQLM.InserObject(TableName, Inst);

                }
                else
                {
                    return SqlADOConexion.SQLM.UpdateObject(TableName, Inst, "Id_proveedor");
                }

            }
            catch (Exception e)
            {
                throw;
            }
        }
        public Object Delete(Proveedores Inst)
        {
            try
            {

                SqlADOConexion.IniciarConexion("sa", "1234");
                if (Inst.Id_proveedor < 0)
                {

                    throw new Exception("Favor identifique del Id_proveedor");

                }
                else
                {

                    return SqlADOConexion.SQLM.DeleteObject(TableName, "Id_proveedor", Inst);

                }




            }

            catch (Exception e)
            {
                throw;
            }
        }


        public Object Get(Proveedores Inst)
        {
            try
            {
                SqlADOConexion.IniciarConexion("sa", "1234");
                return SqlADOConexion.SQLM.TakeList(TableName, Inst, null);


            }
            catch (Exception e)
            {
                throw;
            }
        }



        
        


    }
}
