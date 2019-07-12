using System;

namespace CrudTesteTecnico2019.Model.Usuario
{
    public class UsuarioModel
    {
        public long Id { get; set; }

        public string Nome { get; set; }

        public string Sobrenome { get; set; }

        public string Email { get; set; }

        public DateTime DataNascimento { get; set; }

        public int Perfil { get; set; }
    }
}
