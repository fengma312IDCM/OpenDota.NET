namespace OpenDotaDotNet.Endpoints
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using OpenDotaDotNet.Models.Records;

    public interface IRecordsEndpoint
    {
        /// <summary>
        /// Get records in ranked matches. Records reset monthly.
        /// </summary>
        /// <param name="field">Field name to query.</param>
        /// <returns>Records in ranked matches.</returns>
        Task<IEnumerable<Record>> GetRecordsByFieldAsync(RecordField field);
    }
}
