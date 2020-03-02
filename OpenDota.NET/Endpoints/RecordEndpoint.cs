namespace OpenDotaDotNet.Endpoints
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using Newtonsoft.Json;

    using OpenDotaDotNet.Models.Records;

    public class RecordEndpoint : IRecordEndpoint
    {
        private const string Records = "records/{0}";

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
        public async Task<List<Record>> GetRecordsByFieldAsync(RecordField field)
        {
            var response = await this.requester.GetRequestResponseMessageAsync(string.Format(Records, field.Value));

            response.EnsureSuccessStatusCode();

            var records = JsonConvert.DeserializeObject<List<Record>>(await response.Content.ReadAsStringAsync());

            return records;
        }
    }
}
