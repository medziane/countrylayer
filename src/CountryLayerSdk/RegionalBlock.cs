namespace CountryLayerSdk;

/// <summary>
/// Represents a regional block with acronym and name.
/// </summary>
public record RegionalBlock
{
    /// <summary>
    /// Gets the acronym of the regional block.
    /// </summary>
    [JsonPropertyName("acronym")]
    public string? Acronym { get; init; }

    /// <summary>
    /// Gets the name of the regional block.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; init; }
}
