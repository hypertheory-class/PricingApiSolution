using Microsoft.AspNetCore.Mvc;

namespace PricingApi.Controllers;

public class PricingController : ControllerBase
{

    private readonly ILogger<PricingController> _logger;

    public PricingController(ILogger<PricingController> logger)
    {
        _logger = logger;
    }



    // GET /pricing
    [HttpGet("/pricing")]
    public async Task<ActionResult> GetCurrentPricingAsync()
    {
        var response = new CurrentPricingResponse(58, 10, 35, 40);
        _logger.LogInformation("Got a request for the current pricing " + response);
        return Ok(response); // Return a 200 response.
    }

}



public record CurrentPricingResponse(decimal baseAmount, decimal waterDaily, decimal electicalDaily, decimal lakeFrontDaily);
