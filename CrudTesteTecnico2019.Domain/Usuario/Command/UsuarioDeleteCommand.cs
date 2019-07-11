using CrudTesteTecnico2019.Infrastructure.Result;
using MediatR;

namespace CrudTesteTecnico2019.Domain.Usuario.Command
{
    public class UsuarioDeleteCommand : IRequest<CommandResult>
    {
        public long Id { get; set; }
    }
}
