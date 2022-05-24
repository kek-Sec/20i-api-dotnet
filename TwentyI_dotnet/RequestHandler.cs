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
    /// GetAsync is a generic method that will perform a GET request to the 20i api.
    /// </summary>
    /// <typeparam name="T">The type of object that will be returned from the request.</typeparam>
    /// <param name="url">The url to perform the request to.</param>
    /// <param name="token">The bearer token to use for the request.</param>
    /// <returns>A Task that will return the object that was returned from the request.</returns>
    public async Task<T?> GetAsync<T>(string url, string token)
    {
        _client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
        var response = await _client.GetAsync(url);
        if (response.IsSuccessStatusCode)
        {
            var responseString = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<T>(responseString);
        }
        else
        {
            throw new Exception(response.ReasonPhrase);
        }
    }
    
    /// <summary>
    /// PostAsync is a generic method that will perform a POST request to the 20i api.
    /// </summary>
    /// <typeparam name="T">The type of object that will be returned from the request.</typeparam>
    /// <param name="url">The url to perform the request to.</param>
    /// <param name="token">The bearer token to use for the request.</param>
    /// <param name="body">The body of the request.</param>
    /// <returns>A Task that will return the object that was returned from the request.</returns>
    public async Task<T?> PostAsync<T>(string url, string token, object body)
    {
        _client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
        var response = await _client.PostAsync(url, new StringContent(JsonConvert.SerializeObject(body), Encoding.UTF8, "application/json"));
        if (response.IsSuccessStatusCode)
        {
            var responseString = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<T>(responseString);
        }
        else
        {
            throw new Exception(response.ReasonPhrase);
        }
    }
    
    /// <summary>
    /// GetSync is a generic method that will perform a GET request to the 20i api.
    /// </summary>
    /// <typeparam name="T">The type of object that will be returned from the request.</typeparam>
    /// <param name="url">The url to perform the request to.</param>
    /// <param name="token">The bearer token to use for the request.</param>
    /// <returns>The object that was returned from the request.</returns>
    public T? GetSync<T>(string url, string token)
    {
        _client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
        var response = _client.GetAsync(url).Result;
        if (response.IsSuccessStatusCode)
        {
            var responseString = response.Content.ReadAsStringAsync().Result;
            return JsonConvert.DeserializeObject<T>(responseString);
        }
        else
        {
            throw new Exception(response.ReasonPhrase);
        }
    }
    
    /// <summary>
    /// PostSync is a generic method that will perform a POST request to the 20i api.
    /// </summary>
    /// <typeparam name="T">The type of object that will be returned from the request.</typeparam>
    /// <param name="url">The url to perform the request to.</param>
    /// <param name="token">The bearer token to use for the request.</param>
    /// <param name="body">The body of the request.</param>
    /// <returns>The object that was returned from the request.</returns>
    public T? PostSync<T>(string url, string token, object body)
    {
        
        _client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
        var response = _client.PostAsync(url, new StringContent(JsonConvert.SerializeObject(body), Encoding.UTF8, "application/json")).Result;
        if (response.IsSuccessStatusCode)
        {
            var responseString = response.Content.ReadAsStringAsync().Result;
            return JsonConvert.DeserializeObject<T>(responseString);
        }
        else
        {
            throw new Exception(response.ReasonPhrase);
        }
    }

}