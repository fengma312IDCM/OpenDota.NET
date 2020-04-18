namespace OpenDotaDotNet.Endpoints
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using OpenDotaDotNet.Models.ProMatches;

    public class FeedEndpoint : IFeedEndpoint
    {
        private readonly Requester requester;

        public FeedEndpoint(Requester requester)
        {
            this.requester = requester;
        }

        /// <inheritdoc />
        public async Task<IEnumerable<ProMatch>> GetFeedAsync(
            long? sequenceNumber = null,
            int? gameMode = null,
            int? leagueId = null,
            long? includedAccountId = null) =>
            await this.requester.GetResponseAsync<IEnumerable<ProMatch>>(
                "feed",
                this.GetArguments(sequenceNumber, gameMode, leagueId, includedAccountId));

        private IEnumerable<string> GetArguments(
            long? sequenceNumber = null,
            int? gameMode = null,
            int? leagueId = null,
            long? includedAccountId = null)
        {
            var addedArguments = new List<string>();
            if (sequenceNumber != null)
            {
                addedArguments.Add($"sequenceNumber={sequenceNumber}");
            }

            if (gameMode != null)
            {
                addedArguments.Add($"gameMode={gameMode}");
            }

            if (leagueId != null)
            {
                addedArguments.Add($"leagueId={leagueId}");
            }

            if (includedAccountId != null)
            {
                addedArguments.Add($"includedAccountId={includedAccountId}");
            }

            return addedArguments;
        }
    }
}
