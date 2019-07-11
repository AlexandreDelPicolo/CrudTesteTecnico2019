using CrudTesteTecnico2019.Domain.Usuario.Entity;
using System.Collections.Generic;

namespace CrudTesteTecnico2019.Database.Database.Usuario
{
    public interface IUsuarioRepository
    {
        void Adicionar(UsuarioEntity usuario);
        void Editar(UsuarioEntity usuario);
        void Remover(UsuarioEntity usuario);
        IEnumerable<object> Listar();
        int SaveChanges();
    }
}
