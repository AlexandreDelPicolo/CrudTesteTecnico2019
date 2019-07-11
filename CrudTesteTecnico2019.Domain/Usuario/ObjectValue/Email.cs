using CrudTesteTecnico2019.Infrastructure.Helper;
using System.Collections.Generic;

namespace CrudTesteTecnico2019.Domain.Usuario.ObjectValue
{
    public class Email
    {
        public Email(string value)
        {
            Value = value;
        }

        public string Value { get; }

        public bool Valido()
        {
            return EmailHelper.ValidarFormato(Value);
        }
    }
}
