using Newtonsoft.Json;

using OpenDotaDotNet.Models.Metadata;

using System.Threading.Tasks;

namespace OpenDotaDotNet.Endpoints
{
    class MetadataEndpoint : IMetadataEndpoint
    {
        private const string Metadata = "metadata";

        private readonly Requester requester;

        public MetadataEndpoint(Requester requester)
        {
            this.requester = requester;
        }

        /// <summary>
        /// Site metadata
        /// </summary>
        /// <returns></returns>
        public async Task<Metadata> GetMetadataAsync()
        {
            var response = await this.requester.GetRequestResponseMessageAsync(Metadata);

            response.EnsureSuccessStatusCode();

            var metadata = JsonConvert.DeserializeObject<Metadata>(await response.Content.ReadAsStringAsync());

            return metadata;
        }
    }
}
