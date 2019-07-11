using CrudTesteTecnico2019.Domain.Usuario.Command;
using CrudTesteTecnico2019.Domain.Usuario.Entity;
using CrudTesteTecnico2019.Domain.Usuario.Enum;
using CrudTesteTecnico2019.Domain.Usuario.ObjectValue;

namespace CrudTesteTecnico2019.Domain.Usuario.Factory
{
    public static class UsuarioFactory
    {
        public static UsuarioEntity Create(UsuarioBaseCommand command)
        {
            return new UsuarioEntity(command.Id,
                                     command.Nome,
                                     command.Sobrenome,
                                     new Email(command.Email),
                                     new DataNascimento(command.DataNascimento),
                                     (Perfil)command.Perfil);
        }
    }
}
