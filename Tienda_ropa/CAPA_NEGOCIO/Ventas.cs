using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CAPA_DATOS;
namespace CAPA_NEGOCIO
{
    public class Ventas
    {


        private  string TableName="Ventas";

        public int Id_ventas { get; set; }

        public string Cliente { get; set; }

        public string Fecha { get; set; }

        public int  Descuento { get; set; }

        public int Iva { get; set; }

        public int   Subtotal { get; set; }

        public int Total { get; set; }

       




        public Object Save(Ventas Ins)
        {
            try
            {
                SqlADOConexion.IniciarConexion("sa", "1234");
                if (Ins.Id_ventas == -1)
                {
                    return SqlADOConexion.SQLM.InserObject(TableName, Ins);
                }
                else
                {
                    return SqlADOConexion.SQLM.UpdateObject(TableName, Ins, "Id_ventas");
                }

            }
            catch (Exception)
            {

                throw;
            }

        }
        public Object Get(Ventas Ins)
        {
            try
            {
                SqlADOConexion.IniciarConexion("sa", "1234");
                return SqlADOConexion.SQLM.TakeList(TableName, Ins, null);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }


}

