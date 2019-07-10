namespace CrudTesteTecnico2019.Infrastructure.Helper
{
    public static class EmailHelper
    {
        private static readonly string _regexEmailValido = "^([0-9a-zA-Z]([-.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$";

        public static bool ValidarFormato(string email)
        {
            if (string.IsNullOrEmpty(email)) return false;

            return System.Text.RegularExpressions.Regex.IsMatch(email, _regexEmailValido);
        }

        public static bool ValidarFormato(string email, string formato)
        {
            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(formato)) return false;

            return System.Text.RegularExpressions.Regex.IsMatch(email, formato);
        }
    }
}
