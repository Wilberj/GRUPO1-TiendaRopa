using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CAPA_DATOS;

namespace CAPA_NEGOCIO
{
    public class Promociones
    {
        private string TableName = "Promociones";
        public int Id_promocion { get; set; }
        public string Promocion { get; set; }

        public string Fecha_inicio { get; set; }

        public string Fecha_final {get; set; }

        public int Descuento { get; set; }
        public string Descripcion { get; set; }
        public int Estado { get; set; }


        public Object Save(Promociones Inst)
        {
            try
            {
                SqlADOConexion.IniciarConexion("sa", "1234");
                if (Inst.Id_promocion == -1)
                {
                    return SqlADOConexion.SQLM.InserObject(TableName, Inst);
                }
                else
                {
                    return SqlADOConexion.SQLM.UpdateObject(TableName, Inst, "Id_promocion");
                }

            }
            catch (Exception)
            {

                throw;
            }

        }
        public Object Get(Promociones Inst)
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
