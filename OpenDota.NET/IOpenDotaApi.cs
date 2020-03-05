namespace OpenDotaDotNet
{
    using OpenDotaDotNet.Endpoints;

    /// <summary>
    /// The OpenDota API provides Dota 2 related data including advanced match data extracted from match replays.
    /// Full documentation is available on https://docs.opendota.com/
    /// You can find data that can be used to convert hero and ability IDs and other information provided by the
    /// API from the [dotaconstants](https://github.com/odota/dotaconstants) repository.
    /// </summary>
    public interface IOpenDotaApi
    {
        IMatchesEndpoint Matches { get; }

        IPlayersEndpoint Players { get; }

        IProPlayerEndpoint ProPlayers { get; }

        IProMatchEndpoint ProMatches { get; }

        IPublicMatchesEndpoint PublicMatches { get; }

        IMetadataEndpoint Metadata { get; }

        IDistributionsEndpoint Distributions { get; }

        ISearchEndpoint Search { get; }

        IRankingsEndpoint Rankings { get; }

        IBenchmarkEndpoint Benchmarks { get; }

        IStatusEndpoint Status { get; }

        IHealthEndpoint Health { get; }

        IRequestEndpoint Request { get; }

        IFindMatchEndpoint FindMatch { get; }

        IHeroesEndpoint Heroes { get; }

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
