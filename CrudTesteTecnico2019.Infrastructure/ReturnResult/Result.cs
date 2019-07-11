namespace CrudTesteTecnico2019.Infrastructure.ReturnResult
{
    public class Result
    {
        public Result(bool success, string message)
        {
            Success = success;
            Message = message;
        }

        public Result(bool success)
        {
            Success = success;
        }

        public bool Success { get; private set; }
        public string Message { get; private set; }
    }
}
