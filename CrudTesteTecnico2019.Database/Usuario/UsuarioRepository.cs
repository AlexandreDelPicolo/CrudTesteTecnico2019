using CrudTesteTecnico2019.Domain.Usuario.Entity;
using System;
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

        public void Adicionar(UsuarioDomain usuario) => _context.Set<UsuarioDomain>().Add(usuario);

        public void Editar(UsuarioDomain usuario) =>_context.Set<UsuarioDomain>().Update(usuario);

        public void Remover(UsuarioDomain usuario) => _context.Set<UsuarioDomain>().Remove(usuario);

        public IEnumerable<UsuarioDomain> Listar()
        {
            //_context.Usuario.ToList();
            return _context.Set<UsuarioDomain>().ToList();
        }

        IEnumerable<object> IUsuarioRepository.Listar()
        {
            throw new NotImplementedException();
        }

        public int SaveChanges()
        {
            return _context.SaveChanges();
        }
    }
}