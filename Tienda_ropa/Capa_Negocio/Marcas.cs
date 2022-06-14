using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CAPA_DATOS;

namespace Capa_Negocio
{
    public class Marcas
    {
        public string TableName = "TMarca";
        public int id_marca { get; set; }
        public string marca { get; set; }
        public string descripcion { get; set; }
        public bool estado { get; set; }



        public object save(Marcas inst)
        {
            try
            {
                SqlADOConexion.IniciarConexion("sa", "1234");


                if (inst.id_marca == -1)
                {
                    return SqlADOConexion.SQLM.InserObject(TableName, inst);

                }
                else
                {
                    return SqlADOConexion.SQLM.UpdateObject(TableName, inst, "id-marca");
                }

            }
            catch (Exception e)
            {
                throw;
            }
        }

        public object delete(Marcas inst)
        {
            try
            {

                SqlADOConexion.IniciarConexion("sa", "1234");
                if (inst.id_marca < 0)
                {

                    throw new Exception("Favor identifique del id-marcas ");

                }
                else
                {

                    return SqlADOConexion.SQLM.DeleteObject(TableName, "id-marcas", inst);

                }




            }

            catch (Exception e)
            {
                throw;
            }
        }


        public void actualizar_marca(int id_marcas)
        {

        }
        public void buscar_marcas(int id_marcas)
        {

        }

        public void actualizar_descripcion(int id_marcas)
        {

        }

        public void mostrar_marcas()
        {

        }

        public void cambiar_estado(int id_marcas)
        {

        }


    }
}
