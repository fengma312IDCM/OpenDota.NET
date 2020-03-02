using Newtonsoft.Json;
using OpenDotaDotNet.Interfaces;
using OpenDotaDotNet.Models.Search;

using System.Collections.Generic;
using System.Threading.Tasks;

namespace OpenDotaDotNet.Endpoints
{
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
        /// <returns></returns>
        public async Task<List<SearchPlayerResponse>> GetPlayersByNameAsync(string query)
        {
            var addedArguments = CreateArgumentListForSearchPlayersRequest(query);

            var response = await this.requester.GetRequestResponseMessageAsync(Search, addedArguments);

            response.EnsureSuccessStatusCode();

            var players = JsonConvert.DeserializeObject<List<SearchPlayerResponse>>(await response.Content.ReadAsStringAsync());

            return players;
        }

        #region Helper
        private List<string> CreateArgumentListForSearchPlayersRequest(string query = null)
        {
            var addedArguments = new List<string>();

            if (query != null)
            {
                addedArguments.Add($@"q={query}");
            }

            return addedArguments;
        }
        #endregion
    }
}
