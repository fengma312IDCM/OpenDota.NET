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

        /// <inheritdoc />
        public async Task<ServiceStatistics> GetServiceStatisticsAsync() =>
            await this.requester.GetResponseAsync<ServiceStatistics>("status");
    }
}
