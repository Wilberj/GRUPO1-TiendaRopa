using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CAPA_DATOS;

namespace Capa_Negocio
{
   
    internal class Diseños
    {
        public string TableName = "Diseño";
    int id_diseño { get; set; }
    string diseño { get; set; }
    string descripcion { get; set; }
    bool estado { get; set; }


        public object save(Diseños inst)
        {
            try
            {
                SqlADOConexion.IniciarConexion("sa", "1234");


                if (inst.id_diseño == -1)
                {
                    return SqlADOConexion.SQLM.InsertObject(TableName, inst);

                }
                else
                {
                    return SqlADOConexion.SQLM.UpdateObject(TableName, inst, "id_diseño");
                }

            }
            catch (Exception e)
            {
                throw;
            }
        }



    }
}
