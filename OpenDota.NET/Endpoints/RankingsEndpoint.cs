namespace OpenDotaDotNet.Endpoints
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using OpenDotaDotNet.Models.Rankings;

    public class RankingsEndpoint : IRankingsEndpoint
    {
        private readonly Requester requester;

        public RankingsEndpoint(Requester requester)
        {
            this.requester = requester;
        }

        /// <inheritdoc />
        public async Task<HeroRanking> GetHeroRankingsAsync(int heroId) =>
            await this.requester.GetResponseAsync<HeroRanking>(
                "rankings",
                new List<string>
                    {
                        $"hero_id={heroId}",
                    });
    }
}
