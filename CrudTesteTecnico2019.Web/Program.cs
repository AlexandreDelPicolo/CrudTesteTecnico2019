using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;

namespace CrudTesteTecnico2019.Web2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            WebHost.CreateDefaultBuilder().UseStartup<Startup>().Build().Run();
        }
    }
}
