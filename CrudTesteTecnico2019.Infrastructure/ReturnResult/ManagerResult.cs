using CrudTesteTecnico2019.Infrastructure.ManagerResult;

namespace CrudTesteTecnico2019.Infrastructure.ReturnResult
{
    public class ManagerResult : IManagerResult
    {
        public Result Fail() => new Result(false);
        public Result Fail(string message) => new Result(false, message);
        public Result Success() => new Result(true);
        public Result Success(string message) => new Result(true, message);
    }
}
