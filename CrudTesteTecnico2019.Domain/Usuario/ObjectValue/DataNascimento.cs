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

        public bool Validar()
        {
            return Value <= DateTime.Now;
        }
    }
}
