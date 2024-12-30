namespace CountryLayerSdk;

/// <summary>
/// Represents a language with ISO codes, name, and native name.
/// </summary>
public record Language
{
    /// <summary>
    /// Gets the ISO 639-1 code of the language.
    /// </summary>
    [JsonPropertyName("iso639_1")]
    public string? Iso6391 { get; init; }

    /// <summary>
    /// Gets the ISO 639-2 code of the language.
    /// </summary>
    [JsonPropertyName("iso639_2")]
    public string? Iso6392 { get; init; }

    /// <summary>
    /// Gets the name of the language.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; init; }

    /// <summary>
    /// Gets the native name of the language.
    /// </summary>
    [JsonPropertyName("nativeName")]
    public string? NativeName { get; init; }
}
