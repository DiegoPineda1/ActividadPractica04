using Microsoft.AspNetCore.Mvc;
using Actividad_Práctica_04.Servicio;
using Actividad_Práctica_04.Data.Models;
using Actividad_Práctica_04.Data.Repositorio.Interfaces;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApi_Practica_04.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServiciosController : ControllerBase
    {
        private readonly IManeger _manger;
        public ServiciosController(IManeger manger)
        {
            _manger = manger;
        }
        // GET: api/<ServiciosController>
        [HttpGet]
        public IActionResult GetAll()
        {
            try
            {
                if(_manger.GetAll() != null && _manger.GetAll().Count > 0)
                {
                    return Ok(_manger.GetAll());
                }
                return BadRequest();
    
            }
            catch (Exception)
            {
                return StatusCode(500);
                throw;
            }
        }

        // GET api/<ServiciosController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            try
            {
                if (id > 0)
                {
                    return Ok(_manger.GetId(id));
                }
                return BadRequest();

            }
            catch (Exception)
            {
                return StatusCode(500);
                throw;
            }
        }

        // POST api/<ServiciosController>
        [HttpPost]
        public IActionResult Save(T_SERVICIOS tservicio)
        {
            try
            {
                if(tservicio != null)
                {
                    _manger.Save(tservicio);
                    return Ok();
                }
                return BadRequest();
            }
            catch (Exception)
            {
                return StatusCode(500);
                throw;
            }
        }

        // PUT api/<ServiciosController>/5
        [HttpPut()]
        public IActionResult Put(T_SERVICIOS tservicio) 
        {
            try
            {
                if(tservicio != null)
                {
                    _manger.Update(tservicio);
                    return Ok();
                }
                return BadRequest();
            }
            catch (Exception)
            {
                return StatusCode(500);
                throw;
            }
        }

        // DELETE api/<ServiciosController>/5
        [HttpDelete("{id}")]
        public IActionResult DeleteId(int id)
        {
            try
            {
                if(id > 0)
                {
                    _manger.Delete(id);
                    return Ok();
                }
                return BadRequest();
            }
            catch (Exception)
            {
                return StatusCode(500);
                throw;
            }
        }
        [HttpDelete]
        public IActionResult Delete(T_SERVICIOS servicio)
        {
            try
            {
                if(servicio != null)
                {
                    _manger.Delete(servicio);
                    return Ok();
                }
                return BadRequest();
            }
            catch (Exception)
            {
                return StatusCode(500);
                throw;
            }
        }
    }
}
