using DemoPersonas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace DemoPersonas.Controllers
{
    public class PersonaController : ApiController
    {
        // GET api/persona
        public IEnumerable<Persona> Get()
        {
            return new List<Persona>() 
            {
                new Persona() { Identificador = 1, Nombre = "Hernan", Direccion="Calle 32" },
                new Persona() { Identificador = 2, Nombre = "Alejandro", Direccion="Carrera 56" },
            };
        }

        // GET api/persona/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/persona
        public void Post([FromBody]string value)
        {
        }

        // PUT api/persona/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/persona/5
        public void Delete(int id)
        {
        }
    }
}
