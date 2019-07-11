namespace CrudTesteTecnico2019.Infrastructure.Result
{
    public class CommandResult
    {
        public CommandResult(bool success, string message)
        {
            Success = success;
            Message = message;
        }

        public CommandResult(bool success)
        {
            Success = success;
        }

        public bool Success { get; private set; }
        public string Message { get; private set; }
    }
}
