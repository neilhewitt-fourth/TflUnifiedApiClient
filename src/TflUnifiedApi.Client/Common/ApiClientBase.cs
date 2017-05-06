using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TflUnifiedApiClient
{
    public abstract class ApiClientBase
    {
        protected string _baseUrl = "https://api.tfl.gov.uk";

        public string BaseUrl
        {
            get { return _baseUrl; }
            set { _baseUrl = value.TrimEnd('/'); }
        }

        public event EventHandler<BeforeSendEventArgs> BeforeSend;
        public event EventHandler<AfterSendEventArgs> AfterSend;

        protected async Task<T> GetAsync<T>(string verb, params (string key, object value)[] queryParameters)
            where T : class
        {
            return await GetAsync<T>(CancellationToken.None, verb, queryParameters);
        }

        protected async Task<T> GetAsync<T>(CancellationToken cancellationToken, string verb, params (string key, object value)[] queryParameters)
            where T : class
        {
            var client = new HttpClient();

            var urlBuilder = new StringBuilder();
            urlBuilder.Append(BaseUrl).Append("/" + verb.TrimStart('/'));

            string urlString = urlBuilder.ToString().ToLower();
            string queryString = String.Empty;
            foreach (var parameter in queryParameters)
            {
                if (parameter.value != null)
                {
                    if (urlString.Contains("{" + parameter.key.ToLower() + "}"))
                    {
                        urlString = urlString.Replace("{" + parameter.key.ToLower() + "}", Uri.EscapeDataString(GetFormattedValue(parameter.value)));
                    }
                    else
                    {
                        queryString += "&" + parameter.key + "=" + Uri.EscapeDataString(GetFormattedValue(parameter.value));
                    }
                }
            }

            var url = urlString + (!String.IsNullOrWhiteSpace(queryString) ? "?" + queryString.TrimStart('&') : String.Empty);
            var request = new HttpRequestMessage(HttpMethod.Get, url);
            request.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            BeforeSend(this, new BeforeSendEventArgs(client, request, url, queryParameters, verb));

            try
            {
                using (var response = await client.SendAsync(request, HttpCompletionOption.ResponseHeadersRead, cancellationToken))
                {
                    if (response.StatusCode == HttpStatusCode.OK)
                    {
                        var data = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                        T output = JsonConvert.DeserializeObject<T>(data);

                        AfterSend(this, new AfterSendEventArgs(client, response, output));

                        return output;
                    }
                    else
                    {
                        throw new Exception("Something went wrong!"); // placeholder for better exception handling!
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                client.Dispose();
            }
        }

        protected string GetFormattedValue(object value)
        {
            string output = String.Empty;

            // common collection types and special handling
            if (value is IEnumerable<string>)
            {
                output = String.Join(",", ((IEnumerable<string>)value));
            }
            else if (value is IEnumerable<int>)
            {
                output = String.Join(",", ((IEnumerable<int>)value));
            }
            else if (value is DateTime)
            {
                DateTime date = (DateTime)value;
                output = date.ToString("yyyy-MM-dd");
            }
            else
            {
                output = value.ToString();
            }

            return output;
        }

        public ApiClientBase()
        {
            BeforeSend += (sender, e) => { };
            AfterSend += (sender, e) => { };
        }
    }

    public class BeforeSendEventArgs : EventArgs
    {
        public HttpClient Client { get; }
        public HttpRequestMessage Request { get; }
        public IEnumerable<(string key, object value)> Parameters { get; }
        public string Verb { get; }
        public string Url { get; }

        public BeforeSendEventArgs(HttpClient client, HttpRequestMessage request, string url, IEnumerable<(string key, object value)> parameters, string verb)
            : base()
        {
            Client = client;
            Request = request;
            Parameters = parameters;
            Verb = verb;
            Url = url;
        }
    }

    public class AfterSendEventArgs : EventArgs
    {
        public HttpClient Client { get; }
        public HttpResponseMessage Response { get; }
        public object Output { get; }

        public AfterSendEventArgs(HttpClient client, HttpResponseMessage response, object output)
            : base()
        {
            Client = client;
            Response = response;
            Output = output;
        }
    }
}
