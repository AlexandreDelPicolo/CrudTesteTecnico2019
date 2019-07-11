using CrudTesteTecnico2019.Infrastructure.ManagerResult;

namespace CrudTesteTecnico2019.Infrastructure.Result
{
    public class ManagerResult : IManagerResult
    {
        public CommandResult Fail()
        {
            return new CommandResult(false);
        }

        public CommandResult Fail(string message)
        {
            return new CommandResult(false, message);
        }

        public CommandResult Success()
        {
            return new CommandResult(true);
        }

        public CommandResult Success(string message)
        {
            return new CommandResult(true, message);
        }
    }
}
