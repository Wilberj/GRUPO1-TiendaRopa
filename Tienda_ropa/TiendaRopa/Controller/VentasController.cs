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
    public class VentasController : ControllerBase
    {

        #region Ventas

        [HttpPost]
        public Object SaveVentas(object ObjInst)
        {
            Ventas Ins = JsonConvert.DeserializeObject<Ventas>(ObjInst.ToString());
            Ins.Save(Ins);
            return true;
        }
        [HttpGet]
        public object GetVentas()
        {
            Ventas Inst = new Ventas();
            return Inst.Get(Inst);
        }
        #endregion


    }
}
