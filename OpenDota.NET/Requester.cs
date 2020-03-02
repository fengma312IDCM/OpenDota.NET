namespace OpenDotaDotNet
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Net;
    using System.Net.Http;
    using System.Threading.Tasks;

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

        public async Task<HttpResponseMessage> GetRequestResponseMessageAsync(string url, List<string> queryParameters = null)
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
