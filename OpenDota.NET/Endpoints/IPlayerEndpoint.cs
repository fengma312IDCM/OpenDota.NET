namespace OpenDotaDotNet.Endpoints
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using OpenDotaDotNet.Models.Players;

    public interface IPlayerEndpoint
    {
        /// <summary>
        /// Gets player data.
        /// </summary>
        /// <param name="playerId">Steam32 account ID.</param>
        /// <returns>Player data.</returns>
        Task<Player> GetPlayerByIdAsync(long playerId);

        /// <summary>
        /// Gets win/Loss count.
        /// </summary>
        /// <param name="playerId">Steam32 account ID.</param>
        /// <param name="parameters">Query parameters.</param>
        /// <returns>Win/Loss count.</returns>
        Task<PlayerWinLoss> GetPlayerWinLossByIdAsync(long playerId, PlayerEndpointParameters parameters = null);

        /// <summary>
        /// Gets recent matches played.
        /// </summary>
        /// <param name="playerId">Steam32 account ID.</param>
        /// <returns>Recent matches played.</returns>
        Task<List<PlayerRecentMatch>> GetPlayerRecentMatchesAsync(long playerId);

        /// <summary>
        /// Gets matches played.
        /// </summary>
        /// <param name="playerId">Steam32 account ID.</param>
        /// <param name="parameters">Query parameters.</param>
        /// <returns>Matches played.</returns>
        Task<List<PlayerMatch>> GetPlayerMatchesAsync(long playerId, PlayerEndpointParameters parameters = null);

        /// <summary>
        /// Gets heroes played.
        /// </summary>
        /// <param name="playerId">Steam32 account ID.</param>
        /// <param name="parameters">Query Parameters.</param>
        /// <returns>Heroes played.</returns>
        Task<List<PlayerHero>> GetPlayerHeroesAsync(long playerId, PlayerEndpointParameters parameters = null);

        /// <summary>
        /// Gets players played with.
        /// </summary>
        /// <param name="playerId">Steam32 account ID.</param>
        /// <param name="parameters">Query Parameters.</param>
        /// <returns>Players played with.</returns>
        Task<List<PlayerPeer>> GetPlayerPeersAsync(long playerId, PlayerEndpointParameters parameters = null);

        /// <summary>
        /// Gets pro players played with.
        /// </summary>
        /// <param name="playerId">Steam32 account ID.</param>
        /// <param name="parameters">Query Parameters.</param>
        /// <returns>Pro players played with.</returns>
        Task<List<PlayerPro>> GetPlayerProsAsync(long playerId, PlayerEndpointParameters parameters = null);

        /// <summary>
        /// Gets totals in stats.
        /// </summary>
        /// <param name="playerId">Steam32 account ID.</param>
        /// <param name="parameters">Query Parameters.</param>
        /// <returns>Totals in stats.</returns>
        Task<List<PlayerTotal>> GetPlayerTotalsAsync(long playerId, PlayerEndpointParameters parameters = null);

        /// <summary>
        /// Gets counts in categories.
        /// </summary>
        /// <param name="playerId">Steam32 account ID.</param>
        /// <param name="parameters">Query Parameters.</param>
        /// <returns>Counts in categories.</returns>
        Task<PlayerCount> GetPlayerCountsAsync(long playerId, PlayerEndpointParameters parameters = null);

        /// <summary>
        /// Gets distribution of matches in a single stat.
        /// </summary>
        /// <param name="playerId">Steam32 account ID.</param>
        /// <param name="field">Field to aggregate on.</param>
        /// <param name="parameters">Query Parameters.</param>
        /// <returns>Distribution of matches in a single stat.</returns>
        Task<List<PlayerHistogram>> GetPlayerHistogramsAsync(long playerId, string field, PlayerEndpointParameters parameters = null);

        /// <summary>
        /// Gets wards placed in matches played.
        /// </summary>
        /// <param name="playerId">Steam32 account ID.</param>
        /// <param name="parameters">Query Parameters.</param>
        /// <returns>Wards placed in matches played.</returns>
        Task<PlayerWardmap> GetPlayerWardMapAsync(long playerId, PlayerEndpointParameters parameters = null);

        /// <summary>
        /// Gets words said/read in matches played.
        /// </summary>
        /// <param name="playerId">Steam32 account ID.</param>
        /// <param name="parameters">Query Parameters.</param>
        /// <returns>Words said/read in matches played.</returns>
        Task<PlayerWordcloud> GetPlayerWordCloudAsync(long playerId, PlayerEndpointParameters parameters = null);

        /// <summary>
        /// Gets player rating history.
        /// </summary>
        /// <param name="playerId">Steam32 account ID.</param>
        /// <returns>Player rating history.</returns>
        Task<List<PlayerRating>> GetPlayerRatingsAsync(long playerId);

        /// <summary>
        /// Gets player hero rankings.
        /// </summary>
        /// <param name="playerId">Steam32 account ID.</param>
        /// <returns>Player hero rankings.</returns>
        Task<List<PlayerHeroRanking>> GetPlayerHeroRankingsAsync(long playerId);

        /// <summary>
        /// Gets refresh player match history.
        /// </summary>
        /// <param name="playerId"></param>
        /// <returns>Refresh player match history.</returns>
        Task<bool> RefreshPlayerMatchHistoryAsync(long playerId);
    }
}
