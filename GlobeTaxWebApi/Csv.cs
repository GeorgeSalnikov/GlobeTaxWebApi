using CsvHelper;
using System.Globalization;

namespace GlobeTaxWebApi;

public class Csv
{
    private readonly string connectionString;

    public Csv(string fileName)
        => connectionString = fileName; // $"Provider=Microsoft.Jet.OLEDB.4.0;Data Source={fileName};Persist Security Info=True";

    public List<T>? Parse<T>()
    {
        using var sr = new StreamReader(connectionString);
        using var csv = new CsvReader(sr, new CsvHelper.Configuration.CsvConfiguration(CultureInfo.InvariantCulture) { Delimiter = "\t" });
        var recs = csv.GetRecords<T>().ToList();
        return recs;
    }
}
