namespace OpenDotaDotNet.Endpoints
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using OpenDotaDotNet.Models.PublicMatches;

    public class PublicMatchesEndpoint : IPublicMatchesEndpoint
    {
        private readonly Requester requester;

        public PublicMatchesEndpoint(Requester requester)
        {
            this.requester = requester;
        }

        /// <inheritdoc />
        public async Task<IEnumerable<PublicMatch>> GetPublicMatchesAsync(
            int? mmrAscending = null,
            int? mmrDescending = null,
            long? lessThanMatchId = null) =>
            await this.requester.GetResponseAsync<IEnumerable<PublicMatch>>(
                "publicMatches",
                this.GetArguments(mmrAscending, mmrDescending, lessThanMatchId));

        private IEnumerable<string> GetArguments(int? mmrAscending = null, int? mmrDescending = null, long? lessThanMatchId = null)
        {
            var addedArguments = new List<string>();

            if (mmrAscending != null)
            {
                addedArguments.Add($@"mmr_ascending={mmrAscending}");
            }

            if (mmrDescending != null)
            {
                addedArguments.Add($@"mmr_descending={mmrDescending}");
            }

            if (lessThanMatchId != null)
            {
                addedArguments.Add($@"less_than_match_id={lessThanMatchId}");
            }

            return addedArguments;
        }
    }
}
