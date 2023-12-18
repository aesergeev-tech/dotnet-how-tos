# This repo contains the minimum amount of code necessary to demonstrate how to setup Feature Flags management in dotnet application.  

## Core steps. 

1. Install Microsoft.FeatureManagement.AspNetCore 
    ``` 
    dotnet add package Microsoft.FeatureManagement.AspNetCore
    ```
2. Add configuration to appsettings.json
    ```json 
    {
        "FeatureManagement": {
        "FeatureA": true, // Feature flag set to on
        "FeatureB": false, // Feature flag set to off
    }
    ```
3. Inject `IFeatureManager` to the required class
4. Call 
    ```
    featureManager.IsEnabledAsync(featureName)
    ```

I also added extension method `featureManager.IsDisabledAsync(featureName)`