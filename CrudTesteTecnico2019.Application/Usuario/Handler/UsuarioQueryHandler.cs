using CrudTesteTecnico2019.Database.Database.Usuario;
using CrudTesteTecnico2019.Domain.Usuario.Query;
using CrudTesteTecnico2019.Model.Usuario;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace CrudTesteTecnico2019.Application.Usuario.Handler
{
    public class UsuarioQueryHandler : IRequestHandler<UsuarioQuery, IEnumerable<UsuarioModel>>
    {
        private readonly IUsuarioRepository _usuarioRepository;

        public UsuarioQueryHandler(IUsuarioRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }

        public async Task<IEnumerable<UsuarioModel>> Handle(UsuarioQuery request, CancellationToken cancellationToken)
        {
            return await Task.Run(() =>
            {
                return _usuarioRepository.Listar();
            });
        }
    }
}
