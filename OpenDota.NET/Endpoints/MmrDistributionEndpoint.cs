namespace OpenDotaDotNet.Endpoints
{
    using System.Threading.Tasks;

    using OpenDotaDotNet.Models.Distributions;

    public class MmrDistributionEndpoint : IMmrDistributionEndpoint
    {
        private readonly Requester requester;

        public MmrDistributionEndpoint(Requester requester)
        {
            this.requester = requester;
        }

        /// <summary>
        /// Gets distributions of MMR data by bracket and country.
        /// </summary>
        /// <returns>Distributions of MMR data by bracket and country.</returns>
        public async Task<MmrDistribution> GetMmrDistributionAsync() =>
            await this.requester.GetResponseAsync<MmrDistribution>("distributions");
    }
}
