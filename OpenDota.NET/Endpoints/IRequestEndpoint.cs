namespace OpenDotaDotNet.Endpoints
{
    using System.Threading.Tasks;

    using OpenDotaDotNet.Models.Request;

    public interface IRequestEndpoint
    {
        /// <summary>
        /// Get parse request state.
        /// </summary>
        /// <param name="jobId"></param>
        /// <returns>Parse request state.</returns>
        Task<ParseRequestState> GetParseRequestStateAsync(long jobId);

        /// <summary>
        /// Submit a new parse request.
        /// </summary>
        /// <param name="matchId"></param>
        /// <returns>Parse request object.</returns>
        Task<ParseRequest> SubmitNewParseRequestAsync(long matchId);
    }
}
