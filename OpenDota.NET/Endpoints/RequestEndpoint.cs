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

        /// <inheritdoc />
        public async Task<ParseRequestState> GetParseRequestStateAsync(long jobId) =>
            await this.requester.GetResponseAsync<ParseRequestState>($"request/{jobId}");

        /// <inheritdoc />
        public async Task<ParseRequest> SubmitNewParseRequestAsync(long matchId)
        {
            var response = await this.requester.PostRequest($"request/{matchId}");
            response.EnsureSuccessStatusCode();
            var parseRequest = JsonSerializer.Deserialize<ParseRequest>(await response.Content.ReadAsStringAsync());
            return parseRequest;
        }
    }
}
