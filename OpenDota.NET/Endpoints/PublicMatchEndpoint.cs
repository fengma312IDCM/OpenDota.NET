using Newtonsoft.Json;

using OpenDotaDotNet.Models.PublicMatches;

using System.Collections.Generic;
using System.Threading.Tasks;

namespace OpenDotaDotNet.Endpoints
{
    public class PublicMatchEndpoint : IPublicMatchEndpoint
    {
        private const string PublicMatches = "publicMatches";

        private readonly Requester requester;

        public PublicMatchEndpoint(Requester requester)
        {
            this.requester = requester;
        }

        /// <summary>
        /// Get list of randomly sampled public matches
        /// </summary>
        /// <param name="mmrAscending">Order by MMR ascending</param>
        /// <param name="mmrDescending">Order by MMR descending</param>
        /// <param name="lessThanMatchId">Get matches with a match ID lower than this value</param>
        /// <returns></returns>
        public async Task<List<PublicMatch>> GetPublicMatchesAsync(int? mmrAscending = null, int? mmrDescending = null, long? lessThanMatchId = null)
        {
            var addedArguments = CreateArgumentListForPublicMatchesRequest(mmrAscending, mmrDescending, lessThanMatchId);

            var response = await this.requester.GetRequestResponseMessageAsync(PublicMatches, addedArguments);

            response.EnsureSuccessStatusCode();

            var publicMatches = JsonConvert.DeserializeObject<List<PublicMatch>>(await response.Content.ReadAsStringAsync());

            return publicMatches;
        }

        #region Helper
        private List<string> CreateArgumentListForPublicMatchesRequest(int? mmrAscending = null, int? mmrDescending = null, long? lessThanMatchId = null)
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
        #endregion
    }
}
