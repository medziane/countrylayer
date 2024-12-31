using CountryLayerSdk;
using CountryLayerSdk.Handlers;

const string apiKey = "YOUR_API_KEY";

ICountryLayer countryLayer = new CountryLayer(apiKey);
var filters = "name;alpha2Code";
var countries = await countryLayer.GetAllCountries(filters, CancellationToken.None);

foreach (var country in countries)
{
    Console.WriteLine($"{country.Name} ({country.Alpha2Code})");
}
// var country = await countryLayer.GetCountriesByCurrency("eur", CancellationToken.None);
var foo = countries;
