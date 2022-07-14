using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CAPA_DATOS;

namespace CAPA_NEGOCIO
{
    public class Articulos
    {
            private string TableName = "Articulos";

            public int Id_articulo { get; set; }
            public int Id_categoria { get; set; }
            public string Nombre { get; set; }
            public string Descripcion { get; set; }
            public int Estado { get; set; }
            public int Id_promocion { get; set; }


            public Object Save(Articulos Inst)
            {
                try
                {
                    SqlADOConexion.IniciarConexion("sa", "1234");
                    if (Inst.Id_articulo == -1)
                    {
                        return SqlADOConexion.SQLM.InserObject(TableName, Inst);
                    }
                    else
                    {
                        return SqlADOConexion.SQLM.UpdateObject(TableName, Inst, "Id_articulo");
                    }

                }
                catch (Exception)
                {

                    throw;
                }

            }
            public Object Get(Articulos Inst)
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
