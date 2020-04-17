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
                                      Timeout = TimeSpan.FromSeconds(30),
                                      BaseAddress = new Uri("https://api.opendota.com/api/"),
                                  };
        }

        public string ApiKey { get; set; }

        public async Task<T> GetResponseAsync<T>(string url, List<string> queryParameters = null)
            where T : class
        {
            var response = await this.GetRequestResponseMessageAsync(url, queryParameters);
            response.EnsureSuccessStatusCode();
            var options = new JsonSerializerOptions { IgnoreNullValues = true, PropertyNameCaseInsensitive = true };
            options.Converters.Add(new JsonStringEnumConverter());
            options.Converters.Add(new LongConverter());
            options.Converters.Add(new IntConverter());
            options.Converters.Add(new NullableIntConverter());
            options.Converters.Add(new StringConverter());
            options.Converters.Add(new BoolConverter());
            var textResponse = await response.Content.ReadAsStringAsync();
            if (textResponse == string.Empty)
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

        private async Task<HttpResponseMessage> GetRequestResponseMessageAsync(string url, List<string> queryParameters = null)
        {
            try
            {
                var fullUrl = url;

                if (queryParameters == null)
                {
                    if (this.ApiKey != null)
                    {
                        queryParameters = new List<string>();

                        fullUrl = $@"{url}?{this.BuildArgumentsString(queryParameters)}";
                    }
                }
                else
                {
                    fullUrl = $@"{url}?{this.BuildArgumentsString(queryParameters)}";
                }

                var message = await this.httpClient.GetAsync(fullUrl);

                return message;
            }
            catch (HttpRequestException ex)
            {
                var innerExceptionMsg = ex.InnerException?.Message ?? string.Empty;

                Console.WriteLine(innerExceptionMsg);

                return null;
            }
        }

        private string BuildArgumentsString(List<string> arguments)
        {
            if (this.ApiKey != null)
            {
                arguments.Add($@"api_key={this.ApiKey}");
            }

            return arguments.Where(arg => !string.IsNullOrEmpty(arg))
                            .Aggregate(string.Empty, (current, arg) => current + "&" + arg);
        }
    }
}
