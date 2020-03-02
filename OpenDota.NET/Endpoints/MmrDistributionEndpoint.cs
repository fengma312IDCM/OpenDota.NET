using Newtonsoft.Json;
using OpenDotaDotNet.Interfaces;
using OpenDotaDotNet.Models.Distributions;

using System.Threading.Tasks;

namespace OpenDotaDotNet.Endpoints
{
    public class MmrDistributionEndpoint : IMmrDistributionEndpoint
    {
        private const string MmrDistribution = "distributions";

        private readonly Requester requester;

        public MmrDistributionEndpoint(Requester requester)
        {
            this.requester = requester;
        }

        /// <summary>
        /// Distributions of MMR data by bracket and country
        /// </summary>
        /// <returns></returns>
        public async Task<MmrDistribution> GetMmrDistributionAsync()
        {
            var response = await this.requester.GetRequestResponseMessageAsync(MmrDistribution);

            response.EnsureSuccessStatusCode();

            var mmrDistribution = JsonConvert.DeserializeObject<MmrDistribution>(await response.Content.ReadAsStringAsync());

            return mmrDistribution;
        }
    }
}
