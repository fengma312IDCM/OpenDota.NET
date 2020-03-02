namespace OpenDotaDotNet.Endpoints
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using Newtonsoft.Json;

    using OpenDotaDotNet.Models.Players;

    public class PlayerEndpoint : IPlayerEndpoint
    {
        private const string PlayerByIdUrl = "players/{0}";
        private const string PlayerWinLossByIdUrl = "players/{0}/wl";
        private const string PlayerRecentMatches = "players/{0}/recentMatches";
        private const string PlayerMatches = "players/{0}/matches";
        private const string PlayerHeroes = "players/{0}/heroes";
        private const string PlayerPeers = "players/{0}/peers";
        private const string PlayerPros = "players/{0}/pros";
        private const string PlayerTotals = "players/{0}/totals";
        private const string PlayerCounts = "players/{0}/counts";
        private const string PlayerHistograms = "players/{0}/histograms/{1}";
        private const string PlayerWardMap = "players/{0}/wardmap";
        private const string PlayerWordCloud = "players/{0}/wordcloud";
        private const string PlayerRatings = "players/{0}/ratings";
        private const string PlayerHeroRankings = "players/{0}/rankings";
        private const string RefreshPlayerMatchHistory = "players/{0}/refresh";

        private readonly Requester requester;

        public PlayerEndpoint(Requester requester)
        {
            this.requester = requester;
        }

        /// <summary>
        /// Gets player data.
        /// </summary>
        /// <param name="playerId">Steam32 account ID.</param>
        /// <returns>Player data.</returns>
        public async Task<Player> GetPlayerByIdAsync(long playerId)
        {
            var response = await this.requester.GetRequestResponseMessageAsync(string.Format(PlayerByIdUrl, playerId));

            response.EnsureSuccessStatusCode();

            var playerInfo = JsonConvert.DeserializeObject<Player>(await response.Content.ReadAsStringAsync());

            return playerInfo;
        }

        /// <summary>
        /// Gets win/Loss count.
        /// </summary>
        /// <param name="playerId">Steam32 account ID.</param>
        /// <param name="parameters">Query parameters.</param>
        /// <returns>Win/Loss count.</returns>
        public async Task<PlayerWinLoss> GetPlayerWinLossByIdAsync(long playerId, PlayerEndpointParameters parameters = null)
        {
            var addedArguments = this.CreateArgumentListForPlayerEndpointRequest(parameters);

            var response = await this.requester.GetRequestResponseMessageAsync(string.Format(PlayerWinLossByIdUrl, playerId), addedArguments);

            response.EnsureSuccessStatusCode();

            var playerWinLoss = JsonConvert.DeserializeObject<PlayerWinLoss>(await response.Content.ReadAsStringAsync());

            return playerWinLoss;
        }

        /// <summary>
        /// Gets recent matches played.
        /// </summary>
        /// <param name="playerId">Steam32 account ID.</param>
        /// <returns>Recent matches played.</returns>
        public async Task<List<PlayerRecentMatch>> GetPlayerRecentMatchesAsync(long playerId)
        {
            var response = await this.requester.GetRequestResponseMessageAsync(string.Format(PlayerRecentMatches, playerId));

            response.EnsureSuccessStatusCode();

            var playerRecentMatches = JsonConvert.DeserializeObject<List<PlayerRecentMatch>>(await response.Content.ReadAsStringAsync());

            return playerRecentMatches;
        }

        /// <summary>
        /// Gets matches played.
        /// </summary>
        /// <param name="playerId">Steam32 account ID.</param>
        /// <param name="parameters">Query parameters.</param>
        /// <returns>Matches played.</returns>
        public async Task<List<PlayerMatch>> GetPlayerMatchesAsync(long playerId, PlayerEndpointParameters parameters = null)
        {
            var addedArguments = this.CreateArgumentListForPlayerEndpointRequest(parameters);
            var response = await this.requester.GetRequestResponseMessageAsync(string.Format(PlayerMatches, playerId), addedArguments);
            response.EnsureSuccessStatusCode();
            var playerMatches = JsonConvert.DeserializeObject<List<PlayerMatch>>(await response.Content.ReadAsStringAsync());
            return playerMatches;
        }

        /// <summary>
        /// Gets heroes played.
        /// </summary>
        /// <param name="playerId">Steam32 account ID.</param>
        /// <param name="parameters">Query Parameters.</param>
        /// <returns>Heroes played.</returns>
        public async Task<List<PlayerHero>> GetPlayerHeroesAsync(long playerId, PlayerEndpointParameters parameters = null)
        {
            var addedArguments = this.CreateArgumentListForPlayerEndpointRequest(parameters);

            var response = await this.requester.GetRequestResponseMessageAsync(string.Format(PlayerHeroes, playerId), addedArguments);

            response.EnsureSuccessStatusCode();

            var playerHeroes = JsonConvert.DeserializeObject<List<PlayerHero>>(await response.Content.ReadAsStringAsync());

            return playerHeroes;
        }

        /// <summary>
        /// Gets players played with.
        /// </summary>
        /// <param name="playerId">Steam32 account ID.</param>
        /// <param name="parameters">Query Parameters.</param>
        /// <returns>Players played with.</returns>
        public async Task<List<PlayerPeer>> GetPlayerPeersAsync(long playerId, PlayerEndpointParameters parameters)
        {
            var addedArguments = this.CreateArgumentListForPlayerEndpointRequest(parameters);

            var response = await this.requester.GetRequestResponseMessageAsync(string.Format(PlayerPeers, playerId), addedArguments);

            response.EnsureSuccessStatusCode();

            var playerPeers = JsonConvert.DeserializeObject<List<PlayerPeer>>(await response.Content.ReadAsStringAsync());

            return playerPeers;
        }

        /// <summary>
        /// Gets pro players played with.
        /// </summary>
        /// <param name="playerId">Steam32 account ID.</param>
        /// <param name="parameters">Query Parameters.</param>
        /// <returns>Pro players played with.</returns>
        public async Task<List<PlayerPro>> GetPlayerProsAsync(long playerId, PlayerEndpointParameters parameters)
        {
            var addedArguments = this.CreateArgumentListForPlayerEndpointRequest(parameters);

            var response = await this.requester.GetRequestResponseMessageAsync(string.Format(PlayerPros, playerId), addedArguments);

            response.EnsureSuccessStatusCode();

            var playerPros = JsonConvert.DeserializeObject<List<PlayerPro>>(await response.Content.ReadAsStringAsync());

            return playerPros;
        }

        /// <summary>
        /// Gets totals in stats.
        /// </summary>
        /// <param name="playerId">Steam32 account ID.</param>
        /// <param name="parameters">Query Parameters.</param>
        /// <returns>Totals in stats.</returns>
        public async Task<List<PlayerTotal>> GetPlayerTotalsAsync(long playerId, PlayerEndpointParameters parameters)
        {
            var addedArguments = this.CreateArgumentListForPlayerEndpointRequest(parameters);

            var response = await this.requester.GetRequestResponseMessageAsync(string.Format(PlayerTotals, playerId), addedArguments);

            response.EnsureSuccessStatusCode();

            var playerTotals = JsonConvert.DeserializeObject<List<PlayerTotal>>(await response.Content.ReadAsStringAsync());

            return playerTotals;
        }

        /// <summary>
        /// Gets counts in categories.
        /// </summary>
        /// <param name="playerId">Steam32 account ID.</param>
        /// <param name="parameters">Query Parameters.</param>
        /// <returns>Counts in categories.</returns>
        public async Task<PlayerCount> GetPlayerCountsAsync(long playerId, PlayerEndpointParameters parameters)
        {
            var addedArguments = this.CreateArgumentListForPlayerEndpointRequest(parameters);

            var response = await this.requester.GetRequestResponseMessageAsync(string.Format(PlayerCounts, playerId), addedArguments);

            response.EnsureSuccessStatusCode();

            var playerCounts = JsonConvert.DeserializeObject<PlayerCount>(await response.Content.ReadAsStringAsync());

            return playerCounts;
        }

        /// <summary>
        /// Gets distribution of matches in a single stat.
        /// </summary>
        /// <param name="playerId">Steam32 account ID.</param>
        /// <param name="field">Field to aggregate on.</param>
        /// <param name="parameters">Query Parameters.</param>
        /// <returns>Distribution of matches in a single stat.</returns>
        public async Task<List<PlayerHistogram>> GetPlayerHistogramsAsync(long playerId, string field, PlayerEndpointParameters parameters)
        {
            var addedArguments = this.CreateArgumentListForPlayerEndpointRequest(parameters);

            var response = await this.requester.GetRequestResponseMessageAsync(string.Format(PlayerHistograms, playerId, field), addedArguments);

            response.EnsureSuccessStatusCode();

            var playerHistograms = JsonConvert.DeserializeObject<List<PlayerHistogram>>(await response.Content.ReadAsStringAsync());

            return playerHistograms;
        }

        /// <summary>
        /// Gets wards placed in matches played.
        /// </summary>
        /// <param name="playerId">Steam32 account ID.</param>
        /// <param name="parameters">Query Parameters.</param>
        /// <returns>Wards placed in matches played.</returns>
        public async Task<PlayerWardmap> GetPlayerWardMapAsync(long playerId, PlayerEndpointParameters parameters)
        {
            var addedArguments = this.CreateArgumentListForPlayerEndpointRequest(parameters);

            var response = await this.requester.GetRequestResponseMessageAsync(string.Format(PlayerWardMap, playerId), addedArguments);

            response.EnsureSuccessStatusCode();

            var playerWardMap = JsonConvert.DeserializeObject<PlayerWardmap>(await response.Content.ReadAsStringAsync());

            return playerWardMap;
        }

        /// <summary>
        /// Gets words said/read in matches played.
        /// </summary>
        /// <param name="playerId">Steam32 account ID.</param>
        /// <param name="parameters">Query Parameters.</param>
        /// <returns>Words said/read in matches played.</returns>
        public async Task<PlayerWordcloud> GetPlayerWordCloudAsync(long playerId, PlayerEndpointParameters parameters)
        {
            var addedArguments = this.CreateArgumentListForPlayerEndpointRequest(parameters);

            var response = await this.requester.GetRequestResponseMessageAsync(string.Format(PlayerWordCloud, playerId), addedArguments);

            response.EnsureSuccessStatusCode();

            var playerWordCloud = JsonConvert.DeserializeObject<PlayerWordcloud>(await response.Content.ReadAsStringAsync());

            return playerWordCloud;
        }

        /// <summary>
        /// Gets player rating history.
        /// </summary>
        /// <param name="playerId">Steam32 account ID.</param>
        /// <returns>Player rating history.</returns>
        public async Task<List<PlayerRating>> GetPlayerRatingsAsync(long playerId)
        {
            var response = await this.requester.GetRequestResponseMessageAsync(string.Format(PlayerRatings, playerId));

            response.EnsureSuccessStatusCode();

            var playerRatings = JsonConvert.DeserializeObject<List<PlayerRating>>(await response.Content.ReadAsStringAsync());

            return playerRatings;
        }

        /// <summary>
        /// Gets player hero rankings.
        /// </summary>
        /// <param name="playerId">Steam32 account ID.</param>
        /// <returns>Player hero rankings.</returns>
        public async Task<List<PlayerHeroRanking>> GetPlayerHeroRankingsAsync(long playerId)
        {
            var response = await this.requester.GetRequestResponseMessageAsync(string.Format(PlayerHeroRankings, playerId));

            response.EnsureSuccessStatusCode();

            var playerHeroRankings = JsonConvert.DeserializeObject<List<PlayerHeroRanking>>(await response.Content.ReadAsStringAsync());

            return playerHeroRankings;
        }

        /// <summary>
        /// Gets refresh player match history.
        /// </summary>
        /// <param name="playerId"></param>
        /// <returns>Refresh player match history.</returns>
        public async Task<bool> RefreshPlayerMatchHistoryAsync(long playerId)
        {
            var response = await this.requester.PostRequest(string.Format(RefreshPlayerMatchHistory, playerId));

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
