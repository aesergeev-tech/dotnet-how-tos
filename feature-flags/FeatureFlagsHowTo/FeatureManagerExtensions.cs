using Microsoft.FeatureManagement;

namespace FeatureFlagsHowTo;

public static class FeatureManagerExtensions
{
    public static async Task<bool> IsDisabledAsync(this IFeatureManager featureManager, string featureName){
        return (await featureManager.IsEnabledAsync(featureName)) == false;
    }
}
