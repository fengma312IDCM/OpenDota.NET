using Newtonsoft.Json;

using OpenDotaDotNet.Models.Rankings;

using System.Collections.Generic;
using System.Threading.Tasks;

namespace OpenDotaDotNet.Endpoints
{
    public class RankingEndpoint : IRankingEndpoint
    {
        private const string Rankings = "rankings";

        private readonly Requester requester;

        public RankingEndpoint(Requester requester)
        {
            this.requester = requester;
        }

        /// <summary>
        /// Top players by hero
        /// </summary>
        /// <param name="heroId"></param>
        /// <returns></returns>
        public async Task<HeroRanking> GetHeroRankingsAsync(int heroId)
        {
            var addedArguments = CreateArgumentListForHeroRankingsRequest(heroId);

            var response = await this.requester.GetRequestResponseMessageAsync(Rankings, addedArguments);

            response.EnsureSuccessStatusCode();

            var heroRankings = JsonConvert.DeserializeObject<HeroRanking>(await response.Content.ReadAsStringAsync());

            return heroRankings;
        }

        #region Helper
        private List<string> CreateArgumentListForHeroRankingsRequest(int? heroId = null)
        {
            var addedArguments = new List<string>();

            if (heroId != null)
            {
                addedArguments.Add($@"hero_id={heroId}");
            }

            return addedArguments;
        }
        #endregion
    }
}
