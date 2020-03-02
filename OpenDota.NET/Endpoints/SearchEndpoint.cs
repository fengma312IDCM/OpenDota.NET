namespace OpenDotaDotNet.Endpoints
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using Newtonsoft.Json;

    using OpenDotaDotNet.Models.Search;

    public class SearchEndpoint : ISearchEndpoint
    {
        private const string Search = "search";

        private readonly Requester requester;

        public SearchEndpoint(Requester requester)
        {
            this.requester = requester;
        }

        /// <summary>
        /// Search players by personaname.
        /// </summary>
        /// <param name="query"></param>
        /// <returns>Players by personaname.</returns>
        public async Task<List<SearchPlayerResponse>> GetPlayersByNameAsync(string query)
        {
            var addedArguments = this.CreateArgumentListForSearchPlayersRequest(query);

            var response = await this.requester.GetRequestResponseMessageAsync(Search, addedArguments);

            response.EnsureSuccessStatusCode();

            var players = JsonConvert.DeserializeObject<List<SearchPlayerResponse>>(await response.Content.ReadAsStringAsync());

            return players;
        }

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
