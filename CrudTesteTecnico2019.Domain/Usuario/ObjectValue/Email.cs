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

        public override bool Equals(object obj)
        {
            return obj is Email email &&
                   Value == email.Value;
        }

        public override int GetHashCode()
        {
            return -1937169414 + EqualityComparer<string>.Default.GetHashCode(Value);
        }
    }
}
