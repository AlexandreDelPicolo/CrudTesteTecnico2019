using System;

namespace CrudTesteTecnico2019.Domain.Usuario.ObjectValue
{
    public class DataNascimento
    {
        public DataNascimento(DateTime value)
        {
            Value = value;
        }

        public DateTime Value { get; }

        public bool Valido()
        {
            return Value < DateTime.Now;
        }

        public override bool Equals(object obj)
        {
            return obj is DataNascimento nascimento &&
                   Value == nascimento.Value;
        }

        public override int GetHashCode()
        {
            return -1937169414 + Value.GetHashCode();
        }
    }
}
