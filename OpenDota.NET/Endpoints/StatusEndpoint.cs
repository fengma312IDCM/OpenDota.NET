namespace OpenDotaDotNet.Endpoints
{
    using System.Threading.Tasks;

    using Newtonsoft.Json;

    using OpenDotaDotNet.Models.HealthStatus;

    public class StatusEndpoint : IStatusEndpoint
    {
        private const string ServiceStatistics = "status";

        private readonly Requester requester;

        public StatusEndpoint(Requester requester)
        {
            this.requester = requester;
        }

        /// <summary>
        /// Get current service statistics.
        /// </summary>
        /// <returns>Current service statistics.</returns>
        public async Task<ServiceStatistics> GetServiceStatisticsAsync()
        {
            var response = await this.requester.GetRequestResponseMessageAsync(ServiceStatistics);

            response.EnsureSuccessStatusCode();

            var serviceStatistics = JsonConvert.DeserializeObject<ServiceStatistics>(await response.Content.ReadAsStringAsync());

            return serviceStatistics;
        }
    }
}
