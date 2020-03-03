namespace OpenDotaDotNet.Endpoints
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using OpenDotaDotNet.Models.FindMatches;

    public class FindMatchEndpoint : IFindMatchEndpoint
    {
        private readonly Requester requester;

        public FindMatchEndpoint(Requester requester)
        {
            this.requester = requester;
        }

        /// <summary>
        /// Finds matches by heroes played (currently includes matches played after April 2019).
        /// </summary>
        /// <param name="teamA"></param>
        /// <param name="teamB"></param>
        /// <returns>Matched found.</returns>
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
                    addedArguments.Add($@"teamA={heroId}");
                }
            }

            if (teamB != null)
            {
                foreach (var heroId in teamB)
                {
                    addedArguments.Add($@"teamB={heroId}");
                }
            }

            return addedArguments;
        }
    }
}
