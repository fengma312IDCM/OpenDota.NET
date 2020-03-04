namespace OpenDota.NET.Tests
{
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    using OpenDotaDotNet;
    using OpenDotaDotNet.Models.Players;

    using Xunit;
    using Xunit.Abstractions;

    public class ExamplesTests
    {
        private const long PlayerId = 375507918;
        private const long MatchId = 5063190379;

        private readonly ITestOutputHelper testOutputHelper;

        public ExamplesTests(ITestOutputHelper testOutputHelper)
        {
            this.testOutputHelper = testOutputHelper;
        }

        [Fact]
        public async Task TestPlayerGetPlayerById()
        {
            var openDota = OpenDotaApi.GetInstance();
            var playerInfo = await openDota.Players.GetPlayerByIdAsync(PlayerId);

            this.testOutputHelper.WriteLine($@"Basic details of player with id {PlayerId}.");
            this.testOutputHelper.WriteLine($@"Steam name: {playerInfo.Profile.Personaname}");
            this.testOutputHelper.WriteLine($@"Steam ID: {playerInfo.Profile.Steamid}");
            this.testOutputHelper.WriteLine($@"Steam profile direct link: {playerInfo.Profile.Profileurl}");

            if (playerInfo.MmrEstimate.Estimate.HasValue)
            {
                this.testOutputHelper.WriteLine($@"Estimated MMR: {playerInfo.MmrEstimate.Estimate}");
            }
        }

        [Fact]
        public async Task TestPlayerGetPlayerWinLossById()
        {
            var openDota = OpenDotaApi.GetInstance();
            this.testOutputHelper.WriteLine("Win loss ratio");
            var playerWinLoss = await openDota.Players.GetPlayerWinLossByIdAsync(PlayerId);
            this.testOutputHelper.WriteLine($@"Total games played: {playerWinLoss.Wins + playerWinLoss.Losses}.");
            this.testOutputHelper.WriteLine($@"Total wins: {playerWinLoss.Wins}.");
            this.testOutputHelper.WriteLine($@"Total losses: {playerWinLoss.Losses}.");
        }

        [Fact]
        public async Task TestPlayerGetPlayerHeroes()
        {
            var openDota = OpenDotaApi.GetInstance();
            this.testOutputHelper.WriteLine("Player heroes");
            var playerQueryParameters = new PlayerEndpointParameters { Limit = 20 };
            var playerHeroes = await openDota.Players.GetPlayerHeroesAsync(PlayerId, playerQueryParameters);

            var playerMostPlayedHeroLast20 = playerHeroes.FirstOrDefault();

            if (playerMostPlayedHeroLast20 != null)
            {
                this.testOutputHelper.WriteLine(
                    $@"Most played hero in the last 20 matches is hero ID: {playerMostPlayedHeroLast20.HeroId} with {playerMostPlayedHeroLast20.Win} wins.");
            }
        }

        [Fact]
        public async Task TestMatchesGetMatchById()
        {
            var openDota = OpenDotaApi.GetInstance();
            this.testOutputHelper.WriteLine("Player heroes");
            var matchDetails = await openDota.Matches.GetMatchByIdAsync(MatchId);

            this.testOutputHelper.WriteLine($@"Details about match id {MatchId}.");
            this.testOutputHelper.WriteLine($@"Duration of game: {TimeSpan.FromSeconds(matchDetails.Duration):mm\:ss}.");
            this.testOutputHelper.WriteLine($@"Radiant Score: {matchDetails.RadiantScore}. Dire Score: {matchDetails.DireScore}.");

            this.testOutputHelper.WriteLine($@"Nickname of players in the game:");
            foreach (var player in matchDetails.Players)
            {
                this.testOutputHelper.WriteLine(string.IsNullOrEmpty(player.Personaname) ? "Anonymous" : $@"{player.Personaname}");
            }
        }
    }
}
