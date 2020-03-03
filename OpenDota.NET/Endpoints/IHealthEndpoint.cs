namespace OpenDotaDotNet.Endpoints
{
    using System.Threading.Tasks;

    using OpenDotaDotNet.Models.HealthStatus;

    public interface IHealthEndpoint
    {
        /// <summary>
        /// Get service health data.
        /// </summary>
        /// <returns>Service health data</returns>
        Task<ServiceHealth> GetServiceHealthDataAsync();
    }
}
