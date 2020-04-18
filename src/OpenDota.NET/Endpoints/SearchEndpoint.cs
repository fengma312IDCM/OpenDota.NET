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
        public async Task<IEnumerable<SearchPlayerResponse>> GetPlayersByNameAsync(string query) =>
            await this.requester.GetResponseAsync<IEnumerable<SearchPlayerResponse>>(
                "search",
                new List<string>
                    {
                        $@"q={query}",
                    });
    }
}
