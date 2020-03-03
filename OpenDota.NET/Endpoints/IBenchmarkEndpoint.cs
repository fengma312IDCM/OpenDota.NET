namespace OpenDotaDotNet.Endpoints
{
    using System.Threading.Tasks;

    using OpenDotaDotNet.Models.Benchmarks;

    public interface IBenchmarkEndpoint
    {
        /// <summary>
        /// Gets benchmarks of average stat values for a hero.
        /// </summary>
        /// <param name="heroId"></param>
        /// <returns>Benchmarks of average stat values for a hero.</returns>
        Task<HeroBenchmark> GetHeroBenchmarkAsync(int heroId);
    }
}
