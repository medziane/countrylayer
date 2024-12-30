using CountryLayerSdk;
using CountryLayerSdk.Handlers;

const string apiKey = "YOUR_API_KEY";

ICountryLayer countryLayer = new CountryLayer(apiKey);
// var countries = await countryLayer.GetAllCountries(CancellationToken.None);

var country = await countryLayer.GetCountriesByCurrency("eur", CancellationToken.None);
var foo = country;
