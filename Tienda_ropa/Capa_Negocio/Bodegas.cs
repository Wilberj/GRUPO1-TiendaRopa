using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CAPA_DATOS;

namespace CAPA_NEGOCIO
{
    public class Bodegas
    {
        private string TableName = "Bodega";
        public int Id_bodega { get; set; }
        public string Nombre_bodega { get; set; }
        public string Descripcion { get; set; }
        public int Estado { get; set; }

        public Object Save(Bodegas inst)
        {
            try
            {
                SqlADOConexion.IniciarConexion("sa", "1234");


                if (inst.Id_bodega == -1)
                {
                    return SqlADOConexion.SQLM.InserObject(TableName, inst);

                }
                else
                {
                    return SqlADOConexion.SQLM.UpdateObject(TableName, inst, "Id_bodega");
                }

            }  
            catch (Exception e)
            {
                throw;
            }
        }

        public object Delete(Bodegas inst)
        {
            try
            {

                SqlADOConexion.IniciarConexion("sa", "1234");
                if (inst.Id_bodega < 0)
                {

                    throw new Exception("Favor identifique del Id_bodega");

                }
                else
                {

                    return SqlADOConexion.SQLM.DeleteObject(TableName, "Id_bodega", inst);

                }




            }

            catch (Exception e)
            {
                throw;
            }
        }


        public Object Get(Bodegas inst)
        {
            try
            {
                SqlADOConexion.IniciarConexion("sa", "1234");
                return SqlADOConexion.SQLM.TakeList(TableName, inst, null);


            }
            catch (Exception e)
            {
                throw;
            }
        }
    }
}
