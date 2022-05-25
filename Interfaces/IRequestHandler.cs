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
    /// GetSync is a method that will perform a GET request to the 20i api.
    /// </summary>
    /// <param name="url">The url to perform the request to.</param>
    /// <param name="token">The bearer token to use for the request.</param>
    /// <returns>The json string returned from the 20i API</returns>
    string GetSync(string url, string token);

    /// <summary>
    /// PostSync is a method that will perform a POST request to the 20i api.
    /// </summary>
    /// <param name="url">The url to perform the request to.</param>
    /// <param name="token">The bearer token to use for the request.</param>
    /// <param name="body">The body of the request.</param>
    /// <returns>The json string returned from the 20i api</returns>
     string PostSync(string url, string token, object body);

    /// <summary>
    /// GetAsync is a method that will perform a GET request to the 20i api.
    /// </summary>
    /// <param name="url">The url to perform the request to.</param>
    /// <param name="token">The bearer token to use for the request.</param>
    /// <returns>The json response string.</returns>
    Task<string> GetAsync(string url, string token);

    /// <summary>
    /// PostAsync is a method that will perform a POST request to the 20i api.
    /// </summary>
    /// <param name="url">The url to perform the request to.</param>
    /// <param name="token">The bearer token to use for the request.</param>
    /// <param name="body">The body of the request.</param>
    /// <returns>The json string returned from the 20i api.</returns>
    Task<string> PostAsync(string url, string token, object body);
}