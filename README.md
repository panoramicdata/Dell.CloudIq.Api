# Dell.CloudIQ.Api
API client for the Dell CloudIQ REST API

# Visual Studio
1. Open your project in Visual Studio
2. Right-click on the project and click "Manage Nuget packages"
3. Find the package "Dell.CloudIq.Api" - install the latest version

# Example code (C# 11.0):
``` C#
using Dell.CloudIq.Api;
using System;
using System.Threading.Tasks;

namespace My.Project
{
    public static class Program
    {
        public static async Task Main()
        {
            using var cloudIqClient = new CloudIQClient(new CloudIQClientOptions
            {
                ClientId = "0123456789abcdef0123456789abcdef01234567"
                ClientSecret = "0123456789abcdef0123456789abcdef01234567"
                BaseUri = "XXXXXXX"
            });

            var systems = await cloudIqClient
                .System
                .GetSystemsAsync()
                .ConfigureAwait(false);
        }
    }
}
````


## API Documentation
The CloudIQ API documentation can be found here:

  - [CloudIQ API Documentation v1](https://developer.dell.com/apis/d1d6171c-cf6b-49c8-a3de-7994b6069d1a/versions/v1/docs/01-Introduction.md)
