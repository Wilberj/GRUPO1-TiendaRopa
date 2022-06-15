using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CAPA_DATOS;


namespace Capa_Negocio
{
    public class Categorias
    {
        public string TableName = "Tcategorias";

        public int id_categoria;
        public string Categoria;
        public bool estado;
        public string descripcion;


        public object save(Categorias inst)
        {
            try
            {
                SqlADOConexion.IniciarConexion("sa", "1234");


                if (inst.id_categoria == -1)
                {
                    return SqlADOConexion.SQLM.InserObject(TableName, inst);

                }
                else
                {
                    return SqlADOConexion.SQLM.UpdateObject(TableName, inst, "id-categoria");
                }

            }
            catch (Exception e)
            {
                throw;
            }
        }



        public object delete(Categorias inst)
        {
            try
            {

                SqlADOConexion.IniciarConexion("sa", "1234");
                if (inst.id_categoria < 0)
                {

                    throw new Exception("Favor identifique del id_categoria");

                }
                else
                {

                    return SqlADOConexion.SQLM.DeleteObject(TableName,"id_categoria", inst.id_categoria);

                }




            }

            catch (Exception e)
            {
                throw;
            }
        }


        public object TakeList(Categorias inst)
        {
            try
            {
                SqlADOConexion.IniciarConexion("sa", "1234");
                return SqlADOConexion.SQLM.TakeList(TableName, inst.id_categoria, null);


            }
            catch (Exception e)
            {
                throw;
            }
        }


        public void actualizar_categoria(int id_categoria) 
        {
        
        }
        public void buscar_categorias(int id_categoria)
        {

        }

        public void actualizar_descripcion(int id_categoria)
        { 

        }

        public void mostrar_categorias()
        {

        }

        public void cambiar_estado(int id_categoria)
        {

        }








}
}

