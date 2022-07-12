using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CAPA_DATOS;

namespace CAPA_NEGOCIO
{
    public class Usuarios
    {

        private string TableName = "Usuarios";

        public int Id_usuario { get; set; }
        public string  Nombre { get; set; }
        public string Correo { get; set; }
        public string Contraseña { get; set; }
     
        public int Telefono { get; set; }

        public int Estado { get; set; }


        public Object Save(Usuarios Inst)
        {
            try
            {
                SqlADOConexion.IniciarConexion("sa", "1234");
                if (Inst.Id_usuario == -1)
                {
                    return SqlADOConexion.SQLM.InserObject(TableName, Inst);
                }
                else
                {
                    return SqlADOConexion.SQLM.UpdateObject(TableName, Inst, "Id_usuario");
                }

            }
            catch (Exception)
            {

                throw;
            }

        }
        public Object Get(Usuarios Inst)
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

