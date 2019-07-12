using CrudTesteTecnico2019.Database.Database.Usuario;

namespace CrudTesteTecnico2019.Application.Usuario.Handler
{
    public class UsuarioQueryHandler
    {
        private readonly IUsuarioRepository _usuarioRepository;

        public UsuarioQueryHandler(IUsuarioRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }

    }
}
