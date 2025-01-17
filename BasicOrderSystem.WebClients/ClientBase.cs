﻿using System.Net.Http.Json;
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

        protected async Task PostRequest<TRequestType>(string path, TRequestType requestBody)
        {
            HttpResponseMessage response = await HttpClient.PostAsJsonAsync(path, requestBody);
            response.EnsureSuccessStatusCode();
        }

        protected async Task PutRequest<TRequestType>(string path, TRequestType requestBody)
        {
            HttpResponseMessage response = await HttpClient.PutAsJsonAsync(path, requestBody);
            response.EnsureSuccessStatusCode();
        }

        protected async Task<TResponseType> DeleteRequest<TResponseType>(string path)
        {
            HttpResponseMessage response = await HttpClient.DeleteAsync(path);
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