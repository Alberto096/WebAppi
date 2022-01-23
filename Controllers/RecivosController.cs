using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using WebAppi.Contexts;
using WebAppi.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebAppi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RecivosController : ControllerBase
    {
        private readonly AppDbContext context;
        public RecivosController(AppDbContext context)
        {
            this.context = context;
        }
        // GET: api/<RecivosControllers>
        [HttpGet]
        public ActionResult Get()
        {
            try
            {
                return Ok(context.RECIBOS.ToList());
            }
            catch (System.Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // GET api/<RecivosControllers>/5
        [HttpGet("{id}", Name = "GetResivo")]
        public ActionResult Get(string id)
        {
            try
            {
                var IdGuild = new Guid(id);
                var recivo = context.RECIBOS.FirstOrDefault(g => g.Id == IdGuild);
                return Ok(recivo);

            }
            catch (System.Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // POST api/<RecivosControllers>
        [HttpPost]
        public ActionResult Post([FromBody] Recivos gestor)
        {
            try
            {
                context.RECIBOS.Add(gestor);
                context.SaveChanges();
                return CreatedAtRoute("GetResivo", new { id = gestor.Id }, gestor);
            }
            catch (System.Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("{correo}/{password}")]
        public ActionResult Get(string correo, string password)
        {
            try
            {
                var dataUsuario = context.USUARIO.FirstOrDefault(e => e.Correo.Equals(correo) && e.Password == password);
                return Ok(dataUsuario);

            }
            catch (System.Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("usuario/{iduser}")]
        public ActionResult Post(string iduser)
        {
            try
            {
                var IdUserGuild = new Guid(iduser);
                var dataUsuario = context.USUARIO.FirstOrDefault(e => e.Id == IdUserGuild);
                return Ok(dataUsuario);

            }
            catch (System.Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

    }
}
