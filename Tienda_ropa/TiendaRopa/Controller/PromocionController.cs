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
    public class PromocionController : ControllerBase
    {

        #region Promociones

        [HttpPost]
        public object SavePromociones(object ObjInst)
        {
            Promociones Inst = JsonConvert.DeserializeObject<Promociones>(ObjInst.ToString());
            Inst.Save(Inst);
            return true;
        }
        [HttpGet]
        public object GetPromociones()
        {
            Promociones Inst = new Promociones();
            return Inst.Get(Inst);
        }
        #endregion


    }
}
