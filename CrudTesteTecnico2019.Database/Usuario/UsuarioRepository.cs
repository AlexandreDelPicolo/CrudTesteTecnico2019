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

        public void Adicionar(UsuarioEntity usuario)
        {
            _context.Set<UsuarioEntity>().Add(usuario);
        }

        public void Editar(UsuarioEntity usuario)
        {
            _context.Set<UsuarioEntity>().Update(usuario);
        }

        public void Remover(UsuarioEntity usuario)
        {
            _context.Set<UsuarioEntity>().Remove(usuario);
        }

        public IEnumerable<UsuarioModel> Listar()
        {
            return _context.Set<UsuarioModel>().ToList();
        }

        public int SaveChanges()
        {
            return _context.SaveChanges();
        }
    }
}