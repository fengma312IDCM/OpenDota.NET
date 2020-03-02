namespace OpenDotaDotNet.Endpoints
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using Newtonsoft.Json;

    using OpenDotaDotNet.Models.Rankings;

    public class RankingEndpoint : IRankingEndpoint
    {
        private const string Rankings = "rankings";

        private readonly Requester requester;

        public RankingEndpoint(Requester requester)
        {
            this.requester = requester;
        }

        /// <summary>
        /// Gets top players by hero.
        /// </summary>
        /// <param name="heroId"></param>
        /// <returns>Top players by hero.</returns>
        public async Task<HeroRanking> GetHeroRankingsAsync(int heroId)
        {
            var addedArguments = this.CreateArgumentListForHeroRankingsRequest(heroId);

            var response = await this.requester.GetRequestResponseMessageAsync(Rankings, addedArguments);

            response.EnsureSuccessStatusCode();

            var heroRankings = JsonConvert.DeserializeObject<HeroRanking>(await response.Content.ReadAsStringAsync());

            return heroRankings;
        }

        private List<string> CreateArgumentListForHeroRankingsRequest(int? heroId = null)
        {
            var addedArguments = new List<string>();

            if (heroId != null)
            {
                addedArguments.Add($@"hero_id={heroId}");
            }

            return addedArguments;
        }
    }
}
