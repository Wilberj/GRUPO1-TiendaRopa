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
    public class ColorController : ControllerBase
    {
        #region Colores

        [HttpPost]
        public Object SaveColores(object ObjIns)
        {
            Colores Ins = JsonConvert.DeserializeObject<Colores>(ObjIns.ToString());
            Ins.Save(Ins);
            return true;
        }
        [HttpGet]
        public object GetColores()
        {
            Colores Ins = new Colores();
            return Ins.Get(Ins);
        }
        #endregion
    }
}
