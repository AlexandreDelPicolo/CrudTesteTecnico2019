using System.Threading;
using System.Threading.Tasks;
using CrudTesteTecnico2019.Database.Database.Usuario;
using CrudTesteTecnico2019.Domain.Usuario.Command;
using CrudTesteTecnico2019.Domain.Usuario.Entity;
using CrudTesteTecnico2019.Domain.Usuario.Factory;
using MediatR;

namespace CrudTesteTecnico2019.Application.Usuario.Handler
{

    public class UsuarioCommandHandler : RequestHandler<UsuarioCommand>
    {
        private readonly IUsuarioRepository _usuarioRepository;

        public UsuarioCommandHandler(IUsuarioRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }

        //public Task<bool> Handle(UsuarioCommand request, CancellationToken cancellationToken)
        //{
        //    UsuarioDomain usuario = UsuarioFactory.Create(request);
        //    _usuarioRepository.Adicionar(usuario);
        //    return Task.FromResult(true);
        //}


        protected override void Handle(UsuarioCommand request)
        {
            UsuarioEntity usuario = UsuarioFactory.Create(request);
            _usuarioRepository.Adicionar(usuario);
            _usuarioRepository.SaveChanges();
        }
    }
}
