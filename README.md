# 20i API dotnet libary

![Nuget](https://img.shields.io/nuget/v/20i-api-dotnet?style=flat-square)  
#### [Nuget Gallery](https://www.nuget.org/packages/20i-api/)


#### Get started with 3 steps

1. Install Nuget package
 - ``` dotnet add package 20i-api  ```

2. Create new instance of 20i API
 - ``` var api = new TwentyIApi(bearer,new HttpClient()); ```
3. Use the API
 - ```var packages = await api.Package();```

**Note** <i>You can inject your own HttpClient to use your own implementation of HttpClient or an injected client from a factory.</i>


[Official API Documentation](https://my.20i.com/reseller/apiDoc)

## Methods

- [TwentyIApi](#T-TwentyI_dotnet-TwentyIApi 'TwentyI_dotnet.TwentyIApi')
    - [#ctor(bearer,client)](#M-TwentyI_dotnet-TwentyIApi-#ctor-System-String,System-Net-Http-HttpClient- 'TwentyI_dotnet.TwentyIApi.#ctor(System.String,System.Net.Http.HttpClient)')
    - [GetDomainPeriods()](#M-TwentyI_dotnet-TwentyIApi-GetDomainPeriods 'TwentyI_dotnet.TwentyIApi.GetDomainPeriods')
    - [GetDomainPremiumTypes()](#M-TwentyI_dotnet-TwentyIApi-GetDomainPremiumTypes 'TwentyI_dotnet.TwentyIApi.GetDomainPremiumTypes')
    - [GetDomainSearch(query)](#M-TwentyI_dotnet-TwentyIApi-GetDomainSearch-System-String- 'TwentyI_dotnet.TwentyIApi.GetDomainSearch(System.String)')
    - [GetDomains()](#M-TwentyI_dotnet-TwentyIApi-GetDomains 'TwentyI_dotnet.TwentyIApi.GetDomains')
    - [GetManagedVps(id)](#M-TwentyI_dotnet-TwentyIApi-GetManagedVps-System-String- 'TwentyI_dotnet.TwentyIApi.GetManagedVps(System.String)')
    - [GetManagedVpsList()](#M-TwentyI_dotnet-TwentyIApi-GetManagedVpsList 'TwentyI_dotnet.TwentyIApi.GetManagedVpsList')
    - [GetManagedVpsName(id)](#M-TwentyI_dotnet-TwentyIApi-GetManagedVpsName-System-String- 'TwentyI_dotnet.TwentyIApi.GetManagedVpsName(System.String)')
    - [GetManagedVpsPackageCount(id)](#M-TwentyI_dotnet-TwentyIApi-GetManagedVpsPackageCount-System-String- 'TwentyI_dotnet.TwentyIApi.GetManagedVpsPackageCount(System.String)')
    - [GetMssql()](#M-TwentyI_dotnet-TwentyIApi-GetMssql 'TwentyI_dotnet.TwentyIApi.GetMssql')
    - [GetMssqlById(id)](#M-TwentyI_dotnet-TwentyIApi-GetMssqlById-System-String- 'TwentyI_dotnet.TwentyIApi.GetMssqlById(System.String)')
    - [ManagedVpsAddWeb(id,body)](#M-TwentyI_dotnet-TwentyIApi-ManagedVpsAddWeb-System-String,System-String- 'TwentyI_dotnet.TwentyIApi.ManagedVpsAddWeb(System.String,System.String)')
    - [ManagedVpsDeleteWeb(id,body)](#M-TwentyI_dotnet-TwentyIApi-ManagedVpsDeleteWeb-System-String,System-String- 'TwentyI_dotnet.TwentyIApi.ManagedVpsDeleteWeb(System.String,System.String)')
    - [ManagedVpsSetName(id,body)](#M-TwentyI_dotnet-TwentyIApi-ManagedVpsSetName-System-String,System-String- 'TwentyI_dotnet.TwentyIApi.ManagedVpsSetName(System.String,System.String)')
    - [MssqlLinkPackage(id,body)](#M-TwentyI_dotnet-TwentyIApi-MssqlLinkPackage-System-String,System-String- 'TwentyI_dotnet.TwentyIApi.MssqlLinkPackage(System.String,System.String)')
    - [Package()](#M-TwentyI_dotnet-TwentyIApi-Package 'TwentyI_dotnet.TwentyIApi.Package')
    - [Package(packageId)](#M-TwentyI_dotnet-TwentyIApi-Package-System-String- 'TwentyI_dotnet.TwentyIApi.Package(System.String)')
    - [PackageBundleTypeLimits(packageId)](#M-TwentyI_dotnet-TwentyIApi-PackageBundleTypeLimits-System-String- 'TwentyI_dotnet.TwentyIApi.PackageBundleTypeLimits(System.String)')
    - [PackageDatabaseUser(packageId,databaseId,userId)](#M-TwentyI_dotnet-TwentyIApi-PackageDatabaseUser-System-String,System-String,System-String- 'TwentyI_dotnet.TwentyIApi.PackageDatabaseUser(System.String,System.String,System.String)')
    - [PackageDefaultDns(packageId)](#M-TwentyI_dotnet-TwentyIApi-PackageDefaultDns-System-String- 'TwentyI_dotnet.TwentyIApi.PackageDefaultDns(System.String)')
    - [PackageDomain(packageId,domainId)](#M-TwentyI_dotnet-TwentyIApi-PackageDomain-System-String,System-String- 'TwentyI_dotnet.TwentyIApi.PackageDomain(System.String,System.String)')
    - [PackageDomainAuthcode(packageId,domainId)](#M-TwentyI_dotnet-TwentyIApi-PackageDomainAuthcode-System-String,System-String- 'TwentyI_dotnet.TwentyIApi.PackageDomainAuthcode(System.String,System.String)')
    - [PackageDomainCanTransfer(packageId,domainId)](#M-TwentyI_dotnet-TwentyIApi-PackageDomainCanTransfer-System-String,System-String- 'TwentyI_dotnet.TwentyIApi.PackageDomainCanTransfer(System.String,System.String)')
    - [PackageDomainCanTransfer(packageId,domainId,body)](#M-TwentyI_dotnet-TwentyIApi-PackageDomainCanTransfer-System-String,System-String,System-String- 'TwentyI_dotnet.TwentyIApi.PackageDomainCanTransfer(System.String,System.String,System.String)')
    - [PackageDomainCancelTransfer(packageId,domainId)](#M-TwentyI_dotnet-TwentyIApi-PackageDomainCancelTransfer-System-String,System-String- 'TwentyI_dotnet.TwentyIApi.PackageDomainCancelTransfer(System.String,System.String)')
    - [PackageDomainContacts(packageId,domainId)](#M-TwentyI_dotnet-TwentyIApi-PackageDomainContacts-System-String,System-String- 'TwentyI_dotnet.TwentyIApi.PackageDomainContacts(System.String,System.String)')
    - [PackageDomainContacts(packageId,domainId,body)](#M-TwentyI_dotnet-TwentyIApi-PackageDomainContacts-System-String,System-String,System-String- 'TwentyI_dotnet.TwentyIApi.PackageDomainContacts(System.String,System.String,System.String)')
    - [PackageDomainDns(packageId,domainId)](#M-TwentyI_dotnet-TwentyIApi-PackageDomainDns-System-String,System-String- 'TwentyI_dotnet.TwentyIApi.PackageDomainDns(System.String,System.String)')
    - [PackageDomainDnsGoogleApps(packageId,domainId)](#M-TwentyI_dotnet-TwentyIApi-PackageDomainDnsGoogleApps-System-String,System-String- 'TwentyI_dotnet.TwentyIApi.PackageDomainDnsGoogleApps(System.String,System.String)')
    - [PackageDomainDnsGoogleApps(packageId,domainId,body)](#M-TwentyI_dotnet-TwentyIApi-PackageDomainDnsGoogleApps-System-String,System-String,System-Object- 'TwentyI_dotnet.TwentyIApi.PackageDomainDnsGoogleApps(System.String,System.String,System.Object)')
    - [PackageDomainDnsGoogleAppsMailOnly(packageId,domainId)](#M-TwentyI_dotnet-TwentyIApi-PackageDomainDnsGoogleAppsMailOnly-System-String,System-String- 'TwentyI_dotnet.TwentyIApi.PackageDomainDnsGoogleAppsMailOnly(System.String,System.String)')
    - [PackageDomainDnsGoogleAppsMailOnly(packageId,domainId,body)](#M-TwentyI_dotnet-TwentyIApi-PackageDomainDnsGoogleAppsMailOnly-System-String,System-String,System-Object- 'TwentyI_dotnet.TwentyIApi.PackageDomainDnsGoogleAppsMailOnly(System.String,System.String,System.Object)')
    - [PackageDomainDnsOffice365Mail(packageId,domainId)](#M-TwentyI_dotnet-TwentyIApi-PackageDomainDnsOffice365Mail-System-String,System-String- 'TwentyI_dotnet.TwentyIApi.PackageDomainDnsOffice365Mail(System.String,System.String)')
    - [PackageDomainDnsOffice365MailOnly(packageId,domainId,body)](#M-TwentyI_dotnet-TwentyIApi-PackageDomainDnsOffice365MailOnly-System-String,System-String,System-Object- 'TwentyI_dotnet.TwentyIApi.PackageDomainDnsOffice365MailOnly(System.String,System.String,System.Object)')
    - [PackageDomainDnsUpdate(packageId,domainId,body)](#M-TwentyI_dotnet-TwentyIApi-PackageDomainDnsUpdate-System-String,System-String,System-String- 'TwentyI_dotnet.TwentyIApi.PackageDomainDnsUpdate(System.String,System.String,System.String)')
    - [PackageDomainLabels(packageId,domainId,body)](#M-TwentyI_dotnet-TwentyIApi-PackageDomainLabels-System-String,System-String,System-String- 'TwentyI_dotnet.TwentyIApi.PackageDomainLabels(System.String,System.String,System.String)')
    - [PackageDomainLimits(packageId,domainId)](#M-TwentyI_dotnet-TwentyIApi-PackageDomainLimits-System-String,System-String- 'TwentyI_dotnet.TwentyIApi.PackageDomainLimits(System.String,System.String)')
    - [PackageDomainMaxNameservers(packageId,domainId)](#M-TwentyI_dotnet-TwentyIApi-PackageDomainMaxNameservers-System-String,System-String- 'TwentyI_dotnet.TwentyIApi.PackageDomainMaxNameservers(System.String,System.String)')
    - [PackageDomainNameservers(packageId,domainId)](#M-TwentyI_dotnet-TwentyIApi-PackageDomainNameservers-System-String,System-String- 'TwentyI_dotnet.TwentyIApi.PackageDomainNameservers(System.String,System.String)')
    - [PackageDomainNameservers(packageId,domainId,body)](#M-TwentyI_dotnet-TwentyIApi-PackageDomainNameservers-System-String,System-String,System-Object- 'TwentyI_dotnet.TwentyIApi.PackageDomainNameservers(System.String,System.String,System.Object)')
    - [PackageDomainOptOut(packageId,domainId)](#M-TwentyI_dotnet-TwentyIApi-PackageDomainOptOut-System-String,System-String- 'TwentyI_dotnet.TwentyIApi.PackageDomainOptOut(System.String,System.String)')
    - [PackageDomainOptOut(packageId,domainId,body)](#M-TwentyI_dotnet-TwentyIApi-PackageDomainOptOut-System-String,System-String,System-String- 'TwentyI_dotnet.TwentyIApi.PackageDomainOptOut(System.String,System.String,System.String)')
    - [PackageDomainPendingTransfer(packageId,domainId)](#M-TwentyI_dotnet-TwentyIApi-PackageDomainPendingTransfer-System-String,System-String- 'TwentyI_dotnet.TwentyIApi.PackageDomainPendingTransfer(System.String,System.String)')
    - [PackageDomainPendingTransferStatus(packageId,domainId)](#M-TwentyI_dotnet-TwentyIApi-PackageDomainPendingTransferStatus-System-String,System-String- 'TwentyI_dotnet.TwentyIApi.PackageDomainPendingTransferStatus(System.String,System.String)')
    - [PackageDomainPrivacy(packageId,domainId)](#M-TwentyI_dotnet-TwentyIApi-PackageDomainPrivacy-System-String,System-String- 'TwentyI_dotnet.TwentyIApi.PackageDomainPrivacy(System.String,System.String)')
    - [PackageDomainPrivacy(packageId,domainId,body)](#M-TwentyI_dotnet-TwentyIApi-PackageDomainPrivacy-System-String,System-String,System-String- 'TwentyI_dotnet.TwentyIApi.PackageDomainPrivacy(System.String,System.String,System.String)')
    - [PackageDomainPrivacyState(packageId,domainId,body)](#M-TwentyI_dotnet-TwentyIApi-PackageDomainPrivacyState-System-String,System-String,System-String- 'TwentyI_dotnet.TwentyIApi.PackageDomainPrivacyState(System.String,System.String,System.String)')
    - [PackageDomainRenewalMultipleMaxHintFor(packageId,domainId)](#M-TwentyI_dotnet-TwentyIApi-PackageDomainRenewalMultipleMaxHintFor-System-String,System-String- 'TwentyI_dotnet.TwentyIApi.PackageDomainRenewalMultipleMaxHintFor(System.String,System.String)')
    - [PackageDomainResendVerificationEmail(packageId,domainId,body)](#M-TwentyI_dotnet-TwentyIApi-PackageDomainResendVerificationEmail-System-String,System-String,System-String- 'TwentyI_dotnet.TwentyIApi.PackageDomainResendVerificationEmail(System.String,System.String,System.String)')
    - [PackageDomainServicePrice(packageId,domainId)](#M-TwentyI_dotnet-TwentyIApi-PackageDomainServicePrice-System-String,System-String- 'TwentyI_dotnet.TwentyIApi.PackageDomainServicePrice(System.String,System.String)')
    - [PackageDomainSessionlimits(packageId,domainId)](#M-TwentyI_dotnet-TwentyIApi-PackageDomainSessionlimits-System-String,System-String- 'TwentyI_dotnet.TwentyIApi.PackageDomainSessionlimits(System.String,System.String)')
    - [PackageDomainTag(packageId,domainId)](#M-TwentyI_dotnet-TwentyIApi-PackageDomainTag-System-String,System-String- 'TwentyI_dotnet.TwentyIApi.PackageDomainTag(System.String,System.String)')
    - [PackageDomainTransferInfo(packageId,domainId)](#M-TwentyI_dotnet-TwentyIApi-PackageDomainTransferInfo-System-String,System-String- 'TwentyI_dotnet.TwentyIApi.PackageDomainTransferInfo(System.String,System.String)')
    - [PackageDomainUpdateTransfer(packageId,domainId,body)](#M-TwentyI_dotnet-TwentyIApi-PackageDomainUpdateTransfer-System-String,System-String,System-String- 'TwentyI_dotnet.TwentyIApi.PackageDomainUpdateTransfer(System.String,System.String,System.String)')
    - [PackageDomainUpstreamExpiryDate(packageId,domainId)](#M-TwentyI_dotnet-TwentyIApi-PackageDomainUpstreamExpiryDate-System-String,System-String- 'TwentyI_dotnet.TwentyIApi.PackageDomainUpstreamExpiryDate(System.String,System.String)')
    - [PackageDomainUserStatus(packageId,domainId,body)](#M-TwentyI_dotnet-TwentyIApi-PackageDomainUserStatus-System-String,System-String,System-String- 'TwentyI_dotnet.TwentyIApi.PackageDomainUserStatus(System.String,System.String,System.String)')
    - [PackageDomainWhois(packageId,domainId)](#M-TwentyI_dotnet-TwentyIApi-PackageDomainWhois-System-String,System-String- 'TwentyI_dotnet.TwentyIApi.PackageDomainWhois(System.String,System.String)')
    - [PackageEmail(packageId,mailId)](#M-TwentyI_dotnet-TwentyIApi-PackageEmail-System-String,System-String- 'TwentyI_dotnet.TwentyIApi.PackageEmail(System.String,System.String)')
    - [PackageEmail(packageId,mailId,body)](#M-TwentyI_dotnet-TwentyIApi-PackageEmail-System-String,System-String,System-String- 'TwentyI_dotnet.TwentyIApi.PackageEmail(System.String,System.String,System.String)')
    - [PackageEmailAllMailForwarders(packageId)](#M-TwentyI_dotnet-TwentyIApi-PackageEmailAllMailForwarders-System-String- 'TwentyI_dotnet.TwentyIApi.PackageEmailAllMailForwarders(System.String)')
    - [PackageEmailDomain(packageId,mailId)](#M-TwentyI_dotnet-TwentyIApi-PackageEmailDomain-System-String,System-String- 'TwentyI_dotnet.TwentyIApi.PackageEmailDomain(System.String,System.String)')
    - [PackageEmailDomainAlias(packageId,mailId)](#M-TwentyI_dotnet-TwentyIApi-PackageEmailDomainAlias-System-String,System-String- 'TwentyI_dotnet.TwentyIApi.PackageEmailDomainAlias(System.String,System.String)')
    - [PackageEmailForwarder(packageId,mailId)](#M-TwentyI_dotnet-TwentyIApi-PackageEmailForwarder-System-String,System-String- 'TwentyI_dotnet.TwentyIApi.PackageEmailForwarder(System.String,System.String)')
    - [PackageEmailMailForwarder(packageId,mailId)](#M-TwentyI_dotnet-TwentyIApi-PackageEmailMailForwarder-System-String,System-String- 'TwentyI_dotnet.TwentyIApi.PackageEmailMailForwarder(System.String,System.String)')
    - [PackageEmailMailbox(packageId,mailId)](#M-TwentyI_dotnet-TwentyIApi-PackageEmailMailbox-System-String,System-String- 'TwentyI_dotnet.TwentyIApi.PackageEmailMailbox(System.String,System.String)')
    - [PackageEmailResponder(packageId,emailId)](#M-TwentyI_dotnet-TwentyIApi-PackageEmailResponder-System-String,System-String- 'TwentyI_dotnet.TwentyIApi.PackageEmailResponder(System.String,System.String)')
    - [PackageEmailSignature(packageId,emailId)](#M-TwentyI_dotnet-TwentyIApi-PackageEmailSignature-System-String,System-String- 'TwentyI_dotnet.TwentyIApi.PackageEmailSignature(System.String,System.String)')
    - [PackageEmailSignature(packageId,emailId,body)](#M-TwentyI_dotnet-TwentyIApi-PackageEmailSignature-System-String,System-String,System-String- 'TwentyI_dotnet.TwentyIApi.PackageEmailSignature(System.String,System.String,System.String)')
    - [PackageEmailSpamPolicyListBlacklist(packageId,mailId)](#M-TwentyI_dotnet-TwentyIApi-PackageEmailSpamPolicyListBlacklist-System-String,System-String- 'TwentyI_dotnet.TwentyIApi.PackageEmailSpamPolicyListBlacklist(System.String,System.String)')
    - [PackageEmailSpamPolicyListWhitelist(packageId,mailId)](#M-TwentyI_dotnet-TwentyIApi-PackageEmailSpamPolicyListWhitelist-System-String,System-String- 'TwentyI_dotnet.TwentyIApi.PackageEmailSpamPolicyListWhitelist(System.String,System.String)')
    - [PackageEmailWebmail(packageId,mailId,body)](#M-TwentyI_dotnet-TwentyIApi-PackageEmailWebmail-System-String,System-String,System-String- 'TwentyI_dotnet.TwentyIApi.PackageEmailWebmail(System.String,System.String,System.String)')
    - [PackageLimits(packageId)](#M-TwentyI_dotnet-TwentyIApi-PackageLimits-System-String- 'TwentyI_dotnet.TwentyIApi.PackageLimits(System.String)')
    - [PackageNames(packageId)](#M-TwentyI_dotnet-TwentyIApi-PackageNames-System-String- 'TwentyI_dotnet.TwentyIApi.PackageNames(System.String)')
    - [PackageNames(packageId,body)](#M-TwentyI_dotnet-TwentyIApi-PackageNames-System-String,System-String- 'TwentyI_dotnet.TwentyIApi.PackageNames(System.String,System.String)')
    - [PackageSendWelcome(packageId,body)](#M-TwentyI_dotnet-TwentyIApi-PackageSendWelcome-System-String,System-String- 'TwentyI_dotnet.TwentyIApi.PackageSendWelcome(System.String,System.String)')
    - [PackageSessionlimits(packageId)](#M-TwentyI_dotnet-TwentyIApi-PackageSessionlimits-System-String- 'TwentyI_dotnet.TwentyIApi.PackageSessionlimits(System.String)')
    - [PackageStackUserList(packageId)](#M-TwentyI_dotnet-TwentyIApi-PackageStackUserList-System-String- 'TwentyI_dotnet.TwentyIApi.PackageStackUserList(System.String)')
    - [PackageUserStatus(packageId,body)](#M-TwentyI_dotnet-TwentyIApi-PackageUserStatus-System-String,System-String- 'TwentyI_dotnet.TwentyIApi.PackageUserStatus(System.String,System.String)')
    - [PackageWeb(packageId)](#M-TwentyI_dotnet-TwentyIApi-PackageWeb-System-String- 'TwentyI_dotnet.TwentyIApi.PackageWeb(System.String)')
    - [PackageWebAllowedPhpConfiguration(packageId)](#M-TwentyI_dotnet-TwentyIApi-PackageWebAllowedPhpConfiguration-System-String- 'TwentyI_dotnet.TwentyIApi.PackageWebAllowedPhpConfiguration(System.String)')
    - [PackageWebAvailablePhpVersions(packageId)](#M-TwentyI_dotnet-TwentyIApi-PackageWebAvailablePhpVersions-System-String- 'TwentyI_dotnet.TwentyIApi.PackageWebAvailablePhpVersions(System.String)')
    - [PackageWebBandwidthStats(packageId)](#M-TwentyI_dotnet-TwentyIApi-PackageWebBandwidthStats-System-String- 'TwentyI_dotnet.TwentyIApi.PackageWebBandwidthStats(System.String)')
    - [PackageWebBlockedCountries(packageId)](#M-TwentyI_dotnet-TwentyIApi-PackageWebBlockedCountries-System-String- 'TwentyI_dotnet.TwentyIApi.PackageWebBlockedCountries(System.String)')
    - [PackageWebBlockedCountries(packageId,body)](#M-TwentyI_dotnet-TwentyIApi-PackageWebBlockedCountries-System-String,System-String- 'TwentyI_dotnet.TwentyIApi.PackageWebBlockedCountries(System.String,System.String)')
    - [PackageWebBlockedIpAddresses(packageId)](#M-TwentyI_dotnet-TwentyIApi-PackageWebBlockedIpAddresses-System-String- 'TwentyI_dotnet.TwentyIApi.PackageWebBlockedIpAddresses(System.String)')
    - [PackageWebBlockedIpAddresses(packageId,body)](#M-TwentyI_dotnet-TwentyIApi-PackageWebBlockedIpAddresses-System-String,System-String- 'TwentyI_dotnet.TwentyIApi.PackageWebBlockedIpAddresses(System.String,System.String)')
    - [PackageWebCdnStats(packageId)](#M-TwentyI_dotnet-TwentyIApi-PackageWebCdnStats-System-String- 'TwentyI_dotnet.TwentyIApi.PackageWebCdnStats(System.String)')
    - [PackageWebCdnStatsTrafficDistribution(packageId)](#M-TwentyI_dotnet-TwentyIApi-PackageWebCdnStatsTrafficDistribution-System-String- 'TwentyI_dotnet.TwentyIApi.PackageWebCdnStatsTrafficDistribution(System.String)')
    - [PackageWebCertificates(packageId)](#M-TwentyI_dotnet-TwentyIApi-PackageWebCertificates-System-String- 'TwentyI_dotnet.TwentyIApi.PackageWebCertificates(System.String)')
    - [PackageWebCertificatesUpdate(packageId,body)](#M-TwentyI_dotnet-TwentyIApi-PackageWebCertificatesUpdate-System-String,System-String- 'TwentyI_dotnet.TwentyIApi.PackageWebCertificatesUpdate(System.String,System.String)')
    - [PackageWebDatabase(packageId,databaseId)](#M-TwentyI_dotnet-TwentyIApi-PackageWebDatabase-System-String,System-String- 'TwentyI_dotnet.TwentyIApi.PackageWebDatabase(System.String,System.String)')
    - [PackageWebDirectoryIndex(packageId)](#M-TwentyI_dotnet-TwentyIApi-PackageWebDirectoryIndex-System-String- 'TwentyI_dotnet.TwentyIApi.PackageWebDirectoryIndex(System.String)')
    - [PackageWebDirectoryIndex(packageId,body)](#M-TwentyI_dotnet-TwentyIApi-PackageWebDirectoryIndex-System-String,System-String- 'TwentyI_dotnet.TwentyIApi.PackageWebDirectoryIndex(System.String,System.String)')
    - [PackageWebDirectoryIndexing(packageId)](#M-TwentyI_dotnet-TwentyIApi-PackageWebDirectoryIndexing-System-String- 'TwentyI_dotnet.TwentyIApi.PackageWebDirectoryIndexing(System.String)')
    - [PackageWebDirectoryIndexing(packageId,body)](#M-TwentyI_dotnet-TwentyIApi-PackageWebDirectoryIndexing-System-String,System-String- 'TwentyI_dotnet.TwentyIApi.PackageWebDirectoryIndexing(System.String,System.String)')
    - [PackageWebDiskUsage(packageId,body)](#M-TwentyI_dotnet-TwentyIApi-PackageWebDiskUsage-System-String,System-String- 'TwentyI_dotnet.TwentyIApi.PackageWebDiskUsage(System.String,System.String)')
    - [PackageWebDocumentRoots(packageId)](#M-TwentyI_dotnet-TwentyIApi-PackageWebDocumentRoots-System-String- 'TwentyI_dotnet.TwentyIApi.PackageWebDocumentRoots(System.String)')
    - [PackageWebDomainCheck(packageId,body)](#M-TwentyI_dotnet-TwentyIApi-PackageWebDomainCheck-System-String,System-String- 'TwentyI_dotnet.TwentyIApi.PackageWebDomainCheck(System.String,System.String)')
    - [PackageWebExternalSsl(packageId,body)](#M-TwentyI_dotnet-TwentyIApi-PackageWebExternalSsl-System-String,System-String- 'TwentyI_dotnet.TwentyIApi.PackageWebExternalSsl(System.String,System.String)')
    - [PackageWebFilePermissions(packageId)](#M-TwentyI_dotnet-TwentyIApi-PackageWebFilePermissions-System-String- 'TwentyI_dotnet.TwentyIApi.PackageWebFilePermissions(System.String)')
    - [PackageWebFilePermissions(packageId,body)](#M-TwentyI_dotnet-TwentyIApi-PackageWebFilePermissions-System-String,System-String- 'TwentyI_dotnet.TwentyIApi.PackageWebFilePermissions(System.String,System.String)')
    - [PackageWebForceSsl(packageId)](#M-TwentyI_dotnet-TwentyIApi-PackageWebForceSsl-System-String- 'TwentyI_dotnet.TwentyIApi.PackageWebForceSsl(System.String)')
    - [PackageWebForceSsl(packageId,body)](#M-TwentyI_dotnet-TwentyIApi-PackageWebForceSsl-System-String,System-String- 'TwentyI_dotnet.TwentyIApi.PackageWebForceSsl(System.String,System.String)')
    - [PackageWebFreeSsl(packageId,body)](#M-TwentyI_dotnet-TwentyIApi-PackageWebFreeSsl-System-String,System-String- 'TwentyI_dotnet.TwentyIApi.PackageWebFreeSsl(System.String,System.String)')
    - [PackageWebFtpCredentials(packageId)](#M-TwentyI_dotnet-TwentyIApi-PackageWebFtpCredentials-System-String- 'TwentyI_dotnet.TwentyIApi.PackageWebFtpCredentials(System.String)')
    - [PackageWebFtpUsers(packageId)](#M-TwentyI_dotnet-TwentyIApi-PackageWebFtpUsers-System-String- 'TwentyI_dotnet.TwentyIApi.PackageWebFtpUsers(System.String)')
    - [PackageWebFtpUsers(packageId,body)](#M-TwentyI_dotnet-TwentyIApi-PackageWebFtpUsers-System-String,System-String- 'TwentyI_dotnet.TwentyIApi.PackageWebFtpUsers(System.String,System.String)')
    - [PackageWebHomeDirectory(packageId)](#M-TwentyI_dotnet-TwentyIApi-PackageWebHomeDirectory-System-String- 'TwentyI_dotnet.TwentyIApi.PackageWebHomeDirectory(System.String)')
    - [PackageWebInstalledApplications(packageId)](#M-TwentyI_dotnet-TwentyIApi-PackageWebInstalledApplications-System-String- 'TwentyI_dotnet.TwentyIApi.PackageWebInstalledApplications(System.String)')
    - [PackageWebInstalledApplications(packageId,body)](#M-TwentyI_dotnet-TwentyIApi-PackageWebInstalledApplications-System-String,System-String- 'TwentyI_dotnet.TwentyIApi.PackageWebInstalledApplications(System.String,System.String)')
    - [PackageWebInstalledSoftware(packageId)](#M-TwentyI_dotnet-TwentyIApi-PackageWebInstalledSoftware-System-String- 'TwentyI_dotnet.TwentyIApi.PackageWebInstalledSoftware(System.String)')
    - [PackageWebLimits(packageId)](#M-TwentyI_dotnet-TwentyIApi-PackageWebLimits-System-String- 'TwentyI_dotnet.TwentyIApi.PackageWebLimits(System.String)')
    - [PackageWebLogs(packageId)](#M-TwentyI_dotnet-TwentyIApi-PackageWebLogs-System-String- 'TwentyI_dotnet.TwentyIApi.PackageWebLogs(System.String)')
    - [PackageWebMaintenanceMode(packageId)](#M-TwentyI_dotnet-TwentyIApi-PackageWebMaintenanceMode-System-String- 'TwentyI_dotnet.TwentyIApi.PackageWebMaintenanceMode(System.String)')
    - [PackageWebMaintenanceMode(packageId,body)](#M-TwentyI_dotnet-TwentyIApi-PackageWebMaintenanceMode-System-String,System-String- 'TwentyI_dotnet.TwentyIApi.PackageWebMaintenanceMode(System.String,System.String)')
    - [PackageWebMalwareReport(packageId)](#M-TwentyI_dotnet-TwentyIApi-PackageWebMalwareReport-System-String- 'TwentyI_dotnet.TwentyIApi.PackageWebMalwareReport(System.String)')
    - [PackageWebMalwareScan(packageId)](#M-TwentyI_dotnet-TwentyIApi-PackageWebMalwareScan-System-String- 'TwentyI_dotnet.TwentyIApi.PackageWebMalwareScan(System.String)')
    - [PackageWebMalwareScan(packageId,body)](#M-TwentyI_dotnet-TwentyIApi-PackageWebMalwareScan-System-String,System-String- 'TwentyI_dotnet.TwentyIApi.PackageWebMalwareScan(System.String,System.String)')
    - [PackageWebMssqlDatabases(packageId)](#M-TwentyI_dotnet-TwentyIApi-PackageWebMssqlDatabases-System-String- 'TwentyI_dotnet.TwentyIApi.PackageWebMssqlDatabases(System.String)')
    - [PackageWebMssqlDatabases(packageId,body)](#M-TwentyI_dotnet-TwentyIApi-PackageWebMssqlDatabases-System-String,System-String- 'TwentyI_dotnet.TwentyIApi.PackageWebMssqlDatabases(System.String,System.String)')
    - [PackageWebMssqlUserPassword(packageId,body)](#M-TwentyI_dotnet-TwentyIApi-PackageWebMssqlUserPassword-System-String,System-String- 'TwentyI_dotnet.TwentyIApi.PackageWebMssqlUserPassword(System.String,System.String)')
    - [PackageWebMssqlUsers(packageId,body)](#M-TwentyI_dotnet-TwentyIApi-PackageWebMssqlUsers-System-String,System-String- 'TwentyI_dotnet.TwentyIApi.PackageWebMssqlUsers(System.String,System.String)')
    - [PackageWebMysqlDatabase(packageId,body)](#M-TwentyI_dotnet-TwentyIApi-PackageWebMysqlDatabase-System-String,System-String- 'TwentyI_dotnet.TwentyIApi.PackageWebMysqlDatabase(System.String,System.String)')
    - [PackageWebMysqlDatabases(packageId)](#M-TwentyI_dotnet-TwentyIApi-PackageWebMysqlDatabases-System-String- 'TwentyI_dotnet.TwentyIApi.PackageWebMysqlDatabases(System.String)')
    - [PackageWebMysqlGrantUserDatabase(packageId,body)](#M-TwentyI_dotnet-TwentyIApi-PackageWebMysqlGrantUserDatabase-System-String,System-String- 'TwentyI_dotnet.TwentyIApi.PackageWebMysqlGrantUserDatabase(System.String,System.String)')
    - [PackageWebMysqlGrants(packageId)](#M-TwentyI_dotnet-TwentyIApi-PackageWebMysqlGrants-System-String- 'TwentyI_dotnet.TwentyIApi.PackageWebMysqlGrants(System.String)')
    - [PackageWebMysqlGrants(packageId,body)](#M-TwentyI_dotnet-TwentyIApi-PackageWebMysqlGrants-System-String,System-String- 'TwentyI_dotnet.TwentyIApi.PackageWebMysqlGrants(System.String,System.String)')
    - [PackageWebMysqlSso(packageId)](#M-TwentyI_dotnet-TwentyIApi-PackageWebMysqlSso-System-String- 'TwentyI_dotnet.TwentyIApi.PackageWebMysqlSso(System.String)')
    - [PackageWebMysqlUserIpAcl(packageId)](#M-TwentyI_dotnet-TwentyIApi-PackageWebMysqlUserIpAcl-System-String- 'TwentyI_dotnet.TwentyIApi.PackageWebMysqlUserIpAcl(System.String)')
    - [PackageWebMysqlUserIpAcl(packageId,body)](#M-TwentyI_dotnet-TwentyIApi-PackageWebMysqlUserIpAcl-System-String,System-String- 'TwentyI_dotnet.TwentyIApi.PackageWebMysqlUserIpAcl(System.String,System.String)')
    - [PackageWebMysqlUserPassword(packageId,body)](#M-TwentyI_dotnet-TwentyIApi-PackageWebMysqlUserPassword-System-String,System-String- 'TwentyI_dotnet.TwentyIApi.PackageWebMysqlUserPassword(System.String,System.String)')
    - [PackageWebMysqlUsers(packageId)](#M-TwentyI_dotnet-TwentyIApi-PackageWebMysqlUsers-System-String- 'TwentyI_dotnet.TwentyIApi.PackageWebMysqlUsers(System.String)')
    - [PackageWebMysqlUsers(packageId,body)](#M-TwentyI_dotnet-TwentyIApi-PackageWebMysqlUsers-System-String,System-String- 'TwentyI_dotnet.TwentyIApi.PackageWebMysqlUsers(System.String,System.String)')
    - [PackageWebNames(packageId,body)](#M-TwentyI_dotnet-TwentyIApi-PackageWebNames-System-String,System-String- 'TwentyI_dotnet.TwentyIApi.PackageWebNames(System.String,System.String)')
    - [PackageWebOneclick(packageId)](#M-TwentyI_dotnet-TwentyIApi-PackageWebOneclick-System-String- 'TwentyI_dotnet.TwentyIApi.PackageWebOneclick(System.String)')
    - [PackageWebOneclick(packageId,body)](#M-TwentyI_dotnet-TwentyIApi-PackageWebOneclick-System-String,System-String- 'TwentyI_dotnet.TwentyIApi.PackageWebOneclick(System.String,System.String)')
    - [PackageWebPasswordProtection(packageId)](#M-TwentyI_dotnet-TwentyIApi-PackageWebPasswordProtection-System-String- 'TwentyI_dotnet.TwentyIApi.PackageWebPasswordProtection(System.String)')
    - [PackageWebPasswordProtection(packageId,body)](#M-TwentyI_dotnet-TwentyIApi-PackageWebPasswordProtection-System-String,System-String- 'TwentyI_dotnet.TwentyIApi.PackageWebPasswordProtection(System.String,System.String)')
    - [PackageWebPhpConfig(packageId,phpConfigId)](#M-TwentyI_dotnet-TwentyIApi-PackageWebPhpConfig-System-String,System-String- 'TwentyI_dotnet.TwentyIApi.PackageWebPhpConfig(System.String,System.String)')
    - [PackageWebPhpConfigUpdateConfig(packageId,phpConfigId,body)](#M-TwentyI_dotnet-TwentyIApi-PackageWebPhpConfigUpdateConfig-System-String,System-String,System-String- 'TwentyI_dotnet.TwentyIApi.PackageWebPhpConfigUpdateConfig(System.String,System.String,System.String)')
    - [PackageWebPhpVersion(packageId)](#M-TwentyI_dotnet-TwentyIApi-PackageWebPhpVersion-System-String- 'TwentyI_dotnet.TwentyIApi.PackageWebPhpVersion(System.String)')
    - [PackageWebPhpVersion(packageId,body)](#M-TwentyI_dotnet-TwentyIApi-PackageWebPhpVersion-System-String,System-String- 'TwentyI_dotnet.TwentyIApi.PackageWebPhpVersion(System.String,System.String)')
    - [PackageWebPreventHotlinking(packageId)](#M-TwentyI_dotnet-TwentyIApi-PackageWebPreventHotlinking-System-String- 'TwentyI_dotnet.TwentyIApi.PackageWebPreventHotlinking(System.String)')
    - [PackageWebPreventHotlinking(packageId,body)](#M-TwentyI_dotnet-TwentyIApi-PackageWebPreventHotlinking-System-String,System-String- 'TwentyI_dotnet.TwentyIApi.PackageWebPreventHotlinking(System.String,System.String)')
    - [PackageWebRecycleApplicationPool(packageId)](#M-TwentyI_dotnet-TwentyIApi-PackageWebRecycleApplicationPool-System-String- 'TwentyI_dotnet.TwentyIApi.PackageWebRecycleApplicationPool(System.String)')
    - [PackageWebRedirects(packageId)](#M-TwentyI_dotnet-TwentyIApi-PackageWebRedirects-System-String- 'TwentyI_dotnet.TwentyIApi.PackageWebRedirects(System.String)')
    - [PackageWebRedirects(packageId,body)](#M-TwentyI_dotnet-TwentyIApi-PackageWebRedirects-System-String,System-String- 'TwentyI_dotnet.TwentyIApi.PackageWebRedirects(System.String,System.String)')
    - [PackageWebReinstall(packageId)](#M-TwentyI_dotnet-TwentyIApi-PackageWebReinstall-System-String- 'TwentyI_dotnet.TwentyIApi.PackageWebReinstall(System.String)')
    - [PackageWebRemoveMssqlDatabase(packageId,body)](#M-TwentyI_dotnet-TwentyIApi-PackageWebRemoveMssqlDatabase-System-String,System-String- 'TwentyI_dotnet.TwentyIApi.PackageWebRemoveMssqlDatabase(System.String,System.String)')
    - [PackageWebRemoveMssqlUser(packageId,body)](#M-TwentyI_dotnet-TwentyIApi-PackageWebRemoveMssqlUser-System-String,System-String- 'TwentyI_dotnet.TwentyIApi.PackageWebRemoveMssqlUser(System.String,System.String)')
    - [PackageWebRemoveMysqlDatabase(packageId,body)](#M-TwentyI_dotnet-TwentyIApi-PackageWebRemoveMysqlDatabase-System-String,System-String- 'TwentyI_dotnet.TwentyIApi.PackageWebRemoveMysqlDatabase(System.String,System.String)')
    - [PackageWebRemoveMysqlUser(packageId,body)](#M-TwentyI_dotnet-TwentyIApi-PackageWebRemoveMysqlUser-System-String,System-String- 'TwentyI_dotnet.TwentyIApi.PackageWebRemoveMysqlUser(System.String,System.String)')
    - [PackageWebRequestDiskUsage(packageId,body)](#M-TwentyI_dotnet-TwentyIApi-PackageWebRequestDiskUsage-System-String,System-String- 'TwentyI_dotnet.TwentyIApi.PackageWebRequestDiskUsage(System.String,System.String)')
    - [PackageWebRestoreWebsiteBackup(packageId,body)](#M-TwentyI_dotnet-TwentyIApi-PackageWebRestoreWebsiteBackup-System-String,System-String- 'TwentyI_dotnet.TwentyIApi.PackageWebRestoreWebsiteBackup(System.String,System.String)')
    - [PackageWebSitemap(packageId)](#M-TwentyI_dotnet-TwentyIApi-PackageWebSitemap-System-String- 'TwentyI_dotnet.TwentyIApi.PackageWebSitemap(System.String)')
    - [PackageWebSitemapStart(packageId)](#M-TwentyI_dotnet-TwentyIApi-PackageWebSitemapStart-System-String- 'TwentyI_dotnet.TwentyIApi.PackageWebSitemapStart(System.String)')
    - [PackageWebSshAuthenticator(packageId,body)](#M-TwentyI_dotnet-TwentyIApi-PackageWebSshAuthenticator-System-String,System-String- 'TwentyI_dotnet.TwentyIApi.PackageWebSshAuthenticator(System.String,System.String)')
    - [PackageWebSshKeys(packageId)](#M-TwentyI_dotnet-TwentyIApi-PackageWebSshKeys-System-String- 'TwentyI_dotnet.TwentyIApi.PackageWebSshKeys(System.String)')
    - [PackageWebSshKeysUpdate(packageId,body)](#M-TwentyI_dotnet-TwentyIApi-PackageWebSshKeysUpdate-System-String,System-String- 'TwentyI_dotnet.TwentyIApi.PackageWebSshKeysUpdate(System.String,System.String)')
    - [PackageWebSshPassword(packageId)](#M-TwentyI_dotnet-TwentyIApi-PackageWebSshPassword-System-String- 'TwentyI_dotnet.TwentyIApi.PackageWebSshPassword(System.String)')
    - [PackageWebSshPasswordUpdate(packageId,body)](#M-TwentyI_dotnet-TwentyIApi-PackageWebSshPasswordUpdate-System-String,System-String- 'TwentyI_dotnet.TwentyIApi.PackageWebSshPasswordUpdate(System.String,System.String)')
    - [PackageWebStackCache(packageId)](#M-TwentyI_dotnet-TwentyIApi-PackageWebStackCache-System-String- 'TwentyI_dotnet.TwentyIApi.PackageWebStackCache(System.String)')
    - [PackageWebStackCache(packageId,body)](#M-TwentyI_dotnet-TwentyIApi-PackageWebStackCache-System-String,System-String- 'TwentyI_dotnet.TwentyIApi.PackageWebStackCache(System.String,System.String)')
    - [PackageWebSubdomains(packageId)](#M-TwentyI_dotnet-TwentyIApi-PackageWebSubdomains-System-String- 'TwentyI_dotnet.TwentyIApi.PackageWebSubdomains(System.String)')
    - [PackageWebSubdomains(packageId,body)](#M-TwentyI_dotnet-TwentyIApi-PackageWebSubdomains-System-String,System-String- 'TwentyI_dotnet.TwentyIApi.PackageWebSubdomains(System.String,System.String)')
    - [PackageWebTasks(packageId)](#M-TwentyI_dotnet-TwentyIApi-PackageWebTasks-System-String- 'TwentyI_dotnet.TwentyIApi.PackageWebTasks(System.String)')
    - [PackageWebTasks(packageId,body)](#M-TwentyI_dotnet-TwentyIApi-PackageWebTasks-System-String,System-String- 'TwentyI_dotnet.TwentyIApi.PackageWebTasks(System.String,System.String)')
    - [PackageWebTestCronTask(packageId,body)](#M-TwentyI_dotnet-TwentyIApi-PackageWebTestCronTask-System-String,System-String- 'TwentyI_dotnet.TwentyIApi.PackageWebTestCronTask(System.String,System.String)')
    - [PackageWebUsage(packageId)](#M-TwentyI_dotnet-TwentyIApi-PackageWebUsage-System-String- 'TwentyI_dotnet.TwentyIApi.PackageWebUsage(System.String)')
    - [PackageWebWebsiteBuilderSso(packageId)](#M-TwentyI_dotnet-TwentyIApi-PackageWebWebsiteBuilderSso-System-String- 'TwentyI_dotnet.TwentyIApi.PackageWebWebsiteBuilderSso(System.String)')
    - [PackageWebWindowsConfiguration(packageId)](#M-TwentyI_dotnet-TwentyIApi-PackageWebWindowsConfiguration-System-String- 'TwentyI_dotnet.TwentyIApi.PackageWebWindowsConfiguration(System.String)')
    - [PackageWebWindowsConfiguration(packageId,body)](#M-TwentyI_dotnet-TwentyIApi-PackageWebWindowsConfiguration-System-String,System-String- 'TwentyI_dotnet.TwentyIApi.PackageWebWindowsConfiguration(System.String,System.String)')
    - [PackageWebWordpressAdministrators(packageId)](#M-TwentyI_dotnet-TwentyIApi-PackageWebWordpressAdministrators-System-String- 'TwentyI_dotnet.TwentyIApi.PackageWebWordpressAdministrators(System.String)')
    - [PackageWebWordpressChecksum(packageId)](#M-TwentyI_dotnet-TwentyIApi-PackageWebWordpressChecksum-System-String- 'TwentyI_dotnet.TwentyIApi.PackageWebWordpressChecksum(System.String)')
    - [PackageWebWordpressChecksum(packageId,body)](#M-TwentyI_dotnet-TwentyIApi-PackageWebWordpressChecksum-System-String,System-String- 'TwentyI_dotnet.TwentyIApi.PackageWebWordpressChecksum(System.String,System.String)')
    - [PackageWebWordpressDbCheck(packageId)](#M-TwentyI_dotnet-TwentyIApi-PackageWebWordpressDbCheck-System-String- 'TwentyI_dotnet.TwentyIApi.PackageWebWordpressDbCheck(System.String)')
    - [PackageWebWordpressInstallStackCache(packageId,body)](#M-TwentyI_dotnet-TwentyIApi-PackageWebWordpressInstallStackCache-System-String,System-String- 'TwentyI_dotnet.TwentyIApi.PackageWebWordpressInstallStackCache(System.String,System.String)')
    - [PackageWebWordpressIsInstalled(packageId)](#M-TwentyI_dotnet-TwentyIApi-PackageWebWordpressIsInstalled-System-String- 'TwentyI_dotnet.TwentyIApi.PackageWebWordpressIsInstalled(System.String)')
    - [PackageWebWordpressPlugins(packageId)](#M-TwentyI_dotnet-TwentyIApi-PackageWebWordpressPlugins-System-String- 'TwentyI_dotnet.TwentyIApi.PackageWebWordpressPlugins(System.String)')
    - [PackageWebWordpressPlugins(packageId,body)](#M-TwentyI_dotnet-TwentyIApi-PackageWebWordpressPlugins-System-String,System-String- 'TwentyI_dotnet.TwentyIApi.PackageWebWordpressPlugins(System.String,System.String)')
    - [PackageWebWordpressRoles(packageId)](#M-TwentyI_dotnet-TwentyIApi-PackageWebWordpressRoles-System-String- 'TwentyI_dotnet.TwentyIApi.PackageWebWordpressRoles(System.String)')
    - [PackageWebWordpressSearchReplace(packageId,body)](#M-TwentyI_dotnet-TwentyIApi-PackageWebWordpressSearchReplace-System-String,System-String- 'TwentyI_dotnet.TwentyIApi.PackageWebWordpressSearchReplace(System.String,System.String)')
    - [PackageWebWordpressSettings(packageId)](#M-TwentyI_dotnet-TwentyIApi-PackageWebWordpressSettings-System-String- 'TwentyI_dotnet.TwentyIApi.PackageWebWordpressSettings(System.String)')
    - [PackageWebWordpressSettings(packageId,body)](#M-TwentyI_dotnet-TwentyIApi-PackageWebWordpressSettings-System-String,System-String- 'TwentyI_dotnet.TwentyIApi.PackageWebWordpressSettings(System.String,System.String)')
    - [PackageWebWordpressStaging(packageId)](#M-TwentyI_dotnet-TwentyIApi-PackageWebWordpressStaging-System-String- 'TwentyI_dotnet.TwentyIApi.PackageWebWordpressStaging(System.String)')
    - [PackageWebWordpressStaging(packageId,body)](#M-TwentyI_dotnet-TwentyIApi-PackageWebWordpressStaging-System-String,System-String- 'TwentyI_dotnet.TwentyIApi.PackageWebWordpressStaging(System.String,System.String)')
    - [PackageWebWordpressStagingRemoveClone(packageId,body)](#M-TwentyI_dotnet-TwentyIApi-PackageWebWordpressStagingRemoveClone-System-String,System-String- 'TwentyI_dotnet.TwentyIApi.PackageWebWordpressStagingRemoveClone(System.String,System.String)')
    - [PackageWebWordpressTheme(packageId,body)](#M-TwentyI_dotnet-TwentyIApi-PackageWebWordpressTheme-System-String,System-String- 'TwentyI_dotnet.TwentyIApi.PackageWebWordpressTheme(System.String,System.String)')
    - [PackageWebWordpressThemes(packageId)](#M-TwentyI_dotnet-TwentyIApi-PackageWebWordpressThemes-System-String- 'TwentyI_dotnet.TwentyIApi.PackageWebWordpressThemes(System.String)')
    - [PackageWebWordpressUpdate(packageId,body)](#M-TwentyI_dotnet-TwentyIApi-PackageWebWordpressUpdate-System-String,System-String- 'TwentyI_dotnet.TwentyIApi.PackageWebWordpressUpdate(System.String,System.String)')
    - [PackageWebWordpressUsers(packageId)](#M-TwentyI_dotnet-TwentyIApi-PackageWebWordpressUsers-System-String- 'TwentyI_dotnet.TwentyIApi.PackageWebWordpressUsers(System.String)')
    - [PackageWebWordpressVersion(packageId)](#M-TwentyI_dotnet-TwentyIApi-PackageWebWordpressVersion-System-String- 'TwentyI_dotnet.TwentyIApi.PackageWebWordpressVersion(System.String)')
    - [PersonalNameserver(resellerId)](#M-TwentyI_dotnet-TwentyIApi-PersonalNameserver-System-String- 'TwentyI_dotnet.TwentyIApi.PersonalNameserver(System.String)')
    - [ResellerAddDomain(resellerId,body)](#M-TwentyI_dotnet-TwentyIApi-ResellerAddDomain-System-String,System-String- 'TwentyI_dotnet.TwentyIApi.ResellerAddDomain(System.String,System.String)')
    - [ResellerAddMssql(resellerId,body)](#M-TwentyI_dotnet-TwentyIApi-ResellerAddMssql-System-String,System-String- 'TwentyI_dotnet.TwentyIApi.ResellerAddMssql(System.String,System.String)')
    - [ResellerAddTlsCertificate(resellerId,body)](#M-TwentyI_dotnet-TwentyIApi-ResellerAddTlsCertificate-System-String,System-String- 'TwentyI_dotnet.TwentyIApi.ResellerAddTlsCertificate(System.String,System.String)')
    - [ResellerAddVps(resellerId,body)](#M-TwentyI_dotnet-TwentyIApi-ResellerAddVps-System-String,System-String- 'TwentyI_dotnet.TwentyIApi.ResellerAddVps(System.String,System.String)')
    - [ResellerAddWeb(resellerId,body)](#M-TwentyI_dotnet-TwentyIApi-ResellerAddWeb-System-String,System-String- 'TwentyI_dotnet.TwentyIApi.ResellerAddWeb(System.String,System.String)')
    - [ResellerBackupBulkPackages(resellerId)](#M-TwentyI_dotnet-TwentyIApi-ResellerBackupBulkPackages-System-String- 'TwentyI_dotnet.TwentyIApi.ResellerBackupBulkPackages(System.String)')
    - [ResellerBackupBulkPackages(resellerId,body)](#M-TwentyI_dotnet-TwentyIApi-ResellerBackupBulkPackages-System-String,System-String- 'TwentyI_dotnet.TwentyIApi.ResellerBackupBulkPackages(System.String,System.String)')
    - [ResellerDeleteWeb(resellerId,body)](#M-TwentyI_dotnet-TwentyIApi-ResellerDeleteWeb-System-String,System-String- 'TwentyI_dotnet.TwentyIApi.ResellerDeleteWeb(System.String,System.String)')
    - [ResellerMailboxQuotaAddon(resellerId)](#M-TwentyI_dotnet-TwentyIApi-ResellerMailboxQuotaAddon-System-String- 'TwentyI_dotnet.TwentyIApi.ResellerMailboxQuotaAddon(System.String)')
    - [ResellerNominetBrand(resellerId)](#M-TwentyI_dotnet-TwentyIApi-ResellerNominetBrand-System-String- 'TwentyI_dotnet.TwentyIApi.ResellerNominetBrand(System.String)')
    - [ResellerNominetBrand(resellerId,body)](#M-TwentyI_dotnet-TwentyIApi-ResellerNominetBrand-System-String,System-String- 'TwentyI_dotnet.TwentyIApi.ResellerNominetBrand(System.String,System.String)')
    - [ResellerPackageCount(resellerId)](#M-TwentyI_dotnet-TwentyIApi-ResellerPackageCount-System-String- 'TwentyI_dotnet.TwentyIApi.ResellerPackageCount(System.String)')
    - [ResellerPackageTypeBrand(resellerId,body)](#M-TwentyI_dotnet-TwentyIApi-ResellerPackageTypeBrand-System-String,System-String- 'TwentyI_dotnet.TwentyIApi.ResellerPackageTypeBrand(System.String,System.String)')
    - [ResellerPackageTypes(resellerId)](#M-TwentyI_dotnet-TwentyIApi-ResellerPackageTypes-System-String- 'TwentyI_dotnet.TwentyIApi.ResellerPackageTypes(System.String)')
    - [ResellerPackageTypes(resellerId,body)](#M-TwentyI_dotnet-TwentyIApi-ResellerPackageTypes-System-String,System-String- 'TwentyI_dotnet.TwentyIApi.ResellerPackageTypes(System.String,System.String)')
    - [ResellerPasswordResetEmail(resellerId)](#M-TwentyI_dotnet-TwentyIApi-ResellerPasswordResetEmail-System-String- 'TwentyI_dotnet.TwentyIApi.ResellerPasswordResetEmail(System.String)')
    - [ResellerPasswordResetEmail(resellerId,body)](#M-TwentyI_dotnet-TwentyIApi-ResellerPasswordResetEmail-System-String,System-String- 'TwentyI_dotnet.TwentyIApi.ResellerPasswordResetEmail(System.String,System.String)')
    - [ResellerRenewDomain(resellerId,body)](#M-TwentyI_dotnet-TwentyIApi-ResellerRenewDomain-System-String,System-String- 'TwentyI_dotnet.TwentyIApi.ResellerRenewDomain(System.String,System.String)')
    - [ResellerRenewMssql(resellerId,body)](#M-TwentyI_dotnet-TwentyIApi-ResellerRenewMssql-System-String,System-String- 'TwentyI_dotnet.TwentyIApi.ResellerRenewMssql(System.String,System.String)')
    - [ResellerRenewMssqlPre(resellerId,body)](#M-TwentyI_dotnet-TwentyIApi-ResellerRenewMssqlPre-System-String,System-String- 'TwentyI_dotnet.TwentyIApi.ResellerRenewMssqlPre(System.String,System.String)')
    - [ResellerRenewTlsCertificate(resellerId,body)](#M-TwentyI_dotnet-TwentyIApi-ResellerRenewTlsCertificate-System-String,System-String- 'TwentyI_dotnet.TwentyIApi.ResellerRenewTlsCertificate(System.String,System.String)')
    - [ResellerResetPassword(resellerId,body)](#M-TwentyI_dotnet-TwentyIApi-ResellerResetPassword-System-String,System-String- 'TwentyI_dotnet.TwentyIApi.ResellerResetPassword(System.String,System.String)')
    - [ResellerSusers(resellerId)](#M-TwentyI_dotnet-TwentyIApi-ResellerSusers-System-String- 'TwentyI_dotnet.TwentyIApi.ResellerSusers(System.String)')
    - [ResellerSusersUpdate(resellerId,body)](#M-TwentyI_dotnet-TwentyIApi-ResellerSusersUpdate-System-String,System-String- 'TwentyI_dotnet.TwentyIApi.ResellerSusersUpdate(System.String,System.String)')
    - [ResellerTransferDomain(resellerId,body)](#M-TwentyI_dotnet-TwentyIApi-ResellerTransferDomain-System-String,System-String- 'TwentyI_dotnet.TwentyIApi.ResellerTransferDomain(System.String,System.String)')
    - [ResellerUpdate(resellerId,body)](#M-TwentyI_dotnet-TwentyIApi-ResellerUpdate-System-String,System-String- 'TwentyI_dotnet.TwentyIApi.ResellerUpdate(System.String,System.String)')
    - [ResellerUpdatePackage(resellerId,body)](#M-TwentyI_dotnet-TwentyIApi-ResellerUpdatePackage-System-String,System-String- 'TwentyI_dotnet.TwentyIApi.ResellerUpdatePackage(System.String,System.String)')
    - [ResellerUpdateWebType(resellerId,body)](#M-TwentyI_dotnet-TwentyIApi-ResellerUpdateWebType-System-String,System-String- 'TwentyI_dotnet.TwentyIApi.ResellerUpdateWebType(System.String,System.String)')
    - [SetManagedVpsUserStatus(id,body)](#M-TwentyI_dotnet-TwentyIApi-SetManagedVpsUserStatus-System-String,System-String- 'TwentyI_dotnet.TwentyIApi.SetManagedVpsUserStatus(System.String,System.String)')




## TwentyIApi `type`

##### Namespace

TwentyI_dotnet

##### Summary

Library entry class

<a name='M-TwentyI_dotnet-TwentyIApi-#ctor-System-String,System-Net-Http-HttpClient-'></a>
### #ctor(bearer,client) `constructor`

##### Summary

Constructor, will be used to set the bearer token and the http client

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| bearer | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Bearer token, the General API key provided by 20i |
| client | [System.Net.Http.HttpClient](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Net.Http.HttpClient 'System.Net.Http.HttpClient') | Http client |

<a name='M-TwentyI_dotnet-TwentyIApi-GetDomainPeriods'></a>
### GetDomainPeriods() `method`

##### Summary

List all possible domains that are supported with the periods that are supported for registration

##### Returns

The raw json response as a string

##### Parameters

This method has no parameters.

<a name='M-TwentyI_dotnet-TwentyIApi-GetDomainPremiumTypes'></a>
### GetDomainPremiumTypes() `method`

##### Summary

List all domain extentions with their associated premium group.

##### Returns

The raw json response as a string

##### Parameters

This method has no parameters.

<a name='M-TwentyI_dotnet-TwentyIApi-GetDomainSearch-System-String-'></a>
### GetDomainSearch(query) `method`

##### Summary

Searches for one or more domain names.
If you provide a domain name, this will search for that name only, otherwise it will search for that prefix on all
supported TLDs.
You may supply multiple literal domain names if you separate them with commas.
You may supply arbitrary text, which will be stripped down to something suitable for domain search. This is
typically useful with suggestions on.
Under some circumstances this will attempt a detailed search, which will fetch more specific information about
transferrable domains.
This will happen if you search for one domain name. Domain Suggestions Our primary domain availability provider
supports suggesting names based on the search, using simple semantic permutations of the supplied name(s).
For example if you're searching for mailboxdelivery.com it might suggest post-delivery.com, mailboxsend.net and
my-mailbox-delivery.com.
These are supported only in a small set of TLDs (including .com, .net, .org, .info).
These names are probably available, and will get properly checked at the end of the results, meaning that you will
get two results: one marked "suggestion" and a later one which looks like a direct domain search result.
At the current time, setting the TLDs to search is not supported. If a domain is returned which you aren't set up
to sell, you should exclude it from your view.
Note on responsiveness and order All results will be output at the earliest possible opportunity, and will be
delivered in separate packets with each result hash on a line on its own.
This means that the order will usually be different to the header order, and the output will look a little
different to typical JSON responses.
Usage limits Access to this service is subject to reasonable usage limits. If you go over the limit, further access
will be blocked for up to 24 hours.

##### Returns

The raw json response as a string

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| query | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The query to search for |

<a name='M-TwentyI_dotnet-TwentyIApi-GetDomains'></a>
### GetDomains() `method`

##### Summary

RetrieveDomains Returns basic information about the domains in the account.

##### Returns

The raw json response as a string

##### Parameters

This method has no parameters.

<a name='M-TwentyI_dotnet-TwentyIApi-GetManagedVps-System-String-'></a>
### GetManagedVps(id) `method`

##### Summary

Returns an object representation of your managed VPS.

##### Returns

The raw json response as a string

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| id | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The id of the managed vps |

<a name='M-TwentyI_dotnet-TwentyIApi-GetManagedVpsList'></a>
### GetManagedVpsList() `method`

##### Summary

Returns a short, cheap set of info for all managed VPSs.

##### Returns

The raw json response as a string

##### Parameters

This method has no parameters.

<a name='M-TwentyI_dotnet-TwentyIApi-GetManagedVpsName-System-String-'></a>
### GetManagedVpsName(id) `method`

##### Summary

Returns the name of one Managed VPS.

##### Returns

The raw json response as a string

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| id | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The id of the managed vps |

<a name='M-TwentyI_dotnet-TwentyIApi-GetManagedVpsPackageCount-System-String-'></a>
### GetManagedVpsPackageCount(id) `method`

##### Summary

Returns the count of how many packages can be created on this managed VPS.

##### Returns

The raw json response as a string

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| id | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The id of the managed vps |

<a name='M-TwentyI_dotnet-TwentyIApi-GetMssql'></a>
### GetMssql() `method`

##### Summary

Retrieve MSSQL Databases

##### Returns

The raw json response as a string

##### Parameters

This method has no parameters.

<a name='M-TwentyI_dotnet-TwentyIApi-GetMssqlById-System-String-'></a>
### GetMssqlById(id) `method`

##### Summary

Retrieve MSSQL Database by ID

##### Returns

The raw json response as a string

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| id | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The id of the mssql database |

<a name='M-TwentyI_dotnet-TwentyIApi-ManagedVpsAddWeb-System-String,System-String-'></a>
### ManagedVpsAddWeb(id,body) `method`

##### Summary

Add a web site.

##### Returns

The raw json response as a string

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| id | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The id of the managed vps |
| body | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The json body to send |

##### Remarks

Json sample body: { domain_name: "string", extra_domain_names: "string" }

<a name='M-TwentyI_dotnet-TwentyIApi-ManagedVpsDeleteWeb-System-String,System-String-'></a>
### ManagedVpsDeleteWeb(id,body) `method`

##### Summary

Delete web sites.

##### Returns

The raw json response as a string

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| id | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The id of the managed vps |
| body | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The json body to send |

##### Remarks

Json sample body: { delete-id: ["string"] }

<a name='M-TwentyI_dotnet-TwentyIApi-ManagedVpsSetName-System-String,System-String-'></a>
### ManagedVpsSetName(id,body) `method`

##### Summary

Set the VPS Name

##### Returns

The raw json response as a string

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| id | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The id of the managed vps |
| body | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The json body to send |

##### Remarks

Json sample body: { name: "string" }

<a name='M-TwentyI_dotnet-TwentyIApi-MssqlLinkPackage-System-String,System-String-'></a>
### MssqlLinkPackage(id,body) `method`

##### Summary

Update the config to link the MS SQL product to a package.

##### Returns

The raw json response as a string

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| id | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The id of the mssql database |
| body | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The json body to send |

##### Remarks

Json sample body: { id:1 }

<a name='M-TwentyI_dotnet-TwentyIApi-Package'></a>
### Package() `method`

##### Summary

Returns information about this service.

##### Returns

The raw json response as a string

##### Parameters

This method has no parameters.

<a name='M-TwentyI_dotnet-TwentyIApi-Package-System-String-'></a>
### Package(packageId) `method`

##### Summary

Returns an array representation of the package.

##### Returns

The raw json response as a string

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| packageId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The id of the package |

<a name='M-TwentyI_dotnet-TwentyIApi-PackageBundleTypeLimits-System-String-'></a>
### PackageBundleTypeLimits(packageId) `method`

##### Summary

Returns the limits set of this package bundle type.

##### Returns

The raw json response as a string

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| packageId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The id of the package |

<a name='M-TwentyI_dotnet-TwentyIApi-PackageDatabaseUser-System-String,System-String,System-String-'></a>
### PackageDatabaseUser(packageId,databaseId,userId) `method`

##### Summary

Returns some information about the database user

##### Returns

The raw json response as a string

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| packageId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The id of the package |
| databaseId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The id of the database |
| userId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The id of the user |

<a name='M-TwentyI_dotnet-TwentyIApi-PackageDefaultDns-System-String-'></a>
### PackageDefaultDns(packageId) `method`

##### Summary

Returns the default DNS records from the web object.

##### Returns

The raw json response as a string

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| packageId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The id of the package |

<a name='M-TwentyI_dotnet-TwentyIApi-PackageDomain-System-String,System-String-'></a>
### PackageDomain(packageId,domainId) `method`

##### Summary

Returns information about the domain.

##### Returns

The raw json response as a string

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| packageId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The id of the package |
| domainId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The id of the domain |

<a name='M-TwentyI_dotnet-TwentyIApi-PackageDomainAuthcode-System-String,System-String-'></a>
### PackageDomainAuthcode(packageId,domainId) `method`

##### Summary

Returns the domain's EPP auth code, as needed for outbound transfers in some circumstances.
This MAY issue a new authcode, so it's not suitable to call if you're caching an older copy of the authcode,
and it's inadvisable to access this while a transfer is in progress.

##### Returns

The raw json response as a string

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| packageId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The id of the package |
| domainId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The id of the domain |

<a name='M-TwentyI_dotnet-TwentyIApi-PackageDomainCanTransfer-System-String,System-String-'></a>
### PackageDomainCanTransfer(packageId,domainId) `method`

##### Summary

Get the flag allowing or disallowing transfers.

##### Returns

The raw json response as a string

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| packageId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The id of the package |
| domainId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The id of the domain |

<a name='M-TwentyI_dotnet-TwentyIApi-PackageDomainCanTransfer-System-String,System-String,System-String-'></a>
### PackageDomainCanTransfer(packageId,domainId,body) `method`

##### Summary

Set the flag allowing or disallowing transfers, aka the "domain lock".

##### Returns

The raw json response as a string

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| packageId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The id of the package |
| domainId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The id of the domain |
| body | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The body of the request |

##### Remarks

body: {enabled:true}

<a name='M-TwentyI_dotnet-TwentyIApi-PackageDomainCancelTransfer-System-String,System-String-'></a>
### PackageDomainCancelTransfer(packageId,domainId) `method`

##### Summary

Cancel an incoming transfer. If successful, this will also refund to balance.

##### Returns

The raw json response as a string

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| packageId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The id of the package |
| domainId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The id of the domain |

<a name='M-TwentyI_dotnet-TwentyIApi-PackageDomainContacts-System-String,System-String-'></a>
### PackageDomainContacts(packageId,domainId) `method`

##### Summary

Returns the current contacts for the domain name. This is a map of contact types to contact data, in EPP format.

##### Returns

The raw json response as a string

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| packageId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The id of the package |
| domainId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The id of the domain |

<a name='M-TwentyI_dotnet-TwentyIApi-PackageDomainContacts-System-String,System-String,System-String-'></a>
### PackageDomainContacts(packageId,domainId,body) `method`

##### Summary

Sets the contacts for the domain. This is a map of contact types to contact data, in EPP format.

##### Returns

The raw json response as a string

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| packageId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The id of the package |
| domainId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The id of the domain |
| body | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The body of the request |

##### Remarks

sample body: { contacts: { "string": "string" } }

<a name='M-TwentyI_dotnet-TwentyIApi-PackageDomainDns-System-String,System-String-'></a>
### PackageDomainDns(packageId,domainId) `method`

##### Summary

Returns the current DNS records for the domain.

##### Returns

The raw json response as a string

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| packageId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The id of the package |
| domainId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The id of the domain |

<a name='M-TwentyI_dotnet-TwentyIApi-PackageDomainDnsGoogleApps-System-String,System-String-'></a>
### PackageDomainDnsGoogleApps(packageId,domainId) `method`

##### Summary

Returns the records needed for a full Google Apps service, including mail and web services.
You can send these back in the "new" key when updating DNS to add them, but it's recommended that you also delete
any conflicting records at the same time.

##### Returns

The raw json response as a string

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| packageId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The id of the package |
| domainId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The id of the domain |

<a name='M-TwentyI_dotnet-TwentyIApi-PackageDomainDnsGoogleApps-System-String,System-String,System-Object-'></a>
### PackageDomainDnsGoogleApps(packageId,domainId,body) `method`

##### Summary

Equivalent to adding new DNS records with all the results of GET "googleApps". This will not remove any records by
default.

##### Returns

The raw json response as a string

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| packageId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The id of the package |
| domainId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The id of the domain |
| body | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | The body of the request |

##### Remarks

sample body: { conflictPolicy: "string" }

<a name='M-TwentyI_dotnet-TwentyIApi-PackageDomainDnsGoogleAppsMailOnly-System-String,System-String-'></a>
### PackageDomainDnsGoogleAppsMailOnly(packageId,domainId) `method`

##### Summary

Returns the records needed for Google Mail service.
You can send these back in the "new" key when updating DNS to add them, but it's recommended that you also delete
any conflicting records at the same time.

##### Returns

The raw json response as a string

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| packageId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The id of the package |
| domainId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The id of the domain |

<a name='M-TwentyI_dotnet-TwentyIApi-PackageDomainDnsGoogleAppsMailOnly-System-String,System-String,System-Object-'></a>
### PackageDomainDnsGoogleAppsMailOnly(packageId,domainId,body) `method`

##### Summary

Equivalent to adding new DNS records with all the results of GET "googleAppsMailOnly". This will not remove any
records by default.

##### Returns

The raw json response as a string

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| packageId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The id of the package |
| domainId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The id of the domain |
| body | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | The body of the request |

##### Remarks

sample body: { conflictPolicy: "string" }

<a name='M-TwentyI_dotnet-TwentyIApi-PackageDomainDnsOffice365Mail-System-String,System-String-'></a>
### PackageDomainDnsOffice365Mail(packageId,domainId) `method`

##### Summary

Returns the records needed for office 365 mail.

##### Returns

The raw json response as a string

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| packageId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The id of the package |
| domainId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The id of the domain |

<a name='M-TwentyI_dotnet-TwentyIApi-PackageDomainDnsOffice365MailOnly-System-String,System-String,System-Object-'></a>
### PackageDomainDnsOffice365MailOnly(packageId,domainId,body) `method`

##### Summary

Equivalent to adding new DNS records with all the results of GET "Office365MailOnly". This will not remove any
records by default.

##### Returns

The raw json response as a string

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| packageId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The id of the package |
| domainId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The id of the domain |
| body | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | The body of the request |

##### Remarks

sample body: { conflictPolicy:"string" }

<a name='M-TwentyI_dotnet-TwentyIApi-PackageDomainDnsUpdate-System-String,System-String,System-String-'></a>
### PackageDomainDnsUpdate(packageId,domainId,body) `method`

##### Summary

Updates the DNS records for the domain, if the DNS service is in use.
Name prefixes are either plain names like "www" or "mail", or "@" to indicate that it applies to the domain itself
(typically only AAAA, A or MX).
NOTE: The platform may silently rewrite some adds into updates.
NOTE: CNAMEs are special records (see RFC1034, with reference to RFC1912): they actually mean "no stop you're
looking in the wrong place, ask instead for ".
Thus on any name you can only have one of: (a)no records, (b) 1 CNAME, or (c) 1+ non-CNAME records (including SOA
and NS).
If you have a CNAME on a name and want to add records on that name, you should remove the CNAME (this may be done
implicitly for you).
If you have non-CNAME records on a name and want to add a CNAME on that name, you will have to delete every
non-CNAME record on the name.
In most cases, people using CNAME actually want "A/AAAA CNAME", ie. aliasing the A and AAAA records but nothing
else (which the DNS protocol doesn't support).
The distinction doesn't affect anything unless you have conflicting records on the same name, which usually is only
the case for the root.
Since browsers do not support _http._tcp SRV records (and don't intend to), you simply have to manually copy A or
AAAA records in this case.

##### Returns

The raw json response as a string

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| packageId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The id of the package |
| domainId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The id of the domain |
| body | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The body of the request |

##### Remarks

{ conflictPolicy: "string", insertPolicy: "string", new:{ AAAA:{ host: "string", ipv6: "string", }, A:{ host:
"string", ip: "string", }, CNAME:{ reuseId: "string", host: "string", target: "string", }, MX:{ host: "string",
target: "string", pri: "string", }, TXT:{ host: "string", txt: "string", }, SRV:{ host: "string", pri: "string",
weight: "string", port: "string", target: "string", } }, delete: ["string"] }

<a name='M-TwentyI_dotnet-TwentyIApi-PackageDomainLabels-System-String,System-String,System-String-'></a>
### PackageDomainLabels(packageId,domainId,body) `method`

##### Summary

Add or Remove a label for this domain

##### Returns

The raw json response as a string

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| packageId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The id of the package |
| domainId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The id of the domain |
| body | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The raw json body |

##### Remarks

sample body: { label: "string", type: "string" }

<a name='M-TwentyI_dotnet-TwentyIApi-PackageDomainLimits-System-String,System-String-'></a>
### PackageDomainLimits(packageId,domainId) `method`

##### Summary

Returns the limits for the current user, a key-value map.

##### Returns

The raw json response as a string

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| packageId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The id of the package |
| domainId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The id of the domain |

<a name='M-TwentyI_dotnet-TwentyIApi-PackageDomainMaxNameservers-System-String,System-String-'></a>
### PackageDomainMaxNameservers(packageId,domainId) `method`

##### Summary

Returns the maximum number of nameservers for the domain. You can and should cache this information by TLD.

##### Returns

The raw json response as a string

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| packageId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The id of the package |
| domainId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The id of the domain |

<a name='M-TwentyI_dotnet-TwentyIApi-PackageDomainNameservers-System-String,System-String-'></a>
### PackageDomainNameservers(packageId,domainId) `method`

##### Summary

Returns the current nameservers for the domain, if applicable.

##### Returns

The raw json response as a string

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| packageId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The id of the package |
| domainId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The id of the domain |

<a name='M-TwentyI_dotnet-TwentyIApi-PackageDomainNameservers-System-String,System-String,System-Object-'></a>
### PackageDomainNameservers(packageId,domainId,body) `method`

##### Summary

Updates the nameservers for the domain.
If the old nameservers do not match, the registry may reject the request.
Some registries may handle names which are present in both "ns" and "old-ns" incorrectly, so it's recommended that
you do not include names which are being kept.

##### Returns

The raw json response as a string

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| packageId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The id of the package |
| domainId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The id of the domain |
| body | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | The body of the request |

##### Remarks

sample body: { ns: ["string"], old-ns: ["string"] }

<a name='M-TwentyI_dotnet-TwentyIApi-PackageDomainOptOut-System-String,System-String-'></a>
### PackageDomainOptOut(packageId,domainId) `method`

##### Summary

Fetches information about WHOIS contact disclosure (Nominet or .IT) for the domain name.

##### Returns

The raw json response as a string

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| packageId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The id of the package |
| domainId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The id of the domain |

<a name='M-TwentyI_dotnet-TwentyIApi-PackageDomainOptOut-System-String,System-String,System-String-'></a>
### PackageDomainOptOut(packageId,domainId,body) `method`

##### Summary

Updates the WHOIS disclosure options, for applicable domains.

##### Returns

The raw json response as a string

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| packageId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The id of the package |
| domainId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The id of the domain |
| body | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The body of the request |

##### Remarks

sample body: { enabled: true }

<a name='M-TwentyI_dotnet-TwentyIApi-PackageDomainPendingTransfer-System-String,System-String-'></a>
### PackageDomainPendingTransfer(packageId,domainId) `method`

##### Summary

Returns true if this domain is waiting for transfer completion.

##### Returns

The raw json response as a string

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| packageId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The id of the package |
| domainId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The id of the domain |

<a name='M-TwentyI_dotnet-TwentyIApi-PackageDomainPendingTransferStatus-System-String,System-String-'></a>
### PackageDomainPendingTransferStatus(packageId,domainId) `method`

##### Summary

Returns the current cached status of the transfer.

##### Returns

The raw json response as a string

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| packageId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The id of the package |
| domainId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The id of the domain |

<a name='M-TwentyI_dotnet-TwentyIApi-PackageDomainPrivacy-System-String,System-String-'></a>
### PackageDomainPrivacy(packageId,domainId) `method`

##### Summary

Returns information about the service domain privacy.

##### Returns

The raw json response as a string

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| packageId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The id of the package |
| domainId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The id of the domain |

<a name='M-TwentyI_dotnet-TwentyIApi-PackageDomainPrivacy-System-String,System-String,System-String-'></a>
### PackageDomainPrivacy(packageId,domainId,body) `method`

##### Summary

Update the privacy settings for the service domain.

##### Returns

The raw json response as a string

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| packageId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The id of the package |
| domainId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The id of the domain |
| body | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The body of the request |

##### Remarks

sample body: { emailDestination: "string" }

<a name='M-TwentyI_dotnet-TwentyIApi-PackageDomainPrivacyState-System-String,System-String,System-String-'></a>
### PackageDomainPrivacyState(packageId,domainId,body) `method`

##### Summary

Updates the privacy enabled/disabled state (for domains with privacy attached only).

##### Returns

The raw json response as a string

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| packageId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The id of the package |
| domainId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The id of the domain |
| body | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The body of the request |

##### Remarks

sample body: { enabled: true }

<a name='M-TwentyI_dotnet-TwentyIApi-PackageDomainRenewalMultipleMaxHintFor-System-String,System-String-'></a>
### PackageDomainRenewalMultipleMaxHintFor(packageId,domainId) `method`

##### Summary

Will provide a hint on what the current maximum years would be allowed for a renewal

##### Returns

The raw json response as a string

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| packageId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The id of the package |
| domainId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The id of the domain |

<a name='M-TwentyI_dotnet-TwentyIApi-PackageDomainResendVerificationEmail-System-String,System-String,System-String-'></a>
### PackageDomainResendVerificationEmail(packageId,domainId,body) `method`

##### Summary

Resend the registrant verification email, if one applies.

##### Returns

The raw json response as a string

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| packageId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The id of the package |
| domainId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The id of the domain |
| body | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The body of the request |

##### Remarks

body: { }

<a name='M-TwentyI_dotnet-TwentyIApi-PackageDomainServicePrice-System-String,System-String-'></a>
### PackageDomainServicePrice(packageId,domainId) `method`

##### Summary

Get a per-year price, if premium, specifically for renewals.
This is always in GBP; it will require currency conversion for other currencies and may or may not have markup
added for checkout.

##### Returns

The raw json response as a string

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| packageId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The id of the package |
| domainId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The id of the domain |

<a name='M-TwentyI_dotnet-TwentyIApi-PackageDomainSessionlimits-System-String,System-String-'></a>
### PackageDomainSessionlimits(packageId,domainId) `method`

##### Summary

Returns the limits for the session. If the user is a super user then they are exempt from explicit limit
restrictions.

##### Returns

The raw json response as a string

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| packageId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The id of the package |
| domainId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The id of the domain |

<a name='M-TwentyI_dotnet-TwentyIApi-PackageDomainTag-System-String,System-String-'></a>
### PackageDomainTag(packageId,domainId) `method`

##### Summary

Change the IPS-tag for a domain.
Applicable to UK domains only.
If this operation succeeds, the domain will no longer be controllable.

##### Returns

The raw json response as a string

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| packageId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The id of the package |
| domainId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The id of the domain |

##### Remarks

body: {new-tag:"string"}

<a name='M-TwentyI_dotnet-TwentyIApi-PackageDomainTransferInfo-System-String,System-String-'></a>
### PackageDomainTransferInfo(packageId,domainId) `method`

##### Summary

Returns information about the pending transfer (if any).

##### Returns

The raw json response as a string

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| packageId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The id of the package |
| domainId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The id of the domain |

<a name='M-TwentyI_dotnet-TwentyIApi-PackageDomainUpdateTransfer-System-String,System-String,System-String-'></a>
### PackageDomainUpdateTransfer(packageId,domainId,body) `method`

##### Summary

Modify an incoming transfer.

##### Returns

The raw json response as a string

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| packageId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The id of the package |
| domainId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The id of the domain |
| body | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The body of the request |

##### Remarks

body: { action: "string", authInfo:{ pw: "string" }, configuration:{ } }

<a name='M-TwentyI_dotnet-TwentyIApi-PackageDomainUpstreamExpiryDate-System-String,System-String-'></a>
### PackageDomainUpstreamExpiryDate(packageId,domainId) `method`

##### Summary

Returns the expiry date at the registry.
This does not necessarily indicate the payment status of the domain nor does it reflect when renewal will occur.
It is possible for this to return null, eg. for an incomplete transfer or a deleted domain.

##### Returns

The raw json response as a string

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| packageId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The id of the package |
| domainId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The id of the domain |

<a name='M-TwentyI_dotnet-TwentyIApi-PackageDomainUserStatus-System-String,System-String,System-String-'></a>
### PackageDomainUserStatus(packageId,domainId,body) `method`

##### Summary

Activates or deactivates the service. Possible subservice_name are 'default' for a typical set of services and
'main' for the core service only.

##### Returns

The raw json response as a string

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| packageId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The id of the package |
| domainId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The id of the domain |
| body | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The json body to send |

##### Remarks

Json sample body: { includeRepeated: true, subservices:{ (subservice_name): true } }

<a name='M-TwentyI_dotnet-TwentyIApi-PackageDomainWhois-System-String,System-String-'></a>
### PackageDomainWhois(packageId,domainId) `method`

##### Summary

Returns the current live WHOIS text for the domain. Only works for domains registered with 20i.

##### Returns

The raw json response as a string

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| packageId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The id of the package |
| domainId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The id of the domain |

<a name='M-TwentyI_dotnet-TwentyIApi-PackageEmail-System-String,System-String-'></a>
### PackageEmail(packageId,mailId) `method`

##### Summary

Returns the current email configuration for the domain.
This is a map of setting types to arrays of settings, in the same format as the "email" method but with an extra
"id" property on each item.
To facilitate page display, this also redundantly includes the domain name in a "name" property.

##### Returns

The raw json response as a string

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| packageId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The id of the package |
| mailId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The id of the mail |

<a name='M-TwentyI_dotnet-TwentyIApi-PackageEmail-System-String,System-String,System-String-'></a>
### PackageEmail(packageId,mailId,body) `method`

##### Summary

Updates the email configuration for the domain.

##### Returns

The raw json response as a string

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| packageId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The id of the package |
| mailId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The id of the mail |
| body | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The body of the request |

##### Remarks

sample body:{ { result:{ }, name: "string" } }

<a name='M-TwentyI_dotnet-TwentyIApi-PackageEmailAllMailForwarders-System-String-'></a>
### PackageEmailAllMailForwarders(packageId) `method`

##### Summary

Fetches all forwarders by package id.

##### Returns

The raw json response as a string

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| packageId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The id of the package |

<a name='M-TwentyI_dotnet-TwentyIApi-PackageEmailDomain-System-String,System-String-'></a>
### PackageEmailDomain(packageId,mailId) `method`

##### Summary

Returns the current domain config.

##### Returns

The raw json response as a string

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| packageId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The id of the package |
| mailId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The id of the mail |

<a name='M-TwentyI_dotnet-TwentyIApi-PackageEmailDomainAlias-System-String,System-String-'></a>
### PackageEmailDomainAlias(packageId,mailId) `method`

##### Summary

Returns the current domain alias config.

##### Returns

The raw json response as a string

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| packageId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The id of the package |
| mailId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The id of the mail |

<a name='M-TwentyI_dotnet-TwentyIApi-PackageEmailForwarder-System-String,System-String-'></a>
### PackageEmailForwarder(packageId,mailId) `method`

##### Summary

Returns the current forwarder config.

##### Returns

The raw json response as a string

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| packageId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The id of the package |
| mailId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The id of the mail |

<a name='M-TwentyI_dotnet-TwentyIApi-PackageEmailMailForwarder-System-String,System-String-'></a>
### PackageEmailMailForwarder(packageId,mailId) `method`

##### Summary

Returns the current mailbox forwarder config.

##### Returns

The raw json response as a string

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| packageId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The id of the package |
| mailId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The id of the mail |

<a name='M-TwentyI_dotnet-TwentyIApi-PackageEmailMailbox-System-String,System-String-'></a>
### PackageEmailMailbox(packageId,mailId) `method`

##### Summary

Returns the current mailbox config.

##### Returns

The raw json response as a string

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| packageId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The id of the package |
| mailId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The id of the mail |

<a name='M-TwentyI_dotnet-TwentyIApi-PackageEmailResponder-System-String,System-String-'></a>
### PackageEmailResponder(packageId,emailId) `method`

##### Summary

Returns the current autoresponder config.

##### Returns

The raw json response as a string

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| packageId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The id of the package |
| emailId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The id of the email |

<a name='M-TwentyI_dotnet-TwentyIApi-PackageEmailSignature-System-String,System-String-'></a>
### PackageEmailSignature(packageId,emailId) `method`

##### Summary

Returns domain DKIM Signatures.

##### Returns

The raw json response as a string

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| packageId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The id of the package |
| emailId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The id of the email |

<a name='M-TwentyI_dotnet-TwentyIApi-PackageEmailSignature-System-String,System-String,System-String-'></a>
### PackageEmailSignature(packageId,emailId,body) `method`

##### Summary

Set or Delete DKIM Signature for a given domain.

##### Returns

The raw json response as a string

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| packageId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The id of the package |
| emailId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The id of the email |
| body | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The body of the request |

##### Remarks

sample body: { action: "string", body:{ Canonicalization: "string", ExpiryTime: 1, Flag: "string",
Granularity: "string", IsDefault: true, IsStrict: true, Note: "string", Selector: "string", ServiceType: "string" }
}

<a name='M-TwentyI_dotnet-TwentyIApi-PackageEmailSpamPolicyListBlacklist-System-String,System-String-'></a>
### PackageEmailSpamPolicyListBlacklist(packageId,mailId) `method`

##### Summary

Returns the current blacklist config - email.

##### Returns

The raw json response as a string

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| packageId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The id of the package |
| mailId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The id of the mail |

<a name='M-TwentyI_dotnet-TwentyIApi-PackageEmailSpamPolicyListWhitelist-System-String,System-String-'></a>
### PackageEmailSpamPolicyListWhitelist(packageId,mailId) `method`

##### Summary

Returns the current whitelist config.

##### Returns

The raw json response as a string

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| packageId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The id of the package |
| mailId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The id of the mail |

<a name='M-TwentyI_dotnet-TwentyIApi-PackageEmailWebmail-System-String,System-String,System-String-'></a>
### PackageEmailWebmail(packageId,mailId,body) `method`

##### Summary

Generate a webmail single-sign-on URL

##### Returns

The raw json response as a string

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| packageId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The id of the package |
| mailId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The id of the mail |
| body | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The body of the request |

##### Remarks

body: { id: "string" }

<a name='M-TwentyI_dotnet-TwentyIApi-PackageLimits-System-String-'></a>
### PackageLimits(packageId) `method`

##### Summary

Returns the limits for the current user, a key-value map.

##### Returns

The raw json response as a string

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| packageId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The id of the package |

<a name='M-TwentyI_dotnet-TwentyIApi-PackageNames-System-String-'></a>
### PackageNames(packageId) `method`

##### Summary

Returns the names for this package.

##### Returns

The raw json response as a string

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| packageId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The id of the package |

<a name='M-TwentyI_dotnet-TwentyIApi-PackageNames-System-String,System-String-'></a>
### PackageNames(packageId,body) `method`

##### Summary

Add or remove names from the package.
This has special behaviour if any of the names are also registered (renewable) domain names in your account:
As a policy matter, you may not remove the last name from the object. If you attempt to do so, you will get an
error.

##### Returns

The raw json response as a string

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| packageId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The id of the package |
| body | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The body of the request |

##### Remarks

sample body: { add: ["string"], rem: ["string"], chg: "string" }

<a name='M-TwentyI_dotnet-TwentyIApi-PackageSendWelcome-System-String,System-String-'></a>
### PackageSendWelcome(packageId,body) `method`

##### Summary

Sends or re-sends the welcome email
if a contact is found for a provided toAddress then it will be sent to the template data and be available in twig

##### Returns

The raw json response as a string

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| packageId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The id of the package |
| body | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The body of the request |

##### Remarks

body: { toAddress: "string" }

<a name='M-TwentyI_dotnet-TwentyIApi-PackageSessionlimits-System-String-'></a>
### PackageSessionlimits(packageId) `method`

##### Summary

Returns the limits for the session. If the user is a super user then they are exempt from explicit limit
restrictions.

##### Returns

The raw json response as a string

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| packageId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The id of the package |

<a name='M-TwentyI_dotnet-TwentyIApi-PackageStackUserList-System-String-'></a>
### PackageStackUserList(packageId) `method`

##### Summary

Retrieve stack user list.

##### Returns

The raw json response as a string

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| packageId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The id of the package |

<a name='M-TwentyI_dotnet-TwentyIApi-PackageUserStatus-System-String,System-String-'></a>
### PackageUserStatus(packageId,body) `method`

##### Summary

Activates or deactivates the service. Possible subservice_name are 'default' for a typical set of services and
'main' for the core service only.

##### Returns

The raw json response as a string

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| packageId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The id of the package |
| body | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The json body to send |

##### Remarks

Json sample body: { includeRepeated: true, subservices:{ (subservice_name): true } }

<a name='M-TwentyI_dotnet-TwentyIApi-PackageWeb-System-String-'></a>
### PackageWeb(packageId) `method`

##### Summary

Returns detailed information about the package.

##### Returns

The raw json response as a string

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| packageId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The id of the package |

<a name='M-TwentyI_dotnet-TwentyIApi-PackageWebAllowedPhpConfiguration-System-String-'></a>
### PackageWebAllowedPhpConfiguration(packageId) `method`

##### Summary

Get allowed PHP configuration directives.

##### Returns

The raw json response as a string

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| packageId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The id of the package |

<a name='M-TwentyI_dotnet-TwentyIApi-PackageWebAvailablePhpVersions-System-String-'></a>
### PackageWebAvailablePhpVersions(packageId) `method`

##### Summary

Get all available PHP versions.

##### Returns

The raw json response as a string

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| packageId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The id of the package |

<a name='M-TwentyI_dotnet-TwentyIApi-PackageWebBandwidthStats-System-String-'></a>
### PackageWebBandwidthStats(packageId) `method`

##### Summary

Get the bandwidth stats and hits.

##### Returns

The raw json response as a string

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| packageId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The id of the package |

<a name='M-TwentyI_dotnet-TwentyIApi-PackageWebBlockedCountries-System-String-'></a>
### PackageWebBlockedCountries(packageId) `method`

##### Summary

Get blocked countries, in the format of 2-digit ISO codes.

##### Returns

The raw json response as a string

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| packageId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The id of the package |

<a name='M-TwentyI_dotnet-TwentyIApi-PackageWebBlockedCountries-System-String,System-String-'></a>
### PackageWebBlockedCountries(packageId,body) `method`

##### Summary

Set the blocked countries for the site.

##### Returns

The raw json response as a string

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| packageId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The id of the package |
| body | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The body of the request |

##### Remarks

sample body: {countries: ["string"] }

<a name='M-TwentyI_dotnet-TwentyIApi-PackageWebBlockedIpAddresses-System-String-'></a>
### PackageWebBlockedIpAddresses(packageId) `method`

##### Summary

Get blocked IP addresses either in standard format or in CIDR format.

##### Returns

The raw json response as a string

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| packageId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The id of the package |

<a name='M-TwentyI_dotnet-TwentyIApi-PackageWebBlockedIpAddresses-System-String,System-String-'></a>
### PackageWebBlockedIpAddresses(packageId,body) `method`

##### Summary

Set the blocked IP addresses for the web|package. This is an array of IP addresses, with an optional CIDR range.

##### Returns

The raw json response as a string

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| packageId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The id of the package |
| body | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The body of the request |

##### Remarks

sample body: { ip_addresses: ["string"] }

<a name='M-TwentyI_dotnet-TwentyIApi-PackageWebCdnStats-System-String-'></a>
### PackageWebCdnStats(packageId) `method`

##### Summary

Returns the CDN statistics for the package.

##### Returns

The raw json response as a string

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| packageId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The id of the package |

<a name='M-TwentyI_dotnet-TwentyIApi-PackageWebCdnStatsTrafficDistribution-System-String-'></a>
### PackageWebCdnStatsTrafficDistribution(packageId) `method`

##### Summary

Shows bandwidth and hits split by country as recorded by our edge CDN platform

##### Returns

The raw json response as a string

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| packageId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The id of the package |

<a name='M-TwentyI_dotnet-TwentyIApi-PackageWebCertificates-System-String-'></a>
### PackageWebCertificates(packageId) `method`

##### Summary

Gets an array of all the certificates attached to virtual hosts on this web.
Both free and external SSLs will be retreived.

##### Returns

The raw json response as a string

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| packageId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The id of the package |

<a name='M-TwentyI_dotnet-TwentyIApi-PackageWebCertificatesUpdate-System-String,System-String-'></a>
### PackageWebCertificatesUpdate(packageId,body) `method`

##### Summary

Remove or update certificates from the Web. Currently only remove is supported.

##### Returns

The raw json response as a string

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| packageId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The id of the package |
| body | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The raw json body |

##### Remarks

sample body: { delete: ["string"] }

<a name='M-TwentyI_dotnet-TwentyIApi-PackageWebDatabase-System-String,System-String-'></a>
### PackageWebDatabase(packageId,databaseId) `method`

##### Summary

Returns some information about the database.

##### Returns

The raw json response as a string

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| packageId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The id of the package |
| databaseId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The id of the database |

<a name='M-TwentyI_dotnet-TwentyIApi-PackageWebDirectoryIndex-System-String-'></a>
### PackageWebDirectoryIndex(packageId) `method`

##### Summary

Retrieve directory listing configuration.

##### Returns

The raw json response as a string

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| packageId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The id of the package |

<a name='M-TwentyI_dotnet-TwentyIApi-PackageWebDirectoryIndex-System-String,System-String-'></a>
### PackageWebDirectoryIndex(packageId,body) `method`

##### Summary

Set up to 5 files for the directory index in the htaccess.

##### Returns

The raw json response as a string

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| packageId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The id of the package |
| body | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The body of the request |

##### Remarks

sample body: { directoryIndex: ["string"] }

<a name='M-TwentyI_dotnet-TwentyIApi-PackageWebDirectoryIndexing-System-String-'></a>
### PackageWebDirectoryIndexing(packageId) `method`

##### Summary

Get the directory indexing state

##### Returns

The raw json response as a string

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| packageId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The id of the package |

<a name='M-TwentyI_dotnet-TwentyIApi-PackageWebDirectoryIndexing-System-String,System-String-'></a>
### PackageWebDirectoryIndexing(packageId,body) `method`

##### Summary

Directory indexing allows visitors to view a list of files instead of the actual webpage. This can turn on/off
directory indexing for the website

##### Returns

The raw json response as a string

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| packageId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The id of the package |
| body | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The body of the request |

##### Remarks

sample body: { value: true }

<a name='M-TwentyI_dotnet-TwentyIApi-PackageWebDiskUsage-System-String,System-String-'></a>
### PackageWebDiskUsage(packageId,body) `method`

##### Summary

Get report details for Web disk usage.

##### Returns

The raw json response as a string

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| packageId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The id of the package |
| body | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The body of the request |

##### Remarks

body: { reportId:"string" }

<a name='M-TwentyI_dotnet-TwentyIApi-PackageWebDocumentRoots-System-String-'></a>
### PackageWebDocumentRoots(packageId) `method`

##### Summary

Returns a map of DNS names to document root subpaths for the site.

##### Returns

The raw json response as a string

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| packageId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The id of the package |

<a name='M-TwentyI_dotnet-TwentyIApi-PackageWebDomainCheck-System-String,System-String-'></a>
### PackageWebDomainCheck(packageId,body) `method`

##### Summary

Get details about a given domain, ie is this a domain or subdomain.

##### Returns

The raw json response as a string

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| packageId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The id of the package |
| body | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The body of the request |

##### Remarks

sample body: { domain: "string" }

<a name='M-TwentyI_dotnet-TwentyIApi-PackageWebExternalSsl-System-String,System-String-'></a>
### PackageWebExternalSsl(packageId,body) `method`

##### Summary

Install an external SSL certificate.

##### Returns

The raw json response as a string

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| packageId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The id of the package |
| body | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The raw json body |

##### Remarks

sample body: { name: "string", certificate: "string", key: "string", ca: "string" }

<a name='M-TwentyI_dotnet-TwentyIApi-PackageWebFilePermissions-System-String-'></a>
### PackageWebFilePermissions(packageId) `method`

##### Summary

Get the file permissions that do not match the platform recommendations

##### Returns

The raw json response as a string

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| packageId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The id of the package |

<a name='M-TwentyI_dotnet-TwentyIApi-PackageWebFilePermissions-System-String,System-String-'></a>
### PackageWebFilePermissions(packageId,body) `method`

##### Summary

Set file permissions

##### Returns

The raw json response as a string

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| packageId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The id of the package |
| body | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The body of the request |

##### Remarks

sample body: { permissionCheckId: 1, files:{ file: "string", perms: 1 } }

<a name='M-TwentyI_dotnet-TwentyIApi-PackageWebForceSsl-System-String-'></a>
### PackageWebForceSsl(packageId) `method`

##### Summary

Returns whether the site has forced SSL.

##### Returns

The raw json response as a string

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| packageId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The id of the package |

<a name='M-TwentyI_dotnet-TwentyIApi-PackageWebForceSsl-System-String,System-String-'></a>
### PackageWebForceSsl(packageId,body) `method`

##### Summary

Sets the Force SSL flag for a site.

##### Returns

The raw json response as a string

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| packageId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The id of the package |
| body | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The raw json body |

##### Remarks

sample body: { value: true }

<a name='M-TwentyI_dotnet-TwentyIApi-PackageWebFreeSsl-System-String,System-String-'></a>
### PackageWebFreeSsl(packageId,body) `method`

##### Summary

This will toggle the free SSL for a web name.
The lower level platform handles nameserver checks.

##### Returns

The raw json response as a string

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| packageId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The id of the package |
| body | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The raw json body |

##### Remarks

sample body: { name: "string", enabled: true }

<a name='M-TwentyI_dotnet-TwentyIApi-PackageWebFtpCredentials-System-String-'></a>
### PackageWebFtpCredentials(packageId) `method`

##### Summary

Returns the FTP credentials (if any).

##### Returns

The raw json response as a string

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| packageId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The id of the package |

<a name='M-TwentyI_dotnet-TwentyIApi-PackageWebFtpUsers-System-String-'></a>
### PackageWebFtpUsers(packageId) `method`

##### Summary

Returns an array of FTP users for this ExternalId and the Acl associated with the FTP account

##### Returns

The raw json response as a string

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| packageId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The id of the package |

<a name='M-TwentyI_dotnet-TwentyIApi-PackageWebFtpUsers-System-String,System-String-'></a>
### PackageWebFtpUsers(packageId,body) `method`

##### Summary

Update or create a new FTP user. This method will handle the creation of new FTP users and updating existing FTP
users.

##### Returns

The raw json response as a string

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| packageId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The id of the package |
| body | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The body of the request |

##### Remarks

sample body: { new:{ ftp:{ user:{ Username: "string", Domain: "string", Password: "string", JailFrom:
"string" } } }, update:{ ftp:{ id: "string", user:{ Password: "string", JailFrom: "string", UnlockedUntil:
"string", Enabled: true }, acl: "string" } }, delete:{ ftp:{ id: ["string"] } } }

<a name='M-TwentyI_dotnet-TwentyIApi-PackageWebHomeDirectory-System-String-'></a>
### PackageWebHomeDirectory(packageId) `method`

##### Summary

Returns the home directory for the web site.

##### Returns

The raw json response as a string

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| packageId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The id of the package |

<a name='M-TwentyI_dotnet-TwentyIApi-PackageWebInstalledApplications-System-String-'></a>
### PackageWebInstalledApplications(packageId) `method`

##### Summary

Return a list of installed applications

##### Returns

The raw json response as a string

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| packageId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The id of the package |

<a name='M-TwentyI_dotnet-TwentyIApi-PackageWebInstalledApplications-System-String,System-String-'></a>
### PackageWebInstalledApplications(packageId,body) `method`

##### Summary

Add, remove and update applications and set their environment Currently only one type (add,update,delete,setEnv) is
supported per request.

##### Returns

The raw json response as a string

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| packageId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The id of the package |
| body | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The json body to send |

##### Remarks

json sample { add:{ domain: "string", environment: "string", name: "string", path: "string", script: "string",
typeCode: "string" }, update:{ domain: "string", environment: "string", name: "string", path: "string", script:
"string", typeCode: "string" }, delete:{ id: "string" }, setEnv:{ id: "string", environment: "string" } }

<a name='M-TwentyI_dotnet-TwentyIApi-PackageWebInstalledSoftware-System-String-'></a>
### PackageWebInstalledSoftware(packageId) `method`

##### Summary

Returns a list of installed software by type code on managed server.

##### Returns

The raw json response as a string

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| packageId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The id of the package |

<a name='M-TwentyI_dotnet-TwentyIApi-PackageWebLimits-System-String-'></a>
### PackageWebLimits(packageId) `method`

##### Summary

Retrieve limits for a web.

##### Returns

The raw json response as a string

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| packageId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The id of the package |

<a name='M-TwentyI_dotnet-TwentyIApi-PackageWebLogs-System-String-'></a>
### PackageWebLogs(packageId) `method`

##### Summary

Get access and error logs for the site.

##### Returns

The raw json response as a string

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| packageId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The id of the package |

<a name='M-TwentyI_dotnet-TwentyIApi-PackageWebMaintenanceMode-System-String-'></a>
### PackageWebMaintenanceMode(packageId) `method`

##### Summary

Get maintenance mode settings for this web.

##### Returns

The raw json response as a string

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| packageId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The id of the package |

<a name='M-TwentyI_dotnet-TwentyIApi-PackageWebMaintenanceMode-System-String,System-String-'></a>
### PackageWebMaintenanceMode(packageId,body) `method`

##### Summary

Set maintenance mode settings for this web.

##### Returns

The raw json response as a string

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| packageId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The id of the package |
| body | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The raw json body |

##### Remarks

sample body: {"enabled":true}

<a name='M-TwentyI_dotnet-TwentyIApi-PackageWebMalwareReport-System-String-'></a>
### PackageWebMalwareReport(packageId) `method`

##### Summary

Returns the latest malware report for a given website

##### Returns

The raw json response as a string

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| packageId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The id of the package |

<a name='M-TwentyI_dotnet-TwentyIApi-PackageWebMalwareScan-System-String-'></a>
### PackageWebMalwareScan(packageId) `method`

##### Summary

Get the malware scan objects for this web

##### Returns

The raw json response as a string

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| packageId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The id of the package |

<a name='M-TwentyI_dotnet-TwentyIApi-PackageWebMalwareScan-System-String,System-String-'></a>
### PackageWebMalwareScan(packageId,body) `method`

##### Summary

Set Mailware Scan lock state, setting to "new" will request a new scan

##### Returns

The raw json response as a string

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| packageId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The id of the package |
| body | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The raw json body |

##### Remarks

sample body: {"LockState":"new"}

<a name='M-TwentyI_dotnet-TwentyIApi-PackageWebMssqlDatabases-System-String-'></a>
### PackageWebMssqlDatabases(packageId) `method`

##### Summary

Get MSSQL Databases.

##### Returns

The raw json response as a string

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| packageId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The id of the package |

<a name='M-TwentyI_dotnet-TwentyIApi-PackageWebMssqlDatabases-System-String,System-String-'></a>
### PackageWebMssqlDatabases(packageId,body) `method`

##### Summary

Create a new MSSQL Database and a user with the same name.

##### Returns

The raw json response as a string

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| packageId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The id of the package |
| body | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The raw json body |

##### Remarks

sample body: { name: "string",password: "string" }

<a name='M-TwentyI_dotnet-TwentyIApi-PackageWebMssqlUserPassword-System-String,System-String-'></a>
### PackageWebMssqlUserPassword(packageId,body) `method`

##### Summary

Update the password for an MSSQL user.

##### Returns

The raw json response as a string

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| packageId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The id of the package |
| body | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The raw json body |

##### Remarks

sample body: { databaseId: 1, userId: 1, password: "string" }

<a name='M-TwentyI_dotnet-TwentyIApi-PackageWebMssqlUsers-System-String,System-String-'></a>
### PackageWebMssqlUsers(packageId,body) `method`

##### Summary

Add a user to an MSSQL database.

##### Returns

The raw json response as a string

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| packageId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The id of the package |
| body | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The raw json body |

##### Remarks

sample body: { databaseId: 1, username: "string", password: "string" }

<a name='M-TwentyI_dotnet-TwentyIApi-PackageWebMysqlDatabase-System-String,System-String-'></a>
### PackageWebMysqlDatabase(packageId,body) `method`

##### Summary

Create a MySQL database.

##### Returns

The raw json response as a string

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| packageId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The id of the package |
| body | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The raw json body |

##### Remarks

sample body: { name: "string", password: "string", allow_random: true }

<a name='M-TwentyI_dotnet-TwentyIApi-PackageWebMysqlDatabases-System-String-'></a>
### PackageWebMysqlDatabases(packageId) `method`

##### Summary

Get all MySQL databases.

##### Returns

The raw json response as a string

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| packageId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The id of the package |

<a name='M-TwentyI_dotnet-TwentyIApi-PackageWebMysqlGrantUserDatabase-System-String,System-String-'></a>
### PackageWebMysqlGrantUserDatabase(packageId,body) `method`

##### Summary

Grant an existing user the default privileges on a database.

##### Returns

The raw json response as a string

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| packageId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The id of the package |
| body | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The raw json body |

##### Remarks

sample body: { username: "string", database: "string" }

<a name='M-TwentyI_dotnet-TwentyIApi-PackageWebMysqlGrants-System-String-'></a>
### PackageWebMysqlGrants(packageId) `method`

##### Summary

Get the grants for MySQL users and databases.

##### Returns

The raw json response as a string

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| packageId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The id of the package |

<a name='M-TwentyI_dotnet-TwentyIApi-PackageWebMysqlGrants-System-String,System-String-'></a>
### PackageWebMysqlGrants(packageId,body) `method`

##### Summary

Update the grants for MySQL users and databases.

##### Returns

The raw json response as a string

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| packageId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The id of the package |
| body | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The raw json body |

##### Remarks

sample body: { user_id: "string", username: "string", database: "string", grants: ["string"] }

<a name='M-TwentyI_dotnet-TwentyIApi-PackageWebMysqlSso-System-String-'></a>
### PackageWebMysqlSso(packageId) `method`

##### Summary

Get a list of each MySQL database server and a Single Sign on link for each.

##### Returns

The raw json response as a string

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| packageId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The id of the package |

<a name='M-TwentyI_dotnet-TwentyIApi-PackageWebMysqlUserIpAcl-System-String-'></a>
### PackageWebMysqlUserIpAcl(packageId) `method`

##### Summary

Get the external IP addresses that MySQL users are allowed to connect to remotely.

##### Returns

The raw json response as a string

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| packageId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The id of the package |

<a name='M-TwentyI_dotnet-TwentyIApi-PackageWebMysqlUserIpAcl-System-String,System-String-'></a>
### PackageWebMysqlUserIpAcl(packageId,body) `method`

##### Summary

Update the external IP addresses that MySQL users are allowed to connect to remotely.

##### Returns

The raw json response as a string

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| packageId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The id of the package |
| body | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The raw json body |

##### Remarks

sample body: { add:{ user_id: 1, hosts: "string" }, remove:{ user_id: 1, id: 1 } }

<a name='M-TwentyI_dotnet-TwentyIApi-PackageWebMysqlUserPassword-System-String,System-String-'></a>
### PackageWebMysqlUserPassword(packageId,body) `method`

##### Summary

Update a MySQL user's password.

##### Returns

The raw json response as a string

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| packageId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The id of the package |
| body | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The raw json body |

##### Remarks

sample body: { user_id: 1, password: "string" }

<a name='M-TwentyI_dotnet-TwentyIApi-PackageWebMysqlUsers-System-String-'></a>
### PackageWebMysqlUsers(packageId) `method`

##### Summary

Get all mysql users.

##### Returns

The raw json response as a string

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| packageId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The id of the package |

<a name='M-TwentyI_dotnet-TwentyIApi-PackageWebMysqlUsers-System-String,System-String-'></a>
### PackageWebMysqlUsers(packageId,body) `method`

##### Summary

Create a new mysql user.

##### Returns

The raw json response as a string

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| packageId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The id of the package |
| body | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The raw json body |

##### Remarks

sample body: { username: "string", password: "string", database: "string" }

<a name='M-TwentyI_dotnet-TwentyIApi-PackageWebNames-System-String,System-String-'></a>
### PackageWebNames(packageId,body) `method`

##### Summary

Add or remove names from the Web. This is mostly handled on the corresponding Package.

##### Returns

The raw json response as a string

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| packageId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The id of the package |
| body | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The body of the request |

##### Remarks

sample body: { add: ["string"], rem: ["string"], chg: "string" }

<a name='M-TwentyI_dotnet-TwentyIApi-PackageWebOneclick-System-String-'></a>
### PackageWebOneclick(packageId) `method`

##### Summary

Returns an array for One Click objects that contain details of the current version and details in use

##### Returns

The raw json response as a string

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| packageId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The id of the package |

<a name='M-TwentyI_dotnet-TwentyIApi-PackageWebOneclick-System-String,System-String-'></a>
### PackageWebOneclick(packageId,body) `method`

##### Summary

Install a One Click package.

##### Returns

The raw json response as a string

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| packageId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The id of the package |
| body | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The raw json body |

##### Remarks

sample body: { domain: "string", httpsDomain: "string", oneclick: "string", directory: "string", licenceKey:
"string" }

<a name='M-TwentyI_dotnet-TwentyIApi-PackageWebPasswordProtection-System-String-'></a>
### PackageWebPasswordProtection(packageId) `method`

##### Summary

Get the password protected directories.

##### Returns

The raw json response as a string

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| packageId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The id of the package |

<a name='M-TwentyI_dotnet-TwentyIApi-PackageWebPasswordProtection-System-String,System-String-'></a>
### PackageWebPasswordProtection(packageId,body) `method`

##### Summary

Set the password protected directories

##### Returns

The raw json response as a string

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| packageId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The id of the package |
| body | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The raw json body |

##### Remarks

sample body: { directories:{ directory: "string", username: "string", password: "string" } }

<a name='M-TwentyI_dotnet-TwentyIApi-PackageWebPhpConfig-System-String,System-String-'></a>
### PackageWebPhpConfig(packageId,phpConfigId) `method`

##### Summary

Returns the PHP config for a name.

##### Returns

The raw json response as a string

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| packageId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The id of the package |
| phpConfigId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The id of the php config |

<a name='M-TwentyI_dotnet-TwentyIApi-PackageWebPhpConfigUpdateConfig-System-String,System-String,System-String-'></a>
### PackageWebPhpConfigUpdateConfig(packageId,phpConfigId,body) `method`

##### Summary

Update the PHP configuration for a name.

##### Returns

The raw json response as a string

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| packageId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The id of the package |
| phpConfigId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The id of the php config |
| body | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The raw json body |

##### Remarks

sample body: { config:{ (key): "string" } }

<a name='M-TwentyI_dotnet-TwentyIApi-PackageWebPhpVersion-System-String-'></a>
### PackageWebPhpVersion(packageId) `method`

##### Summary

Get the PHP version for the site.

##### Returns

The raw json response as a string

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| packageId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The id of the package |

<a name='M-TwentyI_dotnet-TwentyIApi-PackageWebPhpVersion-System-String,System-String-'></a>
### PackageWebPhpVersion(packageId,body) `method`

##### Summary

Set the PHP version for the site.

##### Returns

The raw json response as a string

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| packageId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The id of the package |
| body | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The raw json body |

##### Remarks

sample body: { value:"string"}

<a name='M-TwentyI_dotnet-TwentyIApi-PackageWebPreventHotlinking-System-String-'></a>
### PackageWebPreventHotlinking(packageId) `method`

##### Summary

Get the prevent hotlinking config.

##### Returns

The raw json response as a string

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| packageId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The id of the package |

<a name='M-TwentyI_dotnet-TwentyIApi-PackageWebPreventHotlinking-System-String,System-String-'></a>
### PackageWebPreventHotlinking(packageId,body) `method`

##### Summary

Set the prevent hotlinking config.

##### Returns

The raw json response as a string

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| packageId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The id of the package |
| body | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The body of the request |

##### Remarks

sample body: { AllowDirect: true, AllowedHostnames: ["string"], RedirectURL: "string", Extensions: ["string"]
}

<a name='M-TwentyI_dotnet-TwentyIApi-PackageWebRecycleApplicationPool-System-String-'></a>
### PackageWebRecycleApplicationPool(packageId) `method`

##### Summary

Recycle a Windows application pool.

##### Returns

The raw json response as a string

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| packageId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The id of the package |

##### Remarks

body: {  }

<a name='M-TwentyI_dotnet-TwentyIApi-PackageWebRedirects-System-String-'></a>
### PackageWebRedirects(packageId) `method`

##### Summary

Returns a list of redirects for the site.

##### Returns

The raw json response as a string

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| packageId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The id of the package |

<a name='M-TwentyI_dotnet-TwentyIApi-PackageWebRedirects-System-String,System-String-'></a>
### PackageWebRedirects(packageId,body) `method`

##### Summary

Set the website redirects.

##### Returns

The raw json response as a string

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| packageId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The id of the package |
| body | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The raw json body |

##### Remarks

sample body:{ redirects:{ domain: "string", from: "string", to: "string", type: "string" } }

<a name='M-TwentyI_dotnet-TwentyIApi-PackageWebReinstall-System-String-'></a>
### PackageWebReinstall(packageId) `method`

##### Summary

Re-install from platform. This will re-install software in the hosting space.
EG wordpress package types will re-install wordpress

##### Returns

The raw json response as a string

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| packageId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The id of the package |

<a name='M-TwentyI_dotnet-TwentyIApi-PackageWebRemoveMssqlDatabase-System-String,System-String-'></a>
### PackageWebRemoveMssqlDatabase(packageId,body) `method`

##### Summary

Remove an MSSQL database.

##### Returns

The raw json response as a string

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| packageId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The id of the package |
| body | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The raw json body |

##### Remarks

sample body: { id: 1 }

<a name='M-TwentyI_dotnet-TwentyIApi-PackageWebRemoveMssqlUser-System-String,System-String-'></a>
### PackageWebRemoveMssqlUser(packageId,body) `method`

##### Summary

Remove an MSSQL user.

##### Returns

The raw json response as a string

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| packageId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The id of the package |
| body | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The raw json body |

##### Remarks

sample body: { databaseId: 1, userId: 1 }

<a name='M-TwentyI_dotnet-TwentyIApi-PackageWebRemoveMysqlDatabase-System-String,System-String-'></a>
### PackageWebRemoveMysqlDatabase(packageId,body) `method`

##### Summary

Remove a MySQL database.

##### Returns

The raw json response as a string

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| packageId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The id of the package |
| body | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The raw json body |

##### Remarks

sample body: { id: 1 }

<a name='M-TwentyI_dotnet-TwentyIApi-PackageWebRemoveMysqlUser-System-String,System-String-'></a>
### PackageWebRemoveMysqlUser(packageId,body) `method`

##### Summary

Remove a MySQL user.

##### Returns

The raw json response as a string

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| packageId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The id of the package |
| body | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The raw json body |

##### Remarks

sample body: { id: 1 }

<a name='M-TwentyI_dotnet-TwentyIApi-PackageWebRequestDiskUsage-System-String,System-String-'></a>
### PackageWebRequestDiskUsage(packageId,body) `method`

##### Summary

Request Disk Usage Report

##### Returns

The raw json response as a string

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| packageId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The id of the package |
| body | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The body of the request |

##### Remarks

sample body: { subdirectory: "string" }

<a name='M-TwentyI_dotnet-TwentyIApi-PackageWebRestoreWebsiteBackup-System-String,System-String-'></a>
### PackageWebRestoreWebsiteBackup(packageId,body) `method`

##### Summary

Restore a backup file which has been uploaded via FTP

##### Returns

The raw json response as a string

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| packageId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The id of the package |
| body | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The raw json body |

##### Remarks

sample body: { filename: "string", restore_type: "string", restore_databases: true }

<a name='M-TwentyI_dotnet-TwentyIApi-PackageWebSitemap-System-String-'></a>
### PackageWebSitemap(packageId) `method`

##### Summary

Get the sitemap jobs, only returls a single jobs (last returned from platform)

##### Returns

The raw json response as a string

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| packageId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The id of the package |

<a name='M-TwentyI_dotnet-TwentyIApi-PackageWebSitemapStart-System-String-'></a>
### PackageWebSitemapStart(packageId) `method`

##### Summary

Start a sitemap job.

##### Returns

The raw json response as a string

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| packageId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The id of the package |

##### Remarks

sample body: { }

<a name='M-TwentyI_dotnet-TwentyIApi-PackageWebSshAuthenticator-System-String,System-String-'></a>
### PackageWebSshAuthenticator(packageId,body) `method`

##### Summary

Set ssh authenticator status.

##### Returns

The raw json response as a string

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| packageId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The id of the package |
| body | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The raw json body |

##### Remarks

sample body: { status:"string" }

<a name='M-TwentyI_dotnet-TwentyIApi-PackageWebSshKeys-System-String-'></a>
### PackageWebSshKeys(packageId) `method`

##### Summary

Get a list of SSH keys for this package.

##### Returns

The raw json response as a string

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| packageId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The id of the package |

<a name='M-TwentyI_dotnet-TwentyIApi-PackageWebSshKeysUpdate-System-String,System-String-'></a>
### PackageWebSshKeysUpdate(packageId,body) `method`

##### Summary

Update or add new SSH keys.

##### Returns

The raw json response as a string

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| packageId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The id of the package |
| body | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The raw json body |

##### Remarks

sample body: { add:{ key: "string", handle: "string" }, delete: ["string"] }

<a name='M-TwentyI_dotnet-TwentyIApi-PackageWebSshPassword-System-String-'></a>
### PackageWebSshPassword(packageId) `method`

##### Summary

Get the SSH password for this package.

##### Returns

The raw json response as a string

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| packageId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The id of the package |

<a name='M-TwentyI_dotnet-TwentyIApi-PackageWebSshPasswordUpdate-System-String,System-String-'></a>
### PackageWebSshPasswordUpdate(packageId,body) `method`

##### Summary

Set the SSH password for this package.

##### Returns

The raw json response as a string

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| packageId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The id of the package |
| body | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The raw json body |

##### Remarks

sample body: { password: "string" }

<a name='M-TwentyI_dotnet-TwentyIApi-PackageWebStackCache-System-String-'></a>
### PackageWebStackCache(packageId) `method`

##### Summary

Get stack cache settings

##### Returns

The raw json response as a string

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| packageId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The id of the package |

<a name='M-TwentyI_dotnet-TwentyIApi-PackageWebStackCache-System-String,System-String-'></a>
### PackageWebStackCache(packageId,body) `method`

##### Summary

Create or update stack cache settings

##### Returns

The raw json response as a string

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| packageId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The id of the package |
| body | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The raw json body |

##### Remarks

sample body: { css: "string", images: "string", javascript: "string" }

<a name='M-TwentyI_dotnet-TwentyIApi-PackageWebSubdomains-System-String-'></a>
### PackageWebSubdomains(packageId) `method`

##### Summary

Returns the list of subdomain names mapped to their document roots.

##### Returns

The raw json response as a string

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| packageId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The id of the package |

<a name='M-TwentyI_dotnet-TwentyIApi-PackageWebSubdomains-System-String,System-String-'></a>
### PackageWebSubdomains(packageId,body) `method`

##### Summary

This does the same as POSTing to /names except that it enforces the subdomain limit and disallows non-subdomains.

##### Returns

The raw json response as a string

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| packageId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The id of the package |
| body | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The raw json body |

##### Remarks

sample body: { add: ["string"], rem: ["string"] }

<a name='M-TwentyI_dotnet-TwentyIApi-PackageWebTasks-System-String-'></a>
### PackageWebTasks(packageId) `method`

##### Summary

Returns an array of currently configured cron tasks.

##### Returns

The raw json response as a string

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| packageId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The id of the package |

<a name='M-TwentyI_dotnet-TwentyIApi-PackageWebTasks-System-String,System-String-'></a>
### PackageWebTasks(packageId,body) `method`

##### Summary

Update, create or delete cron task.

##### Returns

The raw json response as a string

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| packageId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The id of the package |
| body | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The raw json body |

##### Remarks

sample body: { new:{ task:{ Enabled: true, MailTo: "string", TimeSpec: "string", Command: "string" } },
delete:{ task:{ id: ["string"] } }, update:{ task:{ id: "string", Enabled: true, MailTo: "string", TimeSpec:
"string", Command: "string" } } }

<a name='M-TwentyI_dotnet-TwentyIApi-PackageWebTestCronTask-System-String,System-String-'></a>
### PackageWebTestCronTask(packageId,body) `method`

##### Summary

Test a cron task.

##### Returns

The raw json response as a string

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| packageId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The id of the package |
| body | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The raw json body |

##### Remarks

sample body: { task:"string" }

<a name='M-TwentyI_dotnet-TwentyIApi-PackageWebUsage-System-String-'></a>
### PackageWebUsage(packageId) `method`

##### Summary

Get the bandwidth and disk usage stats for the current package

##### Returns

The raw json response as a string

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| packageId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The id of the package |

<a name='M-TwentyI_dotnet-TwentyIApi-PackageWebWebsiteBuilderSso-System-String-'></a>
### PackageWebWebsiteBuilderSso(packageId) `method`

##### Summary

Returns the Website Builder SSO link.

##### Returns

The raw json response as a string

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| packageId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The id of the package |

<a name='M-TwentyI_dotnet-TwentyIApi-PackageWebWindowsConfiguration-System-String-'></a>
### PackageWebWindowsConfiguration(packageId) `method`

##### Summary

Get the existing Windows configuration.

##### Returns

The raw json response as a string

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| packageId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The id of the package |

<a name='M-TwentyI_dotnet-TwentyIApi-PackageWebWindowsConfiguration-System-String,System-String-'></a>
### PackageWebWindowsConfiguration(packageId,body) `method`

##### Summary

Update the Windows application pool configuration.
For example; the runtime version, and the pipeline mode type.

##### Returns

The raw json response as a string

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| packageId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The id of the package |
| body | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The body of the request |

##### Remarks

sample body: { ApplicationPoolPipelineMode: "string", ApplicationPoolRuntimeVersion: "string" }

<a name='M-TwentyI_dotnet-TwentyIApi-PackageWebWordpressAdministrators-System-String-'></a>
### PackageWebWordpressAdministrators(packageId) `method`

##### Summary

Get the WordPress administrator users.

##### Returns

The raw json response as a string

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| packageId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The id of the package |

<a name='M-TwentyI_dotnet-TwentyIApi-PackageWebWordpressChecksum-System-String-'></a>
### PackageWebWordpressChecksum(packageId) `method`

##### Summary

Get a checksum report of WordPress core files.

##### Returns

The raw json response as a string

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| packageId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The id of the package |

<a name='M-TwentyI_dotnet-TwentyIApi-PackageWebWordpressChecksum-System-String,System-String-'></a>
### PackageWebWordpressChecksum(packageId,body) `method`

##### Summary

Ask the platform to fix any checksum issues

##### Returns

The raw json response as a string

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| packageId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The id of the package |
| body | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The body of the request |

##### Remarks

sample body: { }

<a name='M-TwentyI_dotnet-TwentyIApi-PackageWebWordpressDbCheck-System-String-'></a>
### PackageWebWordpressDbCheck(packageId) `method`

##### Summary

Returns a boolean denoting the result of the wordpress database check.

##### Returns

The raw json response as a string

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| packageId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The id of the package |

<a name='M-TwentyI_dotnet-TwentyIApi-PackageWebWordpressInstallStackCache-System-String,System-String-'></a>
### PackageWebWordpressInstallStackCache(packageId,body) `method`

##### Summary

Install the StackCache plugin for this package.

##### Returns

The raw json response as a string

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| packageId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The id of the package |
| body | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The body of the request |

##### Remarks

sample body: { }

<a name='M-TwentyI_dotnet-TwentyIApi-PackageWebWordpressIsInstalled-System-String-'></a>
### PackageWebWordpressIsInstalled(packageId) `method`

##### Summary

Checks whether or not WordPress is currently installed.

##### Returns

The raw json response as a string

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| packageId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The id of the package |

<a name='M-TwentyI_dotnet-TwentyIApi-PackageWebWordpressPlugins-System-String-'></a>
### PackageWebWordpressPlugins(packageId) `method`

##### Summary

Returns an array of Installed wordpress plugins.

##### Returns

The raw json response as a string

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| packageId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The id of the package |

<a name='M-TwentyI_dotnet-TwentyIApi-PackageWebWordpressPlugins-System-String,System-String-'></a>
### PackageWebWordpressPlugins(packageId,body) `method`

##### Summary

Set status or remove a WordPress plugin.

##### Returns

The raw json response as a string

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| packageId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The id of the package |
| body | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The body of the request |

##### Remarks

sample body: { type: "string", name: "string" }

<a name='M-TwentyI_dotnet-TwentyIApi-PackageWebWordpressRoles-System-String-'></a>
### PackageWebWordpressRoles(packageId) `method`

##### Summary

Get the WordPress roles.

##### Returns

The raw json response as a string

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| packageId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The id of the package |

<a name='M-TwentyI_dotnet-TwentyIApi-PackageWebWordpressSearchReplace-System-String,System-String-'></a>
### PackageWebWordpressSearchReplace(packageId,body) `method`

##### Summary

Perform a WordPress search and replace.

##### Returns

The raw json response as a string

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| packageId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The id of the package |
| body | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The body of the request |

##### Remarks

body { search: "string", replace: "string" }

<a name='M-TwentyI_dotnet-TwentyIApi-PackageWebWordpressSettings-System-String-'></a>
### PackageWebWordpressSettings(packageId) `method`

##### Summary

Get the WordPress site settings

##### Returns

The raw json response as a string

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| packageId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The id of the package |

<a name='M-TwentyI_dotnet-TwentyIApi-PackageWebWordpressSettings-System-String,System-String-'></a>
### PackageWebWordpressSettings(packageId,body) `method`

##### Summary

Set a WordPress site setting

##### Returns

The raw json response as a string

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| packageId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The id of the package |
| body | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The body of the request |

##### Remarks

sample body: { option_name: "string", option_value: "string" }

<a name='M-TwentyI_dotnet-TwentyIApi-PackageWebWordpressStaging-System-String-'></a>
### PackageWebWordpressStaging(packageId) `method`

##### Summary

Returns a result based on whether the staging version is in place.

##### Returns

The raw json response as a string

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| packageId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The id of the package |

<a name='M-TwentyI_dotnet-TwentyIApi-PackageWebWordpressStaging-System-String,System-String-'></a>
### PackageWebWordpressStaging(packageId,body) `method`

##### Summary

Clone a new WordPress site either from live to staging or from staging to live.

##### Returns

The raw json response as a string

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| packageId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The id of the package |
| body | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The body of the request |

##### Remarks

sample body: { type:"string" }

<a name='M-TwentyI_dotnet-TwentyIApi-PackageWebWordpressStagingRemoveClone-System-String,System-String-'></a>
### PackageWebWordpressStagingRemoveClone(packageId,body) `method`

##### Summary

Remove a staging clone by id

##### Returns

The raw json response as a string

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| packageId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The id of the package |
| body | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The body of the request |

##### Remarks

sample body: { id: 1 }

<a name='M-TwentyI_dotnet-TwentyIApi-PackageWebWordpressTheme-System-String,System-String-'></a>
### PackageWebWordpressTheme(packageId,body) `method`

##### Summary

Set status (i.e. activate/deactivate) or remove a WordPress theme.

##### Returns

The raw json response as a string

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| packageId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The id of the package |
| body | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The body of the request |

##### Remarks

sample body: { type: "string", name: "string" }

<a name='M-TwentyI_dotnet-TwentyIApi-PackageWebWordpressThemes-System-String-'></a>
### PackageWebWordpressThemes(packageId) `method`

##### Summary

Returns an array of the installed WordPress themes.

##### Returns

The raw json response as a string

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| packageId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The id of the package |

<a name='M-TwentyI_dotnet-TwentyIApi-PackageWebWordpressUpdate-System-String,System-String-'></a>
### PackageWebWordpressUpdate(packageId,body) `method`

##### Summary

Update WordPress to the latest version.

##### Returns

The raw json response as a string

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| packageId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The id of the package |
| body | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The body of the request |

##### Remarks

sample body: {  }

<a name='M-TwentyI_dotnet-TwentyIApi-PackageWebWordpressUsers-System-String-'></a>
### PackageWebWordpressUsers(packageId) `method`

##### Summary

Get Wordpress Users

##### Returns

The raw json response as a string

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| packageId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The id of the package |

<a name='M-TwentyI_dotnet-TwentyIApi-PackageWebWordpressVersion-System-String-'></a>
### PackageWebWordpressVersion(packageId) `method`

##### Summary

Get the WordPress version if installed.

##### Returns

The raw json response as a string

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| packageId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The id of the package |

<a name='M-TwentyI_dotnet-TwentyIApi-PersonalNameserver-System-String-'></a>
### PersonalNameserver(resellerId) `method`

##### Summary

List Virtual Nameservers

##### Returns

The raw json response as a string

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| resellerId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The id of the reseller |

<a name='M-TwentyI_dotnet-TwentyIApi-ResellerAddDomain-System-String,System-String-'></a>
### ResellerAddDomain(resellerId,body) `method`

##### Summary

Register a domain name.
This will charge the appropriate registration fee to your 20i Balance.
If you don't have enough left, this will fail.
If you enable privacy you will also be charged a fee for the privacy service.
Please note you can also just use contract#add, this method only does a simple reformatting to use that.
Please see the documentation there for details.

##### Returns

The raw json response as a string

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| resellerId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The id of the reseller |
| body | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The body of the request |

##### Remarks

body: { name: "string", years: 1, caRegistryAgreement: true, contact:{ organisation: "string", name:
"string", address: "string", telephone: "string", email: "string", cc: "string", pc: "string", sp: "string", city:
"string", extension:{ } }, limits:{ }, otherContacts:{ (type):{ name: "string", organisation: "string", address:
"string", city: "string", sp: "string", pc: "string", cc: "string", telephone: "string", email: "string",
extension:{ } } }, nameservers: ["string"], privacyService: true, stackUser: "string" }

<a name='M-TwentyI_dotnet-TwentyIApi-ResellerAddMssql-System-String,System-String-'></a>
### ResellerAddMssql(resellerId,body) `method`

##### Summary

Add an MS SQL Server allowance.
This will charge the appropriate fee to your 20i Balance.
If you don't have enough left, this will fail.
Please note you can also use contract#add, this method only does a trivial reformatting to use that, specifically:
https://prnt.sc/RDOOsJYX-nQN

##### Returns

The raw json response as a string

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| resellerId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The id of the reseller |
| body | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The body of the request |

<a name='M-TwentyI_dotnet-TwentyIApi-ResellerAddTlsCertificate-System-String,System-String-'></a>
### ResellerAddTlsCertificate(resellerId,body) `method`

##### Summary

Order a TLS certificate for a site.
This will charge the appropriate fee to your 20i Balance. If you don't have enough left, this will fail.

##### Returns

The raw json response as a string

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| resellerId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The id of the reseller |
| body | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The body of the request |

##### Remarks

body { periodMonths: 1, name: "string", configuration:{ } }

<a name='M-TwentyI_dotnet-TwentyIApi-ResellerAddVps-System-String,System-String-'></a>
### ResellerAddVps(resellerId,body) `method`

##### Summary

Order a vps

##### Returns

The raw json response as a string

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| resellerId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The id of the reseller |
| body | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The body of the request |

##### Remarks

https://prnt.sc/_6Hfr9gHcV2G body { configuration:{ ApplicationId: "string", Name: "string" }, forUser:
"string", options:{ os: "string" }, periodMonths: 1, type: "string" }

<a name='M-TwentyI_dotnet-TwentyIApi-ResellerAddWeb-System-String,System-String-'></a>
### ResellerAddWeb(resellerId,body) `method`

##### Summary

Add a web site.
If a welcome email is set for the type and you pass an existing Stack user reference, the welcome email will be
sent ASAP.

##### Returns

The raw json response as a string

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| resellerId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The id of the reseller |
| body | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The body of the request |

##### Remarks

body: { type: "string", domain_name: "string", extra_domain_names: ["string"], label: "string",
documentRoots:{ (domain): "string" }, stackUser: "string" }

<a name='M-TwentyI_dotnet-TwentyIApi-ResellerBackupBulkPackages-System-String-'></a>
### ResellerBackupBulkPackages(resellerId) `method`

##### Summary

Get existing multisite backups.

##### Returns

The raw json response as a string

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| resellerId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The id of the reseller |

<a name='M-TwentyI_dotnet-TwentyIApi-ResellerBackupBulkPackages-System-String,System-String-'></a>
### ResellerBackupBulkPackages(resellerId,body) `method`

##### Summary

Backup Multiple packages

##### Returns

The raw json response as a string

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| resellerId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The id of the reseller |
| body | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The body of the request |

##### Remarks

sample body:{ id: ["string"], delete: true }

<a name='M-TwentyI_dotnet-TwentyIApi-ResellerDeleteWeb-System-String,System-String-'></a>
### ResellerDeleteWeb(resellerId,body) `method`

##### Summary

Delete the web site/packages using the array of ID's in delete-id as a list of packages to delete.

##### Returns

The raw json response as a string

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| resellerId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The id of the reseller |
| body | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The body of the request |

##### Remarks

body: { delete-id: ["string"] }

<a name='M-TwentyI_dotnet-TwentyIApi-ResellerMailboxQuotaAddon-System-String-'></a>
### ResellerMailboxQuotaAddon(resellerId) `method`

##### Summary

Mailbox quota addons Returns a short, cheap list items.

##### Returns

The raw json response as a string

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| resellerId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The id of the reseller |

<a name='M-TwentyI_dotnet-TwentyIApi-ResellerNominetBrand-System-String-'></a>
### ResellerNominetBrand(resellerId) `method`

##### Summary

Fetch your current Nominet brand settings

##### Returns

The raw json response as a string

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| resellerId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The id of the reseller |

<a name='M-TwentyI_dotnet-TwentyIApi-ResellerNominetBrand-System-String,System-String-'></a>
### ResellerNominetBrand(resellerId,body) `method`

##### Summary

Set Nominet reseller settings

##### Returns

The raw json response as a string

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| resellerId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The id of the reseller |
| body | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The body of the request |

##### Remarks

body { nominetReseller: "string", ukResellerEmail: "string", ukResellerTradingName: "string", ukResellerUrl:
"string", ukResellerVoice: "string" }

<a name='M-TwentyI_dotnet-TwentyIApi-ResellerPackageCount-System-String-'></a>
### ResellerPackageCount(resellerId) `method`

##### Summary

Returns a count of packages split by type. Current types are linux, windows and wordpress

##### Returns

The raw json response as a string

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| resellerId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The id of the reseller |

<a name='M-TwentyI_dotnet-TwentyIApi-ResellerPackageTypeBrand-System-String,System-String-'></a>
### ResellerPackageTypeBrand(resellerId,body) `method`

##### Summary

Fetch the package branding.

##### Returns

The raw json response as a string

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| resellerId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The id of the reseller |
| body | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The body of the request |

##### Remarks

body: { packageid: "string" }

<a name='M-TwentyI_dotnet-TwentyIApi-ResellerPackageTypes-System-String-'></a>
### ResellerPackageTypes(resellerId) `method`

##### Summary

Get package type information.

##### Returns

The raw json response as a string

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| resellerId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The id of the reseller |

<a name='M-TwentyI_dotnet-TwentyIApi-ResellerPackageTypes-System-String,System-String-'></a>
### ResellerPackageTypes(resellerId,body) `method`

##### Summary

Add a web type.

##### Returns

The raw json response as a string

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| resellerId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The id of the reseller |
| body | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The body of the request |

##### Remarks

body { label: "string", platform: "string", limit:{ }, installApps: ["string"], welcomeEmail:{ from:
"string", subject: "string", data: "string" }, passwordResetEmail: "string", defaultPages:{ IndexPageHtml:
"string", DeactivatedPageHtml: "string", ServiceUnavailablePageHtml: "string" }, extraData:{ temporaryUrlDomain:
"string" } }

<a name='M-TwentyI_dotnet-TwentyIApi-ResellerPasswordResetEmail-System-String-'></a>
### ResellerPasswordResetEmail(resellerId) `method`

##### Summary

Get the password reset email template (or the default value)

##### Returns

The raw json response as a string

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| resellerId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The id of the reseller |

<a name='M-TwentyI_dotnet-TwentyIApi-ResellerPasswordResetEmail-System-String,System-String-'></a>
### ResellerPasswordResetEmail(resellerId,body) `method`

##### Summary

Set the password reset email.

##### Returns

The raw json response as a string

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| resellerId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The id of the reseller |
| body | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The body of the request |

##### Remarks

sample body: { content: "string" }

<a name='M-TwentyI_dotnet-TwentyIApi-ResellerRenewDomain-System-String,System-String-'></a>
### ResellerRenewDomain(resellerId,body) `method`

##### Summary

Renew a domain name.
This will charge the appropriate registration fee to your 20i Balance.
If you don't have enough left, this will fail.
Please note you can also use contract/domain:{id}#renew, this method only does a trivial reformatting to use that.

##### Returns

The raw json response as a string

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| resellerId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The id of the reseller |
| body | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The body of the request |

##### Remarks

body { name: "string", years: 1, renewPrivacy: true }

<a name='M-TwentyI_dotnet-TwentyIApi-ResellerRenewMssql-System-String,System-String-'></a>
### ResellerRenewMssql(resellerId,body) `method`

##### Summary

Renew the MSSQL database of the given ID This will charge the appropriate registration fee to your 20i Balance.
If you don't have enough left, this will fail.
Please note you can also use contract/mssql:{id}#renew, this method only does a trivial reformatting to use that.

##### Returns

The raw json response as a string

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| resellerId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The id of the reseller |
| body | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The body of the request |

##### Remarks

body { id: "string"}

<a name='M-TwentyI_dotnet-TwentyIApi-ResellerRenewMssqlPre-System-String,System-String-'></a>
### ResellerRenewMssqlPre(resellerId,body) `method`

##### Summary

Renew an MSSQL database with the provided ID

##### Returns

The raw json response as a string

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| resellerId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The id of the reseller |
| body | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The body of the request |

##### Remarks

sample body: { id: "string" }

<a name='M-TwentyI_dotnet-TwentyIApi-ResellerRenewTlsCertificate-System-String,System-String-'></a>
### ResellerRenewTlsCertificate(resellerId,body) `method`

##### Summary

Renew a certificate. This will charge the appropriate fee to your 20i Balance.
If you don't have enough left, this will fail.
Please note you can also use contract/tls_certificate:{id}#renew, this method only does a trivial reformatting to
use that.

##### Returns

The raw json response as a string

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| resellerId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The id of the reseller |
| body | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The body of the request |

##### Remarks

body {id: "string" , periodMonths: 1}

<a name='M-TwentyI_dotnet-TwentyIApi-ResellerResetPassword-System-String,System-String-'></a>
### ResellerResetPassword(resellerId,body) `method`

##### Summary

Sends a password reset email, given a password reset token. See passwordResetInfo on the authentication service.

##### Returns

The raw json response as a string

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| resellerId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The id of the reseller |
| body | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The body of the request |

<a name='M-TwentyI_dotnet-TwentyIApi-ResellerSusers-System-String-'></a>
### ResellerSusers(resellerId) `method`

##### Summary

Returns your Stack user config.

##### Returns

The raw json response as a string

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| resellerId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The id of the reseller |

<a name='M-TwentyI_dotnet-TwentyIApi-ResellerSusersUpdate-System-String,System-String-'></a>
### ResellerSusersUpdate(resellerId,body) `method`

##### Summary

Update your Stack users.

##### Returns

The raw json response as a string

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| resellerId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The id of the reseller |
| body | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The body of the request |

##### Remarks

body: { contact:{ (user_ref):{ person_name: "string", company_name: "string", address: "string", city:
"string", sp: "string", pc: "string", cc: "string", voice: "string", notes: "string", billing_ref: "string", email:
"string", } }, ftpLock:{ (user_ref):{ existing:{ (lock_ref):{ Ip4Address: "string", Ip6Address: "string", delete:
true } }, new:{ Ip4Address: "string", Ip6Address: "string" } } }, grant_map:{ (user_ref):{ (service_ref): true } },
masterFtpAcl:{ (user_ref):{ Ip4Address: ["string"] } }, newUser:{ person_name: "string", company_name: "string",
address: "string", city: "string", sp: "string", pc: "string", cc: "string", voice: "string", notes: "string",
billing_ref: "string", email: "string", nominet_contact_type: "string", sendNewStackUserEmail: true, }, users:{
(user_ref):{ password: "string", delete: true } }, masterFtp:{ } }

<a name='M-TwentyI_dotnet-TwentyIApi-ResellerTransferDomain-System-String,System-String-'></a>
### ResellerTransferDomain(resellerId,body) `method`

##### Summary

Transfer a domain name.
This will charge the appropriate transfer fee to your 20i Balance.
If you don't have enough left, this will fail.
If you enable privacy you will also be charged a fee for the privacy service.
This will return true if the transfer purchase was accepted.
This doesn't guarantee that the transfer will succeed.
Please note you can also just use contract#add, this method only does a simple reformatting to use that.
Please see the documentation there for details.

##### Returns

The raw json response as a string

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| resellerId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The id of the reseller |
| body | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The body of the request |

##### Remarks

sample body: { name: "string", years: 1, contact:{ organisation: "string", name: "string", address: "string",
telephone: "string", email: "string", cc: "string", pc: "string", sp: "string", city: "string", extension:{ } },
emulateYears: true, otherContacts:{ (type):{ name: "string", organisation: "string", address: "string", city:
"string", sp: "string", pc: "string", cc: "string", telephone: "string", email: "string", extension:{ } } },
authcode: "string", limits:{ }, nameservers: ["string"], privacyService: true, stackUser: "string" }

<a name='M-TwentyI_dotnet-TwentyIApi-ResellerUpdate-System-String,System-String-'></a>
### ResellerUpdate(resellerId,body) `method`

##### Summary

Updates the reseller

##### Returns

The raw json response as a string

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| resellerId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The id of the reseller |
| body | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The body of the request |

##### Remarks

body { malwareEmails: true, malwareEmailsStackCpUsers: true, migrationCompleteEmails: true,
domainAutoRenewDefault: true }

<a name='M-TwentyI_dotnet-TwentyIApi-ResellerUpdatePackage-System-String,System-String-'></a>
### ResellerUpdatePackage(resellerId,body) `method`

##### Summary

Delete web sites or update their limits or labels.

##### Returns

The raw json response as a string

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| resellerId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The id of the reseller |
| body | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The body of the request |

##### Remarks

body { billing:{ (package_id):{ date: "string", interval: 1, preferredUser: "string", } }, delete-id:
["string"], id: ["string"], labels:{ (package_id): "string" }, limit:{ (package_id):{ (limit_code): true } },
limit-set:{ (package_id):{ (limit_code): true } }, packageBundleTypes:{ (package_id): "string" } }

<a name='M-TwentyI_dotnet-TwentyIApi-ResellerUpdateWebType-System-String,System-String-'></a>
### ResellerUpdateWebType(resellerId,body) `method`

##### Summary

Update web types.

##### Returns

The raw json response as a string

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| resellerId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The id of the reseller |
| body | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The body of the request |

##### Remarks

body { delete-id: ["string"], extraData:{ (id):{ temporaryUrlDomain: "string" } }, id: ["string"],
installApps:{ (type_id): ["string"] }, labels:{ }, limit:{ (type_id):{ (limit_code): true } }, platform: "string",
syncLimits:{ (type_id): true }, welcomeEmail:{ (id):{ subject: "string", from: "string", content: "string" } } }

<a name='M-TwentyI_dotnet-TwentyIApi-SetManagedVpsUserStatus-System-String,System-String-'></a>
### SetManagedVpsUserStatus(id,body) `method`

##### Summary

Activates or deactivates the service. Possible subservice_name are 'default' for a typical set of services and
'main' for the core service only.

##### Returns

The raw json response as a string

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| id | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The id of the managed vps |
| body | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The json body to send |

##### Remarks

Json sample body: { includeRepeated: true, subservices:{ (subservice_name): true } }
