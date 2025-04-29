using Newtonsoft.Json;
using RadioPlayer.Models;
using System.Net;

namespace RadioPlayer.Services;

internal class RadioApiService
{
    private readonly HttpClient _httpClient = new();

    private async Task<IReadOnlyCollection<T>?> FetchDataAsync<T>(string apiEndpoint)
    {
        var url = $"{RadioBrowserApi.BaseUrl}/{apiEndpoint}";
        var response = await _httpClient.PostAsync(url, null);

        if (!response.IsSuccessStatusCode)
            return null;

        var json = await response.Content.ReadAsStringAsync();
        return JsonConvert.DeserializeObject<List<T>>(json);
    }

    public Task<IReadOnlyCollection<Server>?> GetServersAsync()
    {
        return FetchDataAsync<Server>(RadioBrowserApi.GetServersApi);
    }

    public Task<IReadOnlyCollection<Country>?> GetCountriesAsync()
    {
        return FetchDataAsync<Country>(RadioBrowserApi.GetCountriesApi);
    }

    public async Task<IReadOnlyCollection<CountryFlag>?> GetFlagsAsync()
    {
        var url = CountriesApi.GetFlagsApi;
        var response = await _httpClient.GetAsync(url);
        
        if (!response.IsSuccessStatusCode)
            return null;

        var json = await response.Content.ReadAsStringAsync();
        return JsonConvert.DeserializeObject<List<CountryFlag>>(json);
    }
}
