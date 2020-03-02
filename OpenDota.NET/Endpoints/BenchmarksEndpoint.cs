namespace OpenDotaDotNet.Endpoints
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using Newtonsoft.Json;

    using OpenDotaDotNet.Models.Benchmarks;

    public class BenchmarksEndpoint : IBenchmarkEndpoint
    {
        private const string Benchmarks = "benchmarks";

        private readonly Requester requester;

        public BenchmarksEndpoint(Requester requester)
        {
            this.requester = requester;
        }

        public async Task<HeroBenchmark> GetHeroBenchmarkAsync(int heroId)
        {
            var addedArguments = this.CreateArgumentListForBenchmarksRequest(heroId);

            var response = await this.requester.GetRequestResponseMessageAsync(Benchmarks, addedArguments);

            response.EnsureSuccessStatusCode();

            var heroBenchmarks = JsonConvert.DeserializeObject<HeroBenchmark>(await response.Content.ReadAsStringAsync());

            return heroBenchmarks;
        }

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
