namespace OpenDotaDotNet.Endpoints
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using OpenDotaDotNet.Models.ProMatches;

    public class ProMatchesEndpoint : IProMatchEndpoint
    {
        private readonly Requester requester;

        public ProMatchesEndpoint(Requester requester)
        {
            this.requester = requester;
        }

        /// <inheritdoc />
        public async Task<IEnumerable<ProMatch>> GetProMatchesAsync(long? lessThanMatchId = null) =>
            await this.requester.GetResponseAsync<IEnumerable<ProMatch>>(
                "proMatches",
                this.GetArguments(lessThanMatchId));

        private IEnumerable<string> GetArguments(long? lessThanMatchId = null)
        {
            var addedArguments = new List<string>();
            if (lessThanMatchId != null)
            {
                addedArguments.Add($@"less_than_match_id={lessThanMatchId}");
            }

            return addedArguments;
        }
    }
}
