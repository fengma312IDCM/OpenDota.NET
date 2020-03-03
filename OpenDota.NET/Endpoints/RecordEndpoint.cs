namespace OpenDotaDotNet.Endpoints
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using OpenDotaDotNet.Models.Records;

    public class RecordEndpoint : IRecordEndpoint
    {
        private readonly Requester requester;

        public RecordEndpoint(Requester requester)
        {
            this.requester = requester;
        }

        /// <summary>
        /// Get top performances in a stat.
        /// </summary>
        /// <param name="field">Field name to query.</param>
        /// <returns>Top performances in a stat.</returns>
        public async Task<List<Record>> GetRecordsByFieldAsync(RecordField field) =>
            await this.requester.GetResponseAsync<List<Record>>($"records/{field.Value}");
    }
}
