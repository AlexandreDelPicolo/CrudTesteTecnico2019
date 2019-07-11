using CrudTesteTecnico2019.Infrastructure.Result;

namespace CrudTesteTecnico2019.Infrastructure.ManagerResult
{
    public interface IManagerResult
    {
        CommandResult Success();
        CommandResult Success(string message);
        CommandResult Fail();
        CommandResult Fail(string message);
    }
}
