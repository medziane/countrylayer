namespace CountryLayerSdk;

/// <summary>
/// Represents translations of a country's name in various languages.
/// </summary>
public record Translations
{
    /// <summary>
    /// Gets the Brazilian Portuguese translation.
    /// </summary>
    [JsonPropertyName("br")]
    public string? Brazilian { get; init; }

    /// <summary>
    /// Gets the German translation.
    /// </summary>
    [JsonPropertyName("de")]
    public string? German { get; init; }

    /// <summary>
    /// Gets the Spanish translation.
    /// </summary>
    [JsonPropertyName("es")]
    public string? Spanish { get; init; }

    /// <summary>
    /// Gets the Persian translation.
    /// </summary>
    [JsonPropertyName("fa")]
    public string? Persian { get; init; }

    /// <summary>
    /// Gets the French translation.
    /// </summary>
    [JsonPropertyName("fr")]
    public string? French { get; init; }

    /// <summary>
    /// Gets the Croatian translation.
    /// </summary>
    [JsonPropertyName("hr")]
    public string? Croatian { get; init; }

    /// <summary>
    /// Gets the Italian translation.
    /// </summary>
    [JsonPropertyName("it")]
    public string? Italian { get; init; }

    /// <summary>
    /// Gets the Japanese translation.
    /// </summary>
    [JsonPropertyName("ja")]
    public string? Japanese { get; init; }

    /// <summary>
    /// Gets the Dutch translation.
    /// </summary>
    [JsonPropertyName("nl")]
    public string? Dutch { get; init; }

    /// <summary>
    /// Gets the Portuguese translation.
    /// </summary>
    [JsonPropertyName("pt")]
    public string? Portuguese { get; init; }
}
