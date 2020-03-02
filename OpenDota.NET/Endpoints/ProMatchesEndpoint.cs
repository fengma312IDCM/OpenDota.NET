﻿using Newtonsoft.Json;
using OpenDotaDotNet.Interfaces;
using OpenDotaDotNet.Models.ProMatches;

using System.Collections.Generic;
using System.Threading.Tasks;

namespace OpenDotaDotNet.Endpoints
{
    class ProMatchesEndpoint : IProMatchEndpoint
    {
        private const string ProMatches = "proMatches";

        private readonly Requester requester;

        public ProMatchesEndpoint(Requester requester)
        {
            this.requester = requester;
        }

        /// <summary>
        /// Get list of pro matches
        /// </summary>
        /// <param name="lessThanMatchId"></param>
        /// <returns></returns>
        public async Task<List<ProMatch>> GetProMatchesAsync(long? lessThanMatchId = null)
        {
            var addedArguments = CreateArgumentListForProMatchesRequest(lessThanMatchId);

            var response = await this.requester.GetRequestResponseMessageAsync(ProMatches, addedArguments);

            response.EnsureSuccessStatusCode();

            var proMatches = JsonConvert.DeserializeObject<List<ProMatch>>(await response.Content.ReadAsStringAsync());

            return proMatches;
        }

        #region Helper
        private List<string> CreateArgumentListForProMatchesRequest(long? lessThanMatchId = null)
        {
            var addedArguments = new List<string>();

            if (lessThanMatchId != null)
            {
                addedArguments.Add($@"less_than_match_id={lessThanMatchId}");
            }

            return addedArguments;
        }
        #endregion
    }
}