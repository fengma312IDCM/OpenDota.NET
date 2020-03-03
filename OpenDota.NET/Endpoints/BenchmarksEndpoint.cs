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

        /// <inheritdoc />
        public async Task<HeroBenchmark> GetHeroBenchmarkAsync(int heroId) =>
            await this.requester.GetResponseAsync<HeroBenchmark>(
                "benchmarks",
                new List<string>
                    {
                        $"hero_id={heroId}",
                    });
    }
}
