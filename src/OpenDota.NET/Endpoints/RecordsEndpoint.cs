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
        public async Task<IEnumerable<Record>> GetRecordsByFieldAsync(RecordField field) =>
            await this.requester.GetResponseAsync<IEnumerable<Record>>($"records/{field.Value}");
    }
}
