namespace GlobeTaxWebApi;

public static class CsvClient
{
    private static Dictionary<string, List<Client>>? _cache = null;

    public static Dictionary<string, List<Client>> Get()
    {
        if (_cache == null)
            _cache = new Csv(@"Data\client.csv")
                .Parse<Client>()!
                .GroupBy(c => c.CountryCode)
                .ToDictionary(c => c.Key, c => c.ToList(), StringComparer.InvariantCulture);
        return _cache;
    }
}
