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
    public class ValueController : ControllerBase
    {
        #region Categorias
        [HttpPost]
        public object SaveCategory(object ObjIns)
        {
            Categorias Ins = JsonConvert.DeserializeObject<Categorias>(ObjIns.ToString());
            Ins.Save(Ins);
            return true;
        }
        [HttpGet]
        public object GetCategories()
        {
            Categorias Ins = new Categorias();
            return Ins.Get(Ins);
        }
        #endregion

        

        


        

        #region Materiales

        [HttpPost]
        public object SaveMateriales(object ObjIns)
        {
           Materiales Ins = JsonConvert.DeserializeObject<Materiales>(ObjIns.ToString());
            Ins.Save(Ins);
            return true;
        }
        [HttpGet]
        public object GetMateriales()
        {
            Materiales Ins = new Materiales();
            return Ins.Get(Ins);
        }
        #endregion

        


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

        #region Prooveedores

        [HttpPost]
        public object SaveProoveedores(object ObjIns)
        {
            Proveedores Ins = JsonConvert.DeserializeObject<Proveedores>(ObjIns.ToString());
            Ins.Save(Ins);
            return true;
        }
        [HttpGet]
        public object GetProveedores()
        {
            Proveedores Ins = new Proveedores();
            return Ins.Get(Ins);
        }
        #endregion

     


    }
}
