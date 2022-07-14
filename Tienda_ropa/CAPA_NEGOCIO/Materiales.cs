using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CAPA_DATOS;

namespace CAPA_NEGOCIO
{
    public class Materiales
    {
       private string TableName = "Materiales";
        public int Id_material { get; set; }
        public string Material { get; set; }
        public string Descripcion { get; set; }
        public int Estado { get; set; }

        public Object Save(Materiales inst)
        {
            try
            {
                SqlADOConexion.IniciarConexion("sa", "1234");


                if (inst.Id_material == -1)
                {
                    return SqlADOConexion.SQLM.InserObject(TableName, inst);

                }
                else
                {
                    return SqlADOConexion.SQLM.UpdateObject(TableName, inst, "Id_material");
                }

            }
            catch (Exception e)
            {
                throw;
            }
        }

        public object Delete(Materiales inst)
        {
            try
            {

                SqlADOConexion.IniciarConexion("sa", "1234");
                if (inst.Id_material < 0)
                {

                    throw new Exception("Favor identifique del Id_material");

                }
                else
                {

                    return SqlADOConexion.SQLM.DeleteObject(TableName,"Id_material", inst);

                }




            }

            catch (Exception e)
            {
                throw;
            }
        }


        public Object Get(Materiales inst)
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


        //public void actualizar_material(int id_material)
        //{

        //}
        //public void buscar_material(int id_material)
        //{

        //}

        //public void actualizar_descripcion(int id_material)
        //{

        //}

        //public void mostrar_materiales()
        //{

        //}

        //public void cambiar_estado(int id_material)
        //{

        //}


    }

    }

