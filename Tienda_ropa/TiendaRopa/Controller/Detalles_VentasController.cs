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
    public class Detalles_VentasController : ControllerBase
    {
        #region Detalles_Ventas

        [HttpPost]
        public Object SaveDetalles_Ventas(object ObjIns)
        {
            Detalles_Ventas Ins = JsonConvert.DeserializeObject<Detalles_Ventas>(ObjIns.ToString());
            Ins.Save(Ins);
            return true;
        }
        [HttpGet]
        public object GetDetalles_Ventas()
        {
            Detalles_Ventas Ins = new Detalles_Ventas();
            return Ins.Get(Ins);
        }
        #endregion



    }
}
