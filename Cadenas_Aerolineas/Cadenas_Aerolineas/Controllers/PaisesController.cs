using AutoMapper;
using Cadenas_Aerolineas.Models;
using Cadenas_Aerolineas.Models.Dto;
using Cadenas_Aerolineas.Repository.IRepository;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace Cadenas_Aerolineas.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [ValidateFilters]
    public class PaisesController: ControllerBase
    {
        private readonly ILogger<PaisesController> _logger;
        private readonly IPaisesRepository _paisesRepository;
        private readonly IMapper _mapper;

        public PaisesController(ILogger<PaisesController> logger, IPaisesRepository paisesRepository, IMapper mapper)
        {
            _logger = logger;
            _paisesRepository = paisesRepository;
            _mapper = mapper;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        public async Task<ActionResult<IEnumerable<PaisesDto>>> GetPais()
        {
            _logger.LogInformation("Obtener los Paises");
            var listaPaises = await _paisesRepository.GetAll();
            return Ok(_mapper.Map<IEnumerable<PaisesDto>>(listaPaises));
        }

        [HttpGet("{id:int}", Name = "GetPaises")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<PaisesDto>> GetPais(int id)
        {
            if (id == 0)
            {
                _logger.LogError($"Error al obtener el pais con Id {id}");
                return BadRequest();
            }
            var paises = await _paisesRepository.Get(s => s.ID == id);

            if (paises == null)
            {
                return NotFound();
            }
            return Ok(_mapper.Map<PaisesDto>(paises));

        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<PaisesDto>> AddPais([FromBody] PaisesCreate paisesCreate)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (paisesCreate == null)
                return BadRequest(paisesCreate);

            Paises modelo = _mapper.Map<Paises>(paisesCreate);
            await _paisesRepository.Create(modelo);
            return CreatedAtRoute("GetPaises", new { id = modelo.ID }, modelo);
        }

        [HttpDelete("{id:int}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]

        public async Task<IActionResult> DeletePaises(int id)
        {
            if (id == 0)
            {
                return BadRequest();
            }
            var paises = await _paisesRepository.Get(s => s.ID == id);

            if (paises == null)
            {
                return NotFound();
            }

            await _paisesRepository.Remove(paises);

            return NoContent();
        }

        [HttpPut("{id:int}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> UpdatePaises(int id, [FromBody] PaisesUpdate paisesUpdate)
        {
            if (paisesUpdate == null || id != paisesUpdate.ID)
            {
                return BadRequest();
            }

            Paises modelo = _mapper.Map<Paises>(paisesUpdate);

            await _paisesRepository.Update(modelo);
            return NoContent();
        }

        [HttpPatch("{id:int}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> UpdatePartialPaises(int id, JsonPatchDocument<PaisesUpdate> pathDto)
        {
            if (pathDto == null || id == 0)
            {
                return BadRequest();
            }

            var pais = await _paisesRepository.Get(s => s.ID == id, tracked: false);
            PaisesUpdate paisesUpdate = _mapper.Map<PaisesUpdate>(pais);

            if (pais == null)
                return BadRequest();

            pathDto.ApplyTo(paisesUpdate, (Microsoft.AspNetCore.JsonPatch.Adapters.IObjectAdapter)ModelState);

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            Paises modelo = _mapper.Map<Paises>(paisesUpdate);

            await _paisesRepository.Update(modelo);

            return NoContent();

        }

    }
}
