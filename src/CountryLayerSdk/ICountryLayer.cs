namespace CountryLayerSdk;

/// <summary>
/// Defines the interface for accessing country-related data from the CountryLayer API.
/// </summary>
public interface ICountryLayer
{
    /// <summary>
    /// Retrieves a list of all countries.
    /// </summary>
    /// <param name="cancellationToken">A cancellation token to cancel the operation.</param>
    /// <returns>A task that represents the asynchronous operation. The task result contains a list of countries.</returns>
    /// <exception cref="Exception">Thrown when an error occurs while retrieving the countries.</exception>
    [Get("/v2/all")]
    Task<List<Country>> GetAllCountries(
        CancellationToken cancellationToken);

    /// <summary>
    /// Retrieves a list of all countries.
    /// </summary>
    /// <param name="filters">The filter is semicolon separated values to apply to the query. e.g. filter="name;capital;currency". Only these values will be returned.</param>
    /// <param name="cancellationToken">A cancellation token to cancel the operation.</param>
    /// <returns>A task that represents the asynchronous operation. The task result contains a list of countries.</returns>
    /// <exception cref="Exception">Thrown when an error occurs while retrieving the countries.</exception>
    [Get("/v2/all")]
    Task<List<Country>> GetAllCountries(
        [Query] string filters,
        CancellationToken cancellationToken);

    /// <summary>
    /// Retrieves a list of countries by name.
    /// </summary>
    /// <param name="name">The name of the country.</param>
    /// <param name="cancellationToken">A cancellation token to cancel the operation.</param>
    /// <returns>A task that represents the asynchronous operation. The task result contains a list of countries.</returns>
    /// <exception cref="Exception">Thrown when an error occurs while retrieving the countries.</exception>
    [Get("/v2/name/{name}")]
    Task<List<Country>> GetCountriesByName(
        string name,
        CancellationToken cancellationToken);

    /// <summary>
    /// Retrieves a list of countries by name.
    /// </summary>
    /// <param name="name">The name of the country.</param>
    /// <param name="filters">The filter is semicolon separated values to apply to the query. e.g. filter="name;capital;currency". Only these values will be returned.</param>
    /// <param name="cancellationToken">A cancellation token to cancel the operation.</param>
    /// <returns>A task that represents the asynchronous operation. The task result contains a list of countries.</returns>
    /// <exception cref="Exception">Thrown when an error occurs while retrieving the countries.</exception>
    [Get("/v2/name/{name}")]
    Task<List<Country>> GetCountriesByName(
        string name,
        [Query] string filters,
        CancellationToken cancellationToken);

    /// <summary>
    /// Retrieves a list of countries by capital.
    /// </summary>
    /// <param name="capital">The capital of the country.</param>
    /// <param name="cancellationToken">A cancellation token to cancel the operation.</param>
    /// <returns>A task that represents the asynchronous operation. The task result contains a list of countries.</returns>
    /// <exception cref="Exception">Thrown when an error occurs while retrieving the countries.</exception>
    [Get("/v2/capital/{capital}")]
    Task<List<Country>> GetCountriesByCapital(
        string capital,
        CancellationToken cancellationToken);

    /// <summary>
    /// Retrieves a list of countries by capital.
    /// </summary>
    /// <param name="capital">The capital of the country.</param>
    /// <param name="filters">The filter is semicolon separated values to apply to the query. e.g. filter="name;capital;currency". Only these values will be returned.</param>
    /// <param name="cancellationToken">A cancellation token to cancel the operation.</param>
    /// <returns>A task that represents the asynchronous operation. The task result contains a list of countries.</returns>
    /// <exception cref="Exception">Thrown when an error occurs while retrieving the countries.</exception>
    [Get("/v2/capital/{capital}")]
    Task<List<Country>> GetCountriesByCapital(
        string capital,
        [Query] string filters,
        CancellationToken cancellationToken);

    /// <summary>
    /// Searches for countries by name with an optional full-text search.
    /// </summary>
    /// <param name="name">The name to search for.</param>
    /// <param name="fullText">A boolean indicating whether to perform a full-text search.</param>
    /// <param name="cancellationToken">A cancellation token to cancel the operation.</param>
    /// <returns>A task that represents the asynchronous operation. The task result contains a list of countries.</returns>
    /// <exception cref="Exception">Thrown when an error occurs while retrieving the countries.</exception>
    [Get("/v2/name/{name}")]
    Task<List<Country>> GetCountriesByName(
        string name,
        [Query] bool fullText,
        CancellationToken cancellationToken);

    /// <summary>
    /// Searches for countries by name with an optional full-text search.
    /// </summary>
    /// <param name="name">The name to search for.</param>
    /// <param name="fullText">A boolean indicating whether to perform a full-text search.</param>
    /// <param name="filters">The filter is semicolon separated values to apply to the query. e.g. filter="name;capital;currency". Only these values will be returned.</param>
    /// <param name="cancellationToken">A cancellation token to cancel the operation.</param>
    /// <returns>A task that represents the asynchronous operation. The task result contains a list of countries.</returns>
    /// <exception cref="Exception">Thrown when an error occurs while retrieving the countries.</exception>
    [Get("/v2/name/{name}")]
    Task<List<Country>> GetCountriesByName(
        string name,
        [Query] bool fullText,
        [Query] string filters,
        CancellationToken cancellationToken);

    /// <summary>
    /// Searches for countries by language.
    /// </summary>
    /// <param name="language">The language to search for.</param>
    /// <param name="cancellationToken">A cancellation token to cancel the operation.</param>
    /// <returns>A task that represents the asynchronous operation. The task result contains a list of countries.</returns>
    /// <exception cref="Exception">Thrown when an error occurs while retrieving the countries.</exception>
    [Get("/v2/language/{language}")]
    Task<List<Country>> GetCountriesByLanguage(
        string language,
        CancellationToken cancellationToken);

    /// <summary>
    /// Searches for countries by language.
    /// </summary>
    /// <param name="language">The language to search for.</param>
    /// <param name="filters">The filter is semicolon separated values to apply to the query. e.g. filter="name;capital;currency". Only these values will be returned.</param>
    /// <param name="cancellationToken">A cancellation token to cancel the operation.</param>
    /// <returns>A task that represents the asynchronous operation. The task result contains a list of countries.</returns>
    /// <exception cref="Exception">Thrown when an error occurs while retrieving the countries.</exception>
    [Get("/v2/language/{language}")]
    Task<List<Country>> GetCountriesByLanguage(
        string language,
        [Query] string filters,
        CancellationToken cancellationToken);

    /// <summary>
    /// Searches for countries by currency.
    /// </summary>
    /// <param name="currency">The currency to search for.</param>
    /// <param name="cancellationToken">A cancellation token to cancel the operation.</param>
    /// <returns>A task that represents the asynchronous operation. The task result contains a list of countries.</returns>
    /// <exception cref="Exception">Thrown when an error occurs while retrieving the countries.</exception>
    [Get("/v2/currency/{currency}")]
    Task<List<Country>> GetCountriesByCurrency(
        string currency,
        CancellationToken cancellationToken);

    /// <summary>
    /// Searches for countries by currency.
    /// </summary>
    /// <param name="currency">The currency to search for.</param>
    /// <param name="filters">The filter is semicolon separated values to apply to the query. e.g. filter="name;capital;currency". Only these values will be returned.</param>
    /// <param name="cancellationToken">A cancellation token to cancel the operation.</param>
    /// <returns>A task that represents the asynchronous operation. The task result contains a list of countries.</returns>
    /// <exception cref="Exception">Thrown when an error occurs while retrieving the countries.</exception>
    [Get("/v2/currency/{currency}")]
    Task<List<Country>> GetCountriesByCurrency(
        string currency,
        [Query] string filters,
        CancellationToken cancellationToken);

    /// <summary>
    /// Searches for countries by region.
    /// </summary>
    /// <param name="region">The region to search for.</param>
    /// <param name="cancellationToken">A cancellation token to cancel the operation.</param>
    /// <returns>A task that represents the asynchronous operation. The task result contains a list of countries.</returns>
    /// <exception cref="Exception">Thrown when an error occurs while retrieving the countries.</exception>
    [Get("/v2/region/{region}")]
    Task<List<Country>> GetCountriesByRegion(
        string region,
        CancellationToken cancellationToken);

    /// <summary>
    /// Searches for countries by region.
    /// </summary>
    /// <param name="region">The region to search for.</param>
    /// <param name="filters">The filter is semicolon separated values to apply to the query. e.g. filter="name;capital;currency". Only these values will be returned.</param>
    /// <param name="cancellationToken">A cancellation token to cancel the operation.</param>
    /// <returns>A task that represents the asynchronous operation. The task result contains a list of countries.</returns>
    /// <exception cref="Exception">Thrown when an error occurs while retrieving the countries.</exception>
    [Get("/v2/region/{region}")]
    Task<List<Country>> GetCountriesByRegion(
        string region,
        [Query] string filters,
        CancellationToken cancellationToken);

    /// <summary>
    /// Searches for countries by regional block.
    /// </summary>
    /// <param name="regionalBlock">The regional block to search for.</param>
    /// <param name="cancellationToken">A cancellation token to cancel the operation.</param>
    /// <returns>A task that represents the asynchronous operation. The task result contains a list of countries.</returns>
    /// <exception cref="Exception">Thrown when an error occurs while retrieving the countries.</exception>
    [Get("/v2/regionalbloc/{regionalbloc}")]
    Task<List<Country>> GetCountriesByRegionalBlock(
        [AliasAs("regionalbloc")] string regionalBlock,
        CancellationToken cancellationToken);

    /// <summary>
    /// Searches for countries by regional block.
    /// </summary>
    /// <param name="regionalBlock">The regional block to search for.</param>
    /// <param name="filters">The filter is semicolon separated values to apply to the query. e.g. filter="name;capital;currency". Only these values will be returned.</param>
    /// <param name="cancellationToken">A cancellation token to cancel the operation.</param>
    /// <returns>A task that represents the asynchronous operation. The task result contains a list of countries.</returns>
    /// <exception cref="Exception">Thrown when an error occurs while retrieving the countries.</exception>
    [Get("/v2/regionalbloc/{regionalbloc}")]
    Task<List<Country>> GetCountriesByRegionalBlock(
        [AliasAs("regionalbloc")] string regionalBlock,
        [Query] string filters,
        CancellationToken cancellationToken);

    /// <summary>
    /// Searches for countries by calling code.
    /// </summary>
    /// <param name="callingCode">The calling code to search for.</param>
    /// <param name="cancellationToken">A cancellation token to cancel the operation.</param>
    /// <returns>A task that represents the asynchronous operation. The task result contains a list of countries.</returns>
    /// <exception cref="Exception">Thrown when an error occurs while retrieving the countries.</exception>
    [Get("/v2/callingcode/{callingcode}")]
    Task<List<Country>> GetCountriesByCallingCode(
        [AliasAs("callingcode")] string callingCode,
        CancellationToken cancellationToken);

    /// <summary>
    /// Searches for countries by calling code.
    /// </summary>
    /// <param name="callingCode">The calling code to search for.</param>
    /// <param name="filters">The filter is semicolon separated values to apply to the query. e.g. filter="name;capital;currency". Only these values will be returned.</param>
    /// <param name="cancellationToken">A cancellation token to cancel the operation.</param>
    /// <returns>A task that represents the asynchronous operation. The task result contains a list of countries.</returns>
    /// <exception cref="Exception">Thrown when an error occurs while retrieving the countries.</exception>
    [Get("/v2/callingcode/{callingcode}")]
    Task<List<Country>> GetCountriesByCallingCode(
        [AliasAs("callingcode")] string callingCode,
        [Query] string filters,
        CancellationToken cancellationToken);

    /// <summary>
    /// Searches for countries by alpha code.
    /// </summary>
    /// <param name="alphaCode">The alpha code to search for.</param>
    /// <param name="cancellationToken">A cancellation token to cancel the operation.</param>
    /// <returns>A task that represents the asynchronous operation. The task result contains a list of countries.</returns>
    /// <exception cref="Exception">Thrown when an error occurs while retrieving the countries.</exception>
    [Get("/v2/alpha/{code}")]
    Task<List<Country>> GetCountriesByAlphaCode(
        [AliasAs("code")] string alphaCode,
        CancellationToken cancellationToken);

    /// <summary>
    /// Searches for countries by alpha code.
    /// </summary>
    /// <param name="alphaCode">The alpha code to search for.</param>
    /// <param name="filters">The filter is semicolon separated values to apply to the query. e.g. filter="name;capital;currency". Only these values will be returned.</param>
    /// <param name="cancellationToken">A cancellation token to cancel the operation.</param>
    /// <returns>A task that represents the asynchronous operation. The task result contains a list of countries.</returns>
    /// <exception cref="Exception">Thrown when an error occurs while retrieving the countries.</exception>
    [Get("/v2/alpha/{code}")]
    Task<List<Country>> GetCountriesByAlphaCode(
        [AliasAs("code")] string alphaCode,
        [Query] string filters,
        CancellationToken cancellationToken);
}
