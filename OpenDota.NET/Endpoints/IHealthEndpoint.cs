namespace OpenDotaDotNet.Endpoints
{
    using System.Threading.Tasks;

    using OpenDotaDotNet.Models.HealthStatus;

    public interface IHealthEndpoint
    {
        /// <summary>
        /// Get service health data
        /// </summary>
        /// <returns></returns>
        Task<ServiceHealth> GetServiceHealthDataAsync();
    }
}
