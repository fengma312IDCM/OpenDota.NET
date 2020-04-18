namespace OpenDota.NET.Tests
{
    using OpenDotaDotNet;

    using Xunit.Abstractions;

    public class RequestEndpointTests
    {
        private readonly ITestOutputHelper testOutputHelper;

        private readonly OpenDotaApi openDotaApi;

        public RequestEndpointTests(ITestOutputHelper testOutputHelper)
        {
            this.testOutputHelper = testOutputHelper;
            this.openDotaApi = new OpenDotaApi();
        }

        // Unable to test these endpoints:
        // GetParseRequestStateAsync - Cannot get valid request for testing because every request is immediately deleted.
        // SubmitNewParseRequestAsync - This endpoint requires changing data so testing it is not safe.
    }
}
