using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CAPA_DATOS;

namespace Capa_Negocio
{
    internal class Tallas
    {
        public string TableName="T_tallas";
        int id_talla { get; set; }
        string talla { get; set; }
        bool estado{ get; set; }
        string descipcion { get; set; }


             public object save(Tallas inst)
        {
            try
            {
                SqlADOConexion.IniciarConexion("sa", "1234");


                if (inst.id_talla == -1)
                {
                    return SqlADOConexion.SQLM.InsertObject(TableName, inst);

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


    }
}
