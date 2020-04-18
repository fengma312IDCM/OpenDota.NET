namespace OpenDotaDotNet.Endpoints
{
    using System.Collections.Generic;
    using System.Linq;
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
        public async Task<IEnumerable<FindMatch>> FindMatchesByHeroesPlayedAsync(
            IEnumerable<int> teamA = null,
            IEnumerable<int> teamB = null) =>
            await this.requester.GetResponseAsync<IEnumerable<FindMatch>>(
                "findMatches",
                this.GetArguments(teamA, teamB));

        private IEnumerable<string> GetArguments(
            IEnumerable<int> teamA = null,
            IEnumerable<int> teamB = null)
        {
            var addedArguments = new List<string>();

            if (teamA != null)
            {
                addedArguments.AddRange(teamA.Select(heroId => $"teamA={heroId}"));
            }

            if (teamB != null)
            {
                addedArguments.AddRange(teamB.Select(heroId => $"teamB={heroId}"));
            }

            return addedArguments;
        }
    }
}
