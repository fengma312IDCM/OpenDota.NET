namespace OpenDotaDotNet.Endpoints
{
    using System.Threading.Tasks;

    using OpenDotaDotNet.Models.Metadata;

    public class MetadataEndpoint : IMetadataEndpoint
    {
        private readonly Requester requester;

        public MetadataEndpoint(Requester requester)
        {
            this.requester = requester;
        }

        /// <summary>
        /// Gets site metadata.
        /// </summary>
        /// <returns>Site metadata.</returns>
        public async Task<Metadata> GetMetadataAsync() =>
            await this.requester.GetResponseAsync<Metadata>("metadata");
    }
}
