namespace OpenDotaDotNet.Endpoints
{
    using System.Text.Json;
    using System.Threading.Tasks;

    using OpenDotaDotNet.Models.Request;

    public class RequestEndpoint : IRequestEndpoint
    {
        private readonly Requester requester;

        public RequestEndpoint(Requester requester)
        {
            this.requester = requester;
        }

        /// <summary>
        /// Get parse requester state.
        /// </summary>
        /// <param name="jobId"></param>
        /// <returns>Parse requester state.</returns>
        public async Task<ParseRequestState> GetParseRequestStateAsync(long jobId) =>
            await this.requester.GetResponseAsync<ParseRequestState>($"request/{jobId}");

        /// <summary>
        /// Submit a new parse requester.
        /// </summary>
        /// <param name="matchId"></param>
        /// <returns>Parse request object.</returns>
        public async Task<ParseRequest> SubmitNewParseRequestAsync(long matchId)
        {
            var response = await this.requester.PostRequest($"request/{matchId}");
            response.EnsureSuccessStatusCode();
            var parseRequest = JsonSerializer.Deserialize<ParseRequest>(await response.Content.ReadAsStringAsync());
            return parseRequest;
        }
    }
}
