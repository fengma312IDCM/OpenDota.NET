namespace OpenDotaDotNet.Endpoints
{
    using System.Threading.Tasks;

    using OpenDotaDotNet.Models.Matches;

    public class MatchesEndpoint : IMatchesEndpoint
    {
        private readonly Requester requester;

        public MatchesEndpoint(Requester requester)
        {
            this.requester = requester;
        }

        /// <inheritdoc />
        public async Task<Match> GetMatchByIdAsync(long matchId) =>
            await this.requester.GetResponseAsync<Match>($"matches/{matchId}");
    }
}
