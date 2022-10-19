# odm
ONVIF Device Manager

Original ODM sources has been migrated to VS2019.

Must install F# bundle (https://www.microsoft.com/en-us/download/details.aspx?id=48179)

## Changes
- Migrated C# projects package.config to <PackageConfig>.
- Crypto library replaced with official BouncyCastle "NuGet package NuGet\Install-Package BouncyCastle -Version 1.7.0"
Remember to use "git clean -xdf" to clean out the source folder after switching versions.
