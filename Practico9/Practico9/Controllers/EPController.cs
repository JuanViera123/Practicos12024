using Microsoft.AspNetCore.DataProtection;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using Practico8.Datos;
using Practico8.Modelos;
using Practico8.Modelos.Dto;


namespace Practico8.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EPController : ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<EPDto>> GetEPDto()
        {
           return Ok(EPStore.EPList);
        }
        [HttpGet("Id", Name ="GetEP")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<EPDto> GetEPDto(int Id)
        {
            if (Id == 0)
            {
                return BadRequest();
            }
           var Ep = EPStore.EPList.FirstOrDefault(a => a.Id == Id);
            if (Ep == null) 
            {
               return NotFound();
            }

            return Ok(Ep);
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public ActionResult<EPDto> CrearEPDto([FromBody] EPDto epdto)
        {
            if (epdto == null)
            {
                return BadRequest(epdto);
            }
            if(EPStore.EPList.FirstOrDefault(v => v.Nombre.ToLower() == epdto.Nombre.ToLower()) != null)
            {
                ModelState.AddModelError("NombreExiste", "Ese nombre ya existe");
                return BadRequest(ModelState);
            }
            if(epdto == null)
            {
                return BadRequest(epdto);
            }
            if (epdto.Id > 0) 
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
            epdto.Id = EPStore.EPList.OrderByDescending(e => e.Id).FirstOrDefault().Id +1;
            EPStore.EPList.Add(epdto);
            return CreatedAtRoute("GetEP", new {Id= epdto.Id },epdto);
        }

        [HttpDelete("{id:int}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]

        public ActionResult DeleteEP(int id)
        {
            if(id == 0)
            {
                return BadRequest();
            }
            var ep = EPStore.EPList.FirstOrDefault(v => v.Id == id);
            if(ep == null)
            {
                return NotFound();
            }
            EPStore.EPList.Remove(ep);
            return NoContent();
        }

        [HttpPut("{id:int}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]

        public IActionResult UpdateEP(int id, [FromBody] EPDto epdto)
        {
            if (epdto == null)
            {
                return BadRequest();
            }
            var ep = EPStore.EPList.FirstOrDefault(v => v.Id == id);
            ep.Nombre = epdto.Nombre;
            ep.Ocupantes = epdto.Ocupantes;
            ep.MetrosCuadrados = epdto.MetrosCuadrados;
            return NoContent();
        }

        [HttpPatch("{id:int}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]

        public IActionResult UpdateEP(int id, JsonPatchDocument<EPDto> patchdto)
        {
            if (patchdto == null || id == 0)
            {
                return BadRequest();
            }
            var ep = EPStore.EPList.FirstOrDefault(v => v.Id == id);
            patchdto.ApplyTo(ep, ModelState);
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            return NoContent();
        }
    }
}
