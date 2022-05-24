using TwentyI_dotnet.Interfaces;

namespace TwentyI_dotnet;
/// <summary>
/// Library entry class 
/// </summary>
public class TwentyI_API
{
    private readonly HttpClient _client;
    private readonly string _baseUrl = "https://api.20i.com/";
    private readonly string _bearer;
    private readonly IRequestHandler _requestHandler;
    
    /// <summary>
    /// Constructor, will be used to set the bearer token and the http client
    /// </summary>
    /// <param name="bearer">Bearer token</param>
    /// <param name="client">Http client</param>
    public TwentyI_API(string bearer, HttpClient client)
    {
        _bearer = bearer;
        _client = client;
        _requestHandler = new RequestHandler(_client);
    }
    
    #region Domain Related Requests
    
    /// <summary>
    /// List all possible domains that are supported with the periods that are supported for registration
    /// </summary>
    /// <see cref="https://api.20i.com/domain-period"/>
    /// <returns>List of generic object</returns>
    public async Task<List<object>?> GetDomainPeriods()
    {
        var url = _baseUrl + "domain-period";
        var response = await _requestHandler.GetAsync<List<object>>(url, _bearer);
        return response;
    }
    
    #endregion
    
}