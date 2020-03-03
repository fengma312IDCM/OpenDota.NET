namespace OpenDota.NET.Tests
{
    using System.Linq;
    using System.Threading.Tasks;

    using OpenDotaDotNet;

    using Xunit;
    using Xunit.Abstractions;

    public class SchemaEndpointTests
    {
        private readonly ITestOutputHelper testOutputHelper;

        private readonly OpenDotaApi openDotaApi;

        public SchemaEndpointTests(ITestOutputHelper testOutputHelper)
        {
            this.testOutputHelper = testOutputHelper;
            this.openDotaApi = OpenDotaApi.GetInstance();
        }

        [Fact]
        public async Task TestGetDatabaseSchema()
        {
            var result = await this.openDotaApi.Schema.GetDatabaseSchemaAsync();
            this.testOutputHelper.WriteLine(result.ToJsonString());

            Assert.True(result.Count >= 335);
            Assert.True(result.All(x => x.ColumnName != null && x.DataType != null && x.TableName != null));
        }
    }
}
