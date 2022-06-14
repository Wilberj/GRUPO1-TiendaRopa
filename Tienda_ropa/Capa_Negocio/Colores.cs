using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CAPA_DATOS;


namespace Capa_Negocio
{
    public class Colores
    {
       public string TableName = "TColor";
       public int id_color { get; set; }
       public string color { get; set; }
       public string descripcion { get; set; }
       public bool estado { get; set; }




        public object insertar(Colores inst)
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
                    return SqlADOConexion.SQLM.UpdateObject(TableName, inst, "id-color");
                }

            }
            catch (Exception e)
            {
                throw;
            }
        }

        public object delete( Colores inst)
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

                    return SqlADOConexion.SQLM.DeleteObject(TableName, "id-colores", inst);

                }




            }

            catch (Exception e)
            {
                throw;
            }
        }

        public void bucar_color(int id_color)
        {

        

        }

        public void mostrar_colores()
        {



        }


        public void cambiar_estado(int id_color)
        {


        }


        public void cambiar_descripcion(int id_color)
        {


         
        }

        public void actualizar_color(int id_color)
        {



        }





}


   
}
