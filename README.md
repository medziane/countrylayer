# CountryLayer SDK for .NET
The CountryLayer SDK for .NET is a library that allows you to access the CountryLayer API from your .NET application. The CountryLayer API is a RESTful web service that provides a way to look up information about countries.

## Prerequisites
- You need a CountryLayer API key. You can get one for free at [https://countrylayer.com](https://countrylayer.com).

## Usage
The CountryLayer SDK for .NET is available as a NuGet package. You can install it using the following command:

```bash
dotnet add package CountryLayer
```

Here is an example of how you can use the SDK to look up information about a country:

```csharp
ICountryLayer countryLayer = new CountryLayer(apiKey);
var country = await countryLayer.GetCountriesByCurrency("usd", CancellationToken.None);
```
