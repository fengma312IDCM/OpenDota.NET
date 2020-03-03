namespace OpenDotaDotNet.Endpoints
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using OpenDotaDotNet.Models.Rankings;

    public class RankingEndpoint : IRankingEndpoint
    {
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
        public async Task<HeroRanking> GetHeroRankingsAsync(int heroId) =>
            await this.requester.GetResponseAsync<HeroRanking>(
                "rankings",
                this.CreateArgumentListForHeroRankingsRequest(heroId));

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
