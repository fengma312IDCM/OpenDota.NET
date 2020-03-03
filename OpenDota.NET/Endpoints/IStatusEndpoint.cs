namespace OpenDotaDotNet.Endpoints
{
    using System.Threading.Tasks;

    using OpenDotaDotNet.Models.HealthStatus;

    public interface IStatusEndpoint
    {
        /// <summary>
        /// Get current service statistics.
        /// </summary>
        /// <returns>Current service statistics.</returns>
        Task<ServiceStatistics> GetServiceStatisticsAsync();
    }
}
