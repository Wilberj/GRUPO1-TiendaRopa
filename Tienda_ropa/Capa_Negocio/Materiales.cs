using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CAPA_DATOS;

namespace Capa_Negocio
{
    internal class Material
    {
        public string TableName = "TMateriales";
        int id_material { get; set; }
        string material { get; set; }
        string descipcion { get; set; }
        bool estado { get; set; }

        public object save(Material inst)
        {
            try
            {
                SqlADOConexion.IniciarConexion("sa", "1234");


                if (inst.id_material == -1)
                {
                    return SqlADOConexion.SQLM.InsertObject(TableName, inst);

                }
                else
                {
                    return SqlADOConexion.SQLM.UpdateObject(TableName, inst, "id-material");
                }

            }
            catch (Exception e)
            {
                throw;
            }
        }

    }

    }

