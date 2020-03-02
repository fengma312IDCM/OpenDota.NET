namespace OpenDotaDotNet.Endpoints
{
    using System.Threading.Tasks;

    using Newtonsoft.Json;

    using OpenDotaDotNet.Models.Metadata;

    public class MetadataEndpoint : IMetadataEndpoint
    {
        private const string Metadata = "metadata";

        private readonly Requester requester;

        public MetadataEndpoint(Requester requester)
        {
            this.requester = requester;
        }

        /// <summary>
        /// Gets site metadata.
        /// </summary>
        /// <returns>Site metadata.</returns>
        public async Task<Metadata> GetMetadataAsync()
        {
            var response = await this.requester.GetRequestResponseMessageAsync(Metadata);

            response.EnsureSuccessStatusCode();

            var metadata = JsonConvert.DeserializeObject<Metadata>(await response.Content.ReadAsStringAsync());

            return metadata;
        }
    }
}
