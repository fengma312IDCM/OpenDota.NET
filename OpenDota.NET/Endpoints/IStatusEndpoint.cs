namespace OpenDotaDotNet.Endpoints
{
    using System.Threading.Tasks;

    using OpenDotaDotNet.Models.HealthStatus;

    public interface IStatusEndpoint
    {
        /// <summary>
        /// Get current service statistics
        /// </summary>
        /// <returns></returns>
        Task<ServiceStatistics> GetServiceStatisticsAsync();
    }
}
