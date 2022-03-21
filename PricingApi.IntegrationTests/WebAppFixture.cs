

using System.Threading.Tasks;
using Alba;
using Microsoft.Extensions.DependencyInjection;
using Xunit;

namespace PricingApi.IntegrationTests;
public class WebAppFixture : IAsyncLifetime
{
    public IAlbaHost AlbaHost = null;


    public async Task DisposeAsync()
    {
        await AlbaHost.DisposeAsync();
    }

    public async Task InitializeAsync()
    {
        AlbaHost = await Alba.AlbaHost.For<Program>(builder =>
        {
            builder.ConfigureServices(services =>
            {
                BuildServices(services);
            });
        });
    }

    public virtual void BuildServices(IServiceCollection builder)
    {
        // more here later
    }
}
