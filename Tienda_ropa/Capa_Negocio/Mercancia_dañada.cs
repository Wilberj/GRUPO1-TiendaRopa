using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CAPA_DATOS;

namespace Capa_Negocio
{
    public class Mercancia_dañada
    {
        public string TableName = "T_mercancia_dañada";
        public int id_mercancia_dañada { get; set; }
        public int id_usuario { get; set; }
        public DateTime fecha { get; set; }
        public int id_articulo { get; set; }
        public int cantidad { get; set; }
        public string daños { get; set; }
        public bool estado { get; set; }
        public string descripcion { get; set; }






        public object save(Mercancia_dañada inst)
        {
            try
            {
                SqlADOConexion.IniciarConexion("sa", "1234");


                if (inst.id_mercancia_dañada == -1)
                {
                    return SqlADOConexion.SQLM.InserObject(TableName, inst);

                }
                else
                {
                    return SqlADOConexion.SQLM.UpdateObject(TableName, inst, "id-mercancia_dañada");
                }

            }
            catch (Exception e)
            {
                throw;
            }
        }



        public object delete(Mercancia_dañada inst)
        {
            try
            {

                SqlADOConexion.IniciarConexion("sa", "1234");
                if (inst.id_mercancia_dañada < 0)
                {

                    throw new Exception("Favor identifique del id_mercancia dañada");

                }
                else
                {

                    return SqlADOConexion.SQLM.DeleteObject(TableName, "id_mercancia_dañada", inst.id_mercancia_dañada);

                }




            }

            catch (Exception e)
            {
                throw;
            }
        }


        public void actualizar_mercancia_dañada(int id_mercancia_dañada)
        {

        }
        public void buscar_mercancia_dañada(int id_mecancia_dañada)
        {

        }

        public void actualizar_descripcion(int id_mecancia_dañada)
        {

        }

        public void mostrar_mercancia_dañada()
        {

        }

        public void cambiar_estado(int id_mecancia_dañada)
        {

        }






    }

}
