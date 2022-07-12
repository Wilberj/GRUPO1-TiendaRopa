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
    public class EstilosController : ControllerBase
    {

        #region Estilos

        [HttpPost]
        public object SaveEstilos(object ObjIns)
        {
            Estilos Ins = JsonConvert.DeserializeObject<Estilos>(ObjIns.ToString());
            Ins.Save(Ins);
            return true;
        }
        [HttpGet]
        public object GetEstilos()
        {
            Estilos Ins = new Estilos();
            return Ins.Get(Ins);
        }
        #endregion


    }
}
