using CrudTesteTecnico2019.Domain.Usuario.Entity;
using System.Collections.Generic;

namespace CrudTesteTecnico2019.Database.Database.Usuario
{
    public interface IUsuarioRepository
    {
        void Adicionar(UsuarioDomain usuario);
        void Editar(UsuarioDomain usuario);
        void Remover(UsuarioDomain usuario);
        IEnumerable<object> Listar();
        int SaveChanges();
    }
}
