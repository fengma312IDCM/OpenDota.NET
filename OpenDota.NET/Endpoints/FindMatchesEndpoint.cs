namespace OpenDotaDotNet.Endpoints
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using OpenDotaDotNet.Models.FindMatches;

    public class FindMatchesEndpoint : IFindMatchesEndpoint
    {
        private readonly Requester requester;

        public FindMatchesEndpoint(Requester requester)
        {
            this.requester = requester;
        }

        /// <inheritdoc />
        public async Task<List<FindMatch>>
            FindMatchesByHeroesPlayedAsync(List<int> teamA = null, List<int> teamB = null) =>
            await this.requester.GetResponseAsync<List<FindMatch>>(
                "findMatches",
                this.CreateArgumentListForFindMatchesRequest(teamA, teamB));

        private List<string> CreateArgumentListForFindMatchesRequest(
            IReadOnlyCollection<int> teamA = null,
            IReadOnlyCollection<int> teamB = null)
        {
            var addedArguments = new List<string>();

            if (teamA != null)
            {
                foreach (var heroId in teamA)
                {
                    addedArguments.Add($"teamA={heroId}");
                }
            }

            if (teamB != null)
            {
                foreach (var heroId in teamB)
                {
                    addedArguments.Add($"teamB={heroId}");
                }
            }

            return addedArguments;
        }
    }
}
