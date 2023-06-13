
# Dell.CloudIq.Api
[![Nuget](https://img.shields.io/nuget/v/Dell.CloudIq.Api)](https://www.nuget.org/packages/Dell.CloudIq.Api/)
[![Nuget](https://img.shields.io/nuget/dt/Dell.CloudIq.Api)](https://www.nuget.org/packages/Dell.CloudIq.Api/)
[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)
[![Codacy Badge](https://app.codacy.com/project/badge/Grade/8b910ff2f22d464688acbe0d2a41e61c)](https://app.codacy.com?utm_source=gh&utm_medium=referral&utm_content=&utm_campaign=Badge_grade)

API client for the Dell Cloud IQ REST API

To use the package, follow the instructions below:

# Visual Studio

1.  Open your project in Visual Studio

2.  Right-click on the project and click "Manage Nuget packages"

3.  Find the package "Dell.CloudIq.Api" - install the latest version


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
            using var cloudIqClient = new CloudIqClient(new CloudIqClientOptions
            {
                ClientId = "xxx"
                ClientSecret = "xxx"
                BaseUri = "xxx"
            });

            var systems = await cloudIqClient
                .System
                .GetSystemsAsync()
                .ConfigureAwait(false);
        }
    }
}
````

Remember to substitute your own ClientId, ClientSecret and BaseUri.

## API Documentation
The CloudIQ API documentation can be found here:

-    [CloudIQ API Documentation v1](https://developer.dell.com/apis/d1d6171c-cf6b-49c8-a3de-7994b6069d1a/versions/v1/docs/01-Introduction.md)
