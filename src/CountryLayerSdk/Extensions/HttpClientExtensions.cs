namespace CountryLayerSdk.Extensions;

/// <summary>
/// Provides extension methods for the <see cref="HttpClient"/> class.
/// </summary>
internal static class HttpClientExtensions
{
    /// <summary>
    /// Retrieves the internal <see cref="HttpMessageHandler"/> used by the specified <see cref="HttpClient"/>.
    /// </summary>
    /// <param name="client">The <see cref="HttpClient"/> instance.</param>
    /// <returns>The <see cref="HttpMessageHandler"/> used by the <see cref="HttpClient"/>, or <c>null</c> if it cannot be retrieved.</returns>
    public static HttpMessageHandler GetHandler(this HttpClient client)
    {
        var fieldInfo = typeof(HttpClient).GetField("_handler", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
        var handler = fieldInfo?.GetValue(client) as HttpMessageHandler;
        return handler ?? new HttpClientHandler();
    }
}
