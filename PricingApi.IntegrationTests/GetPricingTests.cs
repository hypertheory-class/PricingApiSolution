
using System.Threading.Tasks;
using Alba;
using Xunit;

namespace PricingApi.IntegrationTests;
public class GetPricingTests : IClassFixture<WebAppFixture>
{

    private readonly IAlbaHost _host;

    public GetPricingTests(WebAppFixture fixture)
    {
        _host = fixture.AlbaHost;
    }

    [Fact]
    public async Task CanGetThePricingInformation()
    {
        await _host.Scenario(api =>
        {
            api.Get.Url("/pricing");
            api.StatusCodeShouldBeOk();
        });

    }
}
