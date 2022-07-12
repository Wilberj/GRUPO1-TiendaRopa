using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CAPA_NEGOCIO;
using Newtonsoft.Json;

namespace TiendaRopa.Pages.Catalogos
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class BodegasController : ControllerBase
    {

        #region Bodegas

        [HttpPost]
        public Object SaveBodegas(object ObjIns)
        {
            Bodegas Ins = JsonConvert.DeserializeObject<Bodegas>(ObjIns.ToString());
            Ins.Save(Ins);
            return true;
        }
        [HttpGet]
        public object GetBodegas()
        {
            Bodegas Ins = new Bodegas();
            return Ins.Get(Ins);
        }
        #endregion

    }
}
