using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CAPA_DATOS;

namespace CAPA_NEGOCIO
{
    public class Tallas
    {
        private string TableName = "Tallas";
        public int Id_talla { get; set; }
        public string Talla { get; set; }
        public string Descripcion { get; set; }
        public int Estado{ get; set; }
      


        public Object Save(Tallas Inst)
        {
            try
            {
                SqlADOConexion.IniciarConexion("sa", "1234");


                if (Inst.Id_talla == -1)
                {
                    return SqlADOConexion.SQLM.InserObject(TableName, Inst);

                }
                else
                {
                    return SqlADOConexion.SQLM.UpdateObject(TableName, Inst, "Id_talla");
                }

            }
            catch (Exception )
            {
                throw;
            }
        }


        public Object Delete(Tallas  Inst)
        {
            try
            {

                SqlADOConexion.IniciarConexion("sa", "1234");
                if (Inst.Id_talla < 0)
                {

                    throw new Exception("Favor identifique del Id_talla ");

                }
                else
                {

                    return SqlADOConexion.SQLM.DeleteObject(TableName, "Id_talla", Inst);

                }




            }

            catch (Exception e)
            {
                throw;
            }
        }


        public Object Get(Tallas Inst)
        {
            try
            {
                SqlADOConexion.IniciarConexion("sa", "1234");
                return SqlADOConexion.SQLM.TakeList(TableName, Inst, null);


            }
            catch (Exception e)
            {
                throw;
            }
        }


        //public void actualizar_mercancia_dañada(int id_tallas)
        //{

        //}
        //public void buscar_tallas(int id_tallas)
        //{

        //}

        //public void actualizar_descripcion(int id_tallas)
        //{

        //}

        //public void mostrar_tallas()
        //{

        //}

        //public void cambiar_estado(int id_tallas)
        //{

        //}

    }
}
