namespace OpenDota.NET.Tests
{
    using System.Linq;
    using System.Threading.Tasks;

    using OpenDotaDotNet;
    using OpenDotaDotNet.Models.Heroes;

    using Xunit;
    using Xunit.Abstractions;

    public class HeroStatsEndpointTests
    {
        private readonly ITestOutputHelper testOutputHelper;

        private readonly OpenDotaApi openDotaApi;

        public HeroStatsEndpointTests(ITestOutputHelper testOutputHelper)
        {
            this.testOutputHelper = testOutputHelper;
            this.openDotaApi = new OpenDotaApi();
        }

        [Fact]
        public async Task TestGetHeroStats()
        {
            var result = await this.openDotaApi.HeroStats.GetHeroStatsAsync();
            this.testOutputHelper.WriteLine(result.ToJsonString());

            Assert.True(result.Count >= 119);
            Assert.True(result.All(x => x.Id > 0));
            Assert.True(result.All(x => x.HeroId > 0));
            Assert.True(result.All(x => x.Legs >= 0));
            Assert.True(result.All(x => !string.IsNullOrWhiteSpace(x.Name)));
            Assert.True(result.All(x => !string.IsNullOrWhiteSpace(x.LocalizedName)));
            Assert.True(result.Count(x => x.AttackType == HeroAttackType.Melee) >= 57);
            Assert.True(result.Count(x => x.AttackType == HeroAttackType.Ranged) >= 62);
            Assert.True(result.Count(x => x.PrimaryAttribute == HeroPrimaryAttribute.Agi) >= 37);
            Assert.True(result.Count(x => x.PrimaryAttribute == HeroPrimaryAttribute.Int) >= 43);
            Assert.True(result.Count(x => x.PrimaryAttribute == HeroPrimaryAttribute.Str) >= 39);
            Assert.True(result.All(x => x.Roles.Count > 0));
            Assert.True(result.All(x => !string.IsNullOrWhiteSpace(x.Image)));
            Assert.True(result.All(x => !string.IsNullOrWhiteSpace(x.Icon)));

            Assert.True(result.All(x => x.BaseHealth > 0));
            Assert.True(result.All(x => !x.BaseHealthRegen.HasValue || x.BaseHealthRegen > 0));
            Assert.True(result.All(x => x.BaseMana > 0));
            Assert.True(result.All(x => x.BaseManaRegen >= 0));
            Assert.True(result.All(x => x.BaseArmor >= -3));
            Assert.True(result.All(x => x.BaseMr > 0));
            Assert.True(result.All(x => x.BaseAttackMin > 0));
            Assert.True(result.All(x => x.BaseAttackMax > 0));
            Assert.True(result.All(x => x.BaseStrength > 0));
            Assert.True(result.All(x => x.BaseAgility >= 0));
            Assert.True(result.All(x => x.BaseIntelligence > 0));
            Assert.True(result.All(x => x.StrengthGain > 0));
            Assert.True(result.All(x => x.AgilityGain >= 0));
            Assert.True(result.All(x => x.IntelligenceGain > 0));
            Assert.True(result.All(x => x.AttackRange > 0));
            Assert.True(result.All(x => x.ProjectileSpeed >= 0));
            Assert.True(result.All(x => x.AttackRate > 0));
            Assert.True(result.All(x => x.MoveSpeed > 0));
            Assert.True(result.All(x => x.TurnRate > 0));

            Assert.True(result.All(x => x.ProPick > 0));
            Assert.True(result.All(x => x.ProWin > 0));
            Assert.True(result.All(x => x.ProBan > 0));
            Assert.True(result.All(x => x.HeraldPicks > 0));
            Assert.True(result.All(x => x.HeraldWins > 0));
            Assert.True(result.All(x => x.GuardianPicks > 0));
            Assert.True(result.All(x => x.GuardianWins > 0));
            Assert.True(result.All(x => x.CrusaderPicks > 0));
            Assert.True(result.All(x => x.CrusaderWins > 0));
            Assert.True(result.All(x => x.ArchonPicks > 0));
            Assert.True(result.All(x => x.ArchonWins > 0));
            Assert.True(result.All(x => x.LegendPicks > 0));
            Assert.True(result.All(x => x.LegendWins > 0));
            Assert.True(result.All(x => x.AncientPicks > 0));
            Assert.True(result.All(x => x.AncientWins > 0));
            Assert.True(result.All(x => x.DivinePicks > 0));
            Assert.True(result.All(x => x.DivineWins > 0));
            Assert.True(result.All(x => x.ImmortalPicks > 0));
            Assert.True(result.All(x => x.ImmortalWins > 0));
            Assert.True(result.All(x => x.NullPicks > 0));
            Assert.True(result.All(x => x.NullWins == 0));
        }
    }
}
