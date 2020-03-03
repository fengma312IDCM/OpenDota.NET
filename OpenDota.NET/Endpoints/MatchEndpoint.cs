namespace OpenDotaDotNet.Endpoints
{
    using System.Threading.Tasks;

    using OpenDotaDotNet.Models.Matches;

    public class MatchEndpoint : IMatchEndpoint
    {
        private readonly Requester requester;

        public MatchEndpoint(Requester requester)
        {
            this.requester = requester;
        }

        public async Task<Match> GetMatchByIdAsync(long matchId) =>
            await this.requester.GetResponseAsync<Match>($"matches/{matchId}");
    }
}
