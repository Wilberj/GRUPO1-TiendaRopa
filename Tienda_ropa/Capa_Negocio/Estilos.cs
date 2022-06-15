using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CAPA_DATOS;

namespace Capa_Negocio
{
    public class Estilos
    {
        public string TableName = "Testilo";
        public int id_estilos { get; set; }
        public string Estilo { get; set; }
        public string descripcion { get; set; }
        public bool estado { get; set; }

        public object save(Estilos inst)
        {
            try
            {
                SqlADOConexion.IniciarConexion("sa", "1234");


                if (inst.id_estilos == -1)
                {
                    return SqlADOConexion.SQLM.InserObject(TableName, inst);

                }
                else
                {
                    return SqlADOConexion.SQLM.UpdateObject(TableName, inst, "id-estilos");
                }

            }
            catch (Exception e)
            {
                throw;
            }
        }


        public object TakeList(Estilos inst)
        {
            try
            {
                SqlADOConexion.IniciarConexion("sa", "1234");
                return SqlADOConexion.SQLM.TakeList(TableName, inst.id_estilos, null);


            }
            catch (Exception e)
            {
                throw;
            }
        }



        public object delete( Estilos inst)
        {
            try
            {

                SqlADOConexion.IniciarConexion("sa", "1234");
                if (inst.id_estilos < 0)
                {

                    throw new Exception("Favor identifique del id-estilos ");

                }
                else
                {

                    return SqlADOConexion.SQLM.DeleteObject(TableName, "id-estilos", inst);

                }




            }

            catch (Exception e)
            {
                throw;
            }
        }


        public void actualizar_cestilos(int id_estilos)
        {

        }
        public void buscar_estilos(int id_estilos)
        {

        }

        public void actualizar_descripcion(int id_estilos)
        {

        }

        public void mostrar_estilos( )
        {

        }

        public void cambiar_estado(Estilos inst)
        {

        }


    }
}
