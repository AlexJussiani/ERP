using Microsoft.AspNetCore.Mvc;
using ERP.Dominio.Contrato;
using ERP.Dominio.Entidades;
using System;

namespace ERP.Web.Controllers
{
    [Route("api/[controller]")]
    public class IngredienteController : Controller
    {
        private readonly IIngredientesRepositorio _ingredienteRepositorio;
        public IngredienteController(IIngredientesRepositorio ingredienteRepositorio)
        {
            _ingredienteRepositorio = ingredienteRepositorio;
        }

        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                return Ok(_ingredienteRepositorio.ObterTodos());
                //if(condicao == false)
                //{
                //    return BadRequest("")
                // }
            }catch(Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpPost("cadastrar")]
        public IActionResult cadastrar([FromBody] Ingredientes ingrediente)
        {
            try
            {                
                _ingredienteRepositorio.Adicionar(ingrediente);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
    }
}
