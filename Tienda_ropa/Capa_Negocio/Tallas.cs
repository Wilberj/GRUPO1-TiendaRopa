using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CAPA_DATOS;

namespace Capa_Negocio
{
    public class Tallas
    {
        public string TableName="T_tallas";
        public int id_talla { get; set; }
        public string talla { get; set; }
        public bool estado{ get; set; }
        public string descipcion { get; set; }


        public object save(Tallas inst)
        {
            try
            {
                SqlADOConexion.IniciarConexion("sa", "1234");


                if (inst.id_talla == -1)
                {
                    return SqlADOConexion.SQLM.InserObject(TableName, inst);

                }
                else
                {
                    return SqlADOConexion.SQLM.UpdateObject(TableName, inst, "id-talla");
                }

            }
            catch (Exception e)
            {
                throw;
            }
        }


        public object delete(Tallas  inst)
        {
            try
            {

                SqlADOConexion.IniciarConexion("sa", "1234");
                if (inst.id_talla < 0)
                {

                    throw new Exception("Favor identifique del id-talla ");

                }
                else
                {

                    return SqlADOConexion.SQLM.DeleteObject(TableName, "id-talla", inst);

                }




            }

            catch (Exception e)
            {
                throw;
            }
        }


        public object TakeList(Tallas inst)
        {
            try
            {
                SqlADOConexion.IniciarConexion("sa", "1234");
                return SqlADOConexion.SQLM.TakeList(TableName, inst.id_talla, null);


            }
            catch (Exception e)
            {
                throw;
            }
        }


        public void actualizar_mercancia_dañada(int id_tallas)
        {

        }
        public void buscar_tallas(int id_tallas)
        {

        }

        public void actualizar_descripcion(int id_tallas)
        {

        }

        public void mostrar_tallas()
        {

        }

        public void cambiar_estado(int id_tallas)
        {

        }

    }
}
