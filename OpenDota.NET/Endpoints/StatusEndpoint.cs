using Newtonsoft.Json;
using OpenDotaDotNet.Interfaces;
using OpenDotaDotNet.Models.HealthStatus;

using System.Threading.Tasks;

namespace OpenDotaDotNet.Endpoints
{
    public class StatusEndpoint : IStatusEndpoint
    {
        private const string ServiceStatistics = "status";

        private readonly Requester requester;

        public StatusEndpoint(Requester requester)
        {
            this.requester = requester;
        }

        /// <summary>
        /// Get current service statistics
        /// </summary>
        /// <returns></returns>
        public async Task<ServiceStatistics> GetServiceStatisticsAsync()
        {
            var response = await this.requester.GetRequestResponseMessageAsync(ServiceStatistics);

            response.EnsureSuccessStatusCode();

            var serviceStatistics = JsonConvert.DeserializeObject<ServiceStatistics>(await response.Content.ReadAsStringAsync());

            return serviceStatistics;
        }
    }
}
