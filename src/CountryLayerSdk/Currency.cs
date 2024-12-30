namespace CountryLayerSdk;

/// <summary>
/// Represents a currency with code, name, and symbol.
/// </summary>
public record Currency
{
    /// <summary>
    /// Gets the code of the currency.
    /// </summary>
    [JsonPropertyName("code")]
    public string? Code { get; init; }

    /// <summary>
    /// Gets the name of the currency.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; init; }

    /// <summary>
    /// Gets the symbol of the currency.
    /// </summary>
    [JsonPropertyName("symbol")]
    public string? Symbol { get; init; }
}
