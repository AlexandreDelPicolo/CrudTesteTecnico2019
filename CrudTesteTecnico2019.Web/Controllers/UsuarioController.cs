using CrudTesteTecnico2019.Domain.Usuario.Command;
using CrudTesteTecnico2019.Infrastructure.Result;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace CrudTesteTecnico2019.Web.Controllers
{
    [Route("api/usuario")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private readonly IMediator _mediator;
        public UsuarioController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost("adicionar")]
        public async Task<CommandResult> Adicionar([FromBody] UsuarioInsertCommand command)
        {
            return await _mediator.Send(command);
        }

        [HttpPut("editar/{id}")]
        public async Task<CommandResult> Editar([FromBody] UsuarioEditCommand command)
        {
            return await _mediator.Send(command);
        }

        [HttpDelete("remover/{id}")]
        public async Task<CommandResult> Remover([FromBody] UsuarioDeleteCommand command)
        {
            return await _mediator.Send(command);
        }
    }
}
