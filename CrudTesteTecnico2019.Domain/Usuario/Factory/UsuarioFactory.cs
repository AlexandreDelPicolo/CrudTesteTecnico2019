using CrudTesteTecnico2019.Domain.Usuario.Command;
using CrudTesteTecnico2019.Domain.Usuario.Entity;
using CrudTesteTecnico2019.Domain.Usuario.Enum;
using CrudTesteTecnico2019.Domain.Usuario.ObjectValue;

namespace CrudTesteTecnico2019.Domain.Usuario.Factory
{
    public static class UsuarioFactory
    {
        public static UsuarioDomain Create(UsuarioCommand command)
        {
            return new UsuarioDomain(command.UsuarioId,
                                     command.Nome,
                                     command.Sobrenome,
                                     new Email(command.Email),
                                     new DataNascimento(command.DataNascimento),
                                     (PerfilEnum)command.Perfil);
        }
    }
}
