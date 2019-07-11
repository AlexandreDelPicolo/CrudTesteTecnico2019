using CrudTesteTecnico2019.Domain.Usuario.Command;
using CrudTesteTecnico2019.Domain.Usuario.Entity;
using CrudTesteTecnico2019.Domain.Usuario.Enum;
using CrudTesteTecnico2019.Domain.Usuario.ObjectValue;

namespace CrudTesteTecnico2019.Domain.Usuario.Factory
{
    public static class UsuarioFactory
    {
        public static UsuarioEntity Create(UsuarioCommand command)
        {
            return new UsuarioEntity(command.UsuarioId,
                                     command.Nome,
                                     command.Sobrenome,
                                     new Email(command.Email),
                                     new DataNascimento(command.DataNascimento),
                                     (Perfil)command.Perfil);
        }
    }
}
