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
    public class ArticulosController : ControllerBase
    {

        #region Articulos

        [HttpPost]
        public Object SaveArticulos(object ObjIns)
        {
            Articulos Ins = JsonConvert.DeserializeObject<Articulos>(ObjIns.ToString());
            Ins.Save(Ins);
            return true;
        }
        [HttpGet]
        public object GetArticulos()
        {
            Articulos Ins = new Articulos();
            return Ins.Get(Ins);
        }
        #endregion

    }
}
