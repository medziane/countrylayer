namespace CountryLayerSdk;

public record Country
{
    public string Name { get; init; }
    public string[]? TopLevelDomain { get; init; }
    public string Alpha2Code { get; init; }
    public string Alpha3Code { get; init; }
    public string[] CallingCodes { get; init; }
    public string Capital { get; init; }
    public string[] AltSpellings { get; init; }
    public string Region { get; init; }
    public string Subregion { get; init; }
    public int Population { get; init; }
    public double[] Latlng { get; init; }
    public string Demonym { get; init; }
    public double Area { get; init; }
    public double? Gini { get; init; }
    public string[] Timezones { get; init; }
    public string[] Borders { get; init; }
    public string NativeName { get; init; }
    public string NumericCode { get; init; }
    public Currency[]? Currencies { get; init; }
    public Language[] Languages { get; init; }
    public Translations Translations { get; init; }
    public string Flag { get; init; }
    public RegionalBloc[] RegionalBlocs { get; init; }
    public string Cioc { get; init; }
}

public record Currency
{
    public string? Code { get; init; }
    public string? Name { get; init; }
    public string? Symbol { get; init; }
}

public record Language
{
    [JsonPropertyName("iso639_1")]
    public string Iso6391 { get; init; }

    [JsonPropertyName("iso639_2")]
    public string Iso6392 { get; init; }

    public string Name { get; init; }
    public string NativeName { get; init; }
}

public record Translations
{
    [JsonPropertyName("br")]
    public string Brazilian { get; init; }

    [JsonPropertyName("de")]
    public string German { get; init; }

    [JsonPropertyName("es")]
    public string Spanish { get; init; }

    [JsonPropertyName("fa")]
    public string Persian { get; init; }

    [JsonPropertyName("fr")]
    public string French { get; init; }

    [JsonPropertyName("hr")]
    public string Croatian { get; init; }

    [JsonPropertyName("it")]
    public string Italian { get; init; }

    [JsonPropertyName("ja")]
    public string Japanese { get; init; }

    [JsonPropertyName("nl")]
    public string Dutch { get; init; }

    [JsonPropertyName("pt")]
    public string Portuguese { get; init; }
}

public record RegionalBloc
{
    public string Acronym { get; init; }
    public string Name { get; init; }
}
