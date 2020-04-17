namespace OpenDotaDotNet
{
    using System.Net;

    using OpenDotaDotNet.Endpoints;

    // TODO: Implement PLAYERS BY RANK endpoint
    // TODO: Implement PARSED MATCHES endpoint
    // TODO: Implement EXPLORER endpoint
    // TODO: Implement CONSTANTS endpoint

    /// <inheritdoc />
    public class OpenDotaApi : IOpenDotaApi
    {
        public OpenDotaApi(string apiKey = null, IWebProxy proxy = null)
        {
            var request = new Requester(apiKey, proxy);
            this.Matches = new MatchesEndpoint(request);
            this.Players = new PlayersEndpoint(request);
            this.ProPlayers = new ProPlayerEndpoint(request);
            this.ProMatches = new ProMatchesEndpoint(request);
            this.PublicMatches = new PublicMatchesEndpoint(request);
            this.Metadata = new MetadataEndpoint(request);
            this.Distributions = new DistributionsEndpoint(request);
            this.Search = new SearchEndpoint(request);
            this.Rankings = new RankingsEndpoint(request);
            this.Benchmarks = new BenchmarksEndpoint(request);
            this.Status = new StatusEndpoint(request);
            this.Health = new HealthEndpoint(request);
            this.Request = new RequestEndpoint(request);
            this.FindMatches = new FindMatchesEndpoint(request);
            this.Heroes = new HeroesEndpoint(request);
            this.HeroStats = new HeroStatsEndpoint(request);
            this.League = new LeagueEndpoint(request);
            this.Teams = new TeamsEndpoint(request);
            this.Replays = new ReplaysEndpoint(request);
            this.Records = new RecordsEndpoint(request);
            this.Live = new LiveEndpoint(request);
            this.Scenarios = new ScenariosEndpoint(request);
            this.Schema = new SchemaEndpoint(request);
            this.Feed = new FeedEndpoint(request);
        }

        public IMatchesEndpoint Matches { get; }

        public IPlayersEndpoint Players { get; }

        public IProPlayerEndpoint ProPlayers { get; }

        public IProMatchEndpoint ProMatches { get; }

        public IPublicMatchesEndpoint PublicMatches { get; }

        public IMetadataEndpoint Metadata { get; }

        public IDistributionsEndpoint Distributions { get; }

        public ISearchEndpoint Search { get; }

        public IRankingsEndpoint Rankings { get; }

        public IBenchmarkEndpoint Benchmarks { get; }

        public IStatusEndpoint Status { get; }

        public IHealthEndpoint Health { get; }

        public IRequestEndpoint Request { get; }

        public IFindMatchesEndpoint FindMatches { get; }

        public IHeroesEndpoint Heroes { get; }

        public IHeroStatsEndpoint HeroStats { get; }

        public ILeagueEndpoint League { get; }

        public ITeamsEndpoint Teams { get; }

        public IReplaysEndpoint Replays { get; }

        public IRecordsEndpoint Records { get; }

        public ILiveEndpoint Live { get; }

        public IScenariosEndpoint Scenarios { get; }

        public ISchemaEndpoint Schema { get; }

        public IFeedEndpoint Feed { get; }
    }
}
