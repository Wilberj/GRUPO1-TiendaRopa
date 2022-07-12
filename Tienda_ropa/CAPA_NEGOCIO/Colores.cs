using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CAPA_DATOS;
namespace CAPA_NEGOCIO
{
    public class Colores
    {
       private string TableName = "Colores";
       public int id_color { get; set; }
       public string Color { get; set; }

        public int Estado { get; set; }
        public string descripcion { get; set; }
       




        public Object Save(Colores inst)
        {
            try
            {
                SqlADOConexion.IniciarConexion("sa", "1234");


                if (inst.id_color == -1)
                {
                    return SqlADOConexion.SQLM.InserObject(TableName, inst);

                }
                else
                {
                    return SqlADOConexion.SQLM.UpdateObject(TableName, inst, "id_color");
                }

            }
            catch (Exception e)
            {
                throw;
            }
        }

        public Object Delete( Colores inst)
        {
            try
            {

                SqlADOConexion.IniciarConexion("sa", "1234");
                if (inst.id_color < 0)
                {

                    throw new Exception("Favor identifique del id-colores");

                }
                else
                {

                    return SqlADOConexion.SQLM.DeleteObject(TableName, "id-color", inst);

                }




            }

            catch (Exception e)
            {
                throw;
            }
        }

        public Object Get(Colores inst)
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
