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
    public class MaterialesController : ControllerBase
    {

        #region Materiales

        [HttpPost]
        public Object SaveMateriales(object ObjIns)
        {
            Materiales Ins = JsonConvert.DeserializeObject<Materiales>(ObjIns.ToString());
            Ins.Save(Ins);
            return true;
        }
        [HttpGet]
        public Object GetMateriales()
        {
            Materiales Ins = new Materiales();
            return Ins.Get(Ins);
        }
        #endregion

    }
}
