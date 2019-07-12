using CrudTesteTecnico2019.Infrastructure.Result;
using MediatR;

namespace CrudTesteTecnico2019.Domain.Usuario.Command
{
    public class ExcluirUsuarioCommand : IRequest<CommandResult>
    {
        public long Id { get; set; }
    }
}
