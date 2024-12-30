namespace CountryLayerSdk.Handlers;

using System.Net;

/// <summary>
/// A message handler that converts HTTP 404 responses to empty list responses.
/// </summary>
public class Http404ToEmptyListMessageHandler :
    DelegatingHandler
{
    /// <summary>
    /// Initializes a new instance of the <see cref="Http404ToEmptyListMessageHandler"/> class.
    /// </summary>
    public Http404ToEmptyListMessageHandler()
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="Http404ToEmptyListMessageHandler"/> class with a specified inner handler.
    /// </summary>
    /// <param name="innerHandler">The inner handler which is responsible for processing the HTTP response messages.</param>
    public Http404ToEmptyListMessageHandler(HttpMessageHandler innerHandler)
        : base(innerHandler)
    {
    }

    /// <summary>
    /// Sends an HTTP request asynchronously and converts HTTP 404 responses to HTTP 200 with an empty list.
    /// </summary>
    /// <param name="request">The HTTP request message to send.</param>
    /// <param name="cancellationToken">A cancellation token to cancel the operation.</param>
    /// <returns>The HTTP response message.</returns>
    protected override async Task<HttpResponseMessage> SendAsync(
        HttpRequestMessage request,
        CancellationToken cancellationToken)
    {
        var response = await base.SendAsync(request, cancellationToken);
        if (response.StatusCode is HttpStatusCode.NotFound)
        {
            return new HttpResponseMessage(HttpStatusCode.OK)
            {
                Content = new StringContent("[]")
            };
        }
        return response;
    }
}
