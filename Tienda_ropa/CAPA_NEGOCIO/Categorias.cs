using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CAPA_DATOS;

namespace CAPA_NEGOCIO
{
    public class Categorias
    {
        private string TableName = "Categorias";

        public int Id_categoria { get; set; }
        public string Categoria { get; set; }
        public string Descripcion { get; set; }
        public int Estado { get; set; }


        public Object Save(Categorias Inst)
        {
            try
            {
                SqlADOConexion.IniciarConexion("sa", "1234");
                if (Inst.Id_categoria == -1)
                {
                    return SqlADOConexion.SQLM.InserObject(TableName, Inst);
                }
                else
                {
                    return SqlADOConexion.SQLM.UpdateObject(TableName, Inst, "Id_categoria");
                }

            }
            catch (Exception)
            {

                throw;
            }

        }
        public Object Get(Categorias Inst)
        {
            try
            {
                SqlADOConexion.IniciarConexion("sa", "1234");
                return SqlADOConexion.SQLM.TakeList(TableName, Inst, null);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
