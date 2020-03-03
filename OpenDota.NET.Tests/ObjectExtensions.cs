namespace OpenDota.NET.Tests
{
    using System.Text.Json;

    public static class ObjectExtensions
    {
        public static string ToJsonString(this object obj)
        {
            var str = JsonSerializer.Serialize(obj);
            return str;
        }
    }
}
