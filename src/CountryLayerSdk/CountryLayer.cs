namespace CountryLayerSdk;

/// <summary>
/// Provides methods for accessing country-related data from the CountryLayer API.
/// </summary>
public class CountryLayer :
    ICountryLayer
{
    private const string BaseUrl = "https://api.countrylayer.com";
    private const string AccessKey = "access_key";
    private readonly ICountryLayer _countryLayer;

    /// <summary>
    /// Initializes a new instance of the <see cref="CountryLayer"/> class with the specified API key.
    /// </summary>
    /// <param name="apiKey">The API key for accessing the CountryLayer API.</param>
    /// <exception cref="ArgumentNullException">Thrown when <paramref name="apiKey"/> is null.</exception>
    public CountryLayer(string apiKey)
        : this(apiKey, CreateQueryStringInjectingHttpMessageHandler(apiKey))
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="CountryLayer"/> class with the specified API key and HTTP client.
    /// </summary>
    /// <param name="apiKey">The API key for accessing the CountryLayer API.</param>
    /// <param name="httpClient">The HTTP client to use for making requests.</param>
    /// <exception cref="ArgumentNullException">Thrown when <paramref name="apiKey"/> is null.</exception>
    public CountryLayer(string apiKey, HttpClient httpClient)
        : this(apiKey, httpClient.GetHandler())
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="CountryLayer"/> class with the specified API key and HTTP message handler.
    /// </summary>
    /// <param name="apiKey">The API key for accessing the CountryLayer API.</param>
    /// <param name="handler">The HTTP message handler to use for making requests.</param>
    /// <exception cref="ArgumentNullException">Thrown when <paramref name="apiKey"/> is null.</exception>
    public CountryLayer(string apiKey, HttpMessageHandler handler)
    {
        ArgumentNullException.ThrowIfNull(apiKey);

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

    Task<List<Country>> ICountryLayer.GetAllCountries(string filters, CancellationToken cancellationToken) => _countryLayer.GetAllCountries(filters, cancellationToken);

    Task<List<Country>> ICountryLayer.GetCountriesByName(string name, CancellationToken cancellationToken) => _countryLayer.GetCountriesByName(name, cancellationToken);

    Task<List<Country>> ICountryLayer.GetCountriesByName(string name, string filters, CancellationToken cancellationToken) => _countryLayer.GetCountriesByName(name, filters, cancellationToken);

    Task<List<Country>> ICountryLayer.GetCountriesByCapital(string capital, CancellationToken cancellationToken) => _countryLayer.GetCountriesByCapital(capital, cancellationToken);

    Task<List<Country>> ICountryLayer.GetCountriesByCapital(string capital, string filters, CancellationToken cancellationToken) => _countryLayer.GetCountriesByCapital(capital, filters, cancellationToken);

    Task<List<Country>> ICountryLayer.GetCountriesByName(string name, bool fullText, CancellationToken cancellationToken) => _countryLayer.GetCountriesByName(name, fullText, cancellationToken);

    Task<List<Country>> ICountryLayer.GetCountriesByName(string name, bool fullText, string filters, CancellationToken cancellationToken) => _countryLayer.GetCountriesByName(name, fullText, filters, cancellationToken);

    Task<List<Country>> ICountryLayer.GetCountriesByLanguage(string language, CancellationToken cancellationToken) => _countryLayer.GetCountriesByLanguage(language, cancellationToken);

    Task<List<Country>> ICountryLayer.GetCountriesByLanguage(string language, string filters, CancellationToken cancellationToken) => _countryLayer.GetCountriesByLanguage(language, filters, cancellationToken);

    Task<List<Country>> ICountryLayer.GetCountriesByCurrency(string currency, CancellationToken cancellationToken) => _countryLayer.GetCountriesByCurrency(currency, cancellationToken);

    Task<List<Country>> ICountryLayer.GetCountriesByCurrency(string currency, string filters, CancellationToken cancellationToken) => _countryLayer.GetCountriesByCurrency(currency, filters, cancellationToken);

    Task<List<Country>> ICountryLayer.GetCountriesByRegion(string region, CancellationToken cancellationToken) => _countryLayer.GetCountriesByRegion(region, cancellationToken);

    Task<List<Country>> ICountryLayer.GetCountriesByRegion(string region, string filters, CancellationToken cancellationToken) => _countryLayer.GetCountriesByRegion(region, filters, cancellationToken);

    Task<List<Country>> ICountryLayer.GetCountriesByRegionalBlock(string regionalBlock, CancellationToken cancellationToken) => _countryLayer.GetCountriesByRegionalBlock(regionalBlock, cancellationToken);

    Task<List<Country>> ICountryLayer.GetCountriesByRegionalBlock(string regionalBlock, string filters, CancellationToken cancellationToken) => _countryLayer.GetCountriesByRegionalBlock(regionalBlock, filters, cancellationToken);

    Task<List<Country>> ICountryLayer.GetCountriesByCallingCode(string callingCode, CancellationToken cancellationToken) => _countryLayer.GetCountriesByCallingCode(callingCode, cancellationToken);

    Task<List<Country>> ICountryLayer.GetCountriesByCallingCode(string callingCode, string filters, CancellationToken cancellationToken) => _countryLayer.GetCountriesByCallingCode(callingCode, filters, cancellationToken);

    Task<List<Country>> ICountryLayer.GetCountriesByAlphaCode(string alphaCode, CancellationToken cancellationToken) => _countryLayer.GetCountriesByAlphaCode(alphaCode, cancellationToken);

    Task<List<Country>> ICountryLayer.GetCountriesByAlphaCode(string alphaCode, string filters, CancellationToken cancellationToken) => _countryLayer.GetCountriesByAlphaCode(alphaCode, filters, cancellationToken);

    #endregion
}
