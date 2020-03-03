namespace OpenDotaDotNet.Endpoints
{
    using System.Threading.Tasks;

    using OpenDotaDotNet.Models.HealthStatus;

    public class StatusEndpoint : IStatusEndpoint
    {
        private readonly Requester requester;

        public StatusEndpoint(Requester requester)
        {
            this.requester = requester;
        }

        /// <summary>
        /// Get current service statistics.
        /// </summary>
        /// <returns>Current service statistics.</returns>
        public async Task<ServiceStatistics> GetServiceStatisticsAsync() =>
            await this.requester.GetResponseAsync<ServiceStatistics>("status");
    }
}
