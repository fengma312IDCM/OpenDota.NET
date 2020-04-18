namespace OpenDotaDotNet.Endpoints
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using OpenDotaDotNet.Models.Schema;

    public class SchemaEndpoint : ISchemaEndpoint
    {
        private readonly Requester requester;

        public SchemaEndpoint(Requester requester)
        {
            this.requester = requester;
        }

        /// <summary>
        /// Get database schema.
        /// </summary>
        /// <returns>Database schema.</returns>
        public async Task<IEnumerable<DatabaseSchema>> GetDatabaseSchemaAsync() =>
            await this.requester.GetResponseAsync<IEnumerable<DatabaseSchema>>("schema");
    }
}
