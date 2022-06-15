using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CAPA_DATOS;

namespace Capa_Negocio
{
   
   public class Diseños
    {
    public string TableName = "TDiseño";
    public int id_diseño { get; set; }
    public string diseño { get; set; }
    public string descripcion { get; set; }
    public bool estado { get; set; }


        public object save(Diseños inst)
        {
            try
            {
                SqlADOConexion.IniciarConexion("sa", "1234");


                if (inst.id_diseño == -1)
                {
                    return SqlADOConexion.SQLM.InserObject(TableName, inst);

                }
                else
                {
                    return SqlADOConexion.SQLM.UpdateObject(TableName, inst, "id_diseño");
                }

            }
            catch (Exception e)
            {
                throw;
            }
        }

        public object delete(Diseños inst)
        {
            try
            {

                SqlADOConexion.IniciarConexion("sa", "1234");
                if (inst.id_diseño < 0)
                {

                    throw new Exception("Favor identifique del id-diseño ");

                }
                else
                {

                    return SqlADOConexion.SQLM.DeleteObject(TableName, "id_diseño" , inst);

                }




            }

            catch (Exception e)
            {
                throw;
            }
        }


        public object TakeList(Diseños inst)
        {
            try
            {
                SqlADOConexion.IniciarConexion("sa", "1234");
                return SqlADOConexion.SQLM.TakeList(TableName, inst.id_diseño, null);


            }
            catch (Exception e)
            {
                throw;
            }
        }


        public void buscar_diseños(int id_diseño)
        {



        }

        public void cambiar_estado(int id_diseño)
        {



        }

        public void mostrar_deseños() 
        {
        
        }

        public void actualizar_diseño(int id_diseño)
        {

        }

        public void cambiar_descripcion(int id_diseño)
        {

        }



}
}
