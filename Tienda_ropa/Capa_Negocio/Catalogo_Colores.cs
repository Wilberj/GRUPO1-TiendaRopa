using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CAPA_DATOS;


namespace Capa_Negocio
{
    internal class Catalogo_Colores
    {
       public string TableName = "Tcolor";
       int id_color { get; set; }
       string color { get; set; }
       string descripcion { get; set; }
       bool estado { get; set; }




        public object save(Catalogo_Colores inst)
        {
            try
            {
                SqlADOConexion.IniciarConexion("sa", "1234");


                if (inst.id_color == -1)
                {
                    return SqlADOConexion.SQLM.InsertObject(TableName, inst);

                }
                else
                {
                    return SqlADOConexion.SQLM.UpdateObject(TableName, inst, "id-color");
                }

            }
            catch (Exception e)
            {
                throw;
            }
        }


    }


   
}
