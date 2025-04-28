using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Hosting;

public static class Program
{
    public static void Main()
    {
        // For non-Web API functions, you do not need `ConfigureFunctionsWebApplication`
        var host = new HostBuilder()
            .ConfigureFunctionsWorkerDefaults()
            .Build();

        host.Run();
    }
}
