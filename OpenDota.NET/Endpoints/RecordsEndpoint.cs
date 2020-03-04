namespace OpenDotaDotNet.Endpoints
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using OpenDotaDotNet.Models.Records;

    public class RecordsEndpoint : IRecordsEndpoint
    {
        private readonly Requester requester;

        public RecordsEndpoint(Requester requester)
        {
            this.requester = requester;
        }

        /// <inheritdoc />
        public async Task<List<Record>> GetRecordsByFieldAsync(RecordField field) =>
            await this.requester.GetResponseAsync<List<Record>>($"records/{field.Value}");
    }
}
