namespace TwentyI_dotnet.Interfaces;
/// <summary>
/// Request handler class is responsible for performing GET and POST requests to the 20i api
/// We want to perform the requests in both a synchronous and asynchronous manner while also
/// handling the exceptions that may be thrown.
/// We will use generic types where possible to make the code more readable.
/// Keep in mind that all requests must have an Authorization header with the bearer token.
/// </summary>
public interface IRequestHandler
{
    /// <summary>
    /// GetAsync is a generic method that will perform a GET request to the 20i api.
    /// </summary>
    /// <typeparam name="T">The type of object that will be returned from the request.</typeparam>
    /// <param name="url">The url to perform the request to.</param>
    /// <param name="token">The bearer token to use for the request.</param>
    /// <returns>A Task that will return the object that was returned from the request.</returns>
    Task<T?> GetAsync<T>(string url, string token);

    /// <summary>
    /// PostAsync is a generic method that will perform a POST request to the 20i api.
    /// </summary>
    /// <typeparam name="T">The type of object that will be returned from the request.</typeparam>
    /// <param name="url">The url to perform the request to.</param>
    /// <param name="token">The bearer token to use for the request.</param>
    /// <param name="body">The body of the request.</param>
    /// <returns>A Task that will return the object that was returned from the request.</returns>
    Task<T?> PostAsync<T>(string url, string token, object body);

    /// <summary>
    /// GetSync is a generic method that will perform a GET request to the 20i api.
    /// </summary>
    /// <typeparam name="T">The type of object that will be returned from the request.</typeparam>
    /// <param name="url">The url to perform the request to.</param>
    /// <param name="token">The bearer token to use for the request.</param>
    /// <returns>The object that was returned from the request.</returns>
    T? GetSync<T>(string url, string token);

    /// <summary>
    /// PostSync is a generic method that will perform a POST request to the 20i api.
    /// </summary>
    /// <typeparam name="T">The type of object that will be returned from the request.</typeparam>
    /// <param name="url">The url to perform the request to.</param>
    /// <param name="token">The bearer token to use for the request.</param>
    /// <param name="body">The body of the request.</param>
    /// <returns>The object that was returned from the request.</returns>
    T? PostSync<T>(string url, string token, object body);
}