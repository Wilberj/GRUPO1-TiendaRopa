using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CAPA_DATOS;

namespace CAPA_NEGOCIO
{
    public class Estilos
    {
        private string TableName = "Estilos";
        public int Id_estilos { get; set; }
        public string Estilo { get; set; }
        public string Descripcion { get; set; }
        public int Estado { get; set; }

        public Object Save(Estilos inst)
        {
            try
            {
                SqlADOConexion.IniciarConexion("sa", "1234");


                if (inst.Id_estilos == -1)
                {
                    return SqlADOConexion.SQLM.InserObject(TableName, inst);

                }
                else
                {
                    return SqlADOConexion.SQLM.UpdateObject(TableName, inst, "Id_estilos");
                }

            }
            catch (Exception e)
            {
                throw;
            }
        }


        public Object Get(Estilos inst)
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



        public Object Delete( Estilos inst)
        {
            try
            {

                SqlADOConexion.IniciarConexion("sa", "1234");
                if (inst.Id_estilos < 0)
                {

                    throw new Exception("Favor identifique del Id_estilos ");

                }
                else
                {

                    return SqlADOConexion.SQLM.DeleteObject(TableName, "Id_estilos", inst);

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
