using System.Reflection.Metadata;

namespace RadioPlayer.Models;

internal class CountriesApi
{
    public const string GetFlagsApi = "https://restcountries.com/v3.1/all?fields=cca2,flags";
}

internal class RadioBrowserApi
{
    public const string BaseUrl = "http://152.53.85.3";
    public const string GetServersApi = "json/servers";
    public const string GetCountriesApi = "json/countries";
}
