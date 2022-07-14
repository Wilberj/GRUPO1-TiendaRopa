using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CAPA_DATOS;
namespace CAPA_NEGOCIO
{
    public class Detalles_Ventas
    {
        private string TableName = "Detalles_venta";
        public int Id_detalles_venta { get; set; }

        public int Id_ventas { get; set; }

        public int Id_articulo { get; set; }

        public int Id_marca { get; set; }

        public int Id_color { get; set; }

        public int Id_estilo { get; set; }

        public int Id_material { get; set; }

        public int Id_talla { get; set; }

        public int Id_diseño { get; set; }

        public int Cantidad { get; set; }

        public int Precio { get; set; }

        public double Subtotal {get; set;}

        public double Iva { get; set; }

        public double Descuento { get; set; }


        public Object Save(Detalles_Ventas Inst)
        {
            try
            {
                SqlADOConexion.IniciarConexion("sa", "1234");
                if (Inst.Id_detalles_venta == -1)
                {
                    return SqlADOConexion.SQLM.InserObject(TableName, Inst);
                }
                else
                {
                    return SqlADOConexion.SQLM.UpdateObject(TableName, Inst, "Id_detalles_venta");
                }

            }
            catch (Exception)
            {

                throw;
            }

        }
        public Object Get(Detalles_Ventas Inst)
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
