namespace OpenDotaDotNet.Endpoints
{
    using System.Threading.Tasks;

    using OpenDotaDotNet.Models.HealthStatus;

    public class HealthEndpoint : IHealthEndpoint
    {
        private readonly Requester requester;

        public HealthEndpoint(Requester requester)
        {
            this.requester = requester;
        }

        /// <summary>
        /// Get service health data.
        /// </summary>
        /// <returns>Service health data.</returns>
        public async Task<ServiceHealth> GetServiceHealthDataAsync() =>
            await this.requester.GetResponseAsync<ServiceHealth>("health");
    }
}
