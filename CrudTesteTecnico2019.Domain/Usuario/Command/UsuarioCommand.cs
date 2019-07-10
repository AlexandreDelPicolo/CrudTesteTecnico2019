using MediatR;
using System;

namespace CrudTesteTecnico2019.Domain.Usuario.Command
{
    public class UsuarioCommand : IRequest
    {
        public long UsuarioId { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Email { get; set; }
        public DateTime DataNascimento { get; set; }
        public int Perfil { get; set; }
    }
}
