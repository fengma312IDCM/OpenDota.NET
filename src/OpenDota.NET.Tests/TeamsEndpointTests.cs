namespace OpenDota.NET.Tests
{
    using System.Linq;
    using System.Threading.Tasks;

    using OpenDotaDotNet;

    using Xunit;
    using Xunit.Abstractions;

    public class TeamsEndpointTests
    {
        private readonly ITestOutputHelper testOutputHelper;

        private readonly OpenDotaApi openDotaApi;

        public TeamsEndpointTests(ITestOutputHelper testOutputHelper)
        {
            this.testOutputHelper = testOutputHelper;
            this.openDotaApi = new OpenDotaApi();
        }

        [Fact]
        public async Task TestGetTeams()
        {
            var result = await this.openDotaApi.Teams.GetTeamsAsync();
            this.testOutputHelper.WriteLine(result.ToJsonString());

            Assert.Equal(1000, result.Count());
            Assert.Contains(result, x => !string.IsNullOrEmpty(x.Name));
            Assert.True(result.All(x => x.Name != null));
            Assert.Contains(result, x => !string.IsNullOrEmpty(x.Tag));
            Assert.True(result.All(x => x.Tag != null));
            Assert.True(result.All(x => x.TeamId > 0));
            Assert.True(result.All(x => x.Wins > 0));
            Assert.True(result.All(x => x.Losses >= 0));
            Assert.True(result.All(x => x.LastMatchTime > 0));
            Assert.True(result.All(x => x.Rating > 0));
            Assert.Contains(result, x => !string.IsNullOrEmpty(x.LogoUrl?.ToString()));
        }

        [Fact]
        public async Task TestGetTeamById()
        {
            var result = await this.openDotaApi.Teams.GetTeamByIdAsync(7554697);
            this.testOutputHelper.WriteLine(result.ToJsonString());

            Assert.Equal("Nigma", result.Name);
            Assert.Equal("Nigma", result.Tag);
            Assert.True(result.TeamId > 0);
            Assert.True(result.Wins > 0);
            Assert.True(result.Losses > 0);
            Assert.True(result.LastMatchTime > 0);
            Assert.True(result.Rating > 0);
            Assert.False(string.IsNullOrWhiteSpace(result.LogoUrl.ToString()));
        }

        [Fact]
        public async Task GetTeamByIdShouldReturnNullForTeamsThatAreNotFound()
        {
            var result = await this.openDotaApi.Teams.GetTeamByIdAsync(1);
            Assert.Null(result);
        }

        [Fact]
        public async Task TestGetTeamMatchesById()
        {
            var result = await this.openDotaApi.Teams.GetTeamMatchesByIdAsync(2586976); // OG
            this.testOutputHelper.WriteLine(result.ToJsonString());

            Assert.True(result.Count() > 800);
            Assert.True(result.All(x => x.MatchId > 0));
            Assert.True(result.All(x => x.Duration > 0));
            Assert.True(result.All(x => x.StartTime > 0));
            Assert.True(result.All(x => x.Leagueid > 0));
            Assert.True(result.All(x => !string.IsNullOrEmpty(x.LeagueName)));
            Assert.True(result.All(x => x.Cluster > 0));
            Assert.True(result.All(x => x.OpposingTeamId > 0));
            Assert.True(result.All(x => x.OpposingTeamName != null));
            Assert.Contains(result, x => !string.IsNullOrEmpty(x.OpposingTeamLogo?.ToString()));
        }

        [Fact]
        public async Task TestGetTeamPlayersById()
        {
            var result = await this.openDotaApi.Teams.GetTeamPlayersByIdAsync(7554697);
            this.testOutputHelper.WriteLine(result.ToJsonString());

            Assert.Equal(5, result.Count(x => x.IsCurrentTeamMember == true));
            Assert.Contains(result, x => x.Name == "KuroKy");
            Assert.Contains(result, x => x.Name == "Gh");
            Assert.Contains(result, x => x.Name == "Miracle-");
            Assert.Contains(result, x => x.Name == "MinD_ContRoL");
            Assert.Contains(result, x => x.Name == "w33");
            Assert.True(result.All(x => x.GamesPlayed > 0));
            Assert.True(result.All(x => x.Wins > 0));
            Assert.True(result.All(x => x.AccountId > 0));
        }

        [Fact]
        public async Task TestGetTeamHeroesById()
        {
            var result = await this.openDotaApi.Teams.GetTeamHeroesByIdAsync(1838315); // Secret
            this.testOutputHelper.WriteLine(result.ToJsonString());

            Assert.True(result.Count() >= 119);
            Assert.True(result.All(x => x.HeroId > 0));
            Assert.True(result.All(x => x.GamesPlayed > 0));
            Assert.True(result.All(x => x.Wins > 0));
            Assert.True(result.All(x => !string.IsNullOrEmpty(x.LocalizedName)));
        }
    }
}
