using CrudTesteTecnico2019.Domain.Usuario.Enum;
using CrudTesteTecnico2019.Domain.Usuario.ObjectValue;

namespace CrudTesteTecnico2019.Domain.Usuario.Entity
{
    public class UsuarioEntity
    {
        public UsuarioEntity(long usuarioId, string nome, string sobrenome, Email email, DataNascimento dataNascimento, Perfil perfil)
        {
            UsuarioId = usuarioId;
            Nome = nome;
            Sobrenome = sobrenome;
            Email = email;
            DataNascimento = dataNascimento;
            Perfil = perfil;
        }

        public UsuarioEntity() { }

        public long UsuarioId { get; private set; }
        public string Nome { get; private set; }
        public string Sobrenome { get; private set; }
        public Email Email { get; private set; }
        public DataNascimento DataNascimento { get; private set; }
        public Perfil Perfil { get; private set; }

        public bool EmailValido() => Email.Valido();
        public bool DataNascimentoValida() => DataNascimento.Valido();
    }
}
