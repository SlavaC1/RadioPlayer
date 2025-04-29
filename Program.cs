using RadioPlayer.Services;

namespace RadioPlayer;

internal class Program
{
    private static async Task Main(string[] args)
    {
        try
        {
            var api = new RadioApiService();
            var servers = await api.GetServersAsync();
            var countries = await api.GetCountriesAsync();
            var flags = await api.GetFlagsAsync();
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
        }
    }
}