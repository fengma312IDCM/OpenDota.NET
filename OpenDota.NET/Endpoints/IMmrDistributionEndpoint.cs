namespace OpenDotaDotNet.Endpoints
{
    using System.Threading.Tasks;

    using OpenDotaDotNet.Models.Distributions;

    public interface IMmrDistributionEndpoint
    {
        /// <summary>
        /// Distributions of MMR data by bracket and country.
        /// </summary>
        /// <returns></returns>
        Task<MmrDistribution> GetMmrDistributionAsync();
    }
}
