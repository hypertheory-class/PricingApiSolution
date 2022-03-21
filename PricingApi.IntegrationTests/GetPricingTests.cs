
using System.Threading.Tasks;
using Alba;
using PricingApi.Controllers;
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
        var result = await _host.Scenario(api =>
        {
            api.Get.Url("/pricing"); // note.
            api.StatusCodeShouldBeOk();
        });

        var actual = result.ReadAsJson<Response>();
        var expected = new CurrentPricingResponse(60, 10, 35, 20);

        Assert.Equal(expected, actual?.data);
    }
}

public record Response(CurrentPricingResponse data);
