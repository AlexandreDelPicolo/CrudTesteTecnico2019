using CrudTesteTecnico2019.Domain.Usuario.Command;
using CrudTesteTecnico2019.Domain.Usuario.Query;
using CrudTesteTecnico2019.Infrastructure.Result;
using CrudTesteTecnico2019.Model.Usuario;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
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

        [HttpPut("{id}")]
        public async Task<CommandResult> Atualizar([FromRoute] long id, [FromBody] AtualizarUsuarioCommand command)
        {
            command.Id = id;

            return await _mediator.Send(command);
        }

        [HttpDelete("{id}")]
        public async Task<CommandResult> Excluir([FromRoute] long id)
        {
            var command = new ExcluirUsuarioCommand { Id = id };

            return await _mediator.Send(command);
        }

        [HttpPost]
        public async Task<CommandResult> Inserir([FromBody] InserirUsuarioCommand command)
        {
            return await _mediator.Send(command);
        }

        [HttpGet]
        public async Task<IEnumerable<UsuarioModel>> Listar()
        {
            return await _mediator.Send(new ListarUsuarioQuery());
        }
    }
}