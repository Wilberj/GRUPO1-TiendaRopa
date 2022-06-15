using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CAPA_DATOS;

namespace Capa_Negocio
{
    public class Material
    {
        public string TableName = "TMateriales";
        public int id_material { get; set; }
        public string material { get; set; }
        public string descipcion { get; set; }
        public bool estado { get; set; }

        public object save(Material inst)
        {
            try
            {
                SqlADOConexion.IniciarConexion("sa", "1234");


                if (inst.id_material == -1)
                {
                    return SqlADOConexion.SQLM.InserObject(TableName, inst);

                }
                else
                {
                    return SqlADOConexion.SQLM.UpdateObject(TableName, inst, "id-material");
                }

            }
            catch (Exception e)
            {
                throw;
            }
        }

        public object delete(Material inst)
        {
            try
            {

                SqlADOConexion.IniciarConexion("sa", "1234");
                if (inst.id_material < 0)
                {

                    throw new Exception("Favor identifique del id-material");

                }
                else
                {

                    return SqlADOConexion.SQLM.DeleteObject(TableName,"id-material", inst);

                }




            }

            catch (Exception e)
            {
                throw;
            }
        }


        public object TakeList(Material inst)
        {
            try
            {
                SqlADOConexion.IniciarConexion("sa", "1234");
                return SqlADOConexion.SQLM.TakeList(TableName, inst.id_material, null);


            }
            catch (Exception e)
            {
                throw;
            }
        }


        public void actualizar_material(int id_material)
        {

        }
        public void buscar_material(int id_material)
        {

        }

        public void actualizar_descripcion(int id_material)
        {

        }

        public void mostrar_materiales()
        {

        }

        public void cambiar_estado(int id_material)
        {

        }


    }

    }

