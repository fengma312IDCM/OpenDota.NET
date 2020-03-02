namespace OpenDotaDotNet.Endpoints
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using Newtonsoft.Json;

    using OpenDotaDotNet.Models.Schema;

    public class SchemaEndpoint : ISchemaEndpoint
    {
        private const string GetDatabaseSchema = "schema";

        private readonly Requester requester;

        public SchemaEndpoint(Requester requester)
        {
            this.requester = requester;
        }

        /// <summary>
        /// Get database schema.
        /// </summary>
        /// <returns>Database schema.</returns>
        public async Task<List<DatabaseSchema>> GetDatabaseSchemaAsync()
        {
            var response = await this.requester.GetRequestResponseMessageAsync(GetDatabaseSchema);

            response.EnsureSuccessStatusCode();

            var databaseSchema = JsonConvert.DeserializeObject<List<DatabaseSchema>>(await response.Content.ReadAsStringAsync());

            return databaseSchema;
        }
    }
}
