using CrudTesteTecnico2019.Infrastructure.Result;

namespace CrudTesteTecnico2019.Infrastructure.ManagerResult
{
    public interface IManagerResult
    {
        CommandResult Fail();

        CommandResult Fail(string message);

        CommandResult Success();

        CommandResult Success(string message);
    }
}