using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CAPA_DATOS;

namespace Capa_Negocio
{
    public class Marcas
    {
        public string TableName = "Tmarca";
        int id_marca { get; set; }
        string marca { get; set; }
        string descripcion { get; set; }
        bool estado { get; set; }



        public object save(Marcas inst)
        {
            try
            {
                SqlADOConexion.IniciarConexion("sa", "1234");


                if (inst.id_marca == -1)
                {
                    return SqlADOConexion.SQLM.InsertObject(TableName, inst);

                }
                else
                {
                    return SqlADOConexion.SQLM.UpdateObject(TableName, inst, "id-marca");
                }

            }
            catch (Exception e)
            {
                throw;
            }
        }




    }
}
