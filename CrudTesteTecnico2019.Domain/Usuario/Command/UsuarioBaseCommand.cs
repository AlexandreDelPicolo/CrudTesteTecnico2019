using CrudTesteTecnico2019.Infrastructure.Result;
using MediatR;
using System;

namespace CrudTesteTecnico2019.Domain.Usuario.Command
{
    public class UsuarioBaseCommand : IRequest<CommandResult>
    {
        public long Id { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Email { get; set; }
        public DateTime DataNascimento { get; set; }
        public int Perfil { get; set; }
    }
}
