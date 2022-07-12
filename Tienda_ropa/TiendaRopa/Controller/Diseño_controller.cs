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
    public class Diseño_Controller : ControllerBase
    {

        #region Diseños

        [HttpPost]
        public object SaveDiseños(object ObjIns)
        {
            Diseños Ins = JsonConvert.DeserializeObject<Diseños>(ObjIns.ToString());
            Ins.Save(Ins);
            return true;
        }
        [HttpGet]
        public object GetDiseños()
        {
            Diseños Ins = new Diseños();
            return Ins.Get(Ins);
        }
        #endregion


    }
}
