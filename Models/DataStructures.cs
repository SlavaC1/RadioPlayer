using System.Security.Cryptography.X509Certificates;
using Newtonsoft.Json;

namespace RadioPlayer.Models;

public record Server
(
    [property: JsonProperty("ip")] string Ip, 
    [property: JsonProperty("name")] string Url
);

public record Country
(
    [property: JsonProperty("name")] string Name,
    [property: JsonProperty("iso_3166_1")] string Code,
    [property: JsonProperty("stationcount")] string StationsCount
);

public record Flag
(
    [property: JsonProperty("png")] string Png,
    [property: JsonProperty("svg")] string Svg,
    [property: JsonProperty("alt")] string Description
);

public record CountryFlag
(
    [property: JsonProperty("flags")] Flag Flags,
    [property: JsonProperty("cca2")] string CountryCode
);