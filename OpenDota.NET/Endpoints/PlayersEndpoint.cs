namespace OpenDotaDotNet.Endpoints
{
    using System.Collections.Generic;
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
                this.CreateArgumentListForPlayerEndpointRequest(parameters));

        /// <inheritdoc />
        public async Task<List<PlayerRecentMatch>> GetPlayerRecentMatchesAsync(long playerId) =>
            await this.requester.GetResponseAsync<List<PlayerRecentMatch>>($"players/{playerId}/recentMatches");

        /// <inheritdoc />
        public async Task<List<PlayerMatch>> GetPlayerMatchesAsync(
            long playerId,
            PlayerEndpointParameters parameters = null) =>
            await this.requester.GetResponseAsync<List<PlayerMatch>>(
                $"players/{playerId}/matches",
                this.CreateArgumentListForPlayerEndpointRequest(parameters));

        /// <inheritdoc />
        public async Task<List<PlayerHero>>
            GetPlayerHeroesAsync(long playerId, PlayerEndpointParameters parameters = null) =>
            await this.requester.GetResponseAsync<List<PlayerHero>>(
                $"players/{playerId}/heroes",
                this.CreateArgumentListForPlayerEndpointRequest(parameters));

        /// <inheritdoc />
        public async Task<List<PlayerPeer>> GetPlayerPeersAsync(long playerId, PlayerEndpointParameters parameters) =>
            await this.requester.GetResponseAsync<List<PlayerPeer>>(
                $"players/{playerId}/peers",
                this.CreateArgumentListForPlayerEndpointRequest(parameters));

        /// <inheritdoc />
        public async Task<List<PlayerPro>> GetPlayerProsAsync(long playerId, PlayerEndpointParameters parameters) =>
            await this.requester.GetResponseAsync<List<PlayerPro>>(
                $"players/{playerId}/pros",
                this.CreateArgumentListForPlayerEndpointRequest(parameters));

        /// <inheritdoc />
        public async Task<List<PlayerTotal>> GetPlayerTotalsAsync(long playerId, PlayerEndpointParameters parameters) =>
            await this.requester.GetResponseAsync<List<PlayerTotal>>(
                $"players/{playerId}/totals",
                this.CreateArgumentListForPlayerEndpointRequest(parameters));

        /// <inheritdoc />
        public async Task<PlayerCount> GetPlayerCountsAsync(long playerId, PlayerEndpointParameters parameters) =>
            await this.requester.GetResponseAsync<PlayerCount>(
                $"players/{playerId}/counts",
                this.CreateArgumentListForPlayerEndpointRequest(parameters));

        /// <inheritdoc />
        public async Task<List<PlayerHistogram>> GetPlayerHistogramsAsync(long playerId, string field, PlayerEndpointParameters parameters) =>
            await this.requester.GetResponseAsync<List<PlayerHistogram>>(
                $"players/{playerId}/histograms/{field}",
                this.CreateArgumentListForPlayerEndpointRequest(parameters));

        /// <inheritdoc />
        public async Task<PlayerWardmap> GetPlayerWardMapAsync(long playerId, PlayerEndpointParameters parameters) =>
            await this.requester.GetResponseAsync<PlayerWardmap>(
                $"players/{playerId}/wardmap",
                this.CreateArgumentListForPlayerEndpointRequest(parameters));

        /// <inheritdoc />
        public async Task<PlayerWordcloud> GetPlayerWordCloudAsync(long playerId, PlayerEndpointParameters parameters) =>
            await this.requester.GetResponseAsync<PlayerWordcloud>(
                $"players/{playerId}/wordcloud",
                this.CreateArgumentListForPlayerEndpointRequest(parameters));

        /// <inheritdoc />
        public async Task<List<PlayerRating>> GetPlayerRatingsAsync(long playerId) =>
            await this.requester.GetResponseAsync<List<PlayerRating>>($"players/{playerId}/ratings");

        /// <inheritdoc />
        public async Task<List<PlayerHeroRanking>> GetPlayerHeroRankingsAsync(long playerId) =>
            await this.requester.GetResponseAsync<List<PlayerHeroRanking>>($"players/{playerId}/rankings");

        /// <inheritdoc />
        public async Task<bool> RefreshPlayerMatchHistoryAsync(long playerId)
        {
            var response = await this.requester.PostRequest($"players/{playerId}/refresh");
            response.EnsureSuccessStatusCode();
            return true;
        }

        private List<string> CreateArgumentListForPlayerEndpointRequest(PlayerEndpointParameters parameters)
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
                foreach (var includedAccountId in parameters.IncludedAccountIds)
                {
                    addedArguments.Add($@"included_account_id={includedAccountId}");
                }
            }

            if (parameters.ExcludedAccountIds != null)
            {
                foreach (var excludedAccountId in parameters.ExcludedAccountIds)
                {
                    addedArguments.Add($@"excluded_account_id={excludedAccountId}");
                }
            }

            if (parameters.WithHeroIds != null)
            {
                foreach (var withHeroId in parameters.WithHeroIds)
                {
                    addedArguments.Add($@"with_hero_id={withHeroId}");
                }
            }

            if (parameters.AgainstHeroIds != null)
            {
                foreach (var againstHeroId in parameters.AgainstHeroIds)
                {
                    addedArguments.Add($@"against_hero_id={againstHeroId}");
                }
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
                foreach (var project in parameters.Project)
                {
                    addedArguments.Add($@"project={project}");
                }
            }

            return addedArguments;
        }
    }
}
