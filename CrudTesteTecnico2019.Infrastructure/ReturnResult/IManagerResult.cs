using CrudTesteTecnico2019.Infrastructure.ReturnResult;

namespace CrudTesteTecnico2019.Infrastructure.ManagerResult
{
    public interface IManagerResult
    {
        Result Success();
        Result Success(string message);
        Result Fail();
        Result Fail(string message);
    }
}
