using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Ejercicio_4___API.Controllers
{
    public class ClienteController : ApiController
    {
        // GET cliente/getAll/
        [Route("cliente/getAll/{id?}")]//ruta personalizada para el ejercicio, get
        public IEnumerable<string> Get()
        {
            //codigo para listar
            return new string[] { "value1", "value2" };
        }

        // GET cliente/get/5
        [Route("cliente/get/{id}")]//ruta personalizada para el ejercicio, get
        public string Get(int id)
        {
            //codigo obtener
            return "value";
        }

        // POST /cliete/create
        [Route("cliente/create/{id?}")]//ruta personalizada para el ejercicio, post
        public IHttpActionResult Post([FromBody] string value)
        {
            //codigo para agregar cliente a base de datos.


            return Ok();
        }

        // PUT cliente/update/5
        [Route("cliente/update/{id?}")] //ruta personalizada para el ejercicio, put
        public IHttpActionResult Put(int id, [FromBody] string value)
        {
            return Ok();
        }

        // DELETE cliente/delete/5
        [Route("cliente/delete/{id?}")] //ruta personalizada para el ejercicio, delete
        public IHttpActionResult Delete(int id)
        {
            return Ok();
        }
    }
}
