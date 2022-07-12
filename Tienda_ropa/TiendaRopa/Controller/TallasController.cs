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
    public class TallasController : ControllerBase
    {

        #region Tallas

        [HttpPost]
        public Object SaveTallas(Object ObjIns)
        {
            Tallas Ins = JsonConvert.DeserializeObject<Tallas>(ObjIns.ToString());
            Ins.Save(Ins);
            return true;
        }
        [HttpGet]
        public Object GetTallas()
        {
            Tallas Ins = new Tallas();
            return Ins.Get(Ins);
        }
        #endregion


    }
}
