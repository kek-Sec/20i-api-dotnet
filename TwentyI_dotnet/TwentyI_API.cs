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
    /// <returns>The raw json response as a string</returns>
    public async Task<string> GetDomainPeriods()
    {
        var url = _baseUrl + "domain-period";
        var response = await _requestHandler.GetAsync(url, _bearer);
        return response;
    }
    
    /// <summary>
    /// List all domain extentions with their associated premium group.
    /// </summary>
    /// <see cref="https://api.20i.com/domainPremiumType"/>
    /// <returns>The raw json response as a string</returns>
    public async Task<string> GetDomainPremiumTypes()
    {
        var url = _baseUrl + "domainPremiumType";
        var response = await _requestHandler.GetAsync(url, _bearer);
        return response;
    }
    
    /// <summary>
    /// Searches for one or more domain names.
    /// If you provide a domain name, this will search for that name only, otherwise it will search for that prefix on all supported TLDs.
    /// You may supply multiple literal domain names if you separate them with commas.
    /// You may supply arbitrary text, which will be stripped down to something suitable for domain search. This is typically useful with suggestions on.
    /// Under some circumstances this will attempt a detailed search, which will fetch more specific information about transferrable domains.
    /// This will happen if you search for one domain name. Domain Suggestions Our primary domain availability provider supports suggesting names based on the search, using simple semantic permutations of the supplied name(s).
    /// For example if you're searching for mailboxdelivery.com it might suggest post-delivery.com, mailboxsend.net and my-mailbox-delivery.com.
    /// These are supported only in a small set of TLDs (including .com, .net, .org, .info).
    /// These names are probably available, and will get properly checked at the end of the results, meaning that you will get two results: one marked "suggestion" and a later one which looks like a direct domain search result.
    /// At the current time, setting the TLDs to search is not supported. If a domain is returned which you aren't set up to sell, you should exclude it from your view.
    /// Note on responsiveness and order All results will be output at the earliest possible opportunity, and will be delivered in separate packets with each result hash on a line on its own.
    /// This means that the order will usually be different to the header order, and the output will look a little different to typical JSON responses.
    /// Usage limits Access to this service is subject to reasonable usage limits. If you go over the limit, further access will be blocked for up to 24 hours.
    /// </summary>
    /// <see cref="https://api.20i.com/domain-search/{query}"/>
    /// <param name="query">The query to search for</param>
    /// <returns>The raw json response as a string</returns>
    public async Task<string> GetDomainSearch(string query)
    {
        var url = _baseUrl + "domain-search/" + query;
        var response = await _requestHandler.GetAsync(url, _bearer);
        return response;
    }
    
    /// <summary>
    /// RetrieveDomains Returns basic information about the domains in the account.
    /// </summary>
    /// <see cref="https://api.20i.com/domain"/>
    /// <returns>The raw json response as a string</returns>
    public async Task<string> GetDomains()
    {
        var url = _baseUrl + "domain";
        var response = await _requestHandler.GetAsync(url, _bearer);
        return response;
    }

    #endregion
    
    #region Managed Vps Requests
    
    /// <summary>
    /// Activates or deactivates the service. Possible subservice_name are 'default' for a typical set of services and 'main' for the core service only.
    /// </summary>
    /// <see cref="https://api.20i.com/managed_vps/{id}/userStatus"/>
    /// <remarks> Json sample body: { includeRepeated: true, subservices:{ (subservice_name): true } } </remarks>
    /// <param name="id">The id of the managed vps</param>
    /// <param name="body">The json body to send</param>
    /// <returns>The raw json response as a string</returns>
    public async Task<string> SetManagedVpsUserStatus(string id, string body)
    {
        var url = _baseUrl + "managed_vps/" + id + "/userStatus";
        var response = await _requestHandler.PostAsync(url, body, _bearer);
        return response;
    } 
    
    /// <summary>
    /// Add a web site.
    /// </summary>
    /// <see cref="https://api.20i.com/managed_vps/{id}/addWeb"/>
    /// <remarks> Json sample body: { domain_name: "string", extra_domain_names: "string" } </remarks>
    /// <param name="id">The id of the managed vps</param>
    /// <param name="body">The json body to send</param>
    /// <returns>The raw json response as a string</returns>
    public async Task<string> ManagedVpsAddWeb(string id, string body)
    {
        var url = _baseUrl + "managed_vps/" + id + "/addWeb";
        var response = await _requestHandler.PostAsync(url, body, _bearer);
        return response;
    }
    
    /// <summary>
    /// Delete web sites.
    /// </summary>
    /// <see cref="https://api.20i.com/managed_vps/{id}/deleteWeb"/>
    /// <remarks> Json sample body: { delete-id: ["string"] } </remarks>
    /// <param name="id">The id of the managed vps</param>
    /// <param name="body">The json body to send</param>
    /// <returns>The raw json response as a string</returns>
    public async Task<string> ManagedVpsDeleteWeb(string id, string body)
    {
        var url = _baseUrl + "managed_vps/" + id + "/deleteWeb";
        var response = await _requestHandler.PostAsync(url, body, _bearer);
        return response;
    }
    
    /// <summary>
    /// Returns an object representation of your managed VPS.
    /// </summary>
    /// <see cref="https://api.20i.com/managed_vps/{id}"/>
    /// <param name="id">The id of the managed vps</param>
    /// <returns>The raw json response as a string</returns>
    public async Task<string> GetManagedVps(string id)
    {
        var url = _baseUrl + "managed_vps/" + id;
        var response = await _requestHandler.GetAsync(url, _bearer);
        return response;
    }
    
    /// <summary>
    /// Returns the count of how many packages can be created on this managed VPS.
    /// </summary>
    /// <see cref="https://api.20i.com/managed_vps/{id}/packageCount"/>
    /// <param name="id">The id of the managed vps</param>
    /// <returns>The raw json response as a string</returns>
    public async Task<string> GetManagedVpsPackageCount(string id)
    {
        var url = _baseUrl + "managed_vps/" + id + "/packageCount";
        var response = await _requestHandler.GetAsync(url, _bearer);
        return response;
    }
    
    /// <summary>
    /// Returns a short, cheap set of info for all managed VPSs.
    /// </summary>
    /// <see cref="https://api.20i.com/managed_vps"/>
    /// <returns>The raw json response as a string</returns>
    public async Task<string> GetManagedVpsList()
    {
        var url = _baseUrl + "managed_vps";
        var response = await _requestHandler.GetAsync(url, _bearer);
        return response;
    }
    
    /// <summary>
    /// Returns the name of one Managed VPS.
    /// </summary>
    /// <see cref="https://api.20i.com/managed_vps/{id}/name"/>
    /// <param name="id">The id of the managed vps</param>
    /// <returns>The raw json response as a string</returns>
    public async Task<string> GetManagedVpsName(string id)
    {
        var url = _baseUrl + "managed_vps/" + id + "/name";
        var response = await _requestHandler.GetAsync(url, _bearer);
        return response;
    }
    
    /// <summary>
    /// Set the VPS Name
    /// </summary>
    /// <see cref="https://api.20i.com/managed_vps/{id}/name"/>
    ///<remarks> Json sample body: { name: "string" } </remarks>
    /// <param name="id">The id of the managed vps</param>
    /// <param name="body">The json body to send</param>
    /// <returns>The raw json response as a string</returns>
    public async Task<string> ManagedVpsSetName(string id, string body)
    {
        var url = _baseUrl + "managed_vps/" + id + "/name";
        var response = await _requestHandler.PostAsync(url, body, _bearer);
        return response;
    }
    
    #endregion
    
    #region MSSQL Endpoints
    /// <summary>
    /// Retrieve MSSQL Databases
    /// </summary>
    /// <see cref="https://api.20i.com/mssql"/>
    /// <returns>The raw json response as a string</returns>
    public async Task<string> GetMssql()
    {
        var url = _baseUrl + "mssql";
        var response = await _requestHandler.GetAsync(url, _bearer);
        return response;
    }
    
    /// <summary>
    /// Retrieve MSSQL Database by ID
    /// </summary>
    /// <see cref="https://api.20i.com/mssql/{id}"/>
    /// <param name="id">The id of the mssql database</param>
    /// <returns>The raw json response as a string</returns>
    public async Task<string> GetMssqlById(string id)
    {
        var url = _baseUrl + "mssql/" + id;
        var response = await _requestHandler.GetAsync(url, _bearer);
        return response;
    }
    
    /// <summary>
    /// Update the config to link the MS SQL product to a package.
    /// </summary>
    /// <see cref="https://api.20i.com/mssql/{id}"/>
    /// <remarks> Json sample body: { id:1 } </remarks>
    /// <param name="id">The id of the mssql database</param>
    /// <param name="body">The json body to send</param>
    /// <returns>The raw json response as a string</returns>
    public async Task<string> MssqlLinkPackage(string id, string body)
    {
        var url = _baseUrl + "mssql/" + id;
        var response = await _requestHandler.PostAsync(url, body, _bearer);
        return response;
    }
    
    #endregion
    
    #region Packages Endpoints
    
    /// <summary>
    /// Activates or deactivates the service. Possible subservice_name are 'default' for a typical set of services and 'main' for the core service only.
    /// </summary>
    /// <see cref="https://api.20i.com/package/{package_id}/domain/{domain_id}/userStatus"/>
    /// <remarks> Json sample body: { includeRepeated: true, subservices:{ (subservice_name): true } } </remarks>
    /// <param name="packageId">The id of the package</param>
    /// <param name="domainId">The id of the domain</param>
    /// <param name="body">The json body to send</param>
    /// <returns>The raw json response as a string</returns>
    public async Task<string> PackageDomainUserStatus(string packageId, string domainId, string body)
    {
        var url = _baseUrl + "package/" + packageId + "/domain/" + domainId + "/userStatus";
        var response = await _requestHandler.PostAsync(url, body, _bearer);
        return response;
    }
    
    /// <summary>
    /// Activates or deactivates the service. Possible subservice_name are 'default' for a typical set of services and 'main' for the core service only.
    /// </summary>
    /// <see cref="https://api.20i.com/package/{package_id}/userStatus"/>
    /// <remarks> Json sample body: { includeRepeated: true, subservices:{ (subservice_name): true } } </remarks>
    /// <param name="packageId">The id of the package</param>
    /// <param name="body">The json body to send</param>
    /// <returns>The raw json response as a string</returns>
    public async Task<string> PackageUserStatus(string packageId, string body)
    {
        var url = _baseUrl + "package/" + packageId + "/userStatus";
        var response = await _requestHandler.PostAsync(url, body, _bearer);
        return response;
    }
    
    /// <summary>
    /// Return a list of installed applications
    /// </summary>
    /// <see cref="https://api.20i.com/package/{package_id}/web/installedApplications"/>
    /// <param name="packageId">The id of the package</param>
    /// <returns>The raw json response as a string</returns>
    public async Task<string> PackageWebInstalledApplications(string packageId)
    {
        var url = _baseUrl + "package/" + packageId + "/web/installedApplications";
        var response = await _requestHandler.GetAsync(url, _bearer);
        return response;
    }
    
    /// <summary>
    /// Add, remove and update applications and set their environment Currently only one type (add,update,delete,setEnv) is supported per request.
    /// </summary>
    /// <see cref="https://api.20i.com/package/{package_id}/web/installedApplications"/>
    /// <param name="packageId">The id of the package</param>
    /// <remarks>json sample { add:{ domain: "string", environment: "string", name: "string", path: "string", script: "string", typeCode: "string" }, update:{ domain: "string", environment: "string", name: "string", path: "string", script: "string", typeCode: "string" }, delete:{ id: "string" }, setEnv:{ id: "string", environment: "string" } }</remarks>
    /// <param name="body">The json body to send</param>
    /// <returns>The raw json response as a string</returns>
    public async Task<string> PackageWebInstalledApplications(string packageId, string body)
    {
        var url = _baseUrl + "package/" + packageId + "/web/installedApplications";
        var response = await _requestHandler.PostAsync(url, body, _bearer);
        return response;
    }
    
    /// <summary>
    /// Returns a list of installed software by type code on managed server.
    /// </summary>
    /// <see cref="https://api.20i.com/package/{package_id}/web/installedSoftware"/>
    /// <param name="packageId">The id of the package</param>
    /// <returns>The raw json response as a string</returns>
    public async Task<string> PackageWebInstalledSoftware(string packageId)
    {
        var url = _baseUrl + "package/" + packageId + "/web/installedSoftware";
        var response = await _requestHandler.GetAsync(url, _bearer);
        return response;
    }
    
    #endregion
}