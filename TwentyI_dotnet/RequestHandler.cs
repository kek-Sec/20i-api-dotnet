using System.Net.Http.Headers;
using System.Text;
using Newtonsoft.Json;
using TwentyI_dotnet.Interfaces;

namespace TwentyI_dotnet;
/// <summary>
/// Request handler class is responsible for performing GET and POST requests to the 20i api
/// We want to perform the requests in both a synchronous and asynchronous manner while also
/// handling the exceptions that may be thrown.
/// We will use generic types where possible to make the code more readable.
/// Keep in mind that all requests must have an Authorization header with the bearer token.
/// </summary>
public class RequestHandler : IRequestHandler
{

    private readonly HttpClient _client;
    
    /// <summary>
    /// Constructor for injecting the HttpClient
    /// </summary>
    /// <param name="client"></param>
    public RequestHandler(HttpClient client)
    {
        _client = client;
    }
    
    /// <summary>
    /// GetSync is a method that will perform a GET request to the 20i api.
    /// </summary>
    /// <param name="url">The url to perform the request to.</param>
    /// <param name="token">The bearer token to use for the request.</param>
    /// <returns>The json string returned from the 20i API</returns>
    public string GetSync(string url, string token)
    {
        _client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
        var response = _client.GetAsync(url).Result;
        if (response.IsSuccessStatusCode)
        {
            return response.Content.ReadAsStringAsync().Result;
        }
        else
        {
            throw new Exception(response.ReasonPhrase);
        }
    }

    /// <summary>
    /// PostSync is a method that will perform a POST request to the 20i api.
    /// </summary>
    /// <param name="url">The url to perform the request to.</param>
    /// <param name="token">The bearer token to use for the request.</param>
    /// <param name="body">The body of the request.</param>
    /// <returns>The json string returned from the 20i api</returns>
    public string PostSync(string url, string token, object body)
    {
        _client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
        var response = _client.PostAsync(url, new StringContent(JsonConvert.SerializeObject(body), Encoding.UTF8, "application/json")).Result;
        if (response.IsSuccessStatusCode)
        {
            return response.Content.ReadAsStringAsync().Result;
        }
        else
        {
            throw new Exception(response.ReasonPhrase);
        }
    }
    
    /// <summary>
    /// GetAsync is a method that will perform a GET request to the 20i api.
    /// </summary>
    /// <param name="url">The url to perform the request to.</param>
    /// <param name="token">The bearer token to use for the request.</param>
    /// <returns>The json response string.</returns>
    public async Task<string> GetAsync(string url, string token)
    {
        _client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
        var response = await _client.GetAsync(url);
        if (response.IsSuccessStatusCode)
        {
            return await response.Content.ReadAsStringAsync();
        }
        else
        {
            throw new Exception(response.ReasonPhrase);
        }
    }

    
    /// <summary>
    /// PostAsync is a method that will perform a POST request to the 20i api.
    /// </summary>
    /// <param name="url">The url to perform the request to.</param>
    /// <param name="token">The bearer token to use for the request.</param>
    /// <param name="body">The body of the request.</param>
    /// <returns>The json string returned from the 20i api.</returns>
    public async Task<string> PostAsync(string url, string token, object body)
    {
        _client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
        var response = await _client.PostAsync(url, new StringContent(JsonConvert.SerializeObject(body), Encoding.UTF8, "application/json"));
        if (response.IsSuccessStatusCode)
        {
            return await response.Content.ReadAsStringAsync();
        }
        else
        {
            throw new Exception(response.ReasonPhrase);
        }
    }
    
    

    

}