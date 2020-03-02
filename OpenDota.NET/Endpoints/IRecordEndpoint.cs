namespace OpenDotaDotNet.Endpoints
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using OpenDotaDotNet.Models.Records;

    public interface IRecordEndpoint
    {
        /// <summary>
        /// Get top performances in a stat.
        /// </summary>
        /// <param name="field">Field name to query.</param>
        /// <returns></returns>
        Task<List<Record>> GetRecordsByFieldAsync(RecordField field);
    }
}
