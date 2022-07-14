using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CAPA_DATOS;

namespace CAPA_NEGOCIO
{
   
   public class Diseños
    {
    public string TableName = "Diseño";
    public int Id_diseño { get; set; }
    public string Diseño { get; set; }
    public string Descripcion { get; set; }
    public int Estado { get; set; }


        public Object Save(Diseños inst)
        {
            try
            {
                SqlADOConexion.IniciarConexion("sa", "1234");


                if (inst.Id_diseño == -1)
                {
                    return SqlADOConexion.SQLM.InserObject(TableName, inst);

                }
                else
                {
                    return SqlADOConexion.SQLM.UpdateObject(TableName, inst, "Id_diseño");
                }

            }
            catch (Exception e)
            {
                throw;
            }
        }

        public Object Delete(Diseños inst)
        {
            try
            {

                SqlADOConexion.IniciarConexion("sa", "1234");
                if (inst.Id_diseño < 0)
                {

                    throw new Exception("Favor identifique del Id_diseño ");

                }
                else
                {

                    return SqlADOConexion.SQLM.DeleteObject(TableName, "Id_diseño" , inst);

                }




            }

            catch (Exception e)
            {
                throw;
            }
        }


        public Object Get(Diseños inst)
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
