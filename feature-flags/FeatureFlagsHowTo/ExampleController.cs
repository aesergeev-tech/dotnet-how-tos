using Microsoft.AspNetCore.Mvc;
using Microsoft.FeatureManagement;

namespace FeatureFlagsHowTo;

[ApiController]
[Route("example")]
public class ExampleController : ControllerBase
{
    private readonly IFeatureManager _featureManager;

    public ExampleController(IFeatureManager featureManager)
    {
        _featureManager = featureManager;
    }

    [HttpGet]
    public async Task LogFeatureStates(){
        if(await _featureManager.IsEnabledAsync(FeatureFlagNames.FeatureA)){
            Console.WriteLine("Feature A is active");
        }
        if(await _featureManager.IsDisabledAsync(FeatureFlagNames.FeatureB)){
            Console.WriteLine("Feature B is not active");
        }
    }
}
