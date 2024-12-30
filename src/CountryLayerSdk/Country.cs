namespace CountryLayerSdk;

/// <summary>
/// Represents a country with various properties such as name, codes, population, etc.
/// </summary>
public record Country
{
    /// <summary>
    /// Gets the name of the country.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; init; }

    /// <summary>
    /// Gets the top-level domains of the country.
    /// </summary>
    [JsonPropertyName("topLevelDomain")]
    public string[]? TopLevelDomain { get; init; }

    /// <summary>
    /// Gets the alpha-2 code of the country.
    /// </summary>
    [JsonPropertyName("alpha2Code")]
    public string? Alpha2Code { get; init; }

    /// <summary>
    /// Gets the alpha-3 code of the country.
    /// </summary>
    [JsonPropertyName("alpha3Code")]
    public string? Alpha3Code { get; init; }

    /// <summary>
    /// Gets the calling codes of the country.
    /// </summary>
    [JsonPropertyName("callingCodes")]
    public string[]? CallingCodes { get; init; }

    /// <summary>
    /// Gets the capital of the country.
    /// </summary>
    [JsonPropertyName("capital")]
    public string? Capital { get; init; }

    /// <summary>
    /// Gets the alternative spellings of the country's name.
    /// </summary>
    [JsonPropertyName("altSpellings")]
    public string[]? AltSpellings { get; init; }

    /// <summary>
    /// Gets the region of the country.
    /// </summary>
    [JsonPropertyName("region")]
    public string? Region { get; init; }

    /// <summary>
    /// Gets the subregion of the country.
    /// </summary>
    [JsonPropertyName("subregion")]
    public string? Subregion { get; init; }

    /// <summary>
    /// Gets the population of the country.
    /// </summary>
    [JsonPropertyName("population")]
    public int? Population { get; init; }

    /// <summary>
    /// Gets the latitude and longitude coordinates of the country.
    /// </summary>
    [JsonPropertyName("latlng")]
    public double[]? Latlng { get; init; }

    /// <summary>
    /// Gets the demonym of the country.
    /// </summary>
    [JsonPropertyName("demonym")]
    public string? Demonym { get; init; }

    /// <summary>
    /// Gets the area of the country in square kilometers.
    /// </summary>
    [JsonPropertyName("area")]
    public double? Area { get; init; }

    /// <summary>
    /// Gets the Gini coefficient of the country.
    /// </summary>
    [JsonPropertyName("gini")]
    public double? Gini { get; init; }

    /// <summary>
    /// Gets the timezones of the country.
    /// </summary>
    [JsonPropertyName("timezones")]
    public string[]? Timezones { get; init; }

    /// <summary>
    /// Gets the borders of the country.
    /// </summary>
    [JsonPropertyName("borders")]
    public string[]? Borders { get; init; }

    /// <summary>
    /// Gets the native name of the country.
    /// </summary>
    [JsonPropertyName("nativeName")]
    public string? NativeName { get; init; }

    /// <summary>
    /// Gets the numeric code of the country.
    /// </summary>
    [JsonPropertyName("numericCode")]
    public string? NumericCode { get; init; }

    /// <summary>
    /// Gets the currencies used in the country.
    /// </summary>
    [JsonPropertyName("currencies")]
    public Currency[]? Currencies { get; init; }

    /// <summary>
    /// Gets the languages spoken in the country.
    /// </summary>
    [JsonPropertyName("languages")]
    public Language[]? Languages { get; init; }

    /// <summary>
    /// Gets the translations of the country's name.
    /// </summary>
    [JsonPropertyName("translations")]
    public Translations? Translations { get; init; }

    /// <summary>
    /// Gets the flag URL of the country.
    /// </summary>
    [JsonPropertyName("flag")]
    public string? Flag { get; init; }

    /// <summary>
    /// Gets the regional blocks the country belongs to.
    /// </summary>
    [JsonPropertyName("regionalBlocs")]
    public RegionalBlock[]? RegionalBlocks { get; init; }

    /// <summary>
    /// Gets the CIOC code of the country.
    /// </summary>
    [JsonPropertyName("cioc")]
    public string? Cioc { get; init; }
}
