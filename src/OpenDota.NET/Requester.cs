namespace OpenDotaDotNet
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Net;
    using System.Net.Http;
    using System.Text.Json;
    using System.Text.Json.Serialization;
    using System.Threading.Tasks;

    using OpenDotaDotNet.JsonConverters;

    public class Requester : IDisposable
    {
        private readonly HttpClient httpClient;
        private readonly HttpClientHandler httpClientHandler;

        public Requester(string apiKey = null, IWebProxy proxy = null)
        {
            this.ApiKey = apiKey;
            this.httpClientHandler = new HttpClientHandler { UseProxy = true, Proxy = proxy, };
            this.httpClient = new HttpClient(this.httpClientHandler)
            {
                Timeout = TimeSpan.FromSeconds(60),
                BaseAddress = new Uri("https://api.opendota.com/api/"),
            };
        }

        public string ApiKey { get; set; }

        public async Task<T> GetResponseAsync<T>(string url, IEnumerable<string> queryParameters = null)
            where T : class
        {
            var response = await this.GetRequestResponseMessageAsync(url, queryParameters?.ToList());
            response.EnsureSuccessStatusCode();
            var options = new JsonSerializerOptions { IgnoreNullValues = true, PropertyNameCaseInsensitive = true };
            options.Converters.Add(new JsonStringEnumConverter());
            options.Converters.Add(new LongConverter());
            options.Converters.Add(new IntConverter());
            options.Converters.Add(new NullableIntConverter());
            options.Converters.Add(new StringConverter());
            options.Converters.Add(new BoolConverter());
            var textResponse = await response.Content.ReadAsStringAsync();
            if (string.IsNullOrEmpty(textResponse))
            {
                return null;
            }

            var data = JsonSerializer.Deserialize<T>(textResponse, options);
            return data;
        }

        public async Task<HttpResponseMessage> PostRequest(string url, HttpContent content = null)
        {
            var response = await this.httpClient.PostAsync(url, content);
            return response;
        }

        public void Dispose()
        {
            this.Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                this.httpClient?.Dispose();
                this.httpClientHandler?.Dispose();
            }
        }

        private async Task<HttpResponseMessage> GetRequestResponseMessageAsync(string url, IList<string> queryParameters = null)
        {
            queryParameters ??= new List<string>();
            if (this.ApiKey != null)
            {
                queryParameters.Add($@"api_key={this.ApiKey}");
            }

            var argumentsString = string.Join("&", queryParameters.Where(arg => !string.IsNullOrEmpty(arg)));
            var fullUrl = $@"{url}?{argumentsString}";

            var message = await this.httpClient.GetAsync(fullUrl);
            return message;
        }
    }
}
