using Newtonsoft.Json;
using OpenDotaDotNet.Interfaces;
using OpenDotaDotNet.Models.HealthStatus;

using System.Threading.Tasks;

namespace OpenDotaDotNet.Endpoints
{
    public class HealthEndpoint : IHealthEndpoint
    {
        private const string ServiceHealth = "health";

        private readonly Requester requester;

        public HealthEndpoint(Requester requester)
        {
            this.requester = requester;
        }

        /// <summary>
        /// Get service health data
        /// </summary>
        /// <returns></returns>
        public async Task<ServiceHealth> GetServiceHealthDataAsync()
        {
            var response = await this.requester.GetRequestResponseMessageAsync(ServiceHealth);

            response.EnsureSuccessStatusCode();

            var serviceHealth = JsonConvert.DeserializeObject<ServiceHealth>(await response.Content.ReadAsStringAsync());

            return serviceHealth;
        }
    }
}
