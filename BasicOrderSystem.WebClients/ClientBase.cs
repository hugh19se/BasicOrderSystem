using System.Text.Json;

namespace BasicOrderSystem.WebClients
{
    public class ClientBase : IDisposable
    {
        private readonly HttpClient HttpClient;

        protected ClientBase(string baseAddress, int timeout = 60)
        {
            HttpClient = GetHttpClient(baseAddress, timeout);
        }

        private static HttpClient GetHttpClient(string baseAddress, int timeout)
        {
            HttpClient client = new()
            {
                BaseAddress = new Uri(baseAddress)
            };

            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

            return client;
        }

        protected async Task<TResponseType> GetResponse<TResponseType>(string path)
        {
            HttpResponseMessage? response = await HttpClient.GetAsync(path);
            response.EnsureSuccessStatusCode();

            Stream? stream = await response.Content.ReadAsStreamAsync();
            TResponseType? result = JsonSerializer.Deserialize<TResponseType>(stream);

            return result;
        }

        public void Dispose()
        { 
            HttpClient.Dispose();
        }
    }
}