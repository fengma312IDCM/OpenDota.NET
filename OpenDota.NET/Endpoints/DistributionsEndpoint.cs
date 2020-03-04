namespace OpenDotaDotNet.Endpoints
{
    using System.Threading.Tasks;

    using OpenDotaDotNet.Models.Distributions;

    public class DistributionsEndpoint : IDistributionsEndpoint
    {
        private readonly Requester requester;

        public DistributionsEndpoint(Requester requester)
        {
            this.requester = requester;
        }

        /// <inheritdoc />
        public async Task<MmrDistribution> GetDistributionsAsync() =>
            await this.requester.GetResponseAsync<MmrDistribution>("distributions");
    }
}
