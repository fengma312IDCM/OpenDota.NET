namespace OpenDota.NET.Tests
{
    using System.Linq;
    using System.Threading.Tasks;

    using OpenDotaDotNet;
    using OpenDotaDotNet.Models.Heroes;

    using Xunit;
    using Xunit.Abstractions;

    public class HeroesEndpointTests
    {
        private readonly ITestOutputHelper testOutputHelper;

        private readonly OpenDotaApi openDotaApi;

        public HeroesEndpointTests(ITestOutputHelper testOutputHelper)
        {
            this.testOutputHelper = testOutputHelper;
            this.openDotaApi = new OpenDotaApi();
        }

        [Fact]
        public async Task TestGetHeroes()
        {
            var result = await this.openDotaApi.Heroes.GetHeroesAsync();
            this.testOutputHelper.WriteLine(result.ToJsonString());

            Assert.True(result.Count() >= 119);
            Assert.True(result.Count(x => x.AttackType == HeroAttackType.Melee) >= 57);
            Assert.True(result.Count(x => x.AttackType == HeroAttackType.Ranged) >= 62);
            Assert.True(result.Count(x => x.PrimaryAttribute == HeroPrimaryAttribute.Agi) >= 37);
            Assert.True(result.Count(x => x.PrimaryAttribute == HeroPrimaryAttribute.Int) >= 43);
            Assert.True(result.Count(x => x.PrimaryAttribute == HeroPrimaryAttribute.Str) >= 39);
            Assert.True(result.All(x => x.Roles.Any()));
            Assert.True(result.All(x => x.Id > 0));
            Assert.True(result.All(x => x.Legs >= 0));
            Assert.True(result.All(x => !string.IsNullOrWhiteSpace(x.Name)));
            Assert.True(result.All(x => !string.IsNullOrWhiteSpace(x.LocalizedName)));
        }

        [Fact]
        public async Task TestGetHeroDurations()
        {
            var result = await this.openDotaApi.Heroes.GetHeroDurationsAsync(1);
            this.testOutputHelper.WriteLine(result.ToJsonString());

            Assert.True(result.All(x => x.GamesPlayed > 0));
            Assert.True(result.All(x => x.DurationBin > 0));
            Assert.True(result.All(x => x.Wins >= 0));
        }

        [Fact]
        public async Task TestGetHeroMatches()
        {
            var result = await this.openDotaApi.Heroes.GetHeroMatchesAsync(2);
            this.testOutputHelper.WriteLine(result.ToJsonString());

            Assert.Equal(100, result.Count());
            Assert.True(result.All(x => x.MatchId > 0));
            Assert.True(result.All(x => x.StartTime > 0));
            Assert.True(result.All(x => x.Duration > 0));
            Assert.True(result.All(x => x.LeagueId > 0));
            Assert.True(result.All(x => !string.IsNullOrWhiteSpace(x.LeagueName)));
            Assert.True(result.All(x => x.PlayerSlot >= 0));
            Assert.True(result.All(x => x.AccountId > 0));
            Assert.True(result.All(x => x.Kills >= 0));
            Assert.True(result.All(x => x.Deaths >= 0));
            Assert.True(result.All(x => x.Assists >= 0));
        }

        [Fact]
        public async Task TestGetHeroMatchups()
        {
            var result = await this.openDotaApi.Heroes.GetHeroMatchupsAsync(3);
            this.testOutputHelper.WriteLine(result.ToJsonString());

            Assert.True(result.Count() >= 118);
            Assert.True(result.All(x => x.HeroId > 0));
            Assert.True(result.All(x => x.GamesPlayed > 0));
            Assert.True(result.All(x => x.Wins > 0));
        }

        [Fact]
        public async Task TestGetHeroPlayers()
        {
            var result = await this.openDotaApi.Heroes.GetHeroPlayersAsync(4);
            this.testOutputHelper.WriteLine(result.ToJsonString());

            Assert.True(result.Count() >= 1000);
            Assert.True(result.All(x => x.AccountId > 0));
            Assert.True(result.All(x => x.GamesPlayed > 0));
            Assert.True(result.All(x => x.Wins >= 0));
        }
    }
}
