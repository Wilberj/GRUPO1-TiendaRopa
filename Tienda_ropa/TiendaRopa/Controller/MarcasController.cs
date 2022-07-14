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
    public class MarcasController : ControllerBase
    {
        #region Marcas

        [HttpPost]
        public object SaveMarcas(object ObjIns)
        {
            Marcas Ins = JsonConvert.DeserializeObject<Marcas>(ObjIns.ToString());
            Ins.Save(Ins);
            return true;
        }
        [HttpGet]
        public object GetMarcas()
        {
            Marcas Ins = new Marcas();
            return Ins.Get(Ins);
        }
        #endregion
    }
}
