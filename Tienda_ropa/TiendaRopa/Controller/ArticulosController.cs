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
            List<Object> Response = new List<object>();

            Articulos CC = new Articulos();
            Response.Add(CC.Get(CC));
            Categorias CP = new Categorias();
            Response.Add(CP.Get(CP));
            Promociones PP = new Promociones();
            Response.Add(PP.Get(PP));
           
            return Response;
        }
        #endregion

    }
}
