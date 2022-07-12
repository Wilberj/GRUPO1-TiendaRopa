using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CAPA_NEGOCIO;
using Newtonsoft.Json;

namespace TiendaRopa.Controller
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ProveedorController : ControllerBase
    {

        #region Estilos

        [HttpPost]
        public Object SaveProveedores(object ObjIns)
        {
            Proveedores Ins = JsonConvert.DeserializeObject<Proveedores>(ObjIns.ToString());
            Ins.Save(Ins);
            return true;
        }
        [HttpGet]
        public Object GetProveedores()
        {
            Proveedores Ins = new Proveedores();
            return Ins.Get(Ins);
        }
        #endregion


    }
}
