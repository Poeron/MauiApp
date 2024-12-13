using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using System.Collections.Generic;
using MauiApp1.Models;

public class ApiService
{
    private readonly HttpClient _httpClient;

    public ApiService()
    {
        _httpClient = new HttpClient();
    }

    public async Task<List<Client>> GetClientsAsync(string url)
    {
        var response = await _httpClient.GetAsync(url);

        if (!response.IsSuccessStatusCode)
        {
            throw new HttpRequestException($"Error fetching clients: {response.StatusCode}");
        }

        var jsonResponse = await response.Content.ReadAsStringAsync();
        return JsonSerializer.Deserialize<List<Client>>(jsonResponse);
    }
}
