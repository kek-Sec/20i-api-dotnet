using System.Text;
using TwentyI_dotnet.Interfaces;

namespace TwentyI_dotnet;

/// <summary>
///     Library entry class
/// </summary>
public class TwentyIApi
{
    private readonly string _baseUrl = "https://api.20i.com/";
    private readonly string _bearer;
    private readonly HttpClient _client;
    private readonly IRequestHandler _requestHandler;

    /// <summary>
    ///     Constructor, will be used to set the bearer token and the http client
    /// </summary>
    /// <param name="bearer">Bearer token, the General API key provided by 20i</param>
    /// <param name="client">Http client</param>
    public TwentyIApi(string bearer, HttpClient client)
    {
        //base64 encode the bearer token
        _bearer = Convert.ToBase64String(Encoding.UTF8.GetBytes(bearer));
        _client = client;
        _requestHandler = new RequestHandler(_client);
    }

    #region Domain Related Requests

    /// <summary>
    ///     List all possible domains that are supported with the periods that are supported for registration
    /// </summary>
    /// <see href="https://api.20i.com/domain-period" />
    /// <returns>The raw json response as a string</returns>
    public async Task<string> GetDomainPeriods()
    {
        var url = _baseUrl + "domain-period";
        var response = await _requestHandler.GetAsync(url, _bearer);
        return response;
    }

    /// <summary>
    ///     List all domain extentions with their associated premium group.
    /// </summary>
    /// <see href="https://api.20i.com/domainPremiumType" />
    /// <returns>The raw json response as a string</returns>
    public async Task<string> GetDomainPremiumTypes()
    {
        var url = _baseUrl + "domainPremiumType";
        var response = await _requestHandler.GetAsync(url, _bearer);
        return response;
    }

    /// <summary>
    ///     Searches for one or more domain names.
    ///     If you provide a domain name, this will search for that name only, otherwise it will search for that prefix on all
    ///     supported TLDs.
    ///     You may supply multiple literal domain names if you separate them with commas.
    ///     You may supply arbitrary text, which will be stripped down to something suitable for domain search. This is
    ///     typically useful with suggestions on.
    ///     Under some circumstances this will attempt a detailed search, which will fetch more specific information about
    ///     transferrable domains.
    ///     This will happen if you search for one domain name. Domain Suggestions Our primary domain availability provider
    ///     supports suggesting names based on the search, using simple semantic permutations of the supplied name(s).
    ///     For example if you're searching for mailboxdelivery.com it might suggest post-delivery.com, mailboxsend.net and
    ///     my-mailbox-delivery.com.
    ///     These are supported only in a small set of TLDs (including .com, .net, .org, .info).
    ///     These names are probably available, and will get properly checked at the end of the results, meaning that you will
    ///     get two results: one marked "suggestion" and a later one which looks like a direct domain search result.
    ///     At the current time, setting the TLDs to search is not supported. If a domain is returned which you aren't set up
    ///     to sell, you should exclude it from your view.
    ///     Note on responsiveness and order All results will be output at the earliest possible opportunity, and will be
    ///     delivered in separate packets with each result hash on a line on its own.
    ///     This means that the order will usually be different to the header order, and the output will look a little
    ///     different to typical JSON responses.
    ///     Usage limits Access to this service is subject to reasonable usage limits. If you go over the limit, further access
    ///     will be blocked for up to 24 hours.
    /// </summary>
    /// <see href="https://api.20i.com/domain-search/{query}" />
    /// <param name="query">The query to search for</param>
    /// <returns>The raw json response as a string</returns>
    public async Task<string> GetDomainSearch(string query)
    {
        var url = _baseUrl + "domain-search/" + query;
        var response = await _requestHandler.GetAsync(url, _bearer);
        return response;
    }

    /// <summary>
    ///     RetrieveDomains Returns basic information about the domains in the account.
    /// </summary>
    /// <see href="https://api.20i.com/domain" />
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
    ///     Activates or deactivates the service. Possible subservice_name are 'default' for a typical set of services and
    ///     'main' for the core service only.
    /// </summary>
    /// <see href="https://api.20i.com/managed_vps/{id}/userStatus" />
    /// <remarks> Json sample body: { includeRepeated: true, subservices:{ (subservice_name): true } } </remarks>
    /// <param name="id">The id of the managed vps</param>
    /// <param name="body">The json body to send</param>
    /// <returns>The raw json response as a string</returns>
    public async Task<string> SetManagedVpsUserStatus(string id, string body)
    {
        var url = _baseUrl + "managed_vps/" + id + "/userStatus";
        var response = await _requestHandler.PostAsync(url,_bearer,body);
        return response;
    }

    /// <summary>
    ///     Add a web site.
    /// </summary>
    /// <see href="https://api.20i.com/managed_vps/{id}/addWeb" />
    /// <remarks> Json sample body: { domain_name: "string", extra_domain_names: "string" } </remarks>
    /// <param name="id">The id of the managed vps</param>
    /// <param name="body">The json body to send</param>
    /// <returns>The raw json response as a string</returns>
    public async Task<string> ManagedVpsAddWeb(string id, string body)
    {
        var url = _baseUrl + "managed_vps/" + id + "/addWeb";
        var response = await _requestHandler.PostAsync(url,_bearer,body);
        return response;
    }

    /// <summary>
    ///     Delete web sites.
    /// </summary>
    /// <see href="https://api.20i.com/managed_vps/{id}/deleteWeb" />
    /// <remarks> Json sample body: { delete-id: ["string"] } </remarks>
    /// <param name="id">The id of the managed vps</param>
    /// <param name="body">The json body to send</param>
    /// <returns>The raw json response as a string</returns>
    public async Task<string> ManagedVpsDeleteWeb(string id, string body)
    {
        var url = _baseUrl + "managed_vps/" + id + "/deleteWeb";
        var response = await _requestHandler.PostAsync(url,_bearer,body);
        return response;
    }

    /// <summary>
    ///     Returns an object representation of your managed VPS.
    /// </summary>
    /// <see href="https://api.20i.com/managed_vps/{id}" />
    /// <param name="id">The id of the managed vps</param>
    /// <returns>The raw json response as a string</returns>
    public async Task<string> GetManagedVps(string id)
    {
        var url = _baseUrl + "managed_vps/" + id;
        var response = await _requestHandler.GetAsync(url, _bearer);
        return response;
    }

    /// <summary>
    ///     Returns the count of how many packages can be created on this managed VPS.
    /// </summary>
    /// <see href="https://api.20i.com/managed_vps/{id}/packageCount" />
    /// <param name="id">The id of the managed vps</param>
    /// <returns>The raw json response as a string</returns>
    public async Task<string> GetManagedVpsPackageCount(string id)
    {
        var url = _baseUrl + "managed_vps/" + id + "/packageCount";
        var response = await _requestHandler.GetAsync(url, _bearer);
        return response;
    }

    /// <summary>
    ///     Returns a short, cheap set of info for all managed VPSs.
    /// </summary>
    /// <see href="https://api.20i.com/managed_vps" />
    /// <returns>The raw json response as a string</returns>
    public async Task<string> GetManagedVpsList()
    {
        var url = _baseUrl + "managed_vps";
        var response = await _requestHandler.GetAsync(url, _bearer);
        return response;
    }

    /// <summary>
    ///     Returns the name of one Managed VPS.
    /// </summary>
    /// <see href="https://api.20i.com/managed_vps/{id}/name" />
    /// <param name="id">The id of the managed vps</param>
    /// <returns>The raw json response as a string</returns>
    public async Task<string> GetManagedVpsName(string id)
    {
        var url = _baseUrl + "managed_vps/" + id + "/name";
        var response = await _requestHandler.GetAsync(url, _bearer);
        return response;
    }

    /// <summary>
    ///     Set the VPS Name
    /// </summary>
    /// <see href="https://api.20i.com/managed_vps/{id}/name" />
    /// <remarks> Json sample body: { name: "string" } </remarks>
    /// <param name="id">The id of the managed vps</param>
    /// <param name="body">The json body to send</param>
    /// <returns>The raw json response as a string</returns>
    public async Task<string> ManagedVpsSetName(string id, string body)
    {
        var url = _baseUrl + "managed_vps/" + id + "/name";
        var response = await _requestHandler.PostAsync(url,_bearer,body);
        return response;
    }

    #endregion

    #region MSSQL Endpoints

    /// <summary>
    ///     Retrieve MSSQL Databases
    /// </summary>
    /// <see href="https://api.20i.com/mssql" />
    /// <returns>The raw json response as a string</returns>
    public async Task<string> GetMssql()
    {
        var url = _baseUrl + "mssql";
        var response = await _requestHandler.GetAsync(url, _bearer);
        return response;
    }

    /// <summary>
    ///     Retrieve MSSQL Database by ID
    /// </summary>
    /// <see href="https://api.20i.com/mssql/{id}" />
    /// <param name="id">The id of the mssql database</param>
    /// <returns>The raw json response as a string</returns>
    public async Task<string> GetMssqlById(string id)
    {
        var url = _baseUrl + "mssql/" + id;
        var response = await _requestHandler.GetAsync(url, _bearer);
        return response;
    }

    /// <summary>
    ///     Update the config to link the MS SQL product to a package.
    /// </summary>
    /// <see href="https://api.20i.com/mssql/{id}" />
    /// <remarks> Json sample body: { id:1 } </remarks>
    /// <param name="id">The id of the mssql database</param>
    /// <param name="body">The json body to send</param>
    /// <returns>The raw json response as a string</returns>
    public async Task<string> MssqlLinkPackage(string id, string body)
    {
        var url = _baseUrl + "mssql/" + id;
        var response = await _requestHandler.PostAsync(url,_bearer,body);
        return response;
    }

    #endregion

    #region Packages Endpoints

    /// <summary>
    ///     Activates or deactivates the service. Possible subservice_name are 'default' for a typical set of services and
    ///     'main' for the core service only.
    /// </summary>
    /// <see href="https://api.20i.com/package/{package_id}/domain/{domain_id}/userStatus" />
    /// <remarks> Json sample body: { includeRepeated: true, subservices:{ (subservice_name): true } } </remarks>
    /// <param name="packageId">The id of the package</param>
    /// <param name="domainId">The id of the domain</param>
    /// <param name="body">The json body to send</param>
    /// <returns>The raw json response as a string</returns>
    public async Task<string> PackageDomainUserStatus(string packageId, string domainId, string body)
    {
        var url = _baseUrl + "package/" + packageId + "/domain/" + domainId + "/userStatus";
        var response = await _requestHandler.PostAsync(url,_bearer,body);
        return response;
    }

    /// <summary>
    ///     Activates or deactivates the service. Possible subservice_name are 'default' for a typical set of services and
    ///     'main' for the core service only.
    /// </summary>
    /// <see href="https://api.20i.com/package/{package_id}/userStatus" />
    /// <remarks> Json sample body: { includeRepeated: true, subservices:{ (subservice_name): true } } </remarks>
    /// <param name="packageId">The id of the package</param>
    /// <param name="body">The json body to send</param>
    /// <returns>The raw json response as a string</returns>
    public async Task<string> PackageUserStatus(string packageId, string body)
    {
        var url = _baseUrl + "package/" + packageId + "/userStatus";
        var response = await _requestHandler.PostAsync(url,_bearer,body);
        return response;
    }

    /// <summary>
    ///     Return a list of installed applications
    /// </summary>
    /// <see href="https://api.20i.com/package/{package_id}/web/installedApplications" />
    /// <param name="packageId">The id of the package</param>
    /// <returns>The raw json response as a string</returns>
    public async Task<string> PackageWebInstalledApplications(string packageId)
    {
        var url = _baseUrl + "package/" + packageId + "/web/installedApplications";
        var response = await _requestHandler.GetAsync(url, _bearer);
        return response;
    }

    /// <summary>
    ///     Add, remove and update applications and set their environment Currently only one type (add,update,delete,setEnv) is
    ///     supported per request.
    /// </summary>
    /// <see href="https://api.20i.com/package/{package_id}/web/installedApplications" />
    /// <param name="packageId">The id of the package</param>
    /// <remarks>
    ///     json sample { add:{ domain: "string", environment: "string", name: "string", path: "string", script: "string",
    ///     typeCode: "string" }, update:{ domain: "string", environment: "string", name: "string", path: "string", script:
    ///     "string", typeCode: "string" }, delete:{ id: "string" }, setEnv:{ id: "string", environment: "string" } }
    /// </remarks>
    /// <param name="body">The json body to send</param>
    /// <returns>The raw json response as a string</returns>
    public async Task<string> PackageWebInstalledApplications(string packageId, string body)
    {
        var url = _baseUrl + "package/" + packageId + "/web/installedApplications";
        var response = await _requestHandler.PostAsync(url,_bearer,body);
        return response;
    }

    /// <summary>
    ///     Returns a list of installed software by type code on managed server.
    /// </summary>
    /// <see href="https://api.20i.com/package/{package_id}/web/installedSoftware" />
    /// <param name="packageId">The id of the package</param>
    /// <returns>The raw json response as a string</returns>
    public async Task<string> PackageWebInstalledSoftware(string packageId)
    {
        var url = _baseUrl + "package/" + packageId + "/web/installedSoftware";
        var response = await _requestHandler.GetAsync(url, _bearer);
        return response;
    }

    /// <summary>
    ///     Returns the current autoresponder config.
    /// </summary>
    /// <see href="https://api.20i.com/package/{package_id}/email/{email_id}/responder" />
    /// <param name="packageId">The id of the package</param>
    /// <param name="emailId">The id of the email</param>
    /// <returns>The raw json response as a string</returns>
    public async Task<string> PackageEmailResponder(string packageId, string emailId)
    {
        var url = _baseUrl + "package/" + packageId + "/email/" + emailId + "/responder";
        var response = await _requestHandler.GetAsync(url, _bearer);
        return response;
    }

    /// <summary>
    ///     Get the bandwidth stats and hits.
    /// </summary>
    /// <see href="https://api.20i.com/package/{package_id}/web/bandwidthStats" />
    /// <param name="packageId">The id of the package</param>
    /// <returns>The raw json response as a string</returns>
    public async Task<string> PackageWebBandwidthStats(string packageId)
    {
        var url = _baseUrl + "package/" + packageId + "/web/bandwidthStats";
        var response = await _requestHandler.GetAsync(url, _bearer);
        return response;
    }

    /// <summary>
    ///     Get blocked countries, in the format of 2-digit ISO codes.
    /// </summary>
    /// <see href="https://api.20i.com/package/{package_id}/web/blockedCountries" />
    /// <param name="packageId">The id of the package</param>
    /// <returns>The raw json response as a string</returns>
    public async Task<string> PackageWebBlockedCountries(string packageId)
    {
        var url = _baseUrl + "package/" + packageId + "/web/blockedCountries";
        var response = await _requestHandler.GetAsync(url, _bearer);
        return response;
    }

    /// <summary>
    ///     Set the blocked countries for the site.
    /// </summary>
    /// <see href="https://api.20i.com/package/{package_id}/web/blockedCountries" />
    /// <remarks> sample body: {countries: ["string"] } </remarks>
    /// <param name="packageId">The id of the package</param>
    /// <param name="body">The body of the request</param>
    /// <returns>The raw json response as a string</returns>
    public async Task<string> PackageWebBlockedCountries(string packageId, string body)
    {
        var url = _baseUrl + "package/" + packageId + "/web/blockedCountries";
        var response = await _requestHandler.PostAsync(url,_bearer,body);
        return response;
    }

    /// <summary>
    ///     Get blocked IP addresses either in standard format or in CIDR format.
    /// </summary>
    /// <see href="https://api.20i.com/package/{package_id}/web/blockedIpAddresses" />
    /// <param name="packageId">The id of the package</param>
    /// <returns>The raw json response as a string</returns>
    public async Task<string> PackageWebBlockedIpAddresses(string packageId)
    {
        var url = _baseUrl + "package/" + packageId + "/web/blockedIpAddresses";
        var response = await _requestHandler.GetAsync(url, _bearer);
        return response;
    }

    /// <summary>
    ///     Set the blocked IP addresses for the web|package. This is an array of IP addresses, with an optional CIDR range.
    /// </summary>
    /// <see href="https://api.20i.com/package/{package_id}/web/blockedIpAddresses" />
    /// <remarks> sample body: { ip_addresses: ["string"] } </remarks>
    /// <param name="packageId">The id of the package</param>
    /// <param name="body">The body of the request</param>
    /// <returns>The raw json response as a string</returns>
    public async Task<string> PackageWebBlockedIpAddresses(string packageId, string body)
    {
        var url = _baseUrl + "package/" + packageId + "/web/blockedIpAddresses";
        var response = await _requestHandler.PostAsync(url,_bearer,body);
        return response;
    }

    /// <summary>
    ///     Returns the CDN statistics for the package.
    /// </summary>
    /// <see href="https://api.20i.com/package/{package_id}/web/cdnStats" />
    /// <param name="packageId">The id of the package</param>
    /// <returns>The raw json response as a string</returns>
    public async Task<string> PackageWebCdnStats(string packageId)
    {
        var url = _baseUrl + "package/" + packageId + "/web/cdnStats";
        var response = await _requestHandler.GetAsync(url, _bearer);
        return response;
    }

    /// <summary>
    ///     Shows bandwidth and hits split by country as recorded by our edge CDN platform
    /// </summary>
    /// <see href="https://api.20i.com/package/{package_id}/web/cdnStatsTrafficDistribution" />
    /// <param name="packageId">The id of the package</param>
    /// <returns>The raw json response as a string</returns>
    public async Task<string> PackageWebCdnStatsTrafficDistribution(string packageId)
    {
        var url = _baseUrl + "package/" + packageId + "/web/cdnStatsTrafficDistribution";
        var response = await _requestHandler.GetAsync(url, _bearer);
        return response;
    }

    /// <summary>
    ///     Returns the current contacts for the domain name. This is a map of contact types to contact data, in EPP format.
    /// </summary>
    /// <see href="https://api.20i.com/package/{package_id}/domain/{domain_id}/contacts" />
    /// <param name="packageId">The id of the package</param>
    /// <param name="domainId">The id of the domain</param>
    /// <returns>The raw json response as a string</returns>
    public async Task<string> PackageDomainContacts(string packageId, string domainId)
    {
        var url = _baseUrl + "package/" + packageId + "/domain/" + domainId + "/contacts";
        var response = await _requestHandler.GetAsync(url, _bearer);
        return response;
    }

    /// <summary>
    ///     Sets the contacts for the domain. This is a map of contact types to contact data, in EPP format.
    /// </summary>
    /// <see href="https://api.20i.com/package/{package_id}/domain/{domain_id}/contacts" />
    /// <remarks> sample body: { contacts: { "string": "string" } } </remarks>
    /// <param name="packageId">The id of the package</param>
    /// <param name="domainId">The id of the domain</param>
    /// <param name="body">The body of the request</param>
    /// <returns>The raw json response as a string</returns>
    public async Task<string> PackageDomainContacts(string packageId, string domainId, string body)
    {
        var url = _baseUrl + "package/" + packageId + "/domain/" + domainId + "/contacts";
        var response = await _requestHandler.PostAsync(url,_bearer,body);
        return response;
    }

    /// <summary>
    ///     Returns some information about the database.
    /// </summary>
    /// <see href="https://api.20i.com/package/{package_id}/web/database/{database_id}" />
    /// <param name="packageId">The id of the package</param>
    /// <param name="databaseId">The id of the database</param>
    /// <returns>The raw json response as a string</returns>
    public async Task<string> PackageWebDatabase(string packageId, string databaseId)
    {
        var url = _baseUrl + "package/" + packageId + "/web/database/" + databaseId;
        var response = await _requestHandler.GetAsync(url, _bearer);
        return response;
    }

    /// <summary>
    ///     Retrieve directory listing configuration.
    /// </summary>
    /// <see href="https://api.20i.com/package/{package_id}/web/directoryIndex" />
    /// <param name="packageId">The id of the package</param>
    /// <returns>The raw json response as a string</returns>
    public async Task<string> PackageWebDirectoryIndex(string packageId)
    {
        var url = _baseUrl + "package/" + packageId + "/web/directoryIndex";
        var response = await _requestHandler.GetAsync(url, _bearer);
        return response;
    }

    /// <summary>
    ///     Set up to 5 files for the directory index in the htaccess.
    /// </summary>
    /// <see href="https://api.20i.com/package/{package_id}/web/directoryIndex" />
    /// <remarks> sample body: { directoryIndex: ["string"] }</remarks>
    /// <param name="packageId">The id of the package</param>
    /// <param name="body">The body of the request</param>
    /// <returns>The raw json response as a string</returns>
    public async Task<string> PackageWebDirectoryIndex(string packageId, string body)
    {
        var url = _baseUrl + "package/" + packageId + "/web/directoryIndex";
        var response = await _requestHandler.PostAsync(url,_bearer,body);
        return response;
    }

    /// <summary>
    ///     Get the directory indexing state
    /// </summary>
    /// <see href="https://api.20i.com/package/{package_id}/web/directoryIndexing" />
    /// <param name="packageId">The id of the package</param>
    /// <returns>The raw json response as a string</returns>
    public async Task<string> PackageWebDirectoryIndexing(string packageId)
    {
        var url = _baseUrl + "package/" + packageId + "/web/directoryIndexing";
        var response = await _requestHandler.GetAsync(url, _bearer);
        return response;
    }

    /// <summary>
    ///     Directory indexing allows visitors to view a list of files instead of the actual webpage. This can turn on/off
    ///     directory indexing for the website
    /// </summary>
    /// <see href="https://api.20i.com/package/{package_id}/web/directoryIndexing" />
    /// <remarks> sample body: { value: true }</remarks>
    /// <param name="packageId">The id of the package</param>
    /// <param name="body">The body of the request</param>
    /// <returns>The raw json response as a string</returns>
    public async Task<string> PackageWebDirectoryIndexing(string packageId, string body)
    {
        var url = _baseUrl + "package/" + packageId + "/web/directoryIndexing";
        var response = await _requestHandler.PostAsync(url,_bearer,body);
        return response;
    }

    /// <summary>
    ///     Request Disk Usage Report
    /// </summary>
    /// <see href="https://api.20i.com/package/{package_id}/web/requestDiskUsage" />
    /// <remarks> sample body: { subdirectory: "string" }</remarks>
    /// <param name="packageId">The id of the package</param>
    /// <param name="body">The body of the request</param>
    /// <returns>The raw json response as a string</returns>
    public async Task<string> PackageWebRequestDiskUsage(string packageId, string body)
    {
        var url = _baseUrl + "package/" + packageId + "/web/requestDiskUsage";
        var response = await _requestHandler.PostAsync(url,_bearer,body);
        return response;
    }

    /// <summary>
    ///     Returns domain DKIM Signatures.
    /// </summary>
    /// <see href="https://api.20i.com/package/{package_id}/email/{email_id}/signature" />
    /// <param name="packageId">The id of the package</param>
    /// <param name="emailId">The id of the email</param>
    /// <returns>The raw json response as a string</returns>
    public async Task<string> PackageEmailSignature(string packageId, string emailId)
    {
        var url = _baseUrl + "package/" + packageId + "/email/" + emailId + "/signature";
        var response = await _requestHandler.GetAsync(url, _bearer);
        return response;
    }

    /// <summary>
    ///     Set or Delete DKIM Signature for a given domain.
    /// </summary>
    /// <see href="https://api.20i.com/package/{package_id}/email/{email_id}/signature" />
    /// <remarks>
    ///     sample body: { action: "string", body:{ Canonicalization: "string", ExpiryTime: 1, Flag: "string",
    ///     Granularity: "string", IsDefault: true, IsStrict: true, Note: "string", Selector: "string", ServiceType: "string" }
    ///     }
    /// </remarks>
    /// <param name="packageId">The id of the package</param>
    /// <param name="emailId">The id of the email</param>
    /// <param name="body">The body of the request</param>
    /// <returns>The raw json response as a string</returns>
    public async Task<string> PackageEmailSignature(string packageId, string emailId, string body)
    {
        var url = _baseUrl + "package/" + packageId + "/email/" + emailId + "/signature";
        var response = await _requestHandler.PostAsync(url,_bearer,body);
        return response;
    }

    /// <summary>
    ///     Returns the maximum number of nameservers for the domain. You can and should cache this information by TLD.
    /// </summary>
    /// <see href="https://api.20i.com/package/{package_id}/domain/{domain_id}/maxNameservers" />
    /// <param name="packageId">The id of the package</param>
    /// <param name="domainId">The id of the domain</param>
    /// <returns>The raw json response as a string</returns>
    public async Task<string> PackageDomainMaxNameservers(string packageId, string domainId)
    {
        var url = _baseUrl + "package/" + packageId + "/domain/" + domainId + "/maxNameservers";
        var response = await _requestHandler.GetAsync(url, _bearer);
        return response;
    }

    /// <summary>
    ///     Returns the default DNS records from the web object.
    /// </summary>
    /// <see href="https://api.20i.com/package/{package_id}/defaultDns" />
    /// <param name="packageId">The id of the package</param>
    /// <returns>The raw json response as a string</returns>
    public async Task<string> PackageDefaultDns(string packageId)
    {
        var url = _baseUrl + "package/" + packageId + "/defaultDns";
        var response = await _requestHandler.GetAsync(url, _bearer);
        return response;
    }

    /// <summary>
    ///     Returns the records needed for a full Google Apps service, including mail and web services.
    ///     You can send these back in the "new" key when updating DNS to add them, but it's recommended that you also delete
    ///     any conflicting records at the same time.
    /// </summary>
    /// <see href="https://api.20i.com/package/{package_id}/domain/{domain_id}/dns/googleApps" />
    /// <param name="packageId">The id of the package</param>
    /// <param name="domainId">The id of the domain</param>
    /// <returns>The raw json response as a string</returns>
    public async Task<string> PackageDomainDnsGoogleApps(string packageId, string domainId)
    {
        var url = _baseUrl + "package/" + packageId + "/domain/" + domainId + "/dns/googleApps";
        var response = await _requestHandler.GetAsync(url, _bearer);
        return response;
    }

    /// <summary>
    ///     Equivalent to adding new DNS records with all the results of GET "googleApps". This will not remove any records by
    ///     default.
    /// </summary>
    /// <see href="https://api.20i.com/package/{package_id}/domain/{domain_id}/dns/googleApps" />
    /// <remarks> sample body: { conflictPolicy: "string" } </remarks>
    /// <param name="packageId">The id of the package</param>
    /// <param name="domainId">The id of the domain</param>
    /// <param name="body">The body of the request</param>
    /// <returns>The raw json response as a string</returns>
    public async Task<string> PackageDomainDnsGoogleApps(string packageId, string domainId, dynamic body)
    {
        var url = _baseUrl + "package/" + packageId + "/domain/" + domainId + "/dns/googleApps";
        var response = await _requestHandler.PostAsync(url,_bearer,body);
        return response;
    }

    /// <summary>
    ///     Returns the records needed for Google Mail service.
    ///     You can send these back in the "new" key when updating DNS to add them, but it's recommended that you also delete
    ///     any conflicting records at the same time.
    /// </summary>
    /// <see href="https://api.20i.com/package/{package_id}/domain/{domain_id}/dns/googleAppsMailOnly" />
    /// <param name="packageId">The id of the package</param>
    /// <param name="domainId">The id of the domain</param>
    /// <returns>The raw json response as a string</returns>
    public async Task<string> PackageDomainDnsGoogleAppsMailOnly(string packageId, string domainId)
    {
        var url = _baseUrl + "package/" + packageId + "/domain/" + domainId + "/dns/googleAppsMailOnly";
        var response = await _requestHandler.GetAsync(url, _bearer);
        return response;
    }

    /// <summary>
    ///     Equivalent to adding new DNS records with all the results of GET "googleAppsMailOnly". This will not remove any
    ///     records by default.
    /// </summary>
    /// <see href="https://api.20i.com/package/{package_id}/domain/{domain_id}/dns/googleAppsMailOnly" />
    /// <remarks> sample body: { conflictPolicy: "string" } </remarks>
    /// <param name="packageId">The id of the package</param>
    /// <param name="domainId">The id of the domain</param>
    /// <param name="body">The body of the request</param>
    /// <returns>The raw json response as a string</returns>
    public async Task<string> PackageDomainDnsGoogleAppsMailOnly(string packageId, string domainId, dynamic body)
    {
        var url = _baseUrl + "package/" + packageId + "/domain/" + domainId + "/dns/googleAppsMailOnly";
        var response = await _requestHandler.PostAsync(url,_bearer,body);
        return response;
    }

    /// <summary>
    ///     Returns the current nameservers for the domain, if applicable.
    /// </summary>
    /// <see href="https://api.20i.com/package/{package_id}/domain/{domain_id}/nameservers" />
    /// <param name="packageId">The id of the package</param>
    /// <param name="domainId">The id of the domain</param>
    /// <returns>The raw json response as a string</returns>
    public async Task<string> PackageDomainNameservers(string packageId, string domainId)
    {
        var url = _baseUrl + "package/" + packageId + "/domain/" + domainId + "/nameservers";
        var response = await _requestHandler.GetAsync(url, _bearer);
        return response;
    }

    /// <summary>
    ///     Updates the nameservers for the domain.
    ///     If the old nameservers do not match, the registry may reject the request.
    ///     Some registries may handle names which are present in both "ns" and "old-ns" incorrectly, so it's recommended that
    ///     you do not include names which are being kept.
    /// </summary>
    /// <see href="https://api.20i.com/package/{package_id}/domain/{domain_id}/nameservers" />
    /// <remarks> sample body: { ns: ["string"], old-ns: ["string"] }</remarks>
    /// <param name="packageId">The id of the package</param>
    /// <param name="domainId">The id of the domain</param>
    /// <param name="body">The body of the request</param>
    /// <returns>The raw json response as a string</returns>
    public async Task<string> PackageDomainNameservers(string packageId, string domainId, dynamic body)
    {
        var url = _baseUrl + "package/" + packageId + "/domain/" + domainId + "/nameservers";
        var response = await _requestHandler.PostAsync(url,_bearer,body);
        return response;
    }

    /// <summary>
    ///     Returns the records needed for office 365 mail.
    /// </summary>
    /// <see href="https://api.20i.com/package/{package_id}/domain/{domain_id}/dns/office365Mail" />
    /// <param name="packageId">The id of the package</param>
    /// <param name="domainId">The id of the domain</param>
    /// <returns>The raw json response as a string</returns>
    public async Task<string> PackageDomainDnsOffice365Mail(string packageId, string domainId)
    {
        var url = _baseUrl + "package/" + packageId + "/domain/" + domainId + "/dns/office365Mail";
        var response = await _requestHandler.GetAsync(url, _bearer);
        return response;
    }

    /// <summary>
    ///     Equivalent to adding new DNS records with all the results of GET "Office365MailOnly". This will not remove any
    ///     records by default.
    /// </summary>
    /// <see href="https://api.20i.com/package/{package_id}/domain/{domain_id}/dns/office365MailOnly" />
    /// <remarks> sample body: { conflictPolicy:"string" }</remarks>
    /// <param name="packageId">The id of the package</param>
    /// <param name="domainId">The id of the domain</param>
    /// <param name="body">The body of the request</param>
    /// <returns>The raw json response as a string</returns>
    public async Task<string> PackageDomainDnsOffice365MailOnly(string packageId, string domainId, dynamic body)
    {
        var url = _baseUrl + "package/" + packageId + "/domain/" + domainId + "/dns/office365MailOnly";
        var response = await _requestHandler.PostAsync(url,_bearer,body);
        return response;
    }

    /// <summary>
    ///     Returns the current DNS records for the domain.
    /// </summary>
    /// <see href="https://api.20i.com/package/{package_id}/domain/{domain_id}/dns" />
    /// <param name="packageId">The id of the package</param>
    /// <param name="domainId">The id of the domain</param>
    /// <returns>The raw json response as a string</returns>
    public async Task<string> PackageDomainDns(string packageId, string domainId)
    {
        var url = _baseUrl + "package/" + packageId + "/domain/" + domainId + "/dns";
        var response = await _requestHandler.GetAsync(url, _bearer);
        return response;
    }

    /// <summary>
    ///     Updates the DNS records for the domain, if the DNS service is in use.
    ///     Name prefixes are either plain names like "www" or "mail", or "@" to indicate that it applies to the domain itself
    ///     (typically only AAAA, A or MX).
    ///     NOTE: The platform may silently rewrite some adds into updates.
    ///     NOTE: CNAMEs are special records (see RFC1034, with reference to RFC1912): they actually mean "no stop you're
    ///     looking in the wrong place, ask instead for ".
    ///     Thus on any name you can only have one of: (a)no records, (b) 1 CNAME, or (c) 1+ non-CNAME records (including SOA
    ///     and NS).
    ///     If you have a CNAME on a name and want to add records on that name, you should remove the CNAME (this may be done
    ///     implicitly for you).
    ///     If you have non-CNAME records on a name and want to add a CNAME on that name, you will have to delete every
    ///     non-CNAME record on the name.
    ///     In most cases, people using CNAME actually want "A/AAAA CNAME", ie. aliasing the A and AAAA records but nothing
    ///     else (which the DNS protocol doesn't support).
    ///     The distinction doesn't affect anything unless you have conflicting records on the same name, which usually is only
    ///     the case for the root.
    ///     Since browsers do not support _http._tcp SRV records (and don't intend to), you simply have to manually copy A or
    ///     AAAA records in this case.
    /// </summary>
    /// <see href="https://api.20i.com/package/{package_id}/domain/{domain_id}/dns" />
    /// <remarks>
    ///     { conflictPolicy: "string", insertPolicy: "string", new:{ AAAA:{ host: "string", ipv6: "string", }, A:{ host:
    ///     "string", ip: "string", }, CNAME:{ reuseId: "string", host: "string", target: "string", }, MX:{ host: "string",
    ///     target: "string", pri: "string", }, TXT:{ host: "string", txt: "string", }, SRV:{ host: "string", pri: "string",
    ///     weight: "string", port: "string", target: "string", } }, delete: ["string"] }
    /// </remarks>
    /// <param name="packageId">The id of the package</param>
    /// <param name="domainId">The id of the domain</param>
    /// <param name="body">The body of the request</param>
    /// <returns>The raw json response as a string</returns>
    public async Task<string> PackageDomainDnsUpdate(string packageId, string domainId, string body)
    {
        var url = _baseUrl + "package/" + packageId + "/domain/" + domainId + "/dns";
        var response = await _requestHandler.PostAsync(url,_bearer,body);
        return response;
    }

    /// <summary>
    ///     Returns a map of DNS names to document root subpaths for the site.
    /// </summary>
    /// <see href="https://api.20i.com/package/{package_id}/web/documentRoots" />
    /// <param name="packageId">The id of the package</param>
    /// <returns>The raw json response as a string</returns>
    public async Task<string> PackageWebDocumentRoots(string packageId)
    {
        var url = _baseUrl + "package/" + packageId + "/web/documentRoots";
        var response = await _requestHandler.GetAsync(url, _bearer);
        return response;
    }

    /// <summary>
    ///     Returns information about the domain.
    /// </summary>
    /// <see href="https://api.20i.com/package/{package_id}/domain/{domain_id}" />
    /// <param name="packageId">The id of the package</param>
    /// <param name="domainId">The id of the domain</param>
    /// <returns>The raw json response as a string</returns>
    public async Task<string> PackageDomain(string packageId, string domainId)
    {
        var url = _baseUrl + "package/" + packageId + "/domain/" + domainId;
        var response = await _requestHandler.GetAsync(url, _bearer);
        return response;
    }

    /// <summary>
    ///     Will provide a hint on what the current maximum years would be allowed for a renewal
    /// </summary>
    /// <see href="https://api.20i.com/package/{package_id}/domain/{domain_id}/renewalMultipleMaxHintFor" />
    /// <param name="packageId">The id of the package</param>
    /// <param name="domainId">The id of the domain</param>
    /// <returns>The raw json response as a string</returns>
    public async Task<string> PackageDomainRenewalMultipleMaxHintFor(string packageId, string domainId)
    {
        var url = _baseUrl + "package/" + packageId + "/domain/" + domainId + "/renewalMultipleMaxHintFor";
        var response = await _requestHandler.GetAsync(url, _bearer);
        return response;
    }

    /// <summary>
    ///     Returns the names for this package.
    /// </summary>
    /// <see href="https://api.20i.com/package/{package_id}/names" />
    /// <param name="packageId">The id of the package</param>
    /// <returns>The raw json response as a string</returns>
    public async Task<string> PackageNames(string packageId)
    {
        var url = _baseUrl + "package/" + packageId + "/names";
        var response = await _requestHandler.GetAsync(url, _bearer);
        return response;
    }

    /// <summary>
    ///     Add or remove names from the package.
    ///     This has special behaviour if any of the names are also registered (renewable) domain names in your account:
    ///     As a policy matter, you may not remove the last name from the object. If you attempt to do so, you will get an
    ///     error.
    /// </summary>
    /// <see href="https://api.20i.com/package/{package_id}/names" />
    /// <remarks> sample body: { add: ["string"], rem: ["string"], chg: "string" } </remarks>
    /// <param name="packageId">The id of the package</param>
    /// <param name="body">The body of the request</param>
    /// <returns>The raw json response as a string</returns>
    public async Task<string> PackageNames(string packageId, string body)
    {
        var url = _baseUrl + "package/" + packageId + "/names";
        var response = await _requestHandler.PostAsync(url,_bearer,body);
        return response;
    }

    /// <summary>
    ///     Get details about a given domain, ie is this a domain or subdomain.
    /// </summary>
    /// <see href="https://api.20i.com/package/{package_id}/web/domainCheck" />
    /// <remarks> sample body: { domain: "string" } </remarks>
    /// <param name="packageId">The id of the package</param>
    /// <param name="body">The body of the request</param>
    /// <returns>The raw json response as a string</returns>
    public async Task<string> PackageWebDomainCheck(string packageId, string body)
    {
        var url = _baseUrl + "package/" + packageId + "/web/domainCheck";
        var response = await _requestHandler.PostAsync(url,_bearer,body);
        return response;
    }

    /// <summary>
    ///     Add or remove names from the Web. This is mostly handled on the corresponding Package.
    /// </summary>
    /// <see href="https://api.20i.com/package/{package_id}/web/names" />
    /// <remarks> sample body: { add: ["string"], rem: ["string"], chg: "string" } </remarks>
    /// <param name="packageId">The id of the package</param>
    /// <param name="body">The body of the request</param>
    /// <returns>The raw json response as a string</returns>
    public async Task<string> PackageWebNames(string packageId, string body)
    {
        var url = _baseUrl + "package/" + packageId + "/web/names";
        var response = await _requestHandler.PostAsync(url,_bearer,body);
        return response;
    }

    /// <summary>
    ///     Get a per-year price, if premium, specifically for renewals.
    ///     This is always in GBP; it will require currency conversion for other currencies and may or may not have markup
    ///     added for checkout.
    /// </summary>
    /// <see href="https://api.20i.com/package/{package_id}/domain/{domain_id}/servicePrice" />
    /// <param name="packageId">The id of the package</param>
    /// <param name="domainId">The id of the domain</param>
    /// <returns>The raw json response as a string</returns>
    public async Task<string> PackageDomainServicePrice(string packageId, string domainId)
    {
        var url = _baseUrl + "package/" + packageId + "/domain/" + domainId + "/servicePrice";
        var response = await _requestHandler.GetAsync(url, _bearer);
        return response;
    }

    /// <summary>
    ///     Returns information about the service domain privacy.
    /// </summary>
    /// <see href="https://api.20i.com/package/{package_id}/domain/{domain_id}/privacy" />
    /// <param name="packageId">The id of the package</param>
    /// <param name="domainId">The id of the domain</param>
    /// <returns>The raw json response as a string</returns>
    public async Task<string> PackageDomainPrivacy(string packageId, string domainId)
    {
        var url = _baseUrl + "package/" + packageId + "/domain/" + domainId + "/privacy";
        var response = await _requestHandler.GetAsync(url, _bearer);
        return response;
    }

    /// <summary>
    ///     Update the privacy settings for the service domain.
    /// </summary>
    /// <see href="https://api.20i.com/package/{package_id}/domain/{domain_id}/privacy" />
    /// <remarks> sample body: { emailDestination: "string" } </remarks>
    /// <param name="packageId">The id of the package</param>
    /// <param name="domainId">The id of the domain</param>
    /// <param name="body">The body of the request</param>
    /// <returns>The raw json response as a string</returns>
    public async Task<string> PackageDomainPrivacy(string packageId, string domainId, string body)
    {
        var url = _baseUrl + "package/" + packageId + "/domain/" + domainId + "/privacy";
        var response = await _requestHandler.PostAsync(url,_bearer,body);
        return response;
    }

    /// <summary>
    ///     Updates the privacy enabled/disabled state (for domains with privacy attached only).
    /// </summary>
    /// <see href="https://api.20i.com/package/{package_id}/domain/{domain_id}/privacyState" />
    /// <remarks> sample body: { enabled: true } </remarks>
    /// <param name="packageId">The id of the package</param>
    /// <param name="domainId">The id of the domain</param>
    /// <param name="body">The body of the request</param>
    /// <returns>The raw json response as a string</returns>
    public async Task<string> PackageDomainPrivacyState(string packageId, string domainId, string body)
    {
        var url = _baseUrl + "package/" + packageId + "/domain/" + domainId + "/privacyState";
        var response = await _requestHandler.PostAsync(url,_bearer,body);
        return response;
    }

    /// <summary>
    ///     Returns the current cached status of the transfer.
    /// </summary>
    /// <see href="https://api.20i.com/package/{package_id}/domain/{domain_id}/pendingTransferStatus" />
    /// <param name="packageId">The id of the package</param>
    /// <param name="domainId">The id of the domain</param>
    /// <returns>The raw json response as a string</returns>
    public async Task<string> PackageDomainPendingTransferStatus(string packageId, string domainId)
    {
        var url = _baseUrl + "package/" + packageId + "/domain/" + domainId + "/pendingTransferStatus";
        var response = await _requestHandler.GetAsync(url, _bearer);
        return response;
    }

    /// <summary>
    ///     Fetches information about WHOIS contact disclosure (Nominet or .IT) for the domain name.
    /// </summary>
    /// <see href="https://api.20i.com/package/{package_id}/domain/{domain_id}/optOut" />
    /// <param name="packageId">The id of the package</param>
    /// <param name="domainId">The id of the domain</param>
    /// <returns>The raw json response as a string</returns>
    public async Task<string> PackageDomainOptOut(string packageId, string domainId)
    {
        var url = _baseUrl + "package/" + packageId + "/domain/" + domainId + "/optOut";
        var response = await _requestHandler.GetAsync(url, _bearer);
        return response;
    }

    /// <summary>
    ///     Updates the WHOIS disclosure options, for applicable domains.
    /// </summary>
    /// <see href="https://api.20i.com/package/{package_id}/domain/{domain_id}/optOut" />
    /// <remarks> sample body: { enabled: true } </remarks>
    /// <param name="packageId">The id of the package</param>
    /// <param name="domainId">The id of the domain</param>
    /// <param name="body">The body of the request</param>
    /// <returns>The raw json response as a string</returns>
    public async Task<string> PackageDomainOptOut(string packageId, string domainId, string body)
    {
        var url = _baseUrl + "package/" + packageId + "/domain/" + domainId + "/optOut";
        var response = await _requestHandler.PostAsync(url,_bearer,body);
        return response;
    }

    /// <summary>
    ///     Returns the current blacklist config - email.
    /// </summary>
    /// <see href="https://api.20i.com/package/{package_id}/email/{mail_id}/spamPolicyListBlacklist" />
    /// <param name="packageId">The id of the package</param>
    /// <param name="mailId">The id of the mail</param>
    /// <returns>The raw json response as a string</returns>
    public async Task<string> PackageEmailSpamPolicyListBlacklist(string packageId, string mailId)
    {
        var url = _baseUrl + "package/" + packageId + "/email/" + mailId + "/spamPolicyListBlacklist";
        var response = await _requestHandler.GetAsync(url, _bearer);
        return response;
    }

    /// <summary>
    ///     Returns the current email configuration for the domain.
    ///     This is a map of setting types to arrays of settings, in the same format as the "email" method but with an extra
    ///     "id" property on each item.
    ///     To facilitate page display, this also redundantly includes the domain name in a "name" property.
    /// </summary>
    /// <see href="https://api.20i.com/package/{package_id}/email/{mail_id}" />
    /// <param name="packageId">The id of the package</param>
    /// <param name="mailId">The id of the mail</param>
    /// <returns>The raw json response as a string</returns>
    public async Task<string> PackageEmail(string packageId, string mailId)
    {
        var url = _baseUrl + "package/" + packageId + "/email/" + mailId;
        var response = await _requestHandler.GetAsync(url, _bearer);
        return response;
    }

    /// <summary>
    ///     Updates the email configuration for the domain.
    /// </summary>
    /// <see href="https://api.20i.com/package/{package_id}/email/{mail_id}" />
    /// <remarks> sample body:{ { result:{ }, name: "string" } }</remarks>
    /// <param name="packageId">The id of the package</param>
    /// <param name="mailId">The id of the mail</param>
    /// <param name="body">The body of the request</param>
    /// <returns>The raw json response as a string</returns>
    public async Task<string> PackageEmail(string packageId, string mailId, string body)
    {
        var url = _baseUrl + "package/" + packageId + "/email/" + mailId;
        var response = await _requestHandler.PostAsync(url,_bearer,body);
        return response;
    }

    /// <summary>
    ///     Returns the current domain config.
    /// </summary>
    /// <see href="https://api.20i.com/package/{package_id}/email/{mail_id}/domain" />
    /// <param name="packageId">The id of the package</param>
    /// <param name="mailId">The id of the mail</param>
    /// <returns>The raw json response as a string</returns>
    public async Task<string> PackageEmailDomain(string packageId, string mailId)
    {
        var url = _baseUrl + "package/" + packageId + "/email/" + mailId + "/domain";
        var response = await _requestHandler.GetAsync(url, _bearer);
        return response;
    }

    /// <summary>
    ///     Returns the current domain alias config.
    /// </summary>
    /// <see href="https://api.20i.com/package/{package_id}/email/{mail_id}/domainAlias" />
    /// <param name="packageId">The id of the package</param>
    /// <param name="mailId">The id of the mail</param>
    /// <returns>The raw json response as a string</returns>
    public async Task<string> PackageEmailDomainAlias(string packageId, string mailId)
    {
        var url = _baseUrl + "package/" + packageId + "/email/" + mailId + "/domainAlias";
        var response = await _requestHandler.GetAsync(url, _bearer);
        return response;
    }

    /// <summary>
    ///     Returns the current forwarder config.
    /// </summary>
    /// <see href="https://api.20i.com/package/{package_id}/email/{mail_id}/forwarder" />
    /// <param name="packageId">The id of the package</param>
    /// <param name="mailId">The id of the mail</param>
    /// <returns>The raw json response as a string</returns>
    public async Task<string> PackageEmailForwarder(string packageId, string mailId)
    {
        var url = _baseUrl + "package/" + packageId + "/email/" + mailId + "/forwarder";
        var response = await _requestHandler.GetAsync(url, _bearer);
        return response;
    }

    /// <summary>
    ///     Fetches all forwarders by package id.
    /// </summary>
    /// <see href="https://api.20i.com/package/{package_id}/email/allMailForwarders" />
    /// <param name="packageId">The id of the package</param>
    /// <returns>The raw json response as a string</returns>
    public async Task<string> PackageEmailAllMailForwarders(string packageId)
    {
        var url = _baseUrl + "package/" + packageId + "/email/allMailForwarders";
        var response = await _requestHandler.GetAsync(url, _bearer);
        return response;
    }

    /// <summary>
    ///     Returns the current whitelist config.
    /// </summary>
    /// <see href="https://api.20i.com/package/{package_id}/email/{mail_id}/spamPolicyListWhitelist" />
    /// <param name="packageId">The id of the package</param>
    /// <param name="mailId">The id of the mail</param>
    /// <returns>The raw json response as a string</returns>
    public async Task<string> PackageEmailSpamPolicyListWhitelist(string packageId, string mailId)
    {
        var url = _baseUrl + "package/" + packageId + "/email/" + mailId + "/spamPolicyListWhitelist";
        var response = await _requestHandler.GetAsync(url, _bearer);
        return response;
    }

    /// <summary>
    ///     Get the file permissions that do not match the platform recommendations
    /// </summary>
    /// <see href="https://api.20i.com/package/{package_id}/web/filePermissions" />
    /// <param name="packageId">The id of the package</param>
    /// <returns>The raw json response as a string</returns>
    public async Task<string> PackageWebFilePermissions(string packageId)
    {
        var url = _baseUrl + "package/" + packageId + "/web/filePermissions";
        var response = await _requestHandler.GetAsync(url, _bearer);
        return response;
    }

    /// <summary>
    ///     Set file permissions
    /// </summary>
    /// <see href="https://api.20i.com/package/{package_id}/web/filePermissions" />
    /// <remarks> sample body: { permissionCheckId: 1, files:{ file: "string", perms: 1 } } </remarks>
    /// <param name="packageId">The id of the package</param>
    /// <param name="body">The body of the request</param>
    /// <returns>The raw json response as a string</returns>
    public async Task<string> PackageWebFilePermissions(string packageId, string body)
    {
        var url = _baseUrl + "package/" + packageId + "/web/filePermissions";
        var response = await _requestHandler.PostAsync(url,_bearer,body);
        return response;
    }

    /// <summary>
    ///     Returns the current mailbox forwarder config.
    /// </summary>
    /// <see href="https://api.20i.com/package/{package_id}/email/{mail_id}/mailForwarder" />
    /// <param name="packageId">The id of the package</param>
    /// <param name="mailId">The id of the mail</param>
    /// <returns>The raw json response as a string</returns>
    public async Task<string> PackageEmailMailForwarder(string packageId, string mailId)
    {
        var url = _baseUrl + "package/" + packageId + "/email/" + mailId + "/mailForwarder";
        var response = await _requestHandler.GetAsync(url, _bearer);
        return response;
    }

    /// <summary>
    ///     Returns the FTP credentials (if any).
    /// </summary>
    /// <see href="https://api.20i.com/package/{package_id}/web/ftpCredentials" />
    /// <param name="packageId">The id of the package</param>
    /// <returns>The raw json response as a string</returns>
    public async Task<string> PackageWebFtpCredentials(string packageId)
    {
        var url = _baseUrl + "package/" + packageId + "/web/ftpCredentials";
        var response = await _requestHandler.GetAsync(url, _bearer);
        return response;
    }

    /// <summary>
    ///     Returns an array of FTP users for this ExternalId and the Acl associated with the FTP account
    /// </summary>
    /// <see href="https://api.20i.com/package/{package_id}/web/ftpUsers" />
    /// <param name="packageId">The id of the package</param>
    /// <returns>The raw json response as a string</returns>
    public async Task<string> PackageWebFtpUsers(string packageId)
    {
        var url = _baseUrl + "package/" + packageId + "/web/ftpUsers";
        var response = await _requestHandler.GetAsync(url, _bearer);
        return response;
    }

    /// <summary>
    ///     Update or create a new FTP user. This method will handle the creation of new FTP users and updating existing FTP
    ///     users.
    /// </summary>
    /// <see href="https://api.20i.com/package/{package_id}/web/ftpUsers" />
    /// <remarks>
    ///     sample body: { new:{ ftp:{ user:{ Username: "string", Domain: "string", Password: "string", JailFrom:
    ///     "string" } } }, update:{ ftp:{ id: "string", user:{ Password: "string", JailFrom: "string", UnlockedUntil:
    ///     "string", Enabled: true }, acl: "string" } }, delete:{ ftp:{ id: ["string"] } } }
    /// </remarks>
    /// <param name="packageId">The id of the package</param>
    /// <param name="body">The body of the request</param>
    /// <returns>The raw json response as a string</returns>
    public async Task<string> PackageWebFtpUsers(string packageId, string body)
    {
        var url = _baseUrl + "package/" + packageId + "/web/ftpUsers";
        var response = await _requestHandler.PostAsync(url,_bearer,body);
        return response;
    }

    /// <summary>
    ///     Returns the home directory for the web site.
    /// </summary>
    /// <see href="https://api.20i.com/package/{package_id}/web/homeDirectory" />
    /// <param name="packageId">The id of the package</param>
    /// <returns>The raw json response as a string</returns>
    public async Task<string> PackageWebHomeDirectory(string packageId)
    {
        var url = _baseUrl + "package/" + packageId + "/web/homeDirectory";
        var response = await _requestHandler.GetAsync(url, _bearer);
        return response;
    }

    /// <summary>
    ///     Get the prevent hotlinking config.
    /// </summary>
    /// <see href="https://api.20i.com/package/{package_id}/web/preventHotlinking" />
    /// <param name="packageId">The id of the package</param>
    /// <returns>The raw json response as a string</returns>
    public async Task<string> PackageWebPreventHotlinking(string packageId)
    {
        var url = _baseUrl + "package/" + packageId + "/web/preventHotlinking";
        var response = await _requestHandler.GetAsync(url, _bearer);
        return response;
    }

    /// <summary>
    ///     Set the prevent hotlinking config.
    /// </summary>
    /// <see href="https://api.20i.com/package/{package_id}/web/preventHotlinking" />
    /// <remarks>
    ///     sample body: { AllowDirect: true, AllowedHostnames: ["string"], RedirectURL: "string", Extensions: ["string"]
    ///     }
    /// </remarks>
    /// <param name="packageId">The id of the package</param>
    /// <param name="body">The body of the request</param>
    /// <returns>The raw json response as a string</returns>
    public async Task<string> PackageWebPreventHotlinking(string packageId, string body)
    {
        var url = _baseUrl + "package/" + packageId + "/web/preventHotlinking";
        var response = await _requestHandler.PostAsync(url,_bearer,body);
        return response;
    }

    /// <summary>
    ///     Returns the limits for the current user, a key-value map.
    /// </summary>
    /// <see href="https://api.20i.com/package/{package_id}/domain/{domain_id}/limits" />
    /// <param name="packageId">The id of the package</param>
    /// <param name="domainId">The id of the domain</param>
    /// <returns>The raw json response as a string</returns>
    public async Task<string> PackageDomainLimits(string packageId, string domainId)
    {
        var url = _baseUrl + "package/" + packageId + "/domain/" + domainId + "/limits";
        var response = await _requestHandler.GetAsync(url, _bearer);
        return response;
    }

    /// <summary>
    ///     Returns the limits for the current user, a key-value map.
    /// </summary>
    /// <see href="https://api.20i.com/package/{package_id}/limits" />
    /// <param name="packageId">The id of the package</param>
    /// <returns>The raw json response as a string</returns>
    public async Task<string> PackageLimits(string packageId)
    {
        var url = _baseUrl + "package/" + packageId + "/limits";
        var response = await _requestHandler.GetAsync(url, _bearer);
        return response;
    }

    /// <summary>
    ///     Retrieve limits for a web.
    /// </summary>
    /// <see href="https://api.20i.com/package/{package_id}/web/limits" />
    /// <param name="packageId">The id of the package</param>
    /// <returns>The raw json response as a string</returns>
    public async Task<string> PackageWebLimits(string packageId)
    {
        var url = _baseUrl + "package/" + packageId + "/web/limits";
        var response = await _requestHandler.GetAsync(url, _bearer);
        return response;
    }

    /// <summary>
    ///     Returns some information about the database user
    /// </summary>
    /// <see href="https://api.20i.com/package/{package_id}/database/{database_id}/user/{user_id}" />
    /// <param name="packageId">The id of the package</param>
    /// <param name="databaseId">The id of the database</param>
    /// <param name="userId">The id of the user</param>
    /// <returns>The raw json response as a string</returns>
    public async Task<string> PackageDatabaseUser(string packageId, string databaseId, string userId)
    {
        var url = _baseUrl + "package/" + packageId + "/database/" + databaseId + "/user/" + userId;
        var response = await _requestHandler.GetAsync(url, _bearer);
        return response;
    }

    /// <summary>
    ///     Returns information about this service.
    /// </summary>
    /// <see href="https://api.20i.com/package" />
    /// <returns>The raw json response as a string</returns>
    public async Task<string> Package()
    {
        var url = _baseUrl + "package";
        var response = await _requestHandler.GetAsync(url, _bearer);
        return response;
    }

    /// <summary>
    ///     Retrieve stack user list.
    /// </summary>
    /// <see href="https://api.20i.com/package/{package_id}/stackUserList" />
    /// <param name="packageId">The id of the package</param>
    /// <returns>The raw json response as a string</returns>
    public async Task<string> PackageStackUserList(string packageId)
    {
        var url = _baseUrl + "package/" + packageId + "/stackUserList";
        var response = await _requestHandler.GetAsync(url, _bearer);
        return response;
    }

    /// <summary>
    ///     Get access and error logs for the site.
    /// </summary>
    /// <see href="https://api.20i.com/package/{package_id}/web/logs" />
    /// <param name="packageId">The id of the package</param>
    /// <returns>The raw json response as a string</returns>
    public async Task<string> PackageWebLogs(string packageId)
    {
        var url = _baseUrl + "package/" + packageId + "/web/logs";
        var response = await _requestHandler.GetAsync(url, _bearer);
        return response;
    }

    /// <summary>
    ///     Returns the current mailbox config.
    /// </summary>
    /// <see href="https://api.20i.com/package/{package_id}/email/{mail_id}/mailbox" />
    /// <param name="packageId">The id of the package</param>
    /// <param name="mailId">The id of the mail</param>
    /// <returns>The raw json response as a string</returns>
    public async Task<string> PackageEmailMailbox(string packageId, string mailId)
    {
        var url = _baseUrl + "package/" + packageId + "/email/" + mailId + "/mailbox";
        var response = await _requestHandler.GetAsync(url, _bearer);
        return response;
    }

    /// <summary>
    ///     Get maintenance mode settings for this web.
    /// </summary>
    /// <see href="https://api.20i.com/package/{package_id}/web/maintenanceMode" />
    /// <param name="packageId">The id of the package</param>
    /// <returns>The raw json response as a string</returns>
    public async Task<string> PackageWebMaintenanceMode(string packageId)
    {
        var url = _baseUrl + "package/" + packageId + "/web/maintenanceMode";
        var response = await _requestHandler.GetAsync(url, _bearer);
        return response;
    }

    /// <summary>
    ///     Set maintenance mode settings for this web.
    /// </summary>
    /// <see href="https://api.20i.com/package/{package_id}/web/maintenanceMode" />
    /// <remarks> sample body: {"enabled":true} </remarks>
    /// <param name="packageId">The id of the package</param>
    /// <param name="body">The raw json body</param>
    /// <returns>The raw json response as a string</returns>
    public async Task<string> PackageWebMaintenanceMode(string packageId, string body)
    {
        var url = _baseUrl + "package/" + packageId + "/web/maintenanceMode";
        var response = await _requestHandler.PostAsync(url,_bearer,body);
        return response;
    }

    /// <summary>
    ///     Get the malware scan objects for this web
    /// </summary>
    /// <see href="https://api.20i.com/package/{package_id}/web/malwareScan" />
    /// <param name="packageId">The id of the package</param>
    /// <returns>The raw json response as a string</returns>
    public async Task<string> PackageWebMalwareScan(string packageId)
    {
        var url = _baseUrl + "package/" + packageId + "/web/malwareScan";
        var response = await _requestHandler.GetAsync(url, _bearer);
        return response;
    }

    /// <summary>
    ///     Set Mailware Scan lock state, setting to "new" will request a new scan
    /// </summary>
    /// <see href="https://api.20i.com/package/{package_id}/web/malwareScan" />
    /// <remarks> sample body: {"LockState":"new"} </remarks>
    /// <param name="packageId">The id of the package</param>
    /// <param name="body">The raw json body</param>
    /// <returns>The raw json response as a string</returns>
    public async Task<string> PackageWebMalwareScan(string packageId, string body)
    {
        var url = _baseUrl + "package/" + packageId + "/web/malwareScan";
        var response = await _requestHandler.PostAsync(url, _bearer, body);
        return response;
    }

    /// <summary>
    ///     Add a user to an MSSQL database.
    /// </summary>
    /// <see href="https://api.20i.com/package/{package_id}/web/mssqlUsers" />
    /// <remarks> sample body: { databaseId: 1, username: "string", password: "string" } </remarks>
    /// <param name="packageId">The id of the package</param>
    /// <param name="body">The raw json body</param>
    /// <returns>The raw json response as a string</returns>
    public async Task<string> PackageWebMssqlUsers(string packageId, string body)
    {
        var url = _baseUrl + "package/" + packageId + "/web/mssqlUsers";
        var response = await _requestHandler.PostAsync(url, _bearer, body);
        return response;
    }

    /// <summary>
    ///     Get MSSQL Databases.
    /// </summary>
    /// <see href="https://api.20i.com/package/{package_id}/web/mssqlDatabases" />
    /// <param name="packageId">The id of the package</param>
    /// <returns>The raw json response as a string</returns>
    public async Task<string> PackageWebMssqlDatabases(string packageId)
    {
        var url = _baseUrl + "package/" + packageId + "/web/mssqlDatabases";
        var response = await _requestHandler.GetAsync(url, _bearer);
        return response;
    }

    /// <summary>
    ///     Create a new MSSQL Database and a user with the same name.
    /// </summary>
    /// <see href="https://api.20i.com/package/{package_id}/web/mssqlDatabases" />
    /// <remarks> sample body: { name: "string",password: "string" } </remarks>
    /// <param name="packageId">The id of the package</param>
    /// <param name="body">The raw json body</param>
    /// <returns>The raw json response as a string</returns>
    public async Task<string> PackageWebMssqlDatabases(string packageId, string body)
    {
        var url = _baseUrl + "package/" + packageId + "/web/mssqlDatabases";
        var response = await _requestHandler.PostAsync(url, _bearer, body);
        return response;
    }

    /// <summary>
    ///     Remove an MSSQL database.
    /// </summary>
    /// <see href="https://api.20i.com/package/{package_id}/web/removeMssqlDatabase" />
    /// <remarks> sample body: { id: 1 } </remarks>
    /// <param name="packageId">The id of the package</param>
    /// <param name="body">The raw json body</param>
    /// <returns>The raw json response as a string</returns>
    public async Task<string> PackageWebRemoveMssqlDatabase(string packageId, string body)
    {
        var url = _baseUrl + "package/" + packageId + "/web/removeMssqlDatabase";
        var response = await _requestHandler.PostAsync(url, _bearer,body);
        return response;
    }

    /// <summary>
    ///     Remove an MSSQL user.
    /// </summary>
    /// <see href="https://api.20i.com/package/{package_id}/web/removeMssqlUser" />
    /// <remarks> sample body: { databaseId: 1, userId: 1 } </remarks>
    /// <param name="packageId">The id of the package</param>
    /// <param name="body">The raw json body</param>
    /// <returns>The raw json response as a string</returns>
    public async Task<string> PackageWebRemoveMssqlUser(string packageId, string body)
    {
        var url = _baseUrl + "package/" + packageId + "/web/removeMssqlUser";
        var response = await _requestHandler.PostAsync(url, _bearer, body);
        return response;
    }

    /// <summary>
    ///     Update the password for an MSSQL user.
    /// </summary>
    /// <see href="https://api.20i.com/package/{package_id}/web/mssqlUserPassword" />
    /// <remarks> sample body: { databaseId: 1, userId: 1, password: "string" } </remarks>
    /// <param name="packageId">The id of the package</param>
    /// <param name="body">The raw json body</param>
    /// <returns>The raw json response as a string</returns>
    public async Task<string> PackageWebMssqlUserPassword(string packageId, string body)
    {
        var url = _baseUrl + "package/" + packageId + "/web/mssqlUserPassword";
        var response = await _requestHandler.PostAsync(url, _bearer, body);
        return response;
    }

    /// <summary>
    ///     Get all MySQL databases.
    /// </summary>
    /// <see href="https://api.20i.com/package/{package_id}/web/mysqlDatabases" />
    /// <param name="packageId">The id of the package</param>
    /// <returns>The raw json response as a string</returns>
    public async Task<string> PackageWebMysqlDatabases(string packageId)
    {
        var url = _baseUrl + "package/" + packageId + "/web/mysqlDatabases";
        var response = await _requestHandler.GetAsync(url, _bearer);
        return response;
    }

    /// <summary>
    ///     Create a MySQL database.
    /// </summary>
    /// <see href="https://api.20i.com/package/{package_id}/web/mysqlDatabases" />
    /// <remarks> sample body: { name: "string", password: "string", allow_random: true } </remarks>
    /// <param name="packageId">The id of the package</param>
    /// <param name="body">The raw json body</param>
    /// <returns>The raw json response as a string</returns>
    public async Task<string> PackageWebMysqlDatabase(string packageId, string body)
    {
        var url = _baseUrl + "package/" + packageId + "/web/mysqlDatabases";
        var response = await _requestHandler.PostAsync(url, _bearer, body);
        return response;
    }

    /// <summary>
    ///     Get the external IP addresses that MySQL users are allowed to connect to remotely.
    /// </summary>
    /// <see href="https://api.20i.com/package/{package_id}/web/mysqlUserIpAcl" />
    /// <param name="packageId">The id of the package</param>
    /// <returns>The raw json response as a string</returns>
    public async Task<string> PackageWebMysqlUserIpAcl(string packageId)
    {
        var url = _baseUrl + "package/" + packageId + "/web/mysqlUserIpAcl";
        var response = await _requestHandler.GetAsync(url, _bearer);
        return response;
    }

    /// <summary>
    ///     Update the external IP addresses that MySQL users are allowed to connect to remotely.
    /// </summary>
    /// <see href="https://api.20i.com/package/{package_id}/web/mysqlUserIpAcl" />
    /// <remarks> sample body: { add:{ user_id: 1, hosts: "string" }, remove:{ user_id: 1, id: 1 } }</remarks>
    /// <param name="packageId">The id of the package</param>
    /// <param name="body">The raw json body</param>
    /// <returns>The raw json response as a string</returns>
    public async Task<string> PackageWebMysqlUserIpAcl(string packageId, string body)
    {
        var url = _baseUrl + "package/" + packageId + "/web/mysqlUserIpAcl";
        var response = await _requestHandler.PostAsync(url, _bearer, body);
        return response;
    }

    /// <summary>
    ///     Remove a MySQL database.
    /// </summary>
    /// <see href="https://api.20i.com/package/{package_id}/web/removeMysqlDatabase" />
    /// <remarks> sample body: { id: 1 }</remarks>
    /// <param name="packageId">The id of the package</param>
    /// <param name="body">The raw json body</param>
    /// <returns>The raw json response as a string</returns>
    public async Task<string> PackageWebRemoveMysqlDatabase(string packageId, string body)
    {
        var url = _baseUrl + "package/" + packageId + "/web/removeMysqlDatabase";
        var response = await _requestHandler.PostAsync(url, _bearer, body);
        return response;
    }

    /// <summary>
    ///     Remove a MySQL user.
    /// </summary>
    /// <see href="https://api.20i.com/package/{package_id}/web/removeMysqlUser" />
    /// <remarks> sample body: { id: 1 }</remarks>
    /// <param name="packageId">The id of the package</param>
    /// <param name="body">The raw json body</param>
    /// <returns>The raw json response as a string</returns>
    public async Task<string> PackageWebRemoveMysqlUser(string packageId, string body)
    {
        var url = _baseUrl + "package/" + packageId + "/web/removeMysqlUser";
        var response = await _requestHandler.PostAsync(url, _bearer, body);
        return response;
    }

    /// <summary>
    ///     Get a list of each MySQL database server and a Single Sign on link for each.
    /// </summary>
    /// <see href="https://api.20i.com/package/{package_id}/web/mysqlSSO" />
    /// <param name="packageId">The id of the package</param>
    /// <returns>The raw json response as a string</returns>
    public async Task<string> PackageWebMysqlSso(string packageId)
    {
        var url = _baseUrl + "package/" + packageId + "/web/mysqlSSO";
        var response = await _requestHandler.GetAsync(url, _bearer);
        return response;
    }

    /// <summary>
    ///     Grant an existing user the default privileges on a database.
    /// </summary>
    /// <see href="https://api.20i.com/package/{package_id}/web/mysqlGrantUserDatabase" />
    /// <remarks> sample body: { username: "string", database: "string" }</remarks>
    /// <param name="packageId">The id of the package</param>
    /// <param name="body">The raw json body</param>
    /// <returns>The raw json response as a string</returns>
    public async Task<string> PackageWebMysqlGrantUserDatabase(string packageId, string body)
    {
        var url = _baseUrl + "package/" + packageId + "/web/mysqlGrantUserDatabase";
        var response = await _requestHandler.PostAsync(url, _bearer, body);
        return response;
    }

    /// <summary>
    ///     Get the grants for MySQL users and databases.
    /// </summary>
    /// <see href="https://api.20i.com/package/{package_id}/web/mysqlGrants" />
    /// <param name="packageId">The id of the package</param>
    /// <returns>The raw json response as a string</returns>
    public async Task<string> PackageWebMysqlGrants(string packageId)
    {
        var url = _baseUrl + "package/" + packageId + "/web/mysqlGrants";
        var response = await _requestHandler.GetAsync(url, _bearer);
        return response;
    }

    /// <summary>
    ///     Update the grants for MySQL users and databases.
    /// </summary>
    /// <see href="https://api.20i.com/package/{package_id}/web/mysqlGrants" />
    /// <remarks> sample body: { user_id: "string", username: "string", database: "string", grants: ["string"] }</remarks>
    /// <param name="packageId">The id of the package</param>
    /// <param name="body">The raw json body</param>
    /// <returns>The raw json response as a string</returns>
    public async Task<string> PackageWebMysqlGrants(string packageId, string body)
    {
        var url = _baseUrl + "package/" + packageId + "/web/mysqlGrants";
        var response = await _requestHandler.PostAsync(url,_bearer,body);
        return response;
    }

    /// <summary>
    ///     Update a MySQL user's password.
    /// </summary>
    /// <see href="https://api.20i.com/package/{package_id}/web/mysqlUserPassword" />
    /// <remarks> sample body: { user_id: 1, password: "string" }</remarks>
    /// <param name="packageId">The id of the package</param>
    /// <param name="body">The raw json body</param>
    /// <returns>The raw json response as a string</returns>
    public async Task<string> PackageWebMysqlUserPassword(string packageId, string body)
    {
        var url = _baseUrl + "package/" + packageId + "/web/mysqlUserPassword";
        var response = await _requestHandler.PostAsync(url,_bearer,body);
        return response;
    }


    /// <summary>
    ///     Get all mysql users.
    /// </summary>
    /// <see href="https://api.20i.com/package/{package_id}/web/mysqlUsers" />
    /// <param name="packageId">The id of the package</param>
    /// <returns>The raw json response as a string</returns>
    public async Task<string> PackageWebMysqlUsers(string packageId)
    {
        var url = _baseUrl + "package/" + packageId + "/web/mysqlUsers";
        var response = await _requestHandler.GetAsync(url, _bearer);
        return response;
    }

    /// <summary>
    ///     Create a new mysql user.
    /// </summary>
    /// <see href="https://api.20i.com/package/{package_id}/web/mysqlUsers" />
    /// <remarks> sample body: { username: "string", password: "string", database: "string" }</remarks>
    /// <param name="packageId">The id of the package</param>
    /// <param name="body">The raw json body</param>
    /// <returns>The raw json response as a string</returns>
    public async Task<string> PackageWebMysqlUsers(string packageId, string body)
    {
        var url = _baseUrl + "package/" + packageId + "/web/mysqlUsers";
        var response = await _requestHandler.PostAsync(url,_bearer,body);
        return response;
    }

    /// <summary>
    ///     Returns an array for One Click objects that contain details of the current version and details in use
    /// </summary>
    /// <see href="https://api.20i.com/package/{package_id}/web/oneclick" />
    /// <param name="packageId">The id of the package</param>
    /// <returns>The raw json response as a string</returns>
    public async Task<string> PackageWebOneclick(string packageId)
    {
        var url = _baseUrl + "package/" + packageId + "/web/oneclick";
        var response = await _requestHandler.GetAsync(url, _bearer);
        return response;
    }

    /// <summary>
    ///     Install a One Click package.
    /// </summary>
    /// <see href="https://api.20i.com/package/{package_id}/web/oneclick" />
    /// <remarks>
    ///     sample body: { domain: "string", httpsDomain: "string", oneclick: "string", directory: "string", licenceKey:
    ///     "string" }
    /// </remarks>
    /// <param name="packageId">The id of the package</param>
    /// <param name="body">The raw json body</param>
    /// <returns>The raw json response as a string</returns>
    public async Task<string> PackageWebOneclick(string packageId, string body)
    {
        var url = _baseUrl + "package/" + packageId + "/web/oneclick";
        var response = await _requestHandler.PostAsync(url,_bearer,body);
        return response;
    }

    /// <summary>
    ///     Returns detailed information about the package.
    /// </summary>
    /// <see href="https://api.20i.com/package/{package_id}/web" />
    /// <param name="packageId">The id of the package</param>
    /// <returns>The raw json response as a string</returns>
    public async Task<string> PackageWeb(string packageId)
    {
        var url = _baseUrl + "package/" + packageId + "/web";
        var response = await _requestHandler.GetAsync(url, _bearer);
        return response;
    }

    /// <summary>
    ///     Returns an array representation of the package.
    /// </summary>
    /// <see href="https://api.20i.com/package/{package_id}" />
    /// 
    /// <param name="packageId">The id of the package</param>
    /// <returns>The raw json response as a string</returns>
    public async Task<string> Package(string packageId)
    {
        var url = _baseUrl + "package/" + packageId;
        var response = await _requestHandler.GetAsync(url, _bearer);
        return response;
    }

    /// <summary>
    ///     Returns the limits set of this package bundle type.
    /// </summary>
    /// <see href="https://api.20i.com/package/{package_id}/bundleType/limits" />
    /// <param name="packageId">The id of the package</param>
    /// <returns>The raw json response as a string</returns>
    public async Task<string> PackageBundleTypeLimits(string packageId)
    {
        var url = _baseUrl + "package/" + packageId + "/bundleType/limits";
        var response = await _requestHandler.GetAsync(url, _bearer);
        return response;
    }

    /// <summary>
    ///     Get the password protected directories.
    /// </summary>
    /// <see href="https://api.20i.com/package/{package_id}/web/passwordProtection" />
    /// <param name="packageId">The id of the package</param>
    /// <returns>The raw json response as a string</returns>
    public async Task<string> PackageWebPasswordProtection(string packageId)
    {
        var url = _baseUrl + "package/" + packageId + "/web/passwordProtection";
        var response = await _requestHandler.GetAsync(url, _bearer);
        return response;
    }

    /// <summary>
    ///     Set the password protected directories
    /// </summary>
    /// <see href="https://api.20i.com/package/{package_id}/web/passwordProtection" />
    /// <remarks> sample body: { directories:{ directory: "string", username: "string", password: "string" } } </remarks>
    /// <param name="packageId">The id of the package</param>
    /// <param name="body">The raw json body</param>
    /// <returns>The raw json response as a string</returns>
    public async Task<string> PackageWebPasswordProtection(string packageId, string body)
    {
        var url = _baseUrl + "package/" + packageId + "/web/passwordProtection";
        var response = await _requestHandler.PostAsync(url,_bearer,body);
        return response;
    }

    /// <summary>
    ///     Get all available PHP versions.
    /// </summary>
    /// <see href="https://api.20i.com/package/{package_id}/web/availablePhpVersions" />
    /// <param name="packageId">The id of the package</param>
    /// <returns>The raw json response as a string</returns>
    public async Task<string> PackageWebAvailablePhpVersions(string packageId)
    {
        var url = _baseUrl + "package/" + packageId + "/web/availablePhpVersions";
        var response = await _requestHandler.GetAsync(url, _bearer);
        return response;
    }

    /// <summary>
    ///     Returns the PHP config for a name.
    /// </summary>
    /// <see href="https://api.20i.com/package/{package_id}/web/phpConfig/{phpconfig_id}" />
    /// <param name="packageId">The id of the package</param>
    /// <param name="phpConfigId">The id of the php config</param>
    /// <returns>The raw json response as a string</returns>
    public async Task<string> PackageWebPhpConfig(string packageId, string phpConfigId)
    {
        var url = _baseUrl + "package/" + packageId + "/web/phpConfig/" + phpConfigId;
        var response = await _requestHandler.GetAsync(url, _bearer);
        return response;
    }

    /// <summary>
    ///     Get allowed PHP configuration directives.
    /// </summary>
    /// <see href="https://api.20i.com/package/{package_id}/web/allowedPhpConfiguration" />
    /// <param name="packageId">The id of the package</param>
    /// <returns>The raw json response as a string</returns>
    public async Task<string> PackageWebAllowedPhpConfiguration(string packageId)
    {
        var url = _baseUrl + "package/" + packageId + "/web/allowedPhpConfiguration";
        var response = await _requestHandler.GetAsync(url, _bearer);
        return response;
    }

    /// <summary>
    ///     Update the PHP configuration for a name.
    /// </summary>
    /// <see href="https://api.20i.com/package/{package_id}/web/phpConfig/{phpconfig_id}/updateConfig" />
    /// <remarks> sample body: { config:{ (key): "string" } } </remarks>
    /// <param name="packageId">The id of the package</param>
    /// <param name="phpConfigId">The id of the php config</param>
    /// <param name="body">The raw json body</param>
    /// <returns>The raw json response as a string</returns>
    public async Task<string> PackageWebPhpConfigUpdateConfig(string packageId, string phpConfigId, string body)
    {
        var url = _baseUrl + "package/" + packageId + "/web/phpConfig/" + phpConfigId + "/updateConfig";
        var response = await _requestHandler.PostAsync(url,_bearer,body);
        return response;
    }

    /// <summary>
    ///     Get the PHP version for the site.
    /// </summary>
    /// <see href="https://api.20i.com/package/{package_id}/web/phpVersion" />
    /// <param name="packageId">The id of the package</param>
    /// <returns>The raw json response as a string</returns>
    public async Task<string> PackageWebPhpVersion(string packageId)
    {
        var url = _baseUrl + "package/" + packageId + "/web/phpVersion";
        var response = await _requestHandler.GetAsync(url, _bearer);
        return response;
    }

    /// <summary>
    ///     Set the PHP version for the site.
    /// </summary>
    /// <see href="https://api.20i.com/package/{package_id}/web/phpVersion" />
    /// <remarks> sample body: { value:"string"} </remarks>
    /// <param name="packageId">The id of the package</param>
    /// <param name="body">The raw json body</param>
    /// <returns>The raw json response as a string</returns>
    public async Task<string> PackageWebPhpVersion(string packageId, string body)
    {
        var url = _baseUrl + "package/" + packageId + "/web/phpVersion";
        var response = await _requestHandler.PostAsync(url,_bearer,body);
        return response;
    }

    /// <summary>
    ///     Returns a list of redirects for the site.
    /// </summary>
    /// <see href="https://api.20i.com/package/{package_id}/web/redirects" />
    /// <param name="packageId">The id of the package</param>
    /// <returns>The raw json response as a string</returns>
    public async Task<string> PackageWebRedirects(string packageId)
    {
        var url = _baseUrl + "package/" + packageId + "/web/redirects";
        var response = await _requestHandler.GetAsync(url, _bearer);
        return response;
    }

    /// <summary>
    ///     Set the website redirects.
    /// </summary>
    /// <see href="https://api.20i.com/package/{package_id}/web/redirects" />
    /// <remarks> sample body:{ redirects:{ domain: "string", from: "string", to: "string", type: "string" } }</remarks>
    /// <param name="packageId">The id of the package</param>
    /// <param name="body">The raw json body</param>
    /// <returns>The raw json response as a string</returns>
    public async Task<string> PackageWebRedirects(string packageId, string body)
    {
        var url = _baseUrl + "package/" + packageId + "/web/redirects";
        var response = await _requestHandler.PostAsync(url,_bearer,body);
        return response;
    }

    /// <summary>
    ///     Returns the expiry date at the registry.
    ///     This does not necessarily indicate the payment status of the domain nor does it reflect when renewal will occur.
    ///     It is possible for this to return null, eg. for an incomplete transfer or a deleted domain.
    /// </summary>
    /// <see href="https://api.20i.com/package/{package_id}/domain/{domain_id}/upstreamExpiryDate" />
    /// <param name="packageId">The id of the package</param>
    /// <param name="domainId">The id of the domain</param>
    /// <returns>The raw json response as a string</returns>
    public async Task<string> PackageDomainUpstreamExpiryDate(string packageId, string domainId)
    {
        var url = _baseUrl + "package/" + packageId + "/domain/" + domainId + "/upstreamExpiryDate";
        var response = await _requestHandler.GetAsync(url, _bearer);
        return response;
    }

    /// <summary>
    ///     Restore a backup file which has been uploaded via FTP
    /// </summary>
    /// <see href="https://api.20i.com/package/{package_id}/web/restoreWebsiteBackup" />
    /// <remarks> sample body: { filename: "string", restore_type: "string", restore_databases: true }</remarks>
    /// <param name="packageId">The id of the package</param>
    /// <param name="body">The raw json body</param>
    /// <returns>The raw json response as a string</returns>
    public async Task<string> PackageWebRestoreWebsiteBackup(string packageId, string body)
    {
        var url = _baseUrl + "package/" + packageId + "/web/restoreWebsiteBackup";
        var response = await _requestHandler.PostAsync(url,_bearer,body);
        return response;
    }

    /// <summary>
    ///     Returns an array of currently configured cron tasks.
    /// </summary>
    /// <see href="https://api.20i.com/package/{package_id}/web/tasks" />
    /// <param name="packageId">The id of the package</param>
    /// <returns>The raw json response as a string</returns>
    public async Task<string> PackageWebTasks(string packageId)
    {
        var url = _baseUrl + "package/" + packageId + "/web/tasks";
        var response = await _requestHandler.GetAsync(url, _bearer);
        return response;
    }

    /// <summary>
    ///     Update, create or delete cron task.
    /// </summary>
    /// <see href="https://api.20i.com/package/{package_id}/web/tasks" />
    /// <remarks>
    ///     sample body: { new:{ task:{ Enabled: true, MailTo: "string", TimeSpec: "string", Command: "string" } },
    ///     delete:{ task:{ id: ["string"] } }, update:{ task:{ id: "string", Enabled: true, MailTo: "string", TimeSpec:
    ///     "string", Command: "string" } } }
    /// </remarks>
    /// <param name="packageId">The id of the package</param>
    /// <param name="body">The raw json body</param>
    /// <returns>The raw json response as a string</returns>
    public async Task<string> PackageWebTasks(string packageId, string body)
    {
        var url = _baseUrl + "package/" + packageId + "/web/tasks";
        var response = await _requestHandler.PostAsync(url,_bearer,body);
        return response;
    }

    /// <summary>
    ///     Test a cron task.
    /// </summary>
    /// <see href="https://api.20i.com/package/{package_id}/web/testCronTask" />
    /// <remarks> sample body: { task:"string" } </remarks>
    /// <param name="packageId">The id of the package</param>
    /// <param name="body">The raw json body</param>
    /// <returns>The raw json response as a string</returns>
    public async Task<string> PackageWebTestCronTask(string packageId, string body)
    {
        var url = _baseUrl + "package/" + packageId + "/web/testCronTask";
        var response = await _requestHandler.PostAsync(url,_bearer,body);
        return response;
    }

    /// <summary>
    ///     Returns the limits for the session. If the user is a super user then they are exempt from explicit limit
    ///     restrictions.
    /// </summary>
    /// <see href="https://api.20i.com/package/{package_id}/domain/{domain_id}/sessionlimits" />
    /// <param name="packageId">The id of the package</param>
    /// <param name="domainId">The id of the domain</param>
    /// <returns>The raw json response as a string</returns>
    public async Task<string> PackageDomainSessionlimits(string packageId, string domainId)
    {
        var url = _baseUrl + "package/" + packageId + "/domain/" + domainId + "/sessionlimits";
        var response = await _requestHandler.GetAsync(url, _bearer);
        return response;
    }

    /// <summary>
    ///     Returns the limits for the session. If the user is a super user then they are exempt from explicit limit
    ///     restrictions.
    /// </summary>
    /// <see href="https://api.20i.com/package/{package_id}/sessionlimits" />
    /// <param name="packageId">The id of the package</param>
    /// <returns>The raw json response as a string</returns>
    public async Task<string> PackageSessionlimits(string packageId)
    {
        var url = _baseUrl + "package/" + packageId + "/sessionlimits";
        var response = await _requestHandler.GetAsync(url, _bearer);
        return response;
    }

    /// <summary>
    ///     Add or Remove a label for this domain
    /// </summary>
    /// <see href="https://api.20i.com/package/{package_id}/domain/{domain_id}/labels" />
    /// <remarks> sample body: { label: "string", type: "string" } </remarks>
    /// <param name="packageId">The id of the package</param>
    /// <param name="domainId">The id of the domain</param>
    /// <param name="body">The raw json body</param>
    /// <returns>The raw json response as a string</returns>
    public async Task<string> PackageDomainLabels(string packageId, string domainId, string body)
    {
        var url = _baseUrl + "package/" + packageId + "/domain/" + domainId + "/labels";
        var response = await _requestHandler.PostAsync(url,_bearer,body);
        return response;
    }

    /// <summary>
    ///     Get the sitemap jobs, only returls a single jobs (last returned from platform)
    /// </summary>
    /// <see href="https://api.20i.com/package/{package_id}/web/sitemap" />
    /// <param name="packageId">The id of the package</param>
    /// <returns>The raw json response as a string</returns>
    public async Task<string> PackageWebSitemap(string packageId)
    {
        var url = _baseUrl + "package/" + packageId + "/web/sitemap";
        var response = await _requestHandler.GetAsync(url, _bearer);
        return response;
    }

    /// <summary>
    ///     Start a sitemap job.
    /// </summary>
    /// <see href="https://api.20i.com/package/{package_id}/web/sitemap" />
    /// <param name="packageId">The id of the package</param>
    /// <returns>The raw json response as a string</returns>
    /// <remarks> sample body: { } </remarks>
    public async Task<string> PackageWebSitemapStart(string packageId)
    {
        var url = _baseUrl + "package/" + packageId + "/web/sitemap";
        var response = await _requestHandler.PostAsync(url, "{}", _bearer);
        return response;
    }

    /// <summary>
    ///     Re-install from platform. This will re-install software in the hosting space.
    ///     EG wordpress package types will re-install wordpress
    /// </summary>
    /// <see href="https://api.20i.com/package/{package_id}/web/reinstall" />
    /// <param name="packageId">The id of the package</param>
    /// <returns>The raw json response as a string</returns>
    public async Task<string> PackageWebReinstall(string packageId)
    {
        var url = _baseUrl + "package/" + packageId + "/web/reinstall";
        var response = await _requestHandler.PostAsync(url, "{}", _bearer);
        return response;
    }

    /// <summary>
    ///     Set ssh authenticator status.
    /// </summary>
    /// <see href="https://api.20i.com/package/{package_id}/web/sshauthenticator" />
    /// <remarks> sample body: { status:"string" } </remarks>
    /// <param name="packageId">The id of the package</param>
    /// <param name="body">The raw json body</param>
    /// <returns>The raw json response as a string</returns>
    public async Task<string> PackageWebSshAuthenticator(string packageId, string body)
    {
        var url = _baseUrl + "package/" + packageId + "/web/sshauthenticator";
        var response = await _requestHandler.PostAsync(url,_bearer,body);
        return response;
    }

    /// <summary>
    ///     Get a list of SSH keys for this package.
    /// </summary>
    /// <see href="https://api.20i.com/package/{package_id}/web/sshkeys" />
    /// <param name="packageId">The id of the package</param>
    /// <returns>The raw json response as a string</returns>
    public async Task<string> PackageWebSshKeys(string packageId)
    {
        var url = _baseUrl + "package/" + packageId + "/web/sshkeys";
        var response = await _requestHandler.GetAsync(url, _bearer);
        return response;
    }

    /// <summary>
    ///     Update or add new SSH keys.
    /// </summary>
    /// <see href="https://api.20i.com/package/{package_id}/web/sshkeys" />
    /// <remarks> sample body: { add:{ key: "string", handle: "string" }, delete: ["string"] } </remarks>
    /// <param name="packageId">The id of the package</param>
    /// <param name="body">The raw json body</param>
    /// <returns>The raw json response as a string</returns>
    public async Task<string> PackageWebSshKeysUpdate(string packageId, string body)
    {
        var url = _baseUrl + "package/" + packageId + "/web/sshkeys";
        var response = await _requestHandler.PostAsync(url,_bearer,body);
        return response;
    }

    /// <summary>
    ///     Get the SSH password for this package.
    /// </summary>
    /// <see href="https://api.20i.com/package/{package_id}/web/sshpassword" />
    /// <param name="packageId">The id of the package</param>
    /// <returns>The raw json response as a string</returns>
    public async Task<string> PackageWebSshPassword(string packageId)
    {
        var url = _baseUrl + "package/" + packageId + "/web/sshpassword";
        var response = await _requestHandler.GetAsync(url, _bearer);
        return response;
    }

    /// <summary>
    ///     Set the SSH password for this package.
    /// </summary>
    /// <see href="https://api.20i.com/package/{package_id}/web/sshpassword" />
    /// <remarks> sample body: { password: "string" } </remarks>
    /// <param name="packageId">The id of the package</param>
    /// <param name="body">The raw json body</param>
    /// <returns>The raw json response as a string</returns>
    public async Task<string> PackageWebSshPasswordUpdate(string packageId, string body)
    {
        var url = _baseUrl + "package/" + packageId + "/web/sshpassword";
        var response = await _requestHandler.PostAsync(url,_bearer,body);
        return response;
    }

    /// <summary>
    ///     This will toggle the free SSL for a web name.
    ///     The lower level platform handles nameserver checks.
    /// </summary>
    /// <see href="https://api.20i.com/package/{package_id}/web/freeSSL" />
    /// <remarks> sample body: { name: "string", enabled: true } </remarks>
    /// <param name="packageId">The id of the package</param>
    /// <param name="body">The raw json body</param>
    /// <returns>The raw json response as a string</returns>
    public async Task<string> PackageWebFreeSsl(string packageId, string body)
    {
        var url = _baseUrl + "package/" + packageId + "/web/freeSSL";
        var response = await _requestHandler.PostAsync(url,_bearer,body);
        return response;
    }

    /// <summary>
    ///     Gets an array of all the certificates attached to virtual hosts on this web.
    ///     Both free and external SSLs will be retreived.
    /// </summary>
    /// <see href="https://api.20i.com/package/{package_id}/web/certificates" />
    /// <param name="packageId">The id of the package</param>
    /// <returns>The raw json response as a string</returns>
    public async Task<string> PackageWebCertificates(string packageId)
    {
        var url = _baseUrl + "package/" + packageId + "/web/certificates";
        var response = await _requestHandler.GetAsync(url, _bearer);
        return response;
    }

    /// <summary>
    ///     Remove or update certificates from the Web. Currently only remove is supported.
    /// </summary>
    /// <see href="https://api.20i.com/package/{package_id}/web/certificates" />
    /// <remarks> sample body: { delete: ["string"] } </remarks>
    /// <param name="packageId">The id of the package</param>
    /// <param name="body">The raw json body</param>
    /// <returns>The raw json response as a string</returns>
    public async Task<string> PackageWebCertificatesUpdate(string packageId, string body)
    {
        var url = _baseUrl + "package/" + packageId + "/web/certificates";
        var response = await _requestHandler.PostAsync(url,_bearer,body);
        return response;
    }

    /// <summary>
    ///     Returns whether the site has forced SSL.
    /// </summary>
    /// <see href="https://api.20i.com/package/{package_id}/web/forceSSL" />
    /// <param name="packageId">The id of the package</param>
    /// <returns>The raw json response as a string</returns>
    public async Task<string> PackageWebForceSsl(string packageId)
    {
        var url = _baseUrl + "package/" + packageId + "/web/forceSSL";
        var response = await _requestHandler.GetAsync(url, _bearer);
        return response;
    }

    /// <summary>
    ///     Sets the Force SSL flag for a site.
    /// </summary>
    /// <see href="https://api.20i.com/package/{package_id}/web/forceSSL" />
    /// <remarks> sample body: { value: true } </remarks>
    /// <param name="packageId">The id of the package</param>
    /// <param name="body">The raw json body</param>
    /// <returns>The raw json response as a string</returns>
    public async Task<string> PackageWebForceSsl(string packageId, string body)
    {
        var url = _baseUrl + "package/" + packageId + "/web/forceSSL";
        var response = await _requestHandler.PostAsync(url,_bearer,body);
        return response;
    }

    /// <summary>
    ///     Install an external SSL certificate.
    /// </summary>
    /// <see href="https://api.20i.com/package/{package_id}/web/externalSSL" />
    /// <remarks> sample body: { name: "string", certificate: "string", key: "string", ca: "string" } </remarks>
    /// <param name="packageId">The id of the package</param>
    /// <param name="body">The raw json body</param>
    /// <returns>The raw json response as a string</returns>
    public async Task<string> PackageWebExternalSsl(string packageId, string body)
    {
        var url = _baseUrl + "package/" + packageId + "/web/externalSSL";
        var response = await _requestHandler.PostAsync(url,_bearer,body);
        return response;
    }

    /// <summary>
    ///     Get stack cache settings
    /// </summary>
    /// <see href="https://api.20i.com/package/{package_id}/web/stackCache" />
    /// <param name="packageId">The id of the package</param>
    /// <returns>The raw json response as a string</returns>
    public async Task<string> PackageWebStackCache(string packageId)
    {
        var url = _baseUrl + "package/" + packageId + "/web/stackCache";
        var response = await _requestHandler.GetAsync(url, _bearer);
        return response;
    }

    /// <summary>
    ///     Create or update stack cache settings
    /// </summary>
    /// <see href="https://api.20i.com/package/{package_id}/web/stackCache" />
    /// <remarks> sample body: { css: "string", images: "string", javascript: "string" } </remarks>
    /// <param name="packageId">The id of the package</param>
    /// <param name="body">The raw json body</param>
    /// <returns>The raw json response as a string</returns>
    public async Task<string> PackageWebStackCache(string packageId, string body)
    {
        var url = _baseUrl + "package/" + packageId + "/web/stackCache";
        var response = await _requestHandler.PostAsync(url,_bearer,body);
        return response;
    }

    /// <summary>
    ///     Returns the list of subdomain names mapped to their document roots.
    /// </summary>
    /// <see href="https://api.20i.com/package/{package_id}/web/subdomains" />
    /// <param name="packageId">The id of the package</param>
    /// <returns>The raw json response as a string</returns>
    public async Task<string> PackageWebSubdomains(string packageId)
    {
        var url = _baseUrl + "package/" + packageId + "/web/subdomains";
        var response = await _requestHandler.GetAsync(url, _bearer);
        return response;
    }

    /// <summary>
    ///     This does the same as POSTing to /names except that it enforces the subdomain limit and disallows non-subdomains.
    /// </summary>
    /// <see href="https://api.20i.com/package/{package_id}/web/subdomains" />
    /// <remarks> sample body: { add: ["string"], rem: ["string"] } </remarks>
    /// <param name="packageId">The id of the package</param>
    /// <param name="body">The raw json body</param>
    /// <returns>The raw json response as a string</returns>
    public async Task<string> PackageWebSubdomains(string packageId, string body)
    {
        var url = _baseUrl + "package/" + packageId + "/web/subdomains";
        var response = await _requestHandler.PostAsync(url,_bearer,body);
        return response;
    }

    /// <summary>
    ///     Cancel an incoming transfer. If successful, this will also refund to balance.
    /// </summary>
    /// <see href="https://api.20i.com/package/{package_id}/domain/{domain_id}/cancelTransfer" />
    /// <param name="packageId">The id of the package</param>
    /// <param name="domainId">The id of the domain</param>
    /// <returns>The raw json response as a string</returns>
    public async Task<string> PackageDomainCancelTransfer(string packageId, string domainId)
    {
        var url = _baseUrl + "package/" + packageId + "/domain/" + domainId + "/cancelTransfer";
        var response = await _requestHandler.PostAsync(url, _bearer, _bearer);
        return response;
    }

    /// <summary>
    ///     Change the IPS-tag for a domain.
    ///     Applicable to UK domains only.
    ///     If this operation succeeds, the domain will no longer be controllable.
    /// </summary>
    /// <see href="https://api.20i.com/package/{package_id}/domain/{domain_id}/tag" />
    /// <param name="packageId">The id of the package</param>
    /// <param name="domainId">The id of the domain</param>
    /// <remarks> body: {new-tag:"string"} </remarks>
    /// <returns>The raw json response as a string</returns>
    public async Task<string> PackageDomainTag(string packageId, string domainId)
    {
        var url = _baseUrl + "package/" + packageId + "/domain/" + domainId + "/tag";
        var response = await _requestHandler.PostAsync(url, _bearer, _bearer);
        return response;
    }

    /// <summary>
    ///     Returns the domain's EPP auth code, as needed for outbound transfers in some circumstances.
    ///     This MAY issue a new authcode, so it's not suitable to call if you're caching an older copy of the authcode,
    ///     and it's inadvisable to access this while a transfer is in progress.
    /// </summary>
    /// <see href="https://api.20i.com/package/{package_id}/domain/{domain_id}/authcode" />
    /// <param name="packageId">The id of the package</param>
    /// <param name="domainId">The id of the domain</param>
    /// <returns>The raw json response as a string</returns>
    public async Task<string> PackageDomainAuthcode(string packageId, string domainId)
    {
        var url = _baseUrl + "package/" + packageId + "/domain/" + domainId + "/authcode";
        var response = await _requestHandler.GetAsync(url, _bearer);
        return response;
    }

    /// <summary>
    ///     Returns information about the pending transfer (if any).
    /// </summary>
    /// <see href="https://api.20i.com/package/{package_id}/domain/{domain_id}/transferinfo" />
    /// <param name="packageId">The id of the package</param>
    /// <param name="domainId">The id of the domain</param>
    /// <returns>The raw json response as a string</returns>
    public async Task<string> PackageDomainTransferInfo(string packageId, string domainId)
    {
        var url = _baseUrl + "package/" + packageId + "/domain/" + domainId + "/transferinfo";
        var response = await _requestHandler.GetAsync(url, _bearer);
        return response;
    }

    /// <summary>
    ///     Get the flag allowing or disallowing transfers.
    /// </summary>
    /// <see href="https://api.20i.com/package/{package_id}/domain/{domain_id}/canTransfer" />
    /// <param name="packageId">The id of the package</param>
    /// <param name="domainId">The id of the domain</param>
    /// <returns>The raw json response as a string</returns>
    public async Task<string> PackageDomainCanTransfer(string packageId, string domainId)
    {
        var url = _baseUrl + "package/" + packageId + "/domain/" + domainId + "/canTransfer";
        var response = await _requestHandler.GetAsync(url, _bearer);
        return response;
    }

    /// <summary>
    ///     Set the flag allowing or disallowing transfers, aka the "domain lock".
    /// </summary>
    /// <see href="https://api.20i.com/package/{package_id}/domain/{domain_id}/canTransfer" />
    /// <remarks> body: {enabled:true} </remarks>
    /// <param name="packageId">The id of the package</param>
    /// <param name="domainId">The id of the domain</param>
    /// <param name="body">The body of the request</param>
    /// <returns>The raw json response as a string</returns>
    public async Task<string> PackageDomainCanTransfer(string packageId, string domainId, string body)
    {
        var url = _baseUrl + "package/" + packageId + "/domain/" + domainId + "/canTransfer";
        var response = await _requestHandler.PostAsync(url, _bearer, body);
        return response;
    }


    /// <summary>
    ///     Modify an incoming transfer.
    /// </summary>
    /// <see href="https://api.20i.com/package/{package_id}/domain/{domain_id}/updateTransfer" />
    /// <remarks> body: { action: "string", authInfo:{ pw: "string" }, configuration:{ } } </remarks>
    /// <param name="packageId">The id of the package</param>
    /// <param name="domainId">The id of the domain</param>
    /// <param name="body">The body of the request</param>
    /// <returns>The raw json response as a string</returns>
    public async Task<string> PackageDomainUpdateTransfer(string packageId, string domainId, string body)
    {
        var url = _baseUrl + "package/" + packageId + "/domain/" + domainId + "/updateTransfer";
        var response = await _requestHandler.PostAsync(url, _bearer, body);
        return response;
    }

    /// <summary>
    ///     Resend the registrant verification email, if one applies.
    /// </summary>
    /// <see href="https://api.20i.com/package/{package_id}/domain/{domain_id}/resendVerificationEmail" />
    /// <remarks> body: { } </remarks>
    /// <param name="packageId">The id of the package</param>
    /// <param name="domainId">The id of the domain</param>
    /// <param name="body">The body of the request</param>
    /// <returns>The raw json response as a string</returns>
    public async Task<string> PackageDomainResendVerificationEmail(string packageId, string domainId, string body)
    {
        var url = _baseUrl + "package/" + packageId + "/domain/" + domainId + "/resendVerificationEmail";
        var response = await _requestHandler.PostAsync(url, _bearer, body);
        return response;
    }

    /// <summary>
    ///     Returns true if this domain is waiting for transfer completion.
    /// </summary>
    /// <see href="https://api.20i.com/package/{package_id}/domain/{domain_id}/pendingTransfer" />
    /// <param name="packageId">The id of the package</param>
    /// <param name="domainId">The id of the domain</param>
    /// <returns>The raw json response as a string</returns>
    public async Task<string> PackageDomainPendingTransfer(string packageId, string domainId)
    {
        var url = _baseUrl + "package/" + packageId + "/domain/" + domainId + "/pendingTransfer";
        var response = await _requestHandler.GetAsync(url, _bearer);
        return response;
    }

    /// <summary>
    ///     Returns the Website Builder SSO link.
    /// </summary>
    /// <see href="https://api.20i.com/package/{package_id}/web/websiteBuilderSso" />
    /// <param name="packageId">The id of the package</param>
    /// <returns>The raw json response as a string</returns>
    public async Task<string> PackageWebWebsiteBuilderSso(string packageId)
    {
        var url = _baseUrl + "package/" + packageId + "/web/websiteBuilderSso";
        var response = await _requestHandler.GetAsync(url, _bearer);
        return response;
    }

    /// <summary>
    ///     Get report details for Web disk usage.
    /// </summary>
    /// <see href="https://api.20i.com/package/{package_id}/web/diskUsage" />
    /// <remarks> body: { reportId:"string" } </remarks>
    /// <param name="packageId">The id of the package</param>
    /// <param name="body">The body of the request</param>
    /// <returns>The raw json response as a string</returns>
    public async Task<string> PackageWebDiskUsage(string packageId, string body)
    {
        var url = _baseUrl + "package/" + packageId + "/web/diskUsage";
        var response = await _requestHandler.PostAsync(url, _bearer, body);
        return response;
    }

    /// <summary>
    ///     Get the bandwidth and disk usage stats for the current package
    /// </summary>
    /// <see href="https://api.20i.com/package/{package_id}/web/usage" />
    /// <param name="packageId">The id of the package</param>
    /// <returns>The raw json response as a string</returns>
    public async Task<string> PackageWebUsage(string packageId)
    {
        var url = _baseUrl + "package/" + packageId + "/web/usage";
        var response = await _requestHandler.GetAsync(url, _bearer);
        return response;
    }

    /// <summary>
    ///     Generate a webmail single-sign-on URL
    /// </summary>
    /// <see href="https://api.20i.com/package/{package_id}/email/{mail_id}/webmail" />
    /// <remarks> body: { id: "string" } </remarks>
    /// <param name="packageId">The id of the package</param>
    /// <param name="mailId">The id of the mail</param>
    /// <param name="body">The body of the request</param>
    /// <returns>The raw json response as a string</returns>
    public async Task<string> PackageEmailWebmail(string packageId, string mailId, string body)
    {
        var url = _baseUrl + "package/" + packageId + "/email/" + mailId + "/webmail";
        var response = await _requestHandler.PostAsync(url, _bearer, body);
        return response;
    }

    /// <summary>
    ///     Sends or re-sends the welcome email
    ///     if a contact is found for a provided toAddress then it will be sent to the template data and be available in twig
    /// </summary>
    /// <see href="https://api.20i.com/package/{package_id}/sendWelcome" />
    /// <remarks> body: { toAddress: "string" } </remarks>
    /// <param name="packageId">The id of the package</param>
    /// <param name="body">The body of the request</param>
    /// <returns>The raw json response as a string</returns>
    public async Task<string> PackageSendWelcome(string packageId, string body)
    {
        var url = _baseUrl + "package/" + packageId + "/sendWelcome";
        var response = await _requestHandler.PostAsync(url, _bearer, body);
        return response;
    }

    /// <summary>
    ///     Returns the current live WHOIS text for the domain. Only works for domains registered with 20i.
    /// </summary>
    /// <see href="https://api.20i.com/package/{package_id}/domain/{domain_id}/whois" />
    /// <param name="packageId">The id of the package</param>
    /// <param name="domainId">The id of the domain</param>
    /// <returns>The raw json response as a string</returns>
    public async Task<string> PackageDomainWhois(string packageId, string domainId)
    {
        var url = _baseUrl + "package/" + packageId + "/domain/" + domainId + "/whois";
        var response = await _requestHandler.GetAsync(url, _bearer);
        return response;
    }

    /// <summary>
    ///     Recycle a Windows application pool.
    /// </summary>
    /// <see href="https://api.20i.com/package/{package_id}/web/recycleApplicationPool" />
    /// <param name="packageId">The id of the package</param>
    /// <returns>The raw json response as a string</returns>
    /// <remarks> body: {  } </remarks>
    public async Task<string> PackageWebRecycleApplicationPool(string packageId)
    {
        var url = _baseUrl + "package/" + packageId + "/web/recycleApplicationPool";
        var response = await _requestHandler.PostAsync(url, _bearer, "{}");
        return response;
    }

    /// <summary>
    ///     Get the existing Windows configuration.
    /// </summary>
    /// <see href="https://api.20i.com/package/{package_id}/web/windowsConfiguration" />
    /// <param name="packageId">The id of the package</param>
    /// <returns>The raw json response as a string</returns>
    public async Task<string> PackageWebWindowsConfiguration(string packageId)
    {
        var url = _baseUrl + "package/" + packageId + "/web/windowsConfiguration";
        var response = await _requestHandler.GetAsync(url, _bearer);
        return response;
    }

    /// <summary>
    ///     Update the Windows application pool configuration.
    ///     For example; the runtime version, and the pipeline mode type.
    /// </summary>
    /// <see href="https://api.20i.com/package/{package_id}/web/windowsConfiguration" />
    /// <remarks> sample body: { ApplicationPoolPipelineMode: "string", ApplicationPoolRuntimeVersion: "string" } </remarks>
    /// <param name="packageId">The id of the package</param>
    /// <param name="body">The body of the request</param>
    /// <returns>The raw json response as a string</returns>
    public async Task<string> PackageWebWindowsConfiguration(string packageId, string body)
    {
        var url = _baseUrl + "package/" + packageId + "/web/windowsConfiguration";
        var response = await _requestHandler.PostAsync(url, _bearer, body);
        return response;
    }

    /// <summary>
    ///     Get the WordPress administrator users.
    /// </summary>
    /// <see href="https://api.20i.com/package/{package_id}/web/wordpressAdministrators" />
    /// <param name="packageId">The id of the package</param>
    /// <returns>The raw json response as a string</returns>
    public async Task<string> PackageWebWordpressAdministrators(string packageId)
    {
        var url = _baseUrl + "package/" + packageId + "/web/wordpressAdministrators";
        var response = await _requestHandler.GetAsync(url, _bearer);
        return response;
    }

    /// <summary>
    ///     Get a checksum report of WordPress core files.
    /// </summary>
    /// <see href="https://api.20i.com/package/{package_id}/web/wordpressChecksum" />
    /// <param name="packageId">The id of the package</param>
    /// <returns>The raw json response as a string</returns>
    public async Task<string> PackageWebWordpressChecksum(string packageId)
    {
        var url = _baseUrl + "package/" + packageId + "/web/wordpressChecksum";
        var response = await _requestHandler.GetAsync(url, _bearer);
        return response;
    }

    /// <summary>
    ///     Ask the platform to fix any checksum issues
    /// </summary>
    /// <see href="https://api.20i.com/package/{package_id}/web/wordpressChecksum" />
    /// <remarks> sample body: { } </remarks>
    /// <param name="packageId">The id of the package</param>
    /// <param name="body">The body of the request</param>
    /// <returns>The raw json response as a string</returns>
    public async Task<string> PackageWebWordpressChecksum(string packageId, string body)
    {
        var url = _baseUrl + "package/" + packageId + "/web/wordpressChecksum";
        var response = await _requestHandler.PostAsync(url, _bearer, body);
        return response;
    }

    /// <summary>
    ///     Returns a boolean denoting the result of the wordpress database check.
    /// </summary>
    /// <see href="https://api.20i.com/package/{package_id}/web/wordpressDbCheck" />
    /// <param name="packageId">The id of the package</param>
    /// <returns>The raw json response as a string</returns>
    public async Task<string> PackageWebWordpressDbCheck(string packageId)
    {
        var url = _baseUrl + "package/" + packageId + "/web/wordpressDbCheck";
        var response = await _requestHandler.GetAsync(url, _bearer);
        return response;
    }

    /// <summary>
    ///     Install the StackCache plugin for this package.
    /// </summary>
    /// <see href="https://api.20i.com/package/{package_id}/web/wordpressInstallStackCache" />
    /// <remarks> sample body: { } </remarks>
    /// <param name="packageId">The id of the package</param>
    /// <param name="body">The body of the request</param>
    /// <returns>The raw json response as a string</returns>
    public async Task<string> PackageWebWordpressInstallStackCache(string packageId, string body)
    {
        var url = _baseUrl + "package/" + packageId + "/web/wordpressInstallStackCache";
        var response = await _requestHandler.PostAsync(url, _bearer, body);
        return response;
    }

    /// <summary>
    ///     Checks whether or not WordPress is currently installed.
    /// </summary>
    /// <see href="https://api.20i.com/package/{package_id}/web/wordpressIsInstalled" />
    /// <param name="packageId">The id of the package</param>
    /// <returns>The raw json response as a string</returns>
    public async Task<string> PackageWebWordpressIsInstalled(string packageId)
    {
        var url = _baseUrl + "package/" + packageId + "/web/wordpressIsInstalled";
        var response = await _requestHandler.GetAsync(url, _bearer);
        return response;
    }

    /// <summary>
    ///     Returns an array of Installed wordpress plugins.
    /// </summary>
    /// <see href="https://api.20i.com/package/{package_id}/web/wordpressPlugins" />
    /// <param name="packageId">The id of the package</param>
    /// <returns>The raw json response as a string</returns>
    public async Task<string> PackageWebWordpressPlugins(string packageId)
    {
        var url = _baseUrl + "package/" + packageId + "/web/wordpressPlugins";
        var response = await _requestHandler.GetAsync(url, _bearer);
        return response;
    }

    /// <summary>
    ///     Set status or remove a WordPress plugin.
    /// </summary>
    /// <see href="https://api.20i.com/package/{package_id}/web/wordpressPlugins" />
    /// <remarks> sample body: { type: "string", name: "string" } </remarks>
    /// <param name="packageId">The id of the package</param>
    /// <param name="body">The body of the request</param>
    /// <returns>The raw json response as a string</returns>
    public async Task<string> PackageWebWordpressPlugins(string packageId, string body)
    {
        var url = _baseUrl + "package/" + packageId + "/web/wordpressPlugins";
        var response = await _requestHandler.PostAsync(url, _bearer, body);
        return response;
    }

    /// <summary>
    ///     Get the WordPress roles.
    /// </summary>
    /// <see href="https://api.20i.com/package/{package_id}/web/wordpressRoles" />
    /// <param name="packageId">The id of the package</param>
    /// <returns>The raw json response as a string</returns>
    public async Task<string> PackageWebWordpressRoles(string packageId)
    {
        var url = _baseUrl + "package/" + packageId + "/web/wordpressRoles";
        var response = await _requestHandler.GetAsync(url, _bearer);
        return response;
    }

    /// <summary>
    ///     Perform a WordPress search and replace.
    /// </summary>
    /// <see href="https://api.20i.com/package/{package_id}/web/wordpressSearchReplace" />
    /// <remarks> body { search: "string", replace: "string" } </remarks>
    /// <param name="packageId">The id of the package</param>
    /// <param name="body">The body of the request</param>
    /// <returns>The raw json response as a string</returns>
    public async Task<string> PackageWebWordpressSearchReplace(string packageId, string body)
    {
        var url = _baseUrl + "package/" + packageId + "/web/wordpressSearchReplace";
        var response = await _requestHandler.PostAsync(url, _bearer, body);
        return response;
    }

    /// <summary>
    ///     Get the WordPress site settings
    /// </summary>
    /// <see href="https://api.20i.com/package/{package_id}/web/wordpressSettings" />
    /// <param name="packageId">The id of the package</param>
    /// <returns>The raw json response as a string</returns>
    public async Task<string> PackageWebWordpressSettings(string packageId)
    {
        var url = _baseUrl + "package/" + packageId + "/web/wordpressSettings";
        var response = await _requestHandler.GetAsync(url, _bearer);
        return response;
    }

    /// <summary>
    ///     Set a WordPress site setting
    /// </summary>
    /// <see href="https://api.20i.com/package/{package_id}/web/wordpressSettings" />
    /// <remarks> sample body: { option_name: "string", option_value: "string" } </remarks>
    /// <param name="packageId">The id of the package</param>
    /// <param name="body">The body of the request</param>
    /// <returns>The raw json response as a string</returns>
    public async Task<string> PackageWebWordpressSettings(string packageId, string body)
    {
        var url = _baseUrl + "package/" + packageId + "/web/wordpressSettings";
        var response = await _requestHandler.PostAsync(url, _bearer, body);
        return response;
    }

    /// <summary>
    ///     Remove a staging clone by id
    /// </summary>
    /// <see href="https://api.20i.com/package/{package_id}/web/wordpressStagingRemoveClone" />
    /// <remarks> sample body: { id: 1 } </remarks>
    /// <param name="packageId">The id of the package</param>
    /// <param name="body">The body of the request</param>
    /// <returns>The raw json response as a string</returns>
    public async Task<string> PackageWebWordpressStagingRemoveClone(string packageId, string body)
    {
        var url = _baseUrl + "package/" + packageId + "/web/wordpressStagingRemoveClone";
        var response = await _requestHandler.PostAsync(url, _bearer, body);
        return response;
    }

    /// <summary>
    ///     Returns a result based on whether the staging version is in place.
    /// </summary>
    /// <see href="https://api.20i.com/package/{package_id}/web/wordpressStaging" />
    /// <param name="packageId">The id of the package</param>
    /// <returns>The raw json response as a string</returns>
    public async Task<string> PackageWebWordpressStaging(string packageId)
    {
        var url = _baseUrl + "package/" + packageId + "/web/wordpressStaging";
        var response = await _requestHandler.GetAsync(url, _bearer);
        return response;
    }

    /// <summary>
    ///     Clone a new WordPress site either from live to staging or from staging to live.
    /// </summary>
    /// <see href="https://api.20i.com/package/{package_id}/web/wordpressStaging" />
    /// <remarks> sample body: { type:"string" } </remarks>
    /// <param name="packageId">The id of the package</param>
    /// <param name="body">The body of the request</param>
    /// <returns>The raw json response as a string</returns>
    public async Task<string> PackageWebWordpressStaging(string packageId, string body)
    {
        var url = _baseUrl + "package/" + packageId + "/web/wordpressStaging";
        var response = await _requestHandler.PostAsync(url, _bearer, body);
        return response;
    }

    /// <summary>
    ///     Returns an array of the installed WordPress themes.
    /// </summary>
    /// <see href="https://api.20i.com/package/{package_id}/web/wordpressThemes" />
    /// <param name="packageId">The id of the package</param>
    /// <returns>The raw json response as a string</returns>
    public async Task<string> PackageWebWordpressThemes(string packageId)
    {
        var url = _baseUrl + "package/" + packageId + "/web/wordpressThemes";
        var response = await _requestHandler.GetAsync(url, _bearer);
        return response;
    }

    /// <summary>
    ///     Set status (i.e. activate/deactivate) or remove a WordPress theme.
    /// </summary>
    /// <see href="https://api.20i.com/package/{package_id}/web/wordpressTheme" />
    /// <remarks> sample body: { type: "string", name: "string" } </remarks>
    /// <param name="packageId">The id of the package</param>
    /// <param name="body">The body of the request</param>
    /// <returns>The raw json response as a string</returns>
    public async Task<string> PackageWebWordpressTheme(string packageId, string body)
    {
        var url = _baseUrl + "package/" + packageId + "/web/wordpressTheme";
        var response = await _requestHandler.PostAsync(url, _bearer, body);
        return response;
    }

    /// <summary>
    ///     Update WordPress to the latest version.
    /// </summary>
    /// <see href="https://api.20i.com/package/{package_id}/web/wordpressUpdate" />
    /// <remarks> sample body: {  } </remarks>
    /// <param name="packageId">The id of the package</param>
    /// <param name="body">The body of the request</param>
    /// <returns>The raw json response as a string</returns>
    public async Task<string> PackageWebWordpressUpdate(string packageId, string body)
    {
        var url = _baseUrl + "package/" + packageId + "/web/wordpressUpdate";
        var response = await _requestHandler.PostAsync(url, _bearer, body);
        return response;
    }

    /// <summary>
    ///     Get Wordpress Users
    /// </summary>
    /// <see href="https://api.20i.com/package/{package_id}/web/wordpressUsers" />
    /// <param name="packageId">The id of the package</param>
    /// <returns>The raw json response as a string</returns>
    public async Task<string> PackageWebWordpressUsers(string packageId)
    {
        var url = _baseUrl + "package/" + packageId + "/web/wordpressUsers";
        var response = await _requestHandler.GetAsync(url, _bearer);
        return response;
    }

    /// <summary>
    ///     Get the WordPress version if installed.
    /// </summary>
    /// <see href="https://api.20i.com/package/{package_id}/web/wordpressVersion" />
    /// <param name="packageId">The id of the package</param>
    /// <returns>The raw json response as a string</returns>
    public async Task<string> PackageWebWordpressVersion(string packageId)
    {
        var url = _baseUrl + "package/" + packageId + "/web/wordpressVersion";
        var response = await _requestHandler.GetAsync(url, _bearer);
        return response;
    }

    #endregion

    #region Reseller

    /// <summary>
    ///     Transfer a domain name.
    ///     This will charge the appropriate transfer fee to your 20i Balance.
    ///     If you don't have enough left, this will fail.
    ///     If you enable privacy you will also be charged a fee for the privacy service.
    ///     This will return true if the transfer purchase was accepted.
    ///     This doesn't guarantee that the transfer will succeed.
    ///     Please note you can also just use contract#add, this method only does a simple reformatting to use that.
    ///     Please see the documentation there for details.
    /// </summary>
    /// <see href="https://api.20i.com/reseller/{reseller_id}/transferDomain" />
    /// <remarks>
    ///     sample body: { name: "string", years: 1, contact:{ organisation: "string", name: "string", address: "string",
    ///     telephone: "string", email: "string", cc: "string", pc: "string", sp: "string", city: "string", extension:{ } },
    ///     emulateYears: true, otherContacts:{ (type):{ name: "string", organisation: "string", address: "string", city:
    ///     "string", sp: "string", pc: "string", cc: "string", telephone: "string", email: "string", extension:{ } } },
    ///     authcode: "string", limits:{ }, nameservers: ["string"], privacyService: true, stackUser: "string" }
    /// </remarks>
    /// <param name="resellerId">The id of the reseller</param>
    /// <param name="body">The body of the request</param>
    /// <returns>The raw json response as a string</returns>
    public async Task<string> ResellerTransferDomain(string resellerId, string body)
    {
        var url = _baseUrl + "reseller/" + resellerId + "/transferDomain";
        var response = await _requestHandler.PostAsync(url, _bearer, body);
        return response;
    }

    /// <summary>
    ///     Get the password reset email template (or the default value)
    /// </summary>
    /// <see href="https://api.20i.com/reseller/{reseller_id}/passwordResetEmail" />
    /// <param name="resellerId">The id of the reseller</param>
    /// <returns>The raw json response as a string</returns>
    public async Task<string> ResellerPasswordResetEmail(string resellerId)
    {
        var url = _baseUrl + "reseller/" + resellerId + "/passwordResetEmail";
        var response = await _requestHandler.GetAsync(url, _bearer);
        return response;
    }

    /// <summary>
    ///     Set the password reset email.
    /// </summary>
    /// <see href="https://api.20i.com/reseller/{reseller_id}/passwordResetEmail" />
    /// <remarks> sample body: { content: "string" } </remarks>
    /// <param name="resellerId">The id of the reseller</param>
    /// <param name="body">The body of the request</param>
    /// <returns>The raw json response as a string</returns>
    public async Task<string> ResellerPasswordResetEmail(string resellerId, string body)
    {
        var url = _baseUrl + "reseller/" + resellerId + "/passwordResetEmail";
        var response = await _requestHandler.PostAsync(url, _bearer, body);
        return response;
    }

    /// <summary>
    ///     Mailbox quota addons Returns a short, cheap list items.
    /// </summary>
    /// <see href="https://api.20i.com/reseller/{reseller_id}/mailbox_quota_addon" />
    /// <param name="resellerId">The id of the reseller</param>
    /// <returns>The raw json response as a string</returns>
    public async Task<string> ResellerMailboxQuotaAddon(string resellerId)
    {
        var url = _baseUrl + "reseller/" + resellerId + "/mailbox_quota_addon";
        var response = await _requestHandler.GetAsync(url, _bearer);
        return response;
    }

    /// <summary>
    ///     List Virtual Nameservers
    /// </summary>
    /// <see href="https://api.20i.com/personal_nameserver" />
    /// <param name="resellerId">The id of the reseller</param>
    /// <returns>The raw json response as a string</returns>
    public async Task<string> PersonalNameserver(string resellerId)
    {
        var url = _baseUrl + "personal_nameserver";
        var response = await _requestHandler.GetAsync(url, _bearer);
        return response;
    }

    /// <summary>
    ///     Renew an MSSQL database with the provided ID
    /// </summary>
    /// <see href="https://api.20i.com/reseller/{reseller_id}/renewMssqlPre" />
    /// <remarks> sample body: { id: "string" } </remarks>
    /// <param name="resellerId">The id of the reseller</param>
    /// <param name="body">The body of the request</param>
    /// <returns>The raw json response as a string</returns>
    public async Task<string> ResellerRenewMssqlPre(string resellerId, string body)
    {
        var url = _baseUrl + "reseller/" + resellerId + "/renewMssqlPre";
        var response = await _requestHandler.PostAsync(url, _bearer, body);
        return response;
    }

    /// <summary>
    ///     Get existing multisite backups.
    /// </summary>
    /// <see href="https://api.20i.com/reseller/{reseller_id}/backupBulkPackages" />
    /// <param name="resellerId">The id of the reseller</param>
    /// <returns>The raw json response as a string</returns>
    public async Task<string> ResellerBackupBulkPackages(string resellerId)
    {
        var url = _baseUrl + "reseller/" + resellerId + "/backupBulkPackages";
        var response = await _requestHandler.GetAsync(url, _bearer);
        return response;
    }

    /// <summary>
    ///     Backup Multiple packages
    /// </summary>
    /// <see href="https://api.20i.com/reseller/{reseller_id}/backupBulkPackages" />
    /// <remarks> sample body:{ id: ["string"], delete: true } </remarks>
    /// <param name="resellerId">The id of the reseller</param>
    /// <param name="body">The body of the request</param>
    /// <returns>The raw json response as a string</returns>
    public async Task<string> ResellerBackupBulkPackages(string resellerId, string body)
    {
        var url = _baseUrl + "reseller/" + resellerId + "/backupBulkPackages";
        var response = await _requestHandler.PostAsync(url, _bearer, body);
        return response;
    }

    /// <summary>
    ///     Fetch your current Nominet brand settings
    /// </summary>
    /// <see href="https://api.20i.com/reseller/{reseller_id}/nominetBrand" />
    /// <param name="resellerId">The id of the reseller</param>
    /// <returns>The raw json response as a string</returns>
    public async Task<string> ResellerNominetBrand(string resellerId)
    {
        var url = _baseUrl + "reseller/" + resellerId + "/nominetBrand";
        var response = await _requestHandler.GetAsync(url, _bearer);
        return response;
    }

    /// <summary>
    ///     Set Nominet reseller settings
    /// </summary>
    /// <see href="https://api.20i.com/reseller/{reseller_id}/nominetBrand" />
    /// <remarks>
    ///     body { nominetReseller: "string", ukResellerEmail: "string", ukResellerTradingName: "string", ukResellerUrl:
    ///     "string", ukResellerVoice: "string" }
    /// </remarks>
    /// <param name="resellerId">The id of the reseller</param>
    /// <param name="body">The body of the request</param>
    /// <returns>The raw json response as a string</returns>
    public async Task<string> ResellerNominetBrand(string resellerId, string body)
    {
        var url = _baseUrl + "reseller/" + resellerId + "/nominetBrand";
        var response = await _requestHandler.PostAsync(url, _bearer, body);
        return response;
    }

    /// <summary>
    ///     Register a domain name.
    ///     This will charge the appropriate registration fee to your 20i Balance.
    ///     If you don't have enough left, this will fail.
    ///     If you enable privacy you will also be charged a fee for the privacy service.
    ///     Please note you can also just use contract#add, this method only does a simple reformatting to use that.
    ///     Please see the documentation there for details.
    /// </summary>
    /// <see href="https://api.20i.com/reseller/{reseller_id}/addDomain" />
    /// <remarks>
    ///     body: { name: "string", years: 1, caRegistryAgreement: true, contact:{ organisation: "string", name:
    ///     "string", address: "string", telephone: "string", email: "string", cc: "string", pc: "string", sp: "string", city:
    ///     "string", extension:{ } }, limits:{ }, otherContacts:{ (type):{ name: "string", organisation: "string", address:
    ///     "string", city: "string", sp: "string", pc: "string", cc: "string", telephone: "string", email: "string",
    ///     extension:{ } } }, nameservers: ["string"], privacyService: true, stackUser: "string" }
    /// </remarks>
    /// <param name="resellerId">The id of the reseller</param>
    /// <param name="body">The body of the request</param>
    /// <returns>The raw json response as a string</returns>
    public async Task<string> ResellerAddDomain(string resellerId, string body)
    {
        var url = _baseUrl + "reseller/" + resellerId + "/addDomain";
        var response = await _requestHandler.PostAsync(url, _bearer, body);
        return response;
    }

    /// <summary>
    ///     Add an MS SQL Server allowance.
    ///     This will charge the appropriate fee to your 20i Balance.
    ///     If you don't have enough left, this will fail.
    ///     Please note you can also use contract#add, this method only does a trivial reformatting to use that, specifically:
    ///     https://prnt.sc/RDOOsJYX-nQN
    /// </summary>
    /// <see href="https://api.20i.com/reseller/{reseller_id}/addMssql" />
    /// <param name="resellerId">The id of the reseller</param>
    /// <param name="body">The body of the request</param>
    /// <returns>The raw json response as a string</returns>
    public async Task<string> ResellerAddMssql(string resellerId, string body)
    {
        var url = _baseUrl + "reseller/" + resellerId + "/addMssql";
        var response = await _requestHandler.PostAsync(url, _bearer, body);
        return response;
    }

    /// <summary>
    ///     Order a TLS certificate for a site.
    ///     This will charge the appropriate fee to your 20i Balance. If you don't have enough left, this will fail.
    /// </summary>
    /// <see href="https://api.20i.com/reseller/{reseller_id}/addTlsCertificate" />
    /// <remarks> body { periodMonths: 1, name: "string", configuration:{ } } </remarks>
    /// <param name="resellerId">The id of the reseller</param>
    /// <param name="body">The body of the request</param>
    /// <returns>The raw json response as a string</returns>
    public async Task<string> ResellerAddTlsCertificate(string resellerId, string body)
    {
        var url = _baseUrl + "reseller/" + resellerId + "/addTlsCertificate";
        var response = await _requestHandler.PostAsync(url, _bearer, body);
        return response;
    }

    /// <summary>
    ///     Order a vps
    /// </summary>
    /// <see href="https://api.20i.com/reseller/{reseller_id}/addVPS" />
    /// <remarks>
    ///     https://prnt.sc/_6Hfr9gHcV2G body { configuration:{ ApplicationId: "string", Name: "string" }, forUser:
    ///     "string", options:{ os: "string" }, periodMonths: 1, type: "string" }
    /// </remarks>
    /// <param name="resellerId">The id of the reseller</param>
    /// <param name="body">The body of the request</param>
    /// <returns>The raw json response as a string</returns>
    public async Task<string> ResellerAddVps(string resellerId, string body)
    {
        var url = _baseUrl + "reseller/" + resellerId + "/addVPS";
        var response = await _requestHandler.PostAsync(url, _bearer, body);
        return response;
    }

    /// <summary>
    ///     Add a web site.
    ///     If a welcome email is set for the type and you pass an existing Stack user reference, the welcome email will be
    ///     sent ASAP.
    /// </summary>
    /// <see href="https://api.20i.com/reseller/{reseller_id}/addWeb" />
    /// <remarks>
    ///     body: { type: "string", domain_name: "string", extra_domain_names: ["string"], label: "string",
    ///     documentRoots:{ (domain): "string" }, stackUser: "string" }
    /// </remarks>
    /// <param name="resellerId">The id of the reseller</param>
    /// <param name="body">The body of the request</param>
    /// <returns>The raw json response as a string</returns>
    public async Task<string> ResellerAddWeb(string resellerId, string body)
    {
        var url = _baseUrl + "reseller/" + resellerId + "/addWeb";
        var response = await _requestHandler.PostAsync(url, _bearer, body);
        return response;
    }

    /// <summary>
    ///     Fetch the package branding.
    /// </summary>
    /// <see href="https://api.20i.com/reseller/{reseller_id}/packageTypeBrand" />
    /// <remarks> body: { packageid: "string" } </remarks>
    /// <param name="resellerId">The id of the reseller</param>
    /// <param name="body">The body of the request</param>
    /// <returns>The raw json response as a string</returns>
    public async Task<string> ResellerPackageTypeBrand(string resellerId, string body)
    {
        var url = _baseUrl + "reseller/" + resellerId + "/packageTypeBrand";
        var response = await _requestHandler.PostAsync(url, _bearer, body);
        return response;
    }

    /// <summary>
    ///     Returns a count of packages split by type. Current types are linux, windows and wordpress
    /// </summary>
    /// <see href="https://api.20i.com/reseller/{reseller_id}/packageCount" />
    /// <param name="resellerId">The id of the reseller</param>
    /// <returns>The raw json response as a string</returns>
    public async Task<string> ResellerPackageCount(string resellerId)
    {
        var url = _baseUrl + "reseller/" + resellerId + "/packageCount";
        var response = await _requestHandler.GetAsync(url, _bearer);
        return response;
    }

    /// <summary>
    ///     Delete the web site/packages using the array of ID's in delete-id as a list of packages to delete.
    /// </summary>
    /// <see href="https://api.20i.com/reseller/{reseller_id}/deleteWeb" />
    /// <remarks> body: { delete-id: ["string"] } </remarks>
    /// <param name="resellerId">The id of the reseller</param>
    /// <param name="body">The body of the request</param>
    /// <returns>The raw json response as a string</returns>
    public async Task<string> ResellerDeleteWeb(string resellerId, string body)
    {
        var url = _baseUrl + "reseller/" + resellerId + "/deleteWeb";
        var response = await _requestHandler.PostAsync(url, _bearer, body);
        return response;
    }

    /// <summary>
    ///     Get package type information.
    /// </summary>
    /// <see href="https://api.20i.com/reseller/{reseller_id}/packageTypes" />
    /// <param name="resellerId">The id of the reseller</param>
    /// <returns>The raw json response as a string</returns>
    public async Task<string> ResellerPackageTypes(string resellerId)
    {
        var url = _baseUrl + "reseller/" + resellerId + "/packageTypes";
        var response = await _requestHandler.GetAsync(url, _bearer);
        return response;
    }

    /// <summary>
    ///     Add a web type.
    /// </summary>
    /// <see href="https://api.20i.com/reseller/{reseller_id}/packageTypes" />
    /// <remarks>
    ///     body { label: "string", platform: "string", limit:{ }, installApps: ["string"], welcomeEmail:{ from:
    ///     "string", subject: "string", data: "string" }, passwordResetEmail: "string", defaultPages:{ IndexPageHtml:
    ///     "string", DeactivatedPageHtml: "string", ServiceUnavailablePageHtml: "string" }, extraData:{ temporaryUrlDomain:
    ///     "string" } }
    /// </remarks>
    /// <param name="resellerId">The id of the reseller</param>
    /// <param name="body">The body of the request</param>
    /// <returns>The raw json response as a string</returns>
    public async Task<string> ResellerPackageTypes(string resellerId, string body)
    {
        var url = _baseUrl + "reseller/" + resellerId + "/packageTypes";
        var response = await _requestHandler.PostAsync(url, _bearer, body);
        return response;
    }

    /// <summary>
    ///     Update web types.
    /// </summary>
    /// <see href="https://api.20i.com/reseller/{reseller_id}/updateWebType" />
    /// <remarks>
    ///     body { delete-id: ["string"], extraData:{ (id):{ temporaryUrlDomain: "string" } }, id: ["string"],
    ///     installApps:{ (type_id): ["string"] }, labels:{ }, limit:{ (type_id):{ (limit_code): true } }, platform: "string",
    ///     syncLimits:{ (type_id): true }, welcomeEmail:{ (id):{ subject: "string", from: "string", content: "string" } } }
    /// </remarks>
    /// <param name="resellerId">The id of the reseller</param>
    /// <param name="body">The body of the request</param>
    /// <returns>The raw json response as a string</returns>
    public async Task<string> ResellerUpdateWebType(string resellerId, string body)
    {
        var url = _baseUrl + "reseller/" + resellerId + "/updateWebType";
        var response = await _requestHandler.PostAsync(url, _bearer, body);
        return response;
    }

    /// <summary>
    ///     Delete web sites or update their limits or labels.
    /// </summary>
    /// <see href="https://api.20i.com/reseller/{reseller_id}/updatePackage" />
    /// <remarks>
    ///     body { billing:{ (package_id):{ date: "string", interval: 1, preferredUser: "string", } }, delete-id:
    ///     ["string"], id: ["string"], labels:{ (package_id): "string" }, limit:{ (package_id):{ (limit_code): true } },
    ///     limit-set:{ (package_id):{ (limit_code): true } }, packageBundleTypes:{ (package_id): "string" } }
    /// </remarks>
    /// <param name="resellerId">The id of the reseller</param>
    /// <param name="body">The body of the request</param>
    /// <returns>The raw json response as a string</returns>
    public async Task<string> ResellerUpdatePackage(string resellerId, string body)
    {
        var url = _baseUrl + "reseller/" + resellerId + "/updatePackage";
        var response = await _requestHandler.PostAsync(url, _bearer, body);
        return response;
    }

    /// <summary>
    ///     Sends a password reset email, given a password reset token. See passwordResetInfo on the authentication service.
    /// </summary>
    /// <see href="https://api.20i.com/reseller/{reseller_id}/resetPassword" />
    /// <param name="resellerId">The id of the reseller</param>
    /// <param name="body">The body of the request</param>
    /// <returns>The raw json response as a string</returns>
    public async Task<string> ResellerResetPassword(string resellerId, string body)
    {
        var url = _baseUrl + "reseller/" + resellerId + "/resetPassword";
        var response = await _requestHandler.PostAsync(url, _bearer, body);
        return response;
    }

    /// <summary>
    ///     Renew a domain name.
    ///     This will charge the appropriate registration fee to your 20i Balance.
    ///     If you don't have enough left, this will fail.
    ///     Please note you can also use contract/domain:{id}#renew, this method only does a trivial reformatting to use that.
    /// </summary>
    /// <see href="https://api.20i.com/reseller/{reseller_id}/renewDomain" />
    /// <remarks> body { name: "string", years: 1, renewPrivacy: true } </remarks>
    /// <param name="resellerId">The id of the reseller</param>
    /// <param name="body">The body of the request</param>
    /// <returns>The raw json response as a string</returns>
    public async Task<string> ResellerRenewDomain(string resellerId, string body)
    {
        var url = _baseUrl + "reseller/" + resellerId + "/renewDomain";
        var response = await _requestHandler.PostAsync(url, _bearer, body);
        return response;
    }

    /// <summary>
    ///     Renew the MSSQL database of the given ID This will charge the appropriate registration fee to your 20i Balance.
    ///     If you don't have enough left, this will fail.
    ///     Please note you can also use contract/mssql:{id}#renew, this method only does a trivial reformatting to use that.
    /// </summary>
    /// <see href="https://api.20i.com/reseller/{reseller_id}/renewMssql" />
    /// <remarks> body { id: "string"} </remarks>
    /// <param name="resellerId">The id of the reseller</param>
    /// <param name="body">The body of the request</param>
    /// <returns>The raw json response as a string</returns>
    public async Task<string> ResellerRenewMssql(string resellerId, string body)
    {
        var url = _baseUrl + "reseller/" + resellerId + "/renewMssql";
        var response = await _requestHandler.PostAsync(url, _bearer, body);
        return response;
    }

    /// <summary>
    ///     Renew a certificate. This will charge the appropriate fee to your 20i Balance.
    ///     If you don't have enough left, this will fail.
    ///     Please note you can also use contract/tls_certificate:{id}#renew, this method only does a trivial reformatting to
    ///     use that.
    /// </summary>
    /// <see href="https://api.20i.com/reseller/{reseller_id}/renewTlsCertificate" />
    /// <remarks> body {id: "string" , periodMonths: 1} </remarks>
    /// <param name="resellerId">The id of the reseller</param>
    /// <param name="body">The body of the request</param>
    /// <returns>The raw json response as a string</returns>
    public async Task<string> ResellerRenewTlsCertificate(string resellerId, string body)
    {
        var url = _baseUrl + "reseller/" + resellerId + "/renewTlsCertificate";
        var response = await _requestHandler.PostAsync(url, _bearer, body);
        return response;
    }

    /// <summary>
    ///     Updates the reseller
    /// </summary>
    /// <see href="https://api.20i.com/reseller/{reseller_id}" />
    /// <remarks>
    ///     body { malwareEmails: true, malwareEmailsStackCpUsers: true, migrationCompleteEmails: true,
    ///     domainAutoRenewDefault: true }
    /// </remarks>
    /// <param name="resellerId">The id of the reseller</param>
    /// <param name="body">The body of the request</param>
    /// <returns>The raw json response as a string</returns>
    public async Task<string> ResellerUpdate(string resellerId, string body)
    {
        var url = _baseUrl + "reseller/" + resellerId;
        var response = await _requestHandler.PostAsync(url, _bearer, body);
        return response;
    }

    /// <summary>
    ///     Returns your Stack user config.
    /// </summary>
    /// <see href="https://api.20i.com/reseller/{reseller_id}/susers" />
    /// <param name="resellerId">The id of the reseller</param>
    /// <returns>The raw json response as a string</returns>
    public async Task<string> ResellerSusers(string resellerId)
    {
        var url = _baseUrl + "reseller/" + resellerId + "/susers";
        var response = await _requestHandler.GetAsync(url, _bearer);
        return response;
    }

    /// <summary>
    ///     Update your Stack users.
    /// </summary>
    /// <see href="https://api.20i.com/reseller/{reseller_id}/susers" />
    /// <remarks>
    ///     body: { contact:{ (user_ref):{ person_name: "string", company_name: "string", address: "string", city:
    ///     "string", sp: "string", pc: "string", cc: "string", voice: "string", notes: "string", billing_ref: "string", email:
    ///     "string", } }, ftpLock:{ (user_ref):{ existing:{ (lock_ref):{ Ip4Address: "string", Ip6Address: "string", delete:
    ///     true } }, new:{ Ip4Address: "string", Ip6Address: "string" } } }, grant_map:{ (user_ref):{ (service_ref): true } },
    ///     masterFtpAcl:{ (user_ref):{ Ip4Address: ["string"] } }, newUser:{ person_name: "string", company_name: "string",
    ///     address: "string", city: "string", sp: "string", pc: "string", cc: "string", voice: "string", notes: "string",
    ///     billing_ref: "string", email: "string", nominet_contact_type: "string", sendNewStackUserEmail: true, }, users:{
    ///     (user_ref):{ password: "string", delete: true } }, masterFtp:{ } }
    /// </remarks>
    /// <param name="resellerId">The id of the reseller</param>
    /// <param name="body">The body of the request</param>
    /// <returns>The raw json response as a string</returns>
    public async Task<string> ResellerSusersUpdate(string resellerId, string body)
    {
        var url = _baseUrl + "reseller/" + resellerId + "/susers";
        var response = await _requestHandler.PostAsync(url, _bearer, body);
        return response;
    }

    #endregion
}