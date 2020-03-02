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
        private readonly HttpClient _httpClient;
        private readonly HttpClientHandler _httpClientHandler;

        public string ApiKey { get; set; }

        public Requester(string apiKey = null, IWebProxy proxy = null)
        {
            this.ApiKey = apiKey;

            this._httpClientHandler = new HttpClientHandler
                                          {
                                              UseProxy = true,
                                              Proxy = proxy
                                          };

            this._httpClient = new HttpClient(this._httpClientHandler)
                                   {
                                       Timeout = TimeSpan.FromSeconds(30), 
                                       BaseAddress = new Uri("https://api.opendota.com/api/")
                                   };
        }

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

                var message = await this._httpClient.GetAsync(fullUrl);

                return message;
            }
            catch (HttpRequestException ex)
            {
                var innerExceptionMsg = ex.InnerException?.Message ?? string.Empty;

                Console.WriteLine(innerExceptionMsg);

                return null;
                // re?
            }
        }

        public async Task<HttpResponseMessage> PostRequest(string url, HttpContent content = null)
        {
            content = new StringContent("");

            var response = await this._httpClient.PostAsync(url, content);

            return response;
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

        public void Dispose()
        {
            this._httpClient.Dispose();
            this._httpClientHandler.Dispose();
        }
    }
}
