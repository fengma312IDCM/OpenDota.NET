namespace OpenDotaDotNet.Endpoints
{
    using System.Threading.Tasks;

    using OpenDotaDotNet.Models.Metadata;

    public interface IMetadataEndpoint
    {
        /// <summary>
        /// Gets site metadata.
        /// </summary>
        /// <returns>Site metadata.</returns>
        Task<Metadata> GetMetadataAsync();
    }
}
