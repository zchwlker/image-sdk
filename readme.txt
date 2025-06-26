Instructions for using Package

1.	Download package from Release page
	https://github.com/zchwlker/image-sdk/releases
2.	Unzip take the .nupkg and put it into your local package location
	a.	If you don’t have local package folder create a folder to put local package. This will be for all local packages
		i.	Create folder ie C:\LocalPackages
		ii.	Run “dotnet add source “C:\LocalPackages” –name LocalPackages
3.	Add package to project by running “dotnet add package ImageMetricsLib –version x.x.x”. The version is in the name of the .nupkg  package you moved to your local package folder
4.	Add licensing agreement to Project. License file will be provided
	a.	Move license file to project. Same level as appsettings.json will be fine
	b.	This file path will need to be referred to when initializing package 
		i.	await SdkLicenseService.InitializeLicensing("license.lic");
		This call should be made in project startup to give access to everything the license. License.lic would be the full path to the license 
5.	Add public key to appsettings.json. It is expecting this format. Public key will be provided
{
  "LicensingSecrets": {
    "PublicKey": "",
  }
}


Generate License from license app
1.	run AutoNoticeIsv project
2.	Enter customer name, must be unique.
3.	License output to bin/debug/net8.0/{customername}.bin



