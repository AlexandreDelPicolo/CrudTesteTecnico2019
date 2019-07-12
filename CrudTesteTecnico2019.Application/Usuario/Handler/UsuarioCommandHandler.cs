using CrudTesteTecnico2019.Database.Database.Usuario;
using CrudTesteTecnico2019.Domain.Usuario.Command;
using CrudTesteTecnico2019.Domain.Usuario.Factory;
using CrudTesteTecnico2019.Infrastructure.ManagerResult;
using CrudTesteTecnico2019.Infrastructure.Result;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace CrudTesteTecnico2019.Application.Usuario.Handler
{
    public class UsuarioCommandHandler :
        IRequestHandler<InserirUsuarioCommand, CommandResult>,
        IRequestHandler<AtualizarUsuarioCommand, CommandResult>,
        IRequestHandler<ExcluirUsuarioCommand, CommandResult>
    {
        private readonly IManagerResult _managerResult;

        private readonly IUsuarioRepository _usuarioRepository;

        public UsuarioCommandHandler(IUsuarioRepository usuarioRepository, IManagerResult managerResult)
        {
            _usuarioRepository = usuarioRepository;
            _managerResult = managerResult;
        }

        public async Task<CommandResult> Handle(InserirUsuarioCommand request, CancellationToken cancellationToken)
        {
            var usuario = UsuarioFactory.Create(request);

            _usuarioRepository.Inserir(usuario);

            _usuarioRepository.SaveChanges();

            var resultado = _managerResult.Success("Usuário inserido com sucesso.");

            return await Task.FromResult(resultado);
        }

        public async Task<CommandResult> Handle(AtualizarUsuarioCommand request, CancellationToken cancellationToken)
        {
            var usuario = UsuarioFactory.Create(request);

            _usuarioRepository.Atualizar(usuario);

            _usuarioRepository.SaveChanges();

            var resultado = _managerResult.Success("Usuário atualizado com sucesso.");

            return await Task.FromResult(resultado);
        }

        public async Task<CommandResult> Handle(ExcluirUsuarioCommand request, CancellationToken cancellationToken)
        {
            var usuario = UsuarioFactory.Create(request);

            _usuarioRepository.Excluir(usuario);

            _usuarioRepository.SaveChanges();

            var resultado = _managerResult.Success("Usuário excluído com sucesso.");

            return await Task.FromResult(resultado);
        }
    }
}