# CountryLayer SDK for .NET
The CountryLayer SDK for .NET is a library that allows you to access the CountryLayer API from your .NET application. The CountryLayer API is a RESTful web service that provides a way to look up information about countries.

## Prerequisites
- You need a CountryLayer API key. You can get one for free (or paid) at [https://countrylayer.com](https://countrylayer.com).

## Usage
The CountryLayer SDK for .NET is available as a [NuGet package](https://www.nuget.org/packages/CountryLayer/). You can install it using the following command:

```bash
dotnet add package CountryLayer
```

Here is an example of how you can use the SDK to look up information about a country:

```csharp
ICountryLayer countryLayer = new CountryLayer(apiKey);
List<Country> countries = await countryLayer.GetCountriesByCurrency("usd", CancellationToken.None);
```

## Documentation
The CountryLayer SDK for .NET is a thin wrapper around the CountryLayer API.

### ICountryLayer
The `ICountryLayer` interface defines the methods that you can use to access the CountryLayer API.

#### Methods
- `GetAllCountries(CancellationToken cancellationToken)`: Gets a list of all countries.
- `GetAllCountries(string filters, CancellationToken cancellationToken)`: Gets a list of all countries but returns only the data corresponding to the keys specified in filters.
- `GetCountriesByName(string name, CancellationToken cancellationToken)`: Gets a list of countries by name.
- `GetCountriesByName(string name, string filters, CancellationToken cancellationToken)`: Gets a list of countries by name but returns only the data corresponding to the keys specified in filters.
- `GetCountriesByName(string name, bool fullText, CancellationToken cancellationToken)`: Gets a list of countries by name using full-text search.
- `GetCountriesByName(string name, bool fullText, string filters, CancellationToken cancellationToken)`: Gets a list of countries by name using full-text search but returns only the data corresponding to the keys specified in filters.
- `GetCountriesByCapital(string capital, CancellationToken cancellationToken)`: Gets a list of countries by capital.
- `GetCountriesByCapital(string capital, string filters, CancellationToken cancellationToken)`: Gets a list of countries by capital but returns only the data corresponding to the keys specified in filters.
- `GetCountriesByLanguage(string language, CancellationToken cancellationToken)`: Gets a list of countries by language.
- `GetCountriesByLanguage(string language, string filters, CancellationToken cancellationToken)`: Gets a list of countries by language but returns only the data corresponding to the keys specified in filters.
- `GetCountriesByCurrency(string currency, CancellationToken cancellationToken)`: Gets a list of countries by currency.
- `GetCountriesByCurrency(string currency, string filters, CancellationToken cancellationToken)`: Gets a list of countries by currency but returns only the data corresponding to the keys specified in filters.
- `GetCountriesByRegion(string region, CancellationToken cancellationToken)`: Gets a list of countries by region.
- `GetCountriesByRegion(string region, string filters, CancellationToken cancellationToken)`: Gets a list of countries by region but returns only the data corresponding to the keys specified in filters.
- `GetCountriesByRegionalBlock(string regionalBlock, CancellationToken cancellationToken)`: Gets a list of countries by regional block.
- `GetCountriesByRegionalBlock(string regionalBlock, string filters, CancellationToken cancellationToken)`: Gets a list of countries by regional block but returns only the data corresponding to the keys specified in filters.
- `GetCountriesByCallingCode(string callingCode, CancellationToken cancellationToken)`: Gets a list of countries by calling code.
- `GetCountriesByCallingCode(string callingCode, string filters, CancellationToken cancellationToken)`: Gets a list of countries by calling code but returns only the data corresponding to the keys specified in filters.
- `GetCountriesByAlphaCode(string alphaCode, CancellationToken cancellationToken)`: Gets a list of countries by alpha code.
- `GetCountriesByAlphaCode(string alphaCode, string filters, CancellationToken cancellationToken)`: Gets a list of countries by alpha code but returns only the data corresponding to the keys specified in filters.

For more information about the API, see the [CountryLayer API documentation](https://countrylayer.com/documentation).

## License
This project is licensed under the MIT License. See the [LICENSE](https://github.com/medziane/countrylayer/blob/main/LICENSE) file for more information.

