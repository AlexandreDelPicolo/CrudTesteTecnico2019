using CrudTesteTecnico2019.Database.Database.Usuario;
using CrudTesteTecnico2019.Domain.Usuario.Query;
using CrudTesteTecnico2019.Model.Usuario;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace CrudTesteTecnico2019.Application.Usuario.Handler
{
    public class UsuarioQueryHandler : IRequestHandler<ListarUsuarioQuery, IEnumerable<UsuarioModel>>
    {
        private readonly IUsuarioRepository _usuarioRepository;

        public UsuarioQueryHandler(IUsuarioRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }

        public async Task<IEnumerable<UsuarioModel>> Handle(ListarUsuarioQuery request, CancellationToken cancellationToken)
        {
            return await Task.FromResult(_usuarioRepository.Listar());
        }
    }
}