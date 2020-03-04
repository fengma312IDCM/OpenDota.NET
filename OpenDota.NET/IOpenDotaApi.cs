namespace OpenDotaDotNet
{
    using OpenDotaDotNet.Endpoints;

    public interface IOpenDotaApi
    {
        IMatchEndpoint Matches { get; }

        IPlayersEndpoint Players { get; }

        IProPlayerEndpoint ProPlayers { get; }

        IProMatchEndpoint ProMatches { get; }

        IPublicMatchEndpoint PublicMatches { get; }

        IMetadataEndpoint Metadata { get; }

        IDistributionsEndpoint Distributions { get; }

        ISearchEndpoint Search { get; }

        IRankingEndpoint Ranking { get; }

        IBenchmarkEndpoint Benchmarks { get; }

        IStatusEndpoint Status { get; }

        IHealthEndpoint Health { get; }

        IRequestEndpoint Request { get; }

        IFindMatchEndpoint FindMatch { get; }

        IHeroEndpoint Hero { get; }

        IHeroStatsEndpoint HeroStats { get; }

        ILeagueEndpoint League { get; }

        ITeamsEndpoint Teams { get; }

        IReplaysEndpoint Replays { get; }

        IRecordsEndpoint Records { get; }

        ILiveEndpoint Live { get; }

        IScenariosEndpoint Scenarios { get; }

        ISchemaEndpoint Schema { get; }

        IFeedEndpoint Feed { get; }
    }
}
