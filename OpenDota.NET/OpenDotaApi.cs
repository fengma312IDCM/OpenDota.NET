namespace OpenDotaDotNet
{
    using System.Net;

    using OpenDotaDotNet.Endpoints;

    /// <summary>
    /// The OpenDota API provides Dota 2 related data including advanced match data extracted from match replays.
    /// Full documentation is available on https://docs.opendota.com/
    /// You can find data that can be used to convert hero and ability IDs and other information provided by the
    /// API from the [dotaconstants](https://github.com/odota/dotaconstants) repository.
    /// </summary>
    public class OpenDotaApi : IOpenDotaApi
    {
        private static OpenDotaApi instance;

        private OpenDotaApi(string apiKey, IWebProxy proxy)
        {
            var request = new Requester(apiKey, proxy);
            this.Matches = new MatchEndpoint(request);
            this.Player = new PlayerEndpoint(request);
            this.ProPlayers = new ProPlayerEndpoint(request);
            this.ProMatches = new ProMatchesEndpoint(request);
            this.PublicMatches = new PublicMatchEndpoint(request);
            this.Metadata = new MetadataEndpoint(request);
            this.Distributions = new DistributionsEndpoint(request);
            this.Search = new SearchEndpoint(request);
            this.Ranking = new RankingEndpoint(request);
            this.Benchmarks = new BenchmarksEndpoint(request);
            this.Status = new StatusEndpoint(request);
            this.Health = new HealthEndpoint(request);
            this.Request = new RequestEndpoint(request);
            this.FindMatch = new FindMatchEndpoint(request);
            this.Hero = new HeroEndpoint(request);
            this.HeroStats = new HeroStatsEndpoint(request);
            this.League = new LeagueEndpoint(request);
            this.Teams = new TeamsEndpoint(request);
            this.Replay = new ReplayEndpoint(request);
            this.Record = new RecordEndpoint(request);
            this.Live = new LiveEndpoint(request);
            this.Scenarios = new ScenariosEndpoint(request);
            this.Schema = new SchemaEndpoint(request);
            this.Feed = new FeedEndpoint(request);
        }

        public IMatchEndpoint Matches { get; }

        public IPlayerEndpoint Player { get; }

        public IProPlayerEndpoint ProPlayers { get; }

        public IProMatchEndpoint ProMatches { get; }

        public IPublicMatchEndpoint PublicMatches { get; }

        public IMetadataEndpoint Metadata { get; }

        public IDistributionsEndpoint Distributions { get; }

        public ISearchEndpoint Search { get; }

        public IRankingEndpoint Ranking { get; }

        public IBenchmarkEndpoint Benchmarks { get; }

        public IStatusEndpoint Status { get; }

        public IHealthEndpoint Health { get; }

        public IRequestEndpoint Request { get; }

        public IFindMatchEndpoint FindMatch { get; }

        public IHeroEndpoint Hero { get; }

        public IHeroStatsEndpoint HeroStats { get; }

        public ILeagueEndpoint League { get; }

        public ITeamsEndpoint Teams { get; }

        public IReplayEndpoint Replay { get; }

        public IRecordEndpoint Record { get; }

        public ILiveEndpoint Live { get; }

        public IScenariosEndpoint Scenarios { get; }

        public ISchemaEndpoint Schema { get; }

        public IFeedEndpoint Feed { get; }

        public static OpenDotaApi GetInstance(string apiKey = null, IWebProxy proxy = null)
        {
            return instance ?? (instance = new OpenDotaApi(apiKey, proxy));
        }
    }
}
