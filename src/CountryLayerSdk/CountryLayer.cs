namespace CountryLayerSdk;

public class CountryLayer :
    ICountryLayer
{
    private const string BaseUrl = "https://api.countrylayer.com";
    private const string AccessKey = "access_key";
    private readonly ICountryLayer _countryLayer;

    public CountryLayer(string apiKey)
        : this(apiKey, CreateQueryStringInjectingHttpMessageHandler(apiKey))
    {
    }

    public CountryLayer(string apiKey, HttpClient httpClient)
        : this(apiKey, httpClient.GetHandler())
    {
    }

    public CountryLayer(string apiKey, HttpMessageHandler handler)
    {
        var refitSettings = new RefitSettings
        {
            HttpMessageHandlerFactory = () =>
                handler as QueryStringInjectingHttpMessageHandler ??
                CreateQueryStringInjectingHttpMessageHandler(handler, apiKey)
        };
        _countryLayer = RestService.For<ICountryLayer>(BaseUrl, refitSettings);
    }

    private static QueryStringInjectingHttpMessageHandler CreateQueryStringInjectingHttpMessageHandler(
        string apiKey) =>
        CreateQueryStringInjectingHttpMessageHandler(new HttpClientHandler(), apiKey);

    private static QueryStringInjectingHttpMessageHandler CreateQueryStringInjectingHttpMessageHandler(
        HttpMessageHandler innerHandler,
        string apiKey) =>
        new(innerHandler, (AccessKey, apiKey));

    #region ICountryLayer

    Task<List<Country>> ICountryLayer.GetAllCountries(CancellationToken cancellationToken) => _countryLayer.GetAllCountries(cancellationToken);

    Task<List<Country>> ICountryLayer.GetCountriesByName(string name, CancellationToken cancellationToken) => _countryLayer.GetCountriesByName(name, cancellationToken);

    Task<List<Country>> ICountryLayer.GetCountriesByCapital(string capital, CancellationToken cancellationToken) => _countryLayer.GetCountriesByCapital(capital, cancellationToken);

    public Task<List<Country>> GetCountriesByName(string name, bool fullText, CancellationToken cancellationToken) => _countryLayer.GetCountriesByName(name, fullText, cancellationToken);

    Task<List<Country>> ICountryLayer.GetCountriesByLanguage(string language, CancellationToken cancellationToken) => _countryLayer.GetCountriesByLanguage(language, cancellationToken);

    Task<List<Country>> ICountryLayer.GetCountriesByCurrency(string currency, CancellationToken cancellationToken) => _countryLayer.GetCountriesByCurrency(currency, cancellationToken);

    Task<List<Country>> ICountryLayer.GetCountriesByRegion(string region, CancellationToken cancellationToken) => _countryLayer.GetCountriesByRegion(region, cancellationToken);

    Task<List<Country>> ICountryLayer.GetCountriesByRegionalBlock(string regionalBlock, CancellationToken cancellationToken) => _countryLayer.GetCountriesByRegionalBlock(regionalBlock, cancellationToken);

    Task<List<Country>> ICountryLayer.GetCountriesByCallingCode(string callingCode, CancellationToken cancellationToken) => _countryLayer.GetCountriesByCallingCode(callingCode, cancellationToken);

    Task<List<Country>> ICountryLayer.GetCountriesByAlphaCode(string alphaCode, CancellationToken cancellationToken) => _countryLayer.GetCountriesByAlphaCode(alphaCode, cancellationToken);

    #endregion
}
