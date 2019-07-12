using System.Text.RegularExpressions;

namespace CrudTesteTecnico2019.Infrastructure.Helper
{
    public static class EmailHelper
    {
        private static readonly string _regex = "^([0-9a-zA-Z]([-.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$";

        public static bool Validar(string email)
        {
            if (string.IsNullOrEmpty(email)) return false;

            return Regex.IsMatch(email, _regex);
        }

        public static bool Validar(string email, string formato)
        {
            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(formato)) return false;

            return Regex.IsMatch(email, formato);
        }
    }
}