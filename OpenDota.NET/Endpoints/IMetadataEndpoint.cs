namespace OpenDotaDotNet.Endpoints
{
    using System.Threading.Tasks;

    using OpenDotaDotNet.Models.Metadata;

    public interface IMetadataEndpoint
    {
        /// <summary>
        /// Site metadata
        /// </summary>
        /// <returns></returns>
        Task<Metadata> GetMetadataAsync();
    }
}
