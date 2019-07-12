using CrudTesteTecnico2019.Domain.Usuario.Entity;
using CrudTesteTecnico2019.Model.Usuario;
using System.Collections.Generic;
using System.Linq;

namespace CrudTesteTecnico2019.Database.Database.Usuario
{
    public sealed class UsuarioRepository : IUsuarioRepository
    {
        private readonly Context _context;

        public UsuarioRepository(Context context)
        {
            _context = context;
        }

        public void Atualizar(UsuarioEntity usuario)
        {
            _context.Set<UsuarioEntity>().Update(usuario);
        }

        public void Excluir(UsuarioEntity usuario)
        {
            _context.Set<UsuarioEntity>().Remove(usuario);
        }

        public void Inserir(UsuarioEntity usuario)
        {
            _context.Set<UsuarioEntity>().Add(usuario);
        }

        public IEnumerable<UsuarioModel> Listar()
        {
            return _context.Set<UsuarioEntity>().Select(x =>
            new UsuarioModel
            {
                Id = x.UsuarioId,
                Nome = x.Nome,
                Sobrenome = x.Sobrenome,
                DataNascimento = x.DataNascimento.Value,
                Email = x.Email.Value,
                Perfil = (int)x.Perfil
            });
        }

        /// TODO: Remover esse método e utilizar um Unit of Work
        public int SaveChanges()
        {
            return _context.SaveChanges();
        }
    }
}