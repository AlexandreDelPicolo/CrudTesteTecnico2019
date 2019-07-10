using System.Collections.Generic;
using System.Threading.Tasks;
using CrudTesteTecnico2019.Domain.Usuario.Command;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CrudTesteTecnico2019.Web.Controller
{
    [Route("v1/usuario")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private readonly IMediator _mediator;
        public UsuarioController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost("adicionar"), AllowAnonymous]
        public async Task Adicionar([FromBody] UsuarioCommand command)
        {
            await _mediator.Send(command);
        }
    }
}
