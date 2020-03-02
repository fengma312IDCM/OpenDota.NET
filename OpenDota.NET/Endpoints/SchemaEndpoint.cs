using Newtonsoft.Json;

using OpenDotaDotNet.Models.Schema;

using System.Collections.Generic;
using System.Threading.Tasks;

namespace OpenDotaDotNet.Endpoints
{
    public class SchemaEndpoint : ISchemaEndpoint
    {
        private const string GetDatabaseSchema = "schema";

        private readonly Requester requester;

        public SchemaEndpoint(Requester requester)
        {
            this.requester = requester;
        }

        /// <summary>
        /// Get database schema
        /// </summary>
        /// <returns></returns>
        public async Task<List<DatabaseSchema>> GetDatabaseSchemaAsync()
        {
            var response = await this.requester.GetRequestResponseMessageAsync(GetDatabaseSchema);

            response.EnsureSuccessStatusCode();

            var databaseSchema = JsonConvert.DeserializeObject<List<DatabaseSchema>>(await response.Content.ReadAsStringAsync());

            return databaseSchema;
        }
    }
}
