using CrudTesteTecnico2019.Domain.Usuario.Entity;
using CrudTesteTecnico2019.Model.Usuario;
using System.Collections.Generic;

namespace CrudTesteTecnico2019.Database.Database.Usuario
{
    public interface IUsuarioRepository
    {
        void Atualizar(UsuarioEntity usuario);

        void Excluir(UsuarioEntity usuario);

        void Inserir(UsuarioEntity usuario);

        IEnumerable<UsuarioModel> Listar();

        /// TODO: Remover esse método e utilizar um Unit of Work
        int SaveChanges();
    }
}