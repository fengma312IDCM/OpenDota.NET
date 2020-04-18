namespace OpenDotaDotNet.Endpoints
{
    using System.Threading.Tasks;

    using OpenDotaDotNet.Models.Distributions;

    public interface IDistributionsEndpoint
    {
        /// <summary>
        /// Gets distributions of MMR data by bracket and country.
        /// </summary>
        /// <returns>Distributions of MMR data by bracket and country.</returns>
        Task<MmrDistribution> GetDistributionsAsync();
    }
}
