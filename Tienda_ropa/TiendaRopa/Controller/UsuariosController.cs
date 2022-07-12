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
    public class UsuariosController : ControllerBase
    {

        #region Usuarios

        [HttpPost]
        public Object SaveUsuarios(object ObjIns)
        {
            Usuarios Ins = JsonConvert.DeserializeObject<Usuarios>(ObjIns.ToString());
            Ins.Save(Ins);
            return true;
        }
        [HttpGet]
        public object GetUsuarios()
        {
            Usuarios Ins = new Usuarios();
            return Ins.Get(Ins);
        }
        #endregion


    }
}
