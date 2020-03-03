namespace OpenDotaDotNet.Endpoints
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using OpenDotaDotNet.Models.Benchmarks;

    public class BenchmarksEndpoint : IBenchmarkEndpoint
    {
        private readonly Requester requester;

        public BenchmarksEndpoint(Requester requester)
        {
            this.requester = requester;
        }

        public async Task<HeroBenchmark> GetHeroBenchmarkAsync(int heroId) =>
            await this.requester.GetResponseAsync<HeroBenchmark>(
                "benchmarks",
                this.CreateArgumentListForBenchmarksRequest(heroId));

        private List<string> CreateArgumentListForBenchmarksRequest(int? heroId = null)
        {
            var addedArguments = new List<string>();

            if (heroId != null)
            {
                addedArguments.Add($@"hero_id={heroId}");
            }

            return addedArguments;
        }
    }
}
