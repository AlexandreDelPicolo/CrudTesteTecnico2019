using CrudTesteTecnico2019.Database.Database.Usuario;
using CrudTesteTecnico2019.Domain.Usuario.Command;
using CrudTesteTecnico2019.Domain.Usuario.Entity;
using CrudTesteTecnico2019.Domain.Usuario.Factory;
using CrudTesteTecnico2019.Infrastructure.ManagerResult;
using CrudTesteTecnico2019.Infrastructure.Result;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace CrudTesteTecnico2019.Application.Usuario.Handler
{

    public class UsuarioCommandHandler : IRequestHandler<UsuarioInsertCommand, CommandResult>
    {
        private readonly IUsuarioRepository _usuarioRepository;
        private readonly IManagerResult _managerResult;

        public UsuarioCommandHandler(IUsuarioRepository usuarioRepository, IManagerResult managerResult)
        {
            _usuarioRepository = usuarioRepository;
            _managerResult = managerResult;
        }

        public async Task<CommandResult> Handle(UsuarioInsertCommand request, CancellationToken cancellationToken)
        {
            return await Task.Run(() =>
            {
                UsuarioEntity usuario = UsuarioFactory.Create(request);
                _usuarioRepository.Adicionar(usuario);
                _usuarioRepository.SaveChanges();
                return _managerResult.Success("Usuario adicionado com sucesso.");
            });
        }
    }
}
