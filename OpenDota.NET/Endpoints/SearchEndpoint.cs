namespace OpenDotaDotNet.Endpoints
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using OpenDotaDotNet.Models.Search;

    public class SearchEndpoint : ISearchEndpoint
    {
        private readonly Requester requester;

        public SearchEndpoint(Requester requester)
        {
            this.requester = requester;
        }

        /// <inheritdoc />
        public async Task<List<SearchPlayerResponse>> GetPlayersByNameAsync(string query) =>
            await this.requester.GetResponseAsync<List<SearchPlayerResponse>>(
                "search",
                this.CreateArgumentListForSearchPlayersRequest(query));

        private List<string> CreateArgumentListForSearchPlayersRequest(string query = null)
        {
            var addedArguments = new List<string>();

            if (query != null)
            {
                addedArguments.Add($@"q={query}");
            }

            return addedArguments;
        }
    }
}
