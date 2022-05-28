using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CAPA_DATOS;

namespace Capa_Negocio
{
    internal class Estilos
    {
        public string TableName = "Testilo";
        int id_estilos { get; set; }
        string Estilo { get; set; }
        string descripcion { get; set; }
        bool estado { get; set; }

        public object save(Estilos inst)
        {
            try
            {
                SqlADOConexion.IniciarConexion("sa", "1234");


                if (inst.id_estilos == -1)
                {
                    return SqlADOConexion.SQLM.InsertObject(TableName, inst);

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


    }
}
