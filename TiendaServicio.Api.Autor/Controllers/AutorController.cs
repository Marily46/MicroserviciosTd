using MediatR;
using Microsoft.AspNetCore.Mvc;
using TiendaServicio.Api.Autor.Aplicacion;
using System.Threading.Tasks;
using TiendaServicio.Api.Autor.Modelo;

namespace TiendaServicio.Api.Autor.Controllers
{
    [Route("api/[controller]")] 
    [ApiController]
    public class AutorController : ControllerBase
    {
        private readonly IMediator _mediator;

        // Inyección de dependencia
        public AutorController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost] 
        public async Task<ActionResult<Unit>> Crear(Nuevo.Ejecuta data)
        {
            return await _mediator.Send(data);
        }

        [HttpGet]
        public async Task<ActionResult<List<AutorLibro>>> GetAutores()
        {
            return await _mediator.Send(new Consulta.ListaAutor());
        }

    }
}