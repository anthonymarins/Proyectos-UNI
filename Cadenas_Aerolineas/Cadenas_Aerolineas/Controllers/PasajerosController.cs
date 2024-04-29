using AutoMapper;
using Cadenas_Aerolineas.Models;
using Cadenas_Aerolineas.Models.Dto;
using Cadenas_Aerolineas.Repository.IRepository;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;

namespace Cadenas_Aerolineas.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [ValidateFilters]
    public class PasajerosController : ControllerBase
    {
        private readonly ILogger<PasajerosController> _logger;
        private readonly IPasajerosRepository _pasajerosRepository;
        private readonly IMapper _mapper;

        public PasajerosController(ILogger<PasajerosController> logger, IPasajerosRepository peliculasRepository, IMapper mapper)
        {
            _logger = logger;
            _pasajerosRepository = peliculasRepository;
            _mapper = mapper;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        public async Task<ActionResult<IEnumerable<PasajerosDto>>> GetPasajeros()
        {
            _logger.LogInformation("Obtener los Pasajeros");
            var listaPasajeros = await _pasajerosRepository.GetAll();
            return Ok(_mapper.Map<IEnumerable<PasajerosDto>>(listaPasajeros));
        }

        [HttpGet("{id:int}", Name = "GetPasajero")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<PasajerosDto>> GetPasajero(int id)
        {
            if (id == 0)
            {
                _logger.LogError($"Error al obtener el pasajero con Id {id}");
                return BadRequest();
            }
            var pasajeros = await _pasajerosRepository.Get(s => s.ID == id);

            if (pasajeros == null)
            {
                return NotFound();
            }
            return Ok(_mapper.Map<PasajerosDto>(pasajeros));

        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<PasajerosDto>> AddPasajeros([FromBody] PasajerosCreate pasajerosCreate)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (pasajerosCreate == null)
                return BadRequest(pasajerosCreate);

            Pasajeros modelo = _mapper.Map<Pasajeros>(pasajerosCreate);
            await _pasajerosRepository.Create(modelo);
            return CreatedAtRoute("GetPasajero", new { id = modelo.ID }, modelo); //*****//
        }

        [HttpDelete("{id:int}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]

        public async Task<IActionResult> DeletePasajeros(int id)
        {
            if (id == 0)
            {
                return BadRequest();
            }
            var peliculas = await _pasajerosRepository.Get(s => s.ID == id); //*****//

            if (peliculas == null)
            {
                return NotFound();
            }

            await _pasajerosRepository.Remove(peliculas);

            return NoContent();
        }

        [HttpPut("{id:int}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> UpdatePasajeros(int id, [FromBody] PasajerosUpdate pasajerosUpdate)
        {
            if (pasajerosUpdate == null || id != pasajerosUpdate.ID)
            {
                return BadRequest();
            }

            Pasajeros modelo = _mapper.Map<Pasajeros>(pasajerosUpdate);

            await _pasajerosRepository.Update(modelo);
            return NoContent();
        }

        [HttpPatch("{id:int}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> UpdatePartialPasajeros(int id, JsonPatchDocument<PasajerosUpdate> pathDto)
        {
            if (pathDto == null || id == 0)
            {
                return BadRequest();
            }

            var pasa = await _pasajerosRepository.Get(s => s.ID == id, tracked: false);
            PasajerosUpdate pasajerosUpdate = _mapper.Map<PasajerosUpdate>(pasa);

            if (pasa == null)
                return BadRequest();

            pathDto.ApplyTo(pasajerosUpdate, (Microsoft.AspNetCore.JsonPatch.Adapters.IObjectAdapter)ModelState);

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            Pasajeros modelo = _mapper.Map<Pasajeros>(pasajerosUpdate);

            await _pasajerosRepository.Update(modelo);

            return NoContent();

        }

    }
}
