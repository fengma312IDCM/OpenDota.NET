namespace OpenDotaDotNet.Endpoints
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using OpenDotaDotNet.Models.Schema;

    public interface ISchemaEndpoint
    {
        /// <summary>
        /// Get database schema.
        /// </summary>
        /// <returns>Database schema.</returns>
        Task<List<DatabaseSchema>> GetDatabaseSchemaAsync();
    }
}
