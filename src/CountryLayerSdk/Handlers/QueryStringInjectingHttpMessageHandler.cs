namespace CountryLayerSdk.Handlers;

/// <summary>
/// A message handler that injects query string parameters into HTTP requests.
/// </summary>
public class QueryStringInjectingHttpMessageHandler :
    DelegatingHandler
{
    private readonly IReadOnlyDictionary<string, string> _injectedParameters;

    /// <summary>
    /// Initializes a new instance of the <see cref="QueryStringInjectingHttpMessageHandler"/> class with the specified parameters.
    /// </summary>
    /// <param name="injectedParameters">The parameters to inject into the query string.</param>
    public QueryStringInjectingHttpMessageHandler(
        params (string key, string value)[] injectedParameters)
        : this(new Http404ToEmptyListMessageHandler(), injectedParameters)
    {
    }

    private QueryStringInjectingHttpMessageHandler(
        Http404ToEmptyListMessageHandler innerHandler,
        params (string key, string value)[] injectedParameters)
        : this((HttpMessageHandler) innerHandler, injectedParameters)
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="QueryStringInjectingHttpMessageHandler"/> class with the specified inner handler and parameters.
    /// </summary>
    /// <param name="innerHandler">The inner handler to delegate to.</param>
    /// <param name="injectedParameters">The parameters to inject into the query string.</param>
    public QueryStringInjectingHttpMessageHandler(
        HttpMessageHandler innerHandler,
        params (string key, string value)[] injectedParameters)
        : base(new Http404ToEmptyListMessageHandler(innerHandler))
    {
        _injectedParameters = injectedParameters.ToDictionary(x => x.key, x => x.value);
    }

    /// <inheritdoc />
    protected override Task<HttpResponseMessage> SendAsync(
        HttpRequestMessage request,
        CancellationToken cancellationToken)
    {
        if (request.RequestUri is not null)
        {
            request.RequestUri = InjectIntoQueryString(request.RequestUri, _injectedParameters);
        }

        return base.SendAsync(request, cancellationToken);
    }

    private static Uri InjectIntoQueryString(
        Uri uri,
        IReadOnlyDictionary<string, string> parametersToInject)
    {
        var uriBuilder = new UriBuilder(uri);
        var query = HttpUtility.ParseQueryString(uriBuilder.Query);

        foreach (var (key, value) in parametersToInject)
        {
            query[key] = value;
        }

        uriBuilder.Query = query.ToString();
        return uriBuilder.Uri;
    }
}
