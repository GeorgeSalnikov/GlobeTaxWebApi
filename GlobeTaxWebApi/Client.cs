namespace GlobeTaxWebApi;
using CsvHelper.Configuration.Attributes;
public class Client
{
    [Name("client_id")]
    public int ClientId { get; set; }
    [Name("name")]
    public string Name { get; set; }
    [Name("tax_id")]
    public string TaxId { get; set; }
    [Name("country_code")]
    public string CountryCode { get; set; }
}
