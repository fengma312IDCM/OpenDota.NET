namespace OpenDotaDotNet.Endpoints
{
    using System.Threading.Tasks;

    using OpenDotaDotNet.Models.Benchmarks;

    public interface IBenchmarkEndpoint
    {
        /// <summary>
        /// Benchmarks of average stat values for a hero
        /// </summary>
        /// <param name="heroId"></param>
        /// <returns></returns>
        Task<HeroBenchmark> GetHeroBenchmarkAsync(int heroId);
    }
}
