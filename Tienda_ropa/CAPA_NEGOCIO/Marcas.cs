using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CAPA_DATOS;

namespace CAPA_NEGOCIO
{
    public class Marcas
    {
        private string TableName = "Marcas";
        public int Id_marca { get; set; }
        public string Marca { get; set; }
        public string Descripcion { get; set; }
        public int Estado { get; set; }



        public Object Save(Marcas inst)
        {
            try
            {
                SqlADOConexion.IniciarConexion("sa", "1234");


                if (inst.Id_marca == -1)
                {
                    return SqlADOConexion.SQLM.InserObject(TableName, inst);

                }
                else
                {
                    return SqlADOConexion.SQLM.UpdateObject(TableName, inst, "Id_marca");
                }

            }
            catch (Exception e)
            {
                throw;
            }
        }

        public Object Delete(Marcas inst)
        {
            try
            {

                SqlADOConexion.IniciarConexion("sa", "1234");
                if (inst.Id_marca < 0)
                {

                    throw new Exception("Favor identifique del id-marcas ");

                }
                else
                {

                    return SqlADOConexion.SQLM.DeleteObject(TableName, "Id_marcas", inst);

                }




            }

            catch (Exception e)
            {
                throw;
            }
        }


        public Object Get(Marcas inst)
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


        public void actualizar_marca(int id_marcas)
        {

        }
        //    public void buscar_marcas(int id_marcas)
        //    {

        //    }

        //    public void actualizar_descripcion(int id_marcas)
        //    {

        //    }

        //    public void mostrar_marcas()
        //    {

        //    }

        //    public void cambiar_estado(int id_marcas)
        //    {

        //    }


        //}
    }
}

