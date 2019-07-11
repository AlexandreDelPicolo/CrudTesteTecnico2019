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
    }
}
