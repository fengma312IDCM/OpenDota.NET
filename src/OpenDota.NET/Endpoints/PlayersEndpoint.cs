namespace OpenDotaDotNet.Endpoints
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using OpenDotaDotNet.Models.Players;

    public class PlayersEndpoint : IPlayersEndpoint
    {
        private readonly Requester requester;

        public PlayersEndpoint(Requester requester)
        {
            this.requester = requester;
        }

        /// <inheritdoc />
        public async Task<Player> GetPlayerByIdAsync(long playerId) =>
            await this.requester.GetResponseAsync<Player>($"players/{playerId}");

        /// <inheritdoc />
        public async Task<PlayerWinLoss> GetPlayerWinLossByIdAsync(
            long playerId,
            PlayerEndpointParameters parameters = null) =>
            await this.requester.GetResponseAsync<PlayerWinLoss>(
                $"players/{playerId}/wl",
                this.GetArguments(parameters));

        /// <inheritdoc />
        public async Task<IEnumerable<PlayerRecentMatch>> GetPlayerRecentMatchesAsync(long playerId) =>
            await this.requester.GetResponseAsync<IEnumerable<PlayerRecentMatch>>($"players/{playerId}/recentMatches");

        /// <inheritdoc />
        public async Task<IEnumerable<PlayerMatch>> GetPlayerMatchesAsync(
            long playerId,
            PlayerEndpointParameters parameters = null) =>
            await this.requester.GetResponseAsync<IEnumerable<PlayerMatch>>(
                $"players/{playerId}/matches",
                this.GetArguments(parameters));

        /// <inheritdoc />
        public async Task<IEnumerable<PlayerHero>>
            GetPlayerHeroesAsync(long playerId, PlayerEndpointParameters parameters = null) =>
            await this.requester.GetResponseAsync<IEnumerable<PlayerHero>>(
                $"players/{playerId}/heroes",
                this.GetArguments(parameters));

        /// <inheritdoc />
        public async Task<IEnumerable<PlayerPeer>> GetPlayerPeersAsync(long playerId, PlayerEndpointParameters parameters) =>
            await this.requester.GetResponseAsync<IEnumerable<PlayerPeer>>(
                $"players/{playerId}/peers",
                this.GetArguments(parameters));

        /// <inheritdoc />
        public async Task<IEnumerable<PlayerPro>> GetPlayerProsAsync(long playerId, PlayerEndpointParameters parameters) =>
            await this.requester.GetResponseAsync<IEnumerable<PlayerPro>>(
                $"players/{playerId}/pros",
                this.GetArguments(parameters));

        /// <inheritdoc />
        public async Task<IEnumerable<PlayerTotal>> GetPlayerTotalsAsync(long playerId, PlayerEndpointParameters parameters) =>
            await this.requester.GetResponseAsync<IEnumerable<PlayerTotal>>(
                $"players/{playerId}/totals",
                this.GetArguments(parameters));

        /// <inheritdoc />
        public async Task<PlayerCount> GetPlayerCountsAsync(long playerId, PlayerEndpointParameters parameters) =>
            await this.requester.GetResponseAsync<PlayerCount>(
                $"players/{playerId}/counts",
                this.GetArguments(parameters));

        /// <inheritdoc />
        public async Task<IEnumerable<PlayerHistogram>> GetPlayerHistogramsAsync(long playerId, string field, PlayerEndpointParameters parameters) =>
            await this.requester.GetResponseAsync<IEnumerable<PlayerHistogram>>(
                $"players/{playerId}/histograms/{field}",
                this.GetArguments(parameters));

        /// <inheritdoc />
        public async Task<PlayerWardmap> GetPlayerWardMapAsync(long playerId, PlayerEndpointParameters parameters) =>
            await this.requester.GetResponseAsync<PlayerWardmap>(
                $"players/{playerId}/wardmap",
                this.GetArguments(parameters));

        /// <inheritdoc />
        public async Task<PlayerWordcloud> GetPlayerWordCloudAsync(long playerId, PlayerEndpointParameters parameters) =>
            await this.requester.GetResponseAsync<PlayerWordcloud>(
                $"players/{playerId}/wordcloud",
                this.GetArguments(parameters));

        /// <inheritdoc />
        public async Task<IEnumerable<PlayerRating>> GetPlayerRatingsAsync(long playerId) =>
            await this.requester.GetResponseAsync<IEnumerable<PlayerRating>>($"players/{playerId}/ratings");

        /// <inheritdoc />
        public async Task<IEnumerable<PlayerHeroRanking>> GetPlayerHeroRankingsAsync(long playerId) =>
            await this.requester.GetResponseAsync<IEnumerable<PlayerHeroRanking>>($"players/{playerId}/rankings");

        /// <inheritdoc />
        public async Task<bool> RefreshPlayerMatchHistoryAsync(long playerId)
        {
            var response = await this.requester.PostRequest($"players/{playerId}/refresh");
            response.EnsureSuccessStatusCode();
            return true;
        }

        private IEnumerable<string> GetArguments(PlayerEndpointParameters parameters)
        {
            var addedArguments = new List<string>();

            if (parameters == null)
            {
                return addedArguments;
            }

            if (parameters.Limit != null)
            {
                addedArguments.Add($@"limit={parameters.Limit}");
            }

            if (parameters.Offset != null)
            {
                addedArguments.Add($@"offset={parameters.Offset}");
            }

            if (parameters.Win != null)
            {
                addedArguments.Add($@"win={parameters.Win}");
            }

            if (parameters.Patch != null)
            {
                addedArguments.Add($@"patch={parameters.Patch}");
            }

            if (parameters.GameMode != null)
            {
                addedArguments.Add($@"game_mode={parameters.GameMode}");
            }

            if (parameters.LobbyType != null)
            {
                addedArguments.Add($@"lobby_type={parameters.LobbyType}");
            }

            if (parameters.Region != null)
            {
                addedArguments.Add($@"region={parameters.Region}");
            }

            if (parameters.Date != null)
            {
                addedArguments.Add($@"date={parameters.Date}");
            }

            if (parameters.LaneRole != null)
            {
                addedArguments.Add($@"lane_role={parameters.LaneRole}");
            }

            if (parameters.HeroId != null)
            {
                addedArguments.Add($@"hero_id={parameters.HeroId}");
            }

            if (parameters.IsRadiant != null)
            {
                addedArguments.Add($@"is_radiant={parameters.IsRadiant}");
            }

            if (parameters.IncludedAccountIds != null)
            {
                addedArguments.AddRange(
                    parameters.IncludedAccountIds.Select(
                        includedAccountId => $@"included_account_id={includedAccountId}"));
            }

            if (parameters.ExcludedAccountIds != null)
            {
                addedArguments.AddRange(
                    parameters.ExcludedAccountIds.Select(
                        excludedAccountId => $@"excluded_account_id={excludedAccountId}"));
            }

            if (parameters.WithHeroIds != null)
            {
                addedArguments.AddRange(parameters.WithHeroIds.Select(withHeroId => $@"with_hero_id={withHeroId}"));
            }

            if (parameters.AgainstHeroIds != null)
            {
                addedArguments.AddRange(parameters.AgainstHeroIds.Select(againstHeroId => $@"against_hero_id={againstHeroId}"));
            }

            if (parameters.Significant != null)
            {
                addedArguments.Add($@"significant={parameters.Significant}");
            }

            if (parameters.Having != null)
            {
                addedArguments.Add($@"having={parameters.Having}");
            }

            if (parameters.Sort != null)
            {
                addedArguments.Add($@"sort={parameters.Sort}");
            }

            if (parameters.Project != null)
            {
                addedArguments.AddRange(parameters.Project.Select(project => $@"project={project}"));
            }

            return addedArguments;
        }
    }
}
