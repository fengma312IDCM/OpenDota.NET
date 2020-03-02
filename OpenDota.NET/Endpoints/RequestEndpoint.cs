namespace OpenDotaDotNet.Endpoints
{
    using System.Threading.Tasks;

    using Newtonsoft.Json;

    using OpenDotaDotNet.Models.Request;

    public class RequestEndpoint : IRequestEndpoint
    {
        private const string GetParseState = "request/{0}";
        private const string SubmitNewParse = "request/{0}";

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
        public async Task<ParseRequestState> GetParseRequestStateAsync(long jobId)
        {
            var response = await this.requester.GetRequestResponseMessageAsync(string.Format(GetParseState, jobId));

            response.EnsureSuccessStatusCode();

            var parseRequestState = JsonConvert.DeserializeObject<ParseRequestState>(await response.Content.ReadAsStringAsync());

            return parseRequestState;
        }

        /// <summary>
        /// Submit a new parse requester.
        /// </summary>
        /// <param name="matchId"></param>
        /// <returns>Parse request object.</returns>
        public async Task<ParseRequest> SubmitNewParseRequestAsync(long matchId)
        {
            var response = await this.requester.PostRequest(string.Format(SubmitNewParse, matchId));

            response.EnsureSuccessStatusCode();

            var parseRequest = JsonConvert.DeserializeObject<ParseRequest>(await response.Content.ReadAsStringAsync());

            return parseRequest;
        }
    }
}
