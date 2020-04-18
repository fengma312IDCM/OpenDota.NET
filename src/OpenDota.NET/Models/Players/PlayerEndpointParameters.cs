namespace OpenDotaDotNet.Models.Players
{
    using System.Collections.Generic;

    public class PlayerEndpointParameters
    {
        /// <summary>
        /// Gets or sets the number of matches to limit to.
        /// </summary>
        public int? Limit { get; set; }

        /// <summary>
        /// Gets or sets the number of matches to offset start by.
        /// </summary>
        public int? Offset { get; set; }

        /// <summary>
        /// Gets or sets whether the player won.
        /// </summary>
        public int? Win { get; set; }

        /// <summary>
        /// Gets or sets the patch ID.
        /// </summary>
        public int? Patch { get; set; }

        /// <summary>
        /// Gets or sets the game Mode ID.
        /// </summary>
        public int? GameMode { get; set; }

        /// <summary>
        /// Gets or sets the lobby type ID.
        /// </summary>
        public int? LobbyType { get; set; }

        /// <summary>
        /// Gets or sets the region ID.
        /// </summary>
        public int? Region { get; set; }

        /// <summary>
        /// Gets or sets the days previous.
        /// </summary>
        public int? Date { get; set; }

        /// <summary>
        /// Gets or sets the lane Role ID.
        /// </summary>
        public int? LaneRole { get; set; }

        /// <summary>
        /// Gets or sets the hero ID.
        /// </summary>
        public int? HeroId { get; set; }

        /// <summary>
        /// Gets or sets whether the player was radiant.
        /// </summary>
        public int? IsRadiant { get; set; }

        /// <summary>
        /// Gets or sets the account IDs in the match (array).
        /// </summary>
        public IEnumerable<int> IncludedAccountIds { get; set; }

        /// <summary>
        /// Gets or sets the account IDs not in the match (array).
        /// </summary>
        public IEnumerable<int> ExcludedAccountIds { get; set; }

        /// <summary>
        /// Gets or sets the hero IDs on the player's team (array).
        /// </summary>
        public IEnumerable<int> WithHeroIds { get; set; }

        /// <summary>
        /// Gets or sets the hero IDs against the player's team (array).
        /// </summary>
        public IEnumerable<int> AgainstHeroIds { get; set; }

        /// <summary>
        /// Gets or sets whether the match was significant for aggregation purposes.
        /// Defaults to 1 (true), set this to 0 to return data for non-standard modes/matches.
        /// </summary>
        public int? Significant { get; set; }

        /// <summary>
        /// Gets or sets the minimum number of games played, for filtering hero stats.
        /// </summary>
        public int? Having { get; set; }

        /// <summary>
        /// Gets or sets the field to return matches sorted by in descending order.
        /// </summary>
        public string Sort { get; set; }

        /// <summary>
        /// Gets or sets the fields to project (array).
        /// </summary>
        public IEnumerable<string> Project { get; set; }
    }
}
