namespace CrudTesteTecnico2019.Domain.Usuario.ObjectValue
{
    public class UsuarioId
    {
        public UsuarioId(int value)
        {
            Value = value;
        }

        public int Value { get; }

        public override bool Equals(object obj)
        {
            return obj is UsuarioId id &&
                   Value == id.Value;
        }

        public override int GetHashCode()
        {
            return -1937169414 + Value.GetHashCode();
        }
    }
}
