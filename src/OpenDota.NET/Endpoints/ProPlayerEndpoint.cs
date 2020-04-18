namespace OpenDotaDotNet.Endpoints
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using OpenDotaDotNet.Models.ProPlayers;

    public class ProPlayerEndpoint : IProPlayerEndpoint
    {
        private readonly Requester requester;

        public ProPlayerEndpoint(Requester requester)
        {
            this.requester = requester;
        }

        /// <inheritdoc />
        public async Task<IEnumerable<ProPlayer>> GetProPlayersAsync() =>
            await this.requester.GetResponseAsync<IEnumerable<ProPlayer>>("proPlayers");
    }
}
